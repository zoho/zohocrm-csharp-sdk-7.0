using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Com.Zoho.API.Exception;
using Com.Zoho.Crm.API.Fields;
using Com.Zoho.Crm.API.Logger;
using Com.Zoho.Crm.API.Modules;
using Com.Zoho.Crm.API.RelatedLists;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static Com.Zoho.Crm.API.Fields.FieldsOperations;
using static Com.Zoho.Crm.API.Modules.ModulesOperations;
using static Com.Zoho.Crm.API.RelatedLists.RelatedListsOperations;
using static Com.Zoho.Crm.API.Users.UsersOperations;
using APIException = Com.Zoho.Crm.API.RelatedLists.APIException;
using ResponseHandler = Com.Zoho.Crm.API.RelatedLists.ResponseHandler;
using ResponseWrapper = Com.Zoho.Crm.API.RelatedLists.ResponseWrapper;

namespace Com.Zoho.Crm.API.Util
{
    /// <summary>
    /// This class handles module field details.
    /// </summary>
    public class Utility
    {
        private static object LOCK = new object();
        private static Dictionary<string, string> apiTypeVsDataType = new Dictionary<string, string>();
        private static Dictionary<string, string> apiTypeVsStructureName = new Dictionary<string, string>();
        private static bool newFile = false;
	    private static bool getModifiedModules = false;
        private static bool forceRefresh = false;
        private static string moduleAPIName;
        private static JObject apiSupportedModule = new JObject();

        public static void AssertNotNull(object value, string errorCode, string errorMessage)
        {
            if(value == null)
            {
                throw new SDKException(errorCode, errorMessage);
            }
        }

