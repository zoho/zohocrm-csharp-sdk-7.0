using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using APIException = Com.Zoho.Crm.API.BulkWrite.APIException;
using BulkWriteOperations = Com.Zoho.Crm.API.BulkWrite.BulkWriteOperations;
using BulkWriteResponse = Com.Zoho.Crm.API.BulkWrite.BulkWriteResponse;
using CallBack = Com.Zoho.Crm.API.BulkWrite.CallBack;
using DefaultValue = Com.Zoho.Crm.API.BulkWrite.DefaultValue;
using FieldMapping = Com.Zoho.Crm.API.BulkWrite.FieldMapping;
using Resource = Com.Zoho.Crm.API.BulkWrite.Resource;
using ResponseWrapper = Com.Zoho.Crm.API.BulkWrite.ResponseWrapper;
using Result = Com.Zoho.Crm.API.BulkWrite.Result;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using MinifiedModule = Com.Zoho.Crm.API.Modules.MinifiedModule;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.Bulkwrite
{
    public class GetBulkWriteJobDetails
    {
        public static void GetBulkWriteJobDetails_1(string jobId)
        {
            BulkWriteOperations bulkWriteOperations = new BulkWriteOperations();
            APIResponse<ResponseWrapper> response = bulkWriteOperations.GetBulkWriteJobDetails(jobId);
            if (response != null)
            {
                Console.WriteLine("Status Code: " + response.StatusCode);
                if (new List<int>() { 204, 304 }.Contains(response.StatusCode))
                {
                    Console.WriteLine(response.StatusCode == 204 ? "No Content" : "Not Modified");
                    return;
                }
                if (response.IsExpected)
                {
                    ResponseWrapper responseWrapper = response.Object;
                    if (responseWrapper is BulkWriteResponse)
                    {
                        BulkWriteResponse bulkWriteResponse = (BulkWriteResponse)responseWrapper;
                        Console.WriteLine("Bulk write Job Status: " + bulkWriteResponse.Status);
                        Console.WriteLine("Bulk write CharacterEncoding: " + bulkWriteResponse.CharacterEncoding);
                        List<Resource> resources = bulkWriteResponse.Resource;
                        if (resources != null)
                        {
                            foreach (Resource resource in resources)
                            {
                                Console.WriteLine("Bulk write Resource Status: " + resource.Status.Value);
                                Console.WriteLine("Bulk write Resource Type: " + resource.Type.Value);
                                MinifiedModule module = resource.Module;
                                if (module != null)
                                {
                                    Console.WriteLine("Bulkwrite Resource Module Name : " + module.APIName);
                                    Console.WriteLine("Bulkwrite Resource Module Id : " + module.Id);
                                }
                                List<FieldMapping> fieldMappings = resource.FieldMappings;
                                if (fieldMappings != null)
                                {
                                    foreach (FieldMapping fieldMapping in fieldMappings)
                                    {
                                        Console.WriteLine("Bulk write Resource FieldMapping Module: " + fieldMapping.APIName);
                                        if (fieldMapping.Index != null)
                                        {
                                            Console.WriteLine("Bulk write Resource FieldMapping Index: " + fieldMapping.Index);
                                        }
                                        if (fieldMapping.Format != null)
                                        {
                                            Console.WriteLine("Bulk write Resource FieldMapping Format: " + fieldMapping.Format);
                                        }
                                        if (fieldMapping.Module != null)
                                        {
                                            Console.WriteLine("Bulk write Resource FieldMapping Module: " + fieldMapping.Module);
                                        }
                                        if (fieldMapping.FindBy != null)
                                        {
                                            Console.WriteLine("Bulk write Resource FieldMapping FindBy: " + fieldMapping.FindBy);
                                        }
                                        if (fieldMapping.DefaultValue != null)
                                        {
                                            DefaultValue defaultValue = fieldMapping.DefaultValue;
                                            if (defaultValue != null)
                                            {
                                                Console.WriteLine("Name : " + defaultValue.Name);
                                                Console.WriteLine("Module : " + defaultValue.Module);
                                                Console.WriteLine("Value : " + defaultValue.Value);
                                            }
                                        }
                                    }
                                }
                                Com.Zoho.Crm.API.BulkWrite.File file = resource.File;
                                if (file != null)
                                {
                                    Console.WriteLine("Bulk write Resource File Status: " + file.Status.Value);
                                    Console.WriteLine("Bulk write Resource File Name: " + file.Name);
                                    Console.WriteLine("Bulk write Resource File AddedCount: " + file.AddedCount);
                                    Console.WriteLine("Bulk write Resource File SkippedCount: " + file.SkippedCount);
                                    Console.WriteLine("Bulk write Resource File UpdatedCount: " + file.UpdatedCount);
                                    Console.WriteLine("Bulk write Resource File TotalCount: " + file.TotalCount);
                                }
                                Console.WriteLine("Bulk write Resource FindBy: " + resource.FindBy);
                                Console.WriteLine("Bulk write Resource Code: " + resource.Code);
                            }
                        }
                        CallBack callback = bulkWriteResponse.Callback;
                        if (callback != null)
                        {
                            Console.WriteLine("Bulk write CallBack Url: " + callback.Url);
                            Console.WriteLine("Bulk write CallBack Method: " + callback.Method.Value);
                        }
                        Console.WriteLine("Bulk write ID: " + bulkWriteResponse.Id);
                        Result result = bulkWriteResponse.Result;
                        if (result != null)
                        {
                            Console.WriteLine("Bulk write DownloadUrl: " + result.DownloadUrl);
                        }
                        Com.Zoho.Crm.API.Users.MinifiedUser createdBy = bulkWriteResponse.CreatedBy;
                        if (createdBy != null)
                        {
                            Console.WriteLine("Bulkread Created By User-ID: " + createdBy.Id);
                            Console.WriteLine("Bulkread Created By user-Name: " + createdBy.Name);
                        }
                        Console.WriteLine("Bulk write Operation: " + bulkWriteResponse.Operation);
                        Console.WriteLine("Bulk write File CreatedTime: " + bulkWriteResponse.CreatedTime);
                    }
                    else if (responseWrapper is APIException)
                    {
                        APIException exception = (APIException)responseWrapper;
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
                else
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
                string jobID = "347706117222006l";
                GetBulkWriteJobDetails_1(jobID);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}