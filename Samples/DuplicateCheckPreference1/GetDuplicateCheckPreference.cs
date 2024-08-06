using System;
using System.Collections.Generic;
using System.Reflection;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.DuplicateCheckPreference;
using Com.Zoho.Crm.API.Util;
using Newtonsoft.Json;

namespace Samples.DuplicateCheckPreference1
{
	public class GetDuplicateCheckPreference
	{
        public static void GetDuplicateCheckPreference_1(string moduleAPIName)
        {
            DuplicateCheckPreferenceOperations duplicateCheckPreferenceOperations = new DuplicateCheckPreferenceOperations(moduleAPIName);
            APIResponse<ResponseHandler> response = duplicateCheckPreferenceOperations.GetDuplicateCheckPreference();
            if (response != null)
            {
                Console.WriteLine("Status Code: " + response.StatusCode);
                if (response.StatusCode == 204)
                {
                    Console.WriteLine("No Content");
                    return;
                }
                if (response.IsExpected)
                {
                    ResponseHandler responseHandler = response.Object;
                    if (responseHandler is ResponseWrapper)
                    {
                        ResponseWrapper responseWrapper = (ResponseWrapper)responseHandler;
                        DuplicateCheckPreference duplicateCheckPreference = responseWrapper.DuplicateCheckPreference;
                        Console.WriteLine("DuplicateCheckPreference Type : " + duplicateCheckPreference.Type.Value);
                        List<TypeConfiguration> typeConfigurations = duplicateCheckPreference.TypeConfigurations;
                        if (typeConfigurations != null)
                        {
                            foreach (TypeConfiguration typeConfiguration in typeConfigurations)
                            {
                                MappedModule mappedModule = typeConfiguration.MappedModule;
                                if (mappedModule != null)
                                {
                                    Console.WriteLine("DuplicateCheckPreference TypeConfiguration MappedModule Id : " + mappedModule.Id);
                                    Console.WriteLine("DuplicateCheckPreference TypeConfiguration MappedModule Name : " + mappedModule.Name);
                                    Console.WriteLine("DuplicateCheckPreference TypeConfiguration MappedModule APIName : " + mappedModule.APIName);
                                }
                                List<FieldMappings> fieldMappings = typeConfiguration.FieldMappings;
                                if (fieldMappings != null)
                                {
                                    foreach (FieldMappings fieldMapping in fieldMappings)
                                    {
                                        CurrentField currentField = fieldMapping.CurrentField;
                                        if (currentField != null)
                                        {
                                            Console.WriteLine("DuplicateCheckPreference TypeConfiguration FieldMappings CurrentField Id : " + currentField.Id);
                                            Console.WriteLine("DuplicateCheckPreference TypeConfiguration FieldMappings CurrentField Name : " + currentField.Name);
                                            Console.WriteLine("DuplicateCheckPreference TypeConfiguration FieldMappings CurrentField APIName : " + currentField.APIName);
                                        }
                                        MappedField mappedField = fieldMapping.MappedField;
                                        if (mappedField != null)
                                        {
                                            Console.WriteLine("DuplicateCheckPreference TypeConfiguration FieldMappings MappedField Id : " + mappedField.Id);
                                            Console.WriteLine("DuplicateCheckPreference TypeConfiguration FieldMappings MappedField Name : " + mappedField.Name);
                                            Console.WriteLine("DuplicateCheckPreference TypeConfiguration FieldMappings MappedField APIName : " + mappedField.APIName);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (responseHandler is APIException)
                    {
                        APIException exception = (APIException)responseHandler;
                        Console.WriteLine("Status: " + exception.Status.Value);
                        Console.WriteLine("Code: " + exception.Code.Value);
                        Console.WriteLine("Details: ");
                        foreach (KeyValuePair<string, object> entry in exception.Details)
                        {
                            Console.WriteLine(entry.Key + ": " + entry.Value);
                        }
                        Console.WriteLine("Message: " + exception.Message.Value);
                    }
                }
                else if (response.StatusCode != 204)
                {
                    Model responseObject = response.Model;
                    Type type = responseObject.GetType();
                    Console.WriteLine("Type is : {0}", type.Name);
                    PropertyInfo[] props = type.GetProperties();
                    Console.WriteLine("Properties (N = {0}) :", props.Length);
                    foreach (var prop in props)
                    {
                        if (prop.GetIndexParameters().Length == 0)
                        {
                            Console.WriteLine("{0} ({1}) in {2}", prop.Name, prop.PropertyType.Name, prop.GetValue(responseObject));
                        }
                        else
                        {
                            Console.WriteLine("{0} ({1}) in <Indexed>", prop.Name, prop.PropertyType.Name);
                        }
                    }
                }
            }
        }

        public static void Call()
        {
            try
            {
                Environment environment = USDataCenter.PRODUCTION;
                IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").RedirectURL("Redirect_URL").Build();
                new Initializer.Builder().Environment(environment).Token(token).Initialize();
                string moduleAPIName = "Contacts";
                GetDuplicateCheckPreference_1(moduleAPIName);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}