        private static void FileExistsFlow(string moduleAPIName, String recordFieldDetailsPath, string lastModifiedTime)
        {
            JObject recordFieldDetailsJson = Initializer.GetJSON(recordFieldDetailsPath);
            if (Initializer.GetInitializer().SDKConfig.AutoRefreshFields && !newFile && !getModifiedModules && (String.IsNullOrEmpty((string)recordFieldDetailsJson[Constants.FIELDS_LAST_MODIFIED_TIME]) || forceRefresh || (DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - Convert.ToInt64(recordFieldDetailsJson[Constants.FIELDS_LAST_MODIFIED_TIME])) > 3600000))
            {
                getModifiedModules = true;
                lastModifiedTime = (!forceRefresh && recordFieldDetailsJson.ContainsKey(Constants.FIELDS_LAST_MODIFIED_TIME)) ? (string)recordFieldDetailsJson.GetValue(Constants.FIELDS_LAST_MODIFIED_TIME) : null;
                ModifyFields(recordFieldDetailsPath, lastModifiedTime);
                getModifiedModules = false;
            }
            else if (!Initializer.GetInitializer().SDKConfig.AutoRefreshFields && forceRefresh && !getModifiedModules)
            {
                getModifiedModules = true;
                ModifyFields(recordFieldDetailsPath, lastModifiedTime);
                getModifiedModules = false;
            }
            recordFieldDetailsJson = Initializer.GetJSON(recordFieldDetailsPath);
            if (moduleAPIName == null || recordFieldDetailsJson.ContainsKey(moduleAPIName.ToLower()))
            {
                return;
            }
            else
            {
                FillDataType();
                recordFieldDetailsJson[moduleAPIName.ToLower()] = new JObject();
                using (StreamWriter sw = File.CreateText(recordFieldDetailsPath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(sw, recordFieldDetailsJson);
                    sw.Flush();
                    sw.Close();
                }
                JObject fieldDetails = (JObject)GetFieldsDetails(moduleAPIName);
                recordFieldDetailsJson = Initializer.GetJSON(recordFieldDetailsPath);
                recordFieldDetailsJson[moduleAPIName.ToLower()] = fieldDetails;
                using (StreamWriter sw = File.CreateText(recordFieldDetailsPath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(sw, recordFieldDetailsJson);
                    sw.Flush();
                    sw.Close();
                }
            }
        }

        private static string VerifyModuleAPIName(string moduleName)
        {
            if (moduleName != null && Constants.DEFAULT_MODULENAME_VS_APINAME.ContainsKey(moduleName.ToLower()))
            {
                return Constants.DEFAULT_MODULENAME_VS_APINAME[moduleName.ToLower()];
            }
            string recordFieldDetailsPath = GetFileName();
            if (File.Exists(recordFieldDetailsPath))
            {
                JObject fieldsJSON = Initializer.GetJSON(recordFieldDetailsPath);
                if (moduleName != null && fieldsJSON.ContainsKey(Constants.SDK_MODULE_METADATA) && ((JObject)fieldsJSON.GetValue(Constants.SDK_MODULE_METADATA)).ContainsKey(moduleName.ToLower()))
                {
                    JObject moduleMetaData = ((JObject)fieldsJSON.GetValue(Constants.SDK_MODULE_METADATA));
                    return (string)((JObject)moduleMetaData.GetValue(moduleName.ToLower())).GetValue(Constants.API_NAME);
                }
            }
            return moduleName;
        }

        private static void SetHandlerAPIPath(string moduleAPIName, CommonAPIHandler handlerInstance)
        {
            if(handlerInstance == null)
            {
                return;
            }
            string apiPath = handlerInstance.APIPath;
            if(apiPath.ToLower().Contains(moduleAPIName.ToLower()))
            {
                string[] apiPathSplit = apiPath.Split('/');
                for(int i = 0; i < apiPathSplit.Length; i++)
                {
                    if(apiPathSplit[i].Equals(moduleAPIName, StringComparison.OrdinalIgnoreCase))
                    {
                        apiPathSplit[i] = moduleAPIName;
                    }
                    else if(Constants.DEFAULT_MODULENAME_VS_APINAME.ContainsKey(apiPathSplit[i].ToLower()))
                    {
                        apiPathSplit[i] = Constants.DEFAULT_MODULENAME_VS_APINAME[apiPathSplit[i].ToLower()];
                    }
                }
                apiPath = string.Join("/", apiPathSplit);
                handlerInstance.APIPath = apiPath;
            }
        }

        public static void GetFields(string moduleAPIName, CommonAPIHandler handlerInstance)
        {
            if(moduleAPIName.Contains(","))
            {
                string[] moduleAPINames = moduleAPIName.Split(',');
                foreach(string name in moduleAPINames)
                {
                    Utility.moduleAPIName = name;
                    GetFieldsInfo(name, handlerInstance);
                }
            }
            else
            {
                Utility.moduleAPIName = moduleAPIName;
                GetFieldsInfo(moduleAPIName, handlerInstance);
            }
        }

        /// <summary>
        /// This method to fetch field details of the current module for the current user and store the result in a JSON file.
        /// </summary>
        /// <param name="moduleAPIName">A String containing the CRM module API name.</param>

        public static void GetFieldsInfo(string moduleAPIName, CommonAPIHandler handlerInstance)
        {
            lock (LOCK)
            {
                string recordFieldDetailsPath = null;
                string lastModifiedTime = null;
                try
                {
                    string resourcesPath = Initializer.GetInitializer().ResourcePath + Path.DirectorySeparatorChar + Constants.FIELD_DETAILS_DIRECTORY;
                    if (!Directory.Exists(resourcesPath))
                    {
                        Directory.CreateDirectory(resourcesPath);
                    }
                    moduleAPIName = VerifyModuleAPIName(moduleAPIName);
                    SetHandlerAPIPath(moduleAPIName, handlerInstance);
                    if (handlerInstance != null && handlerInstance.ModuleAPIName == null && !Constants.SKIP_MODULES.Contains(moduleAPIName.ToLower()))
                    {
                        return;
                    }
                    recordFieldDetailsPath = GetFileName();
                    if (File.Exists(recordFieldDetailsPath))
                    {
                        FileExistsFlow(moduleAPIName, recordFieldDetailsPath, lastModifiedTime);
                    }
                    else if(Initializer.GetInitializer().SDKConfig.AutoRefreshFields)
                    {
                        newFile = true;
                        FillDataType();
                        apiSupportedModule = apiSupportedModule.Count > 0 ? apiSupportedModule : GetModules(null);
                        JObject recordFieldDetailsJson = File.Exists(recordFieldDetailsPath) ? Initializer.GetJSON(recordFieldDetailsPath) : new JObject();
                        recordFieldDetailsJson[Constants.FIELDS_LAST_MODIFIED_TIME] = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                        foreach(var moduleData in apiSupportedModule)
                        {
                            string moduleName = moduleData.Key;
                            JObject metaData = (JObject)moduleData.Value;
                            if (!recordFieldDetailsJson.ContainsKey(moduleName.ToLower()))
                            {
                                recordFieldDetailsJson[moduleName.ToLower()] = new JObject();
                                using (StreamWriter sw = File.CreateText(recordFieldDetailsPath))
                                {
                                    JsonSerializer serializer = new JsonSerializer();
                                    serializer.Serialize(sw, recordFieldDetailsJson);
                                    sw.Flush();
                                    sw.Close();
                                }
							    JObject fieldDetails = (JObject)GetFieldsDetails((string)metaData.GetValue(Constants.API_NAME));
							    recordFieldDetailsJson = Initializer.GetJSON(recordFieldDetailsPath);
							    recordFieldDetailsJson[moduleName.ToLower()] = fieldDetails;
                                using (StreamWriter sw = File.CreateText(recordFieldDetailsPath))
                                {
                                    JsonSerializer serializer = new JsonSerializer();
                                    serializer.Serialize(sw, recordFieldDetailsJson);
                                    sw.Flush();
                                    sw.Close();
                                }
                            }
                        }
                        newFile = false;
                    }
                    else if(forceRefresh && !getModifiedModules)
                    {
                        //New file - and force refresh by User
                        getModifiedModules = true;
                        JObject recordFieldDetailsJson = new JObject();
                        using (StreamWriter sw = File.CreateText(recordFieldDetailsPath))
                        {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.Serialize(sw, recordFieldDetailsJson);
                            sw.Flush();
                            sw.Close();// file created with only dummy
                        }
                        ModifyFields(recordFieldDetailsPath, lastModifiedTime);
                        getModifiedModules = false;
                    }
                    else
                    {
                        FillDataType();
                        JObject recordFieldDetailsJson = new JObject();
                        recordFieldDetailsJson[moduleAPIName.ToLower()] = new JObject();
                        using (StreamWriter sw = File.CreateText(recordFieldDetailsPath))
                        {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.Serialize(sw, recordFieldDetailsJson);
                            sw.Flush();
                            sw.Close();// file created with only dummy
                        }
                        JObject fieldsDetails = (JObject)GetFieldsDetails(moduleAPIName);
                        recordFieldDetailsJson = Initializer.GetJSON(recordFieldDetailsPath);
                        recordFieldDetailsJson[moduleAPIName.ToLower()] = fieldsDetails;
                        using (StreamWriter sw = File.CreateText(recordFieldDetailsPath))
                        {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.Serialize(sw, recordFieldDetailsJson);
                            sw.Flush();
                            sw.Close();
                        }
                    }
                }
                catch (Exception e)
                {
                    if(recordFieldDetailsPath != null && File.Exists(recordFieldDetailsPath))
			        {
				        JObject recordFieldDetailsJson;
				        try
				        {
					        recordFieldDetailsJson = Initializer.GetJSON(recordFieldDetailsPath);
					        if(moduleAPIName != null && recordFieldDetailsJson.ContainsKey(moduleAPIName.ToLower()))
					        {
						        recordFieldDetailsJson.Remove(moduleAPIName.ToLower());
					        }
					        if(newFile)
					        {
						        if(recordFieldDetailsJson.GetValue(Constants.FIELDS_LAST_MODIFIED_TIME) != null)
						        {
							        recordFieldDetailsJson.Remove(Constants.FIELDS_LAST_MODIFIED_TIME);
						        }
						        newFile = false;
					        }
					        if(getModifiedModules || forceRefresh)
					        {
						        getModifiedModules = false;
                                forceRefresh = false;
						        if(lastModifiedTime != null)
						        {
							        recordFieldDetailsJson[Constants.FIELDS_LAST_MODIFIED_TIME] = lastModifiedTime;
						        }
					        }
							using (StreamWriter sw = File.CreateText(recordFieldDetailsPath))
							{
								JsonSerializer serializer = new JsonSerializer();
								serializer.Serialize(sw, recordFieldDetailsJson);
								sw.Flush();
								sw.Close();
							}
						}
				        catch (IOException ex)
				        {
                            throw new SDKException(Constants.EXCEPTION, ex);
				        }
			        }
                    throw (e is SDKException) ? (SDKException) e : new SDKException(Constants.EXCEPTION, e);
                }
            }
        }

        private static void ModifyFields(string recordFieldDetailsPath, string modifiedTime)
	    {
		    JObject modifiedModules = GetModules(modifiedTime);
		    JObject recordFieldDetailsJson = Initializer.GetJSON(recordFieldDetailsPath);
		    recordFieldDetailsJson[Constants.FIELDS_LAST_MODIFIED_TIME] = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			using (StreamWriter sw = File.CreateText(recordFieldDetailsPath))
			{
				JsonSerializer serializer = new JsonSerializer();
				serializer.Serialize(sw, recordFieldDetailsJson);
				sw.Flush();
				sw.Close();
			}
			if (modifiedModules.Count > 0)
		    {
			    foreach(var moduleMetaData in modifiedModules)
			    {
				    if(recordFieldDetailsJson.ContainsKey(moduleMetaData.Key.ToLower()))
				    {
					    DeleteFields(recordFieldDetailsJson, moduleMetaData.Key.ToLower());
				    }
			    }
				using (StreamWriter sw = File.CreateText(recordFieldDetailsPath))
				{
					JsonSerializer serializer = new JsonSerializer();
					serializer.Serialize(sw, recordFieldDetailsJson);
					sw.Flush();
					sw.Close();
				}
				foreach (var moduleMetaData in modifiedModules)
			    {
                    JObject moduleData = (JObject)moduleMetaData.Value;
				    GetFieldsInfo((string)moduleData.GetValue(Constants.API_NAME), null);
			    }
		    }
	    }

        public static void DeleteFields(JObject recordFieldDetailsJson, string module)
        {
            lock (LOCK)
            {
                List<string> subformModules = new List<string>();
                JObject fieldsJSON = (JObject)recordFieldDetailsJson[module.ToLower()];
                foreach (KeyValuePair<string, JToken> fieldDetails in fieldsJSON)
                {
                    JObject fieldDetail = (JObject)fieldDetails.Value;
                    if (fieldDetail.ContainsKey(Constants.SUBFORM) && (bool)fieldDetail[Constants.SUBFORM] && fieldDetail.ContainsKey(Constants.MODULE) && recordFieldDetailsJson.ContainsKey((string)fieldDetail[Constants.MODULE]))
                    {
                        subformModules.Add((string)fieldDetail[Constants.MODULE]);
                    }
                }
                recordFieldDetailsJson.Remove(module.ToLower());
                if (subformModules.Count > 0)
                {
                    foreach (string subformModule in subformModules)
                    {
                        DeleteFields(recordFieldDetailsJson, subformModule);
                    }
                }
            }
        }

        private static string GetFileName()
        {
            Type classType = typeof(JSONConverter);
            object instance = FormatterServices.GetUninitializedObject(classType);
            Converter converterInstance = (Converter)instance;
            return Initializer.GetInitializer().ResourcePath + Path.DirectorySeparatorChar + Constants.FIELD_DETAILS_DIRECTORY + Path.DirectorySeparatorChar + converterInstance.GetEncodedFileName();
        }

        public static void GetRelatedLists(string relatedModuleName, string moduleAPIName, CommonAPIHandler commonAPIHandler)
	    {
            lock (LOCK)
            {
                try
                {
                    bool isNewData = false;
                    string key = (moduleAPIName + Constants.UNDERSCORE + Constants.RELATED_LISTS).ToLower();
                    string resourcesPath = Initializer.GetInitializer().ResourcePath + Path.DirectorySeparatorChar + Constants.FIELD_DETAILS_DIRECTORY;
                    if (!Directory.Exists(resourcesPath))
                    {
                        Directory.CreateDirectory(resourcesPath);
                    }
                    string recordFieldDetailsPath = GetFileName();
                    if (!File.Exists(recordFieldDetailsPath) || (File.Exists(recordFieldDetailsPath) && (!Initializer.GetJSON(recordFieldDetailsPath).ContainsKey(key) || (Initializer.GetJSON(recordFieldDetailsPath).GetValue(key) == null || ((JArray)Initializer.GetJSON(recordFieldDetailsPath).GetValue(key)).Count <= 0))))
                    {
                        isNewData = true;
                        moduleAPIName = VerifyModuleAPIName(moduleAPIName);
                        JArray relatedListValues = GetRelatedListDetails(moduleAPIName);
                        JObject recordFieldDetailsJSON1 = File.Exists(recordFieldDetailsPath) ? Initializer.GetJSON(recordFieldDetailsPath) : new JObject();
                        recordFieldDetailsJSON1[key] = relatedListValues;
                        using (StreamWriter sw = File.CreateText(recordFieldDetailsPath))
                        {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.Serialize(sw, recordFieldDetailsJSON1);
                            sw.Flush();
                            sw.Close();
                        }
                    }
                    JObject recordFieldDetailsJSON = Initializer.GetJSON(recordFieldDetailsPath);
                    JArray modulerelatedList = recordFieldDetailsJSON.ContainsKey(key) ? (JArray)recordFieldDetailsJSON.GetValue(key) : new JArray();
                    if (!CheckRelatedListExists(relatedModuleName, modulerelatedList, commonAPIHandler) && !isNewData)
                    {
                        recordFieldDetailsJSON.Remove(key);
                        using (StreamWriter sw = File.CreateText(recordFieldDetailsPath))
                        {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.Serialize(sw, recordFieldDetailsJSON);
                            sw.Flush();
                            sw.Close();
                        }
                        GetRelatedLists(relatedModuleName, moduleAPIName, commonAPIHandler);
                    }
                }
                catch (SDKException e)
                {
                    throw e;
                }
                catch (Exception e)
                {
                    throw new SDKException(Constants.EXCEPTION, e);
                }
            }
	    }

        private static bool CheckRelatedListExists(string relatedModuleName, JArray modulerelatedListJA, CommonAPIHandler commonAPIHandler)
	    {
		    foreach (JObject relatedListJO in modulerelatedListJA)
		    {
			    if(relatedListJO.ContainsKey(Constants.API_NAME) && relatedListJO.GetValue(Constants.API_NAME) != null && relatedListJO.GetValue(Constants.API_NAME).ToString().Equals(relatedModuleName, StringComparison.OrdinalIgnoreCase))
			    {
                    if(relatedListJO[Constants.HREF].Equals(Constants.NULL_VALUE))
                    {
                        throw new SDKException(Constants.UNSUPPORTED_IN_API, commonAPIHandler.HttpMethod + " " + commonAPIHandler.APIPath + Constants.UNSUPPORTED_IN_API_MESSAGE);
                    }
                    if (relatedListJO.ContainsKey(Constants.MODULE) && !string.IsNullOrEmpty(relatedListJO[Constants.MODULE].ToString()))
                    {
                        commonAPIHandler.ModuleAPIName = (string)relatedListJO[Constants.MODULE];
                        GetFieldsInfo((string)relatedListJO[Constants.MODULE], commonAPIHandler);
                    }
				    return true;
			    }
		    }
		    return false;
	    }

	    private static JArray GetRelatedListDetails(string moduleAPIName)
	    {
		    RelatedListsOperations relatedListsOperations = new RelatedListsOperations(null);
            ParameterMap paramInstance = new ParameterMap();
            paramInstance.Add(GetRelatedListsParam.MODULE, moduleAPIName);
		    APIResponse<ResponseHandler> response = relatedListsOperations.GetRelatedLists(paramInstance);
		    JArray relatedListJA = new JArray();
		    if(response != null)
		    {
			    if(response.StatusCode == Constants.NO_CONTENT_STATUS_CODE)
			    {
				    return relatedListJA;
			    }
			    if(response.IsExpected)
			    {
					ResponseHandler responseHandler = response.Object;
				    if(responseHandler is ResponseWrapper)
				    {
					    ResponseWrapper responseWrapper = (ResponseWrapper) responseHandler;
					    List<RelatedList> relatedLists = responseWrapper.RelatedLists;
					    foreach(RelatedList relatedList in relatedLists)
					    {
						    JObject relatedListDetail = new JObject();
						    relatedListDetail.Add(Constants.API_NAME, relatedList.APIName);
						    relatedListDetail.Add(Constants.MODULE, relatedList.Module != null ? relatedList.Module.APIName : Constants.NULL_VALUE);
						    relatedListDetail.Add(Constants.NAME, relatedList.Name);
						    relatedListDetail.Add(Constants.HREF, relatedList.Href);
						    relatedListJA.Add(relatedListDetail);
					    }
				    }
				    else if(responseHandler is APIException)
				    {
					    APIException exception = (APIException) responseHandler;
					    JObject errorResponse = new JObject();
					    errorResponse.Add(Constants.CODE, exception.Code.Value);
					    errorResponse.Add(Constants.STATUS, exception.Status.Value);
					    errorResponse.Add(Constants.MESSAGE, exception.Message);
					    throw new SDKException(Constants.API_EXCEPTION, errorResponse);
				    }
			    }
			    else
			    {
				    JObject errorResponse = new JObject();
				    errorResponse.Add(Constants.CODE, response.StatusCode);
				    throw new SDKException(Constants.API_EXCEPTION, errorResponse);
			    }
		    }
		    return relatedListJA;
	    }

	    ///<summary>
	    ///This method to get module field data from Zoho CRM.
	    ///</summary>
	    ///<param name="moduleAPIName">A String containing the CRM module API name.</param>
	    ///<returns>A Object representing the Zoho CRM module field details.</returns>
	    public static object GetFieldsDetails(string moduleAPIName)
	    {
		    JObject fieldsDetails = new JObject();
		    FieldsOperations fieldOperation = new FieldsOperations();
            ParameterMap paramInstance = new ParameterMap();
            paramInstance.Add(GetFieldsParam.MODULE, moduleAPIName);
            APIResponse<Fields.ResponseHandler> response = fieldOperation.GetFields(paramInstance);
		    if(response != null)
		    {
			    if(response.StatusCode == Constants.NO_CONTENT_STATUS_CODE)
			    {
				    return fieldsDetails;
			    }
			    //Check if expected response is received
			    if(response.IsExpected)
			    {
					Fields.ResponseHandler responseHandler = response.Object;
				    if (responseHandler is Fields.ResponseWrapper)
				    {
						Fields.ResponseWrapper responseWrapper = (Fields.ResponseWrapper) responseHandler;
					    List<Fields.Fields> fields = responseWrapper.Fields;
					    foreach (Fields.Fields field in fields)
					    {
							string keyName = field.APIName;
						    if (Constants.KEYS_TO_SKIP.Contains(keyName))
						    {
							    continue;
						    }
						    JObject fieldDetail = new JObject();
						    SetDataType(fieldDetail, field, moduleAPIName);
						    fieldsDetails[field.APIName] = fieldDetail;
					    }
					    if(Constants.INVENTORY_MODULES.Contains(moduleAPIName.ToLower()))
					    {
						    JObject fieldDetail = new JObject();
						    fieldDetail.Add(Constants.NAME, Constants.LINE_TAX);
						    fieldDetail.Add(Constants.TYPE, Constants.LIST_NAMESPACE);
						    fieldDetail.Add(Constants.STRUCTURE_NAME, Constants.LINE_TAX_NAMESPACE);
                            fieldDetail.Add(Constants.LOOKUP, true);
						    fieldsDetails.Add(Constants.LINE_TAX, fieldDetail);
					    }
                        if (Constants.NOTES.Equals(moduleAPIName, StringComparison.OrdinalIgnoreCase))
                        {
                            JObject fieldDetail = new JObject();
                            fieldDetail.Add(Constants.NAME, Constants.ATTACHMENTS);
                            fieldDetail.Add(Constants.TYPE, Constants.LIST_NAMESPACE);
                            fieldDetail.Add(Constants.STRUCTURE_NAME, Constants.ATTACHMENTS_NAMESPACE);
                            fieldsDetails.Add(Constants.ATTACHMENTS, fieldDetail);
                        }
				    }
				    else if(responseHandler is Fields.APIException)
				    {
						Fields.APIException exception = (Fields.APIException)responseHandler;
					    JObject errorResponse = new JObject();
					    errorResponse.Add(Constants.CODE, exception.Code.Value);
					    errorResponse.Add(Constants.STATUS, exception.Status.Value);
					    errorResponse.Add(Constants.MESSAGE, exception.Message);
                        SDKException exception1 = new SDKException(Constants.API_EXCEPTION, errorResponse);
                        if(Utility.moduleAPIName != null && Utility.moduleAPIName.Equals(moduleAPIName, StringComparison.OrdinalIgnoreCase))
                        {
                            throw exception1;
                        }
                        SDKLogger.LogError(JsonConvert.SerializeObject(exception1));
                    }
			    }
			    else
			    {
				    JObject errorResponse = new JObject();
				    errorResponse.Add(Constants.CODE, response.StatusCode);
				    throw new SDKException(Constants.API_EXCEPTION, errorResponse);
			    }
		    }
		    return fieldsDetails;
	    }

        public static bool VerifyPhotoSupport(string moduleAPIName)
        {
            lock(LOCK)
            {
                try
                {
                    moduleAPIName = VerifyModuleAPIName(moduleAPIName);
                    if (Constants.PHOTO_SUPPORTED_MODULES.Contains(moduleAPIName.ToLower()))
                    {
                        return true;
                    }
                    JObject modules = GetModuleNames();
                    if(modules.ContainsKey(moduleAPIName.ToLower()))
                    {
                        JObject moduleMetaData = (JObject)modules.GetValue(moduleAPIName.ToLower());
                        if(moduleMetaData.ContainsKey(Constants.GENERATED_TYPE) && !((string)moduleMetaData.GetValue(Constants.GENERATED_TYPE)).Equals(Constants.GENERATED_TYPE_CUSTOM))
                        {
                            throw new SDKException(Constants.UPLOAD_PHOTO_UNSUPPORTED_ERROR, Constants.UPLOAD_PHOTO_UNSUPPORTED_MESSAGE + moduleAPIName);
                        }
                    }
                }
                catch (SDKException e)
                {
                    throw e;
                }
                catch (Exception e)
                {
                    SDKException exception = new SDKException(Constants.EXCEPTION, e);

                    throw exception;
                }
                return true;
            }
        }

        private static JObject GetModuleNames()
        {
            JObject moduleData = new JObject();
            string resourcesPath = Initializer.GetInitializer().ResourcePath + Path.DirectorySeparatorChar + Constants.FIELD_DETAILS_DIRECTORY;
            if (!Directory.Exists(resourcesPath))
            {
                Directory.CreateDirectory(resourcesPath);
            }
            string recordFieldDetailsPath = GetFileName();
            if (!File.Exists(recordFieldDetailsPath) || (File.Exists(recordFieldDetailsPath) && (!Initializer.GetJSON(recordFieldDetailsPath).ContainsKey(Constants.SDK_MODULE_METADATA) || (Initializer.GetJSON(recordFieldDetailsPath).GetValue(Constants.SDK_MODULE_METADATA) == null || ((JObject)Initializer.GetJSON(recordFieldDetailsPath).GetValue(Constants.SDK_MODULE_METADATA)).Count <= 0))))
            {
                moduleData = GetModules(null);
                WriteModuleMetaData(recordFieldDetailsPath, moduleData);
                return moduleData;
            }
            JObject recordFieldDetailsJson = Initializer.GetJSON(recordFieldDetailsPath);
            return (JObject)recordFieldDetailsJson.GetValue(Constants.SDK_MODULE_METADATA);
        }

        private static void WriteModuleMetaData(string recordFieldDetailsPath, JObject moduleData)
        {
            JObject recordFieldDetailsJSON = File.Exists(recordFieldDetailsPath) ? Initializer.GetJSON(recordFieldDetailsPath) : new JObject();
            recordFieldDetailsJSON[Constants.SDK_MODULE_METADATA] = moduleData;
            using (StreamWriter sw = File.CreateText(recordFieldDetailsPath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(sw, recordFieldDetailsJSON);
                sw.Flush();
                sw.Close();
            }
        }

        private static JObject GetModules(string header)
	    {
            JObject apiNames = new JObject();
		    HeaderMap headerMap = new HeaderMap();
		    if(header != null)
		    {
				DateTimeOffset headerValue = DateTimeOffset.FromUnixTimeMilliseconds(Convert.ToInt64(header));
                DateTimeOffset targetTime = TimeZoneInfo.ConvertTime(headerValue, TimeZoneInfo.Local);
                headerMap.Add(GetModulesHeader.IF_MODIFIED_SINCE, targetTime);
		    }
		    APIResponse<Modules.ResponseHandler> response = new ModulesOperations().GetModules(headerMap);
		    if(response != null)
		    {
                if (new List<int>() { Constants.NO_CONTENT_STATUS_CODE, Constants.NOT_MODIFIED_STATUS_CODE }.Contains(response.StatusCode))
                {
                    return apiNames;
                }
                // Check if expected response is received
                if (response.IsExpected)
                {
                    Modules.ResponseHandler responseObject = response.Object;
                    if (responseObject is Modules.ResponseWrapper)
                    {
                        List<Modules.Modules> modules = ((Modules.ResponseWrapper)responseObject).Modules;
                        foreach (Modules.Modules module in modules)
                        {
                            if (module.APISupported != null && (bool)module.APISupported)
                            {
                                JObject moduleDetails = new JObject();
                                moduleDetails.Add(Constants.API_NAME, module.APIName);
                                moduleDetails.Add(Constants.GENERATED_TYPE, module.GeneratedType.Value);
                                apiNames.Add(module.APIName.ToLower(), moduleDetails);
                            }
                        }
                    }
                    else if (responseObject is Modules.APIException)
                    {
                        Modules.APIException exception = (Modules.APIException) responseObject;
                        JObject errorResponse = new JObject();
                        errorResponse.Add(Constants.CODE, exception.Code.Value);
                        errorResponse.Add(Constants.STATUS, exception.Status.Value);
                        errorResponse.Add(Constants.MESSAGE, exception.Message);
                        throw new SDKException(Constants.API_EXCEPTION, errorResponse);
                    }
                }
		    }
            if(header == null)
            {
                try
                {
                    string resourcesPath = Initializer.GetInitializer().ResourcePath + Path.DirectorySeparatorChar + Constants.FIELD_DETAILS_DIRECTORY;
                    if (!Directory.Exists(resourcesPath))
                    {
                        Directory.CreateDirectory(resourcesPath);
                    }
                    WriteModuleMetaData(GetFileName(), apiNames);
                }
                catch (IOException ex)
                {
                    throw new SDKException(Constants.EXCEPTION, ex);
                }
            }
		    return apiNames;
	    }

        public static void RefreshModules()
        {
            lock (LOCK)
            {
                forceRefresh = true;
                GetFieldsInfo(null, null);
                forceRefresh = false;
            }
        }

        public static JObject GetJSONObject(JObject json, string key)
        {
            foreach(var entry in json)
            {
                string keyInJSON = entry.Key;
                if(keyInJSON.Equals(key, StringComparison.OrdinalIgnoreCase))
                {
                    return (JObject)entry.Value;
                }
            }
            return null;
        }

        private static void SetDataType(JObject fieldDetail, Fields.Fields field, string moduleAPIName)
        {
            string apiType = field.DataType;
            string keyName = field.APIName;
            MinifiedModule module = new MinifiedModule();
            if(field.SystemMandatory != null && field.SystemMandatory == true && !(moduleAPIName.Equals(Constants.CALLS, StringComparison.OrdinalIgnoreCase) && keyName.Equals(Constants.CALL_DURATION, StringComparison.OrdinalIgnoreCase)))
            {
                fieldDetail.Add(Constants.REQUIRED, true);
            }
            if (keyName.Equals(Constants.PRICING_DETAILS, StringComparison.OrdinalIgnoreCase) && moduleAPIName.Equals(Constants.PRICE_BOOKS, StringComparison.OrdinalIgnoreCase))
            {
                fieldDetail.Add(Constants.NAME, keyName);
                fieldDetail.Add(Constants.TYPE, Constants.LIST_NAMESPACE);
                fieldDetail.Add(Constants.STRUCTURE_NAME, Constants.PRICINGDETAILS);
                fieldDetail.Add(Constants.SKIP_MANDATORY, true);
                return;
            }
            else if(keyName.Equals(Constants.PARTICIPANT_API_NAME, StringComparison.OrdinalIgnoreCase) && (moduleAPIName.Equals(Constants.EVENTS, StringComparison.OrdinalIgnoreCase) || moduleAPIName.Equals(Constants.ACTIVITIES, StringComparison.OrdinalIgnoreCase)))
            {
                fieldDetail.Add(Constants.NAME, keyName);
                fieldDetail.Add(Constants.TYPE, Constants.LIST_NAMESPACE);
                fieldDetail.Add(Constants.STRUCTURE_NAME, Constants.PARTICIPANTS);
                fieldDetail.Add(Constants.SKIP_MANDATORY, true);
                return;
            }
            else if (keyName.Equals(Constants.COMMENTS, StringComparison.OrdinalIgnoreCase) && (moduleAPIName.Equals(Constants.SOLUTIONS, StringComparison.OrdinalIgnoreCase) || moduleAPIName.Equals(Constants.CASES, StringComparison.OrdinalIgnoreCase)))
            {
                fieldDetail.Add(Constants.NAME, keyName);
                fieldDetail.Add(Constants.TYPE, Constants.LIST_NAMESPACE);
                fieldDetail.Add(Constants.STRUCTURE_NAME, Constants.COMMENT_NAMESPACE);
                fieldDetail.Add(Constants.LOOKUP, true);
                return;
            }
            else if(keyName.Equals(Constants.LAYOUT, StringComparison.OrdinalIgnoreCase))
            {
                fieldDetail.Add(Constants.NAME, keyName);
                fieldDetail.Add(Constants.TYPE, Constants.LAYOUT_NAMESPACE);
                fieldDetail.Add(Constants.STRUCTURE_NAME, Constants.LAYOUT_NAMESPACE);
                fieldDetail.Add(Constants.LOOKUP, true);
                return;
            }
            else if((keyName.Equals(Constants.TERRITORIES, StringComparison.OrdinalIgnoreCase) || keyName.Equals(Constants.TERRITORY,StringComparison.OrdinalIgnoreCase)) && field.CustomField != null && field.CustomField == false)
            {
                fieldDetail.Add(Constants.NAME, keyName);
                fieldDetail.Add(Constants.TYPE, Constants.LIST_NAMESPACE);
                fieldDetail.Add(Constants.STRUCTURE_NAME, Constants.TERRITORY_NAMESPACE);
                fieldDetail.Add(Constants.LOOKUP, true);
                return;
            }
            else if (keyName.Equals(Constants.PRODUCT_NAME, StringComparison.OrdinalIgnoreCase) && Constants.INVENTORY_MODULES_ITEMS.Contains(moduleAPIName.ToLower()))
            {
                fieldDetail.Add(Constants.NAME, keyName);
                fieldDetail.Add(Constants.TYPE, Constants.LINEITEM_PRODUCT);
                fieldDetail.Add(Constants.STRUCTURE_NAME, Constants.LINEITEM_PRODUCT);
                fieldDetail.Add(Constants.SKIP_MANDATORY, true);
                return;
            }
            else if (keyName.Equals(Constants.DISCOUNT, StringComparison.OrdinalIgnoreCase) && Constants.INVENTORY_MODULES_ITEMS.Contains(moduleAPIName.ToLower()))
            {
                fieldDetail.Add(Constants.NAME, keyName);
                fieldDetail.Add(Constants.TYPE, Constants.CSHARP_STRING_NAME);
                return;
            }
            else if (keyName.Equals(Constants.TAX, StringComparison.OrdinalIgnoreCase) && Constants.PRODUCTS.Equals(moduleAPIName, StringComparison.OrdinalIgnoreCase))
            {
                fieldDetail.Add(Constants.NAME, keyName);
                fieldDetail.Add(Constants.TYPE, Constants.LIST_NAMESPACE);
                fieldDetail.Add(Constants.STRUCTURE_NAME, Constants.TAX_NAMESPACE);
                return;
            }
            else if(apiTypeVsDataType.ContainsKey(apiType))
            {
                fieldDetail[Constants.TYPE] = apiTypeVsDataType[apiType];
            }
            else if(apiType.Equals(Constants.FORMULA, StringComparison.OrdinalIgnoreCase))
            {
                if(field.Formula != null)
                {
                    string returnType = field.Formula.ReturnType;
                    if(returnType != null && apiTypeVsDataType.ContainsKey(returnType) && apiTypeVsDataType[returnType] != null)
                    {
                        fieldDetail[Constants.TYPE] = apiTypeVsDataType[returnType];
                    }
                }
                fieldDetail[Constants.READ_ONLY] = true;
            }
            else if (apiType.Equals(Constants.ROLLUP_SUMMARY, StringComparison.OrdinalIgnoreCase))
            {
                if (field.RollupSummary != null)
                {
                    string returnType = field.RollupSummary.ReturnType;
                    if (returnType != null && apiTypeVsDataType.ContainsKey(returnType) && apiTypeVsDataType[returnType] != null)
                    {
                        fieldDetail[Constants.TYPE] = apiTypeVsDataType[returnType];
                    }
                    else if (field.JsonType != null && apiTypeVsDataType.ContainsKey(field.JsonType) && apiTypeVsDataType[field.JsonType] != null)
                    {
                        fieldDetail[Constants.TYPE] = apiTypeVsDataType[field.JsonType];
                    }
                }
            }
            else
            {
                return;
            }
            if(apiType.ToLower().Contains(Constants.LOOKUP))
            {
                fieldDetail[Constants.LOOKUP] = true;
            }
            if (apiType.ToLower().Equals(Constants.CONSENT_LOOKUP, StringComparison.OrdinalIgnoreCase) || apiType.ToLower().Equals(Constants.OWNER_LOOKUP, StringComparison.OrdinalIgnoreCase))
            {
                fieldDetail[Constants.SKIP_MANDATORY] =  true;
            }
            if(apiType.Equals(Constants.MULTI_SELECT_LOOKUP, StringComparison.OrdinalIgnoreCase))
            {
                fieldDetail[Constants.SKIP_MANDATORY] = true;
                if(field.Multiselectlookup != null && field.Multiselectlookup.LinkingModule != null)
                {
                    MinifiedModule linkingModule = field.Multiselectlookup.LinkingModule;
                    fieldDetail[Constants.MODULE] = linkingModule.APIName;
                    module = linkingModule;
                }
                fieldDetail[Constants.SUBFORM] = true;
            }
            if (apiType.Equals(Constants.MULTI_USER_LOOKUP, StringComparison.OrdinalIgnoreCase))
            {
                fieldDetail[Constants.SKIP_MANDATORY] = true;
                if (field.Multiuserlookup != null && field.Multiuserlookup.LinkingModule != null)
                {
                    MinifiedModule linkingModule = field.Multiuserlookup.LinkingModule;
                    fieldDetail[Constants.MODULE] = linkingModule.APIName;
                    module = linkingModule;
                }
                fieldDetail[Constants.SUBFORM] = true;
            }
            if (apiType.Equals(Constants.MULTI_MODULE_LOOKUP, StringComparison.OrdinalIgnoreCase))
            {
                fieldDetail[Constants.SKIP_MANDATORY] = true;
            }
            if (apiTypeVsStructureName.ContainsKey(apiType))
            {
                fieldDetail[Constants.STRUCTURE_NAME] = apiTypeVsStructureName[apiType];
            }
            if(apiType.Equals(Constants.PICKLIST, StringComparison.OrdinalIgnoreCase) && (field.PickListValues != null && field.PickListValues.Count > 0))
            {
                fieldDetail.Add(Constants.PICKLIST, true);
                JArray values = new JArray();
                field.PickListValues.ForEach(plv => values.Add(plv.DisplayValue));
                fieldDetail[Constants.VALUES] = values;
            }
            if(apiType.Equals(Constants.SUBFORM, StringComparison.OrdinalIgnoreCase) && field.AssociatedModule != null)
            {
                module.APIName = field.AssociatedModule.Module;
                fieldDetail[Constants.MODULE] = module.APIName;
                fieldDetail[Constants.SKIP_MANDATORY] = true;
			    fieldDetail[Constants.SUBFORM] = true;
            }
            if(apiType.Equals(Constants.LOOKUP, StringComparison.OrdinalIgnoreCase) && field.Lookup != null)
            {
                MinifiedModule module1 = field.Lookup.Module;
                if(module1 != null && !module1.APIName.Equals(Constants.SE_MODULE, StringComparison.OrdinalIgnoreCase))
                {
                    module.APIName = module1.APIName;
                    module.Id = module1.Id;
                    fieldDetail[Constants.MODULE] = module1.APIName;
                    if(module1.APIName.Equals(Constants.ACCOUNTS, StringComparison.OrdinalIgnoreCase) && (field.CustomField != null && !(bool)field.CustomField))
                    {
                        fieldDetail[Constants.SKIP_MANDATORY] = true;
                    }
                }
                else
                {
                    module = new MinifiedModule();
                }
                fieldDetail[Constants.LOOKUP] = true;
            }
            if (module != null && module.APIName != null && module.APIName.Length > 0)
            {
                GetFieldsInfo(module.APIName, null);
            }
            fieldDetail[Constants.NAME] = keyName;
        }

        private static void FillDataType()
        {
            if (apiTypeVsDataType.Count > 0)
            {
                return;
            }
            string[] fieldAPINamesString = new string[] { "textarea", "text", "website", "email", "phone", "mediumtext", "profileimage", "autonumber"};
            string[] fieldAPINamesInteger = new string[] { "integer" };
            string[] fieldAPINamesBoolean = new string[] { "boolean" };
            string[] fieldAPINamesLong = new string[] { "long", "bigint" };
            string[] fieldAPINamesDouble = new string[] { "double", "percent", "lookup", "currency" };
            string[] fieldAPINamesFieldFile = new string[] { "fileupload" };
            string[] fieldAPINamesDateTime = new string[] { "datetime", "event_reminder" };
            string[] fieldAPINamesDate = new string[] { "date" };
            string[] fieldAPINamesLookup = new string[] { "lookup" };
            string[] fieldAPINamesPickList = new string[] { "picklist" };
            string[] fieldAPINamesMultiSelectPickList = new string[] { "multiselectpicklist" };
            string[] fieldAPINamesSubForm = new string[] { "subform" };
            string[] fieldAPINamesOwnerLookUp = new string[] { "ownerlookup", "userlookup" };
            string[] fieldAPINamesMultiUserLookUp = new string[] { "multiuserlookup" };
            string[] fieldAPINameTaskRemindAt = new string[] { "ALARM" };
            string[] fieldAPINameRecurringActivity = new string[] {"RRULE"};
            string[] fieldAPINameReminder = new string[] {"multireminder"};
            string[] fieldAPINameConsentLookUp = new string[] { "consent_lookup" };
            string[] fieldAPINameImageUpload = new string[] { "imageupload" };
            string[] fieldAPInameMultiSelectLookUp = new string[] { "multiselectlookup" };
            string[] fieldAPINameLineTax = new string[] {"linetax"};
            string[] fieldAPINamesModule = new string[] { "module" };
		    string[] fieldAPINamesLayout = new string[] { "layout" };
            string[] fieldAPINamesMultiModuleLookUp = new string[] { "multi_module_lookup" };
            string[] fieldAPINamesTimeRange = new string[] { "time_range" };
            foreach (string fieldAPIName in fieldAPINamesString)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.CSHARP_STRING_NAME;
            }
            foreach (string fieldAPIName in fieldAPINamesInteger)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.CSHARP_INT_NAME;
            }
            foreach (string fieldAPIName in fieldAPINamesBoolean)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.CSHARP_BOOLEAN_NAME;
            }
            foreach (string fieldAPIName in fieldAPINamesLong)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.CSHARP_LONG_NAME;
            }
            foreach (string fieldAPIName in fieldAPINamesDouble)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.CSHARP_DOUBLE_NAME;
            }
            foreach (string fieldAPIName in fieldAPINamesDateTime)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.SYSTEM_DATETIME_OFFSET;
            }
            foreach (string fieldAPIName in fieldAPINamesDate)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.SYSTEM_DATETIME;
            }
            foreach (string fieldAPIName in fieldAPINamesLookup)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.RECORD_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.RECORD_NAMESPACE;
            }
            foreach (string fieldAPIName in fieldAPINamesPickList)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.CHOICE_NAMESPACE;
            }
            foreach (string fieldAPIName in fieldAPINamesMultiSelectPickList)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.LIST_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.CHOICE_NAMESPACE;
            }
            foreach (string fieldAPIName in fieldAPINamesSubForm)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.LIST_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.RECORD_NAMESPACE;
            }
            foreach (string fieldAPIName in fieldAPINamesOwnerLookUp)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.USER_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.USER_NAMESPACE;
            }
            foreach (string fieldAPIName in fieldAPINamesMultiUserLookUp)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.LIST_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.RECORD_NAMESPACE;
            }
            foreach (string fieldAPIName in fieldAPINamesFieldFile)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.LIST_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.FIELD_FILE_NAMESPACE;
            }
            foreach(string fieldAPIName in fieldAPINameTaskRemindAt)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.REMINDAT_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.REMINDAT_NAMESPACE;
            }
            foreach(string fieldAPIName in fieldAPINameRecurringActivity)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.RECURRING_ACTIVITY_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.RECURRING_ACTIVITY_NAMESPACE;
            }
            foreach(string fieldAPIName in fieldAPINameReminder)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.LIST_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.REMINDER_NAMESPACE;
            }
            foreach (string fieldAPIName in fieldAPINameConsentLookUp)
            {
                apiTypeVsDataType.Add(fieldAPIName, Constants.CONSENT_NAMESPACE);
                apiTypeVsStructureName.Add(fieldAPIName, Constants.CONSENT_NAMESPACE);
            }
            foreach (string fieldAPIName in fieldAPINameImageUpload)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.LIST_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.IMAGEUPLOAD_NAMESPACE;
            }
            foreach (string fieldAPIName in fieldAPInameMultiSelectLookUp)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.LIST_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.RECORD_NAMESPACE;
            }
            foreach (string fieldAPIName in fieldAPINameLineTax)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.LIST_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.LINETAX;
            }
            foreach (string fieldAPIName in fieldAPINamesModule)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.MODULE_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.MODULE_NAMESPACE;
            }
            foreach (string fieldAPIName in fieldAPINamesMultiModuleLookUp)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.RECORD_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.RECORD_NAMESPACE;
            }
            foreach (string fieldAPIName in fieldAPINamesLayout)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.LAYOUT_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.LAYOUT_NAMESPACE;
            }
            foreach (string fieldAPIName in fieldAPINamesTimeRange)
            {
                apiTypeVsDataType[fieldAPIName] = Constants.LIST_NAMESPACE;
                apiTypeVsStructureName[fieldAPIName] = Constants.TIME_RANGE_NAMESPACE;
            }
        }

        public string GetUserName(string token)
        {
            string userName = null;
            ParameterMap paramInstance = new ParameterMap();
            paramInstance.Add(GetUsersParam.TYPE, new Choice<String>(Constants.CURRENTUSER));
            HeaderMap headerInstance = new HeaderMap();
            CommonAPIHandler handlerInstance = new CommonAPIHandler();
            string apiPath = "";
            apiPath = string.Concat(apiPath, "/crm/v7/users");
            handlerInstance.APIPath = apiPath;
            handlerInstance.HttpMethod = Constants.REQUEST_METHOD_GET;
            handlerInstance.CategoryMethod = Constants.REQUEST_CATEGORY_READ;
            handlerInstance.Param = paramInstance;
            headerInstance.Add(new Header<string>(Constants.AUTHORIZATION, Constants.CSHARP_STRING_NAME), Constants.OAUTH_HEADER_PREFIX + token);
            handlerInstance.Header = headerInstance;
            APIResponse<Users.ResponseHandler> response = handlerInstance.APICall<Users.ResponseHandler>(typeof(Users.ResponseHandler), "application/json");
            if (response != null)
            {
                if (new List<int>() { 204, 304 }.Contains(response.StatusCode))
                {
                    return null;
                }
                if (response.IsExpected)
                {
                    Users.ResponseHandler responseHandler = response.Object;
                    if (responseHandler is Users.ResponseWrapper)
                    {
                        Users.ResponseWrapper responseWrapper = (Users.ResponseWrapper) responseHandler;
                        List<Users.Users> users = responseWrapper.Users;
                        foreach (Users.Users user in users)
                        {
                            userName = user.Email;
                            break;
                        }
                    }
                    else if (responseHandler is Users.APIException)
                    {
                        Users.APIException exception = (Users.APIException) responseHandler;
                        JObject errorResponse = new JObject
                        {
                            { Constants.CODE, exception.Code.Value },
                            { Constants.STATUS, exception.Status.Value },
                            { Constants.MESSAGE, exception.Message }
                        };
                        throw new SDKException(Constants.API_EXCEPTION, errorResponse);
                    }
                }
            }
            return userName + ":" + GetUserOrgID(token);
        }
        
        private string GetUserOrgID(string token)
        {
            HeaderMap headerInstance = new HeaderMap();
            CommonAPIHandler handlerInstance = new CommonAPIHandler();
            string apiPath = "";
            apiPath = string.Concat(apiPath, "/crm/v7/org");
            handlerInstance.APIPath = apiPath;
            handlerInstance.HttpMethod = Constants.REQUEST_METHOD_GET;
            handlerInstance.CategoryMethod = Constants.REQUEST_CATEGORY_READ;
            headerInstance.Add(new Header<string>(Constants.AUTHORIZATION, Constants.CSHARP_STRING_NAME), Constants.OAUTH_HEADER_PREFIX + token);
            handlerInstance.Header = headerInstance;
            APIResponse<Org.ResponseHandler> response = handlerInstance.APICall<Org.ResponseHandler>(typeof(Org.ResponseHandler), "application/json");
            if (response != null)
            {
                if (response.IsExpected)
                {
                    Org.ResponseHandler responseHandler = response.Object;
                    if (responseHandler is Org.ResponseWrapper)
                    {
                        Org.ResponseWrapper responseWrapper = (Org.ResponseWrapper) responseHandler;
                        List<Org.Org> orgs = responseWrapper.Org;
                        foreach (Org.Org org in orgs)
                        {
                            return org.Zgid;
                        }
                    }
                    else if (responseHandler is Org.APIException)
                    {
                        Org.APIException exception = (Org.APIException) responseHandler;
                        JObject errorResponse = new JObject
                        {
                            { Constants.CODE, exception.Code.Value },
                            { Constants.STATUS, exception.Status.Value },
                            { Constants.MESSAGE, exception.Message.Value }
                        };
                        throw new SDKException(Constants.API_EXCEPTION, errorResponse);
                    }
                }
            }
            return null;
        }
    }
}
