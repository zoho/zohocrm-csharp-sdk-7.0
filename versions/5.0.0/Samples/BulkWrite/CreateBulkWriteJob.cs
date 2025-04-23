using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using APIException = Com.Zoho.Crm.API.BulkWrite.APIException;
using ActionResponse = Com.Zoho.Crm.API.BulkWrite.ActionResponse;
using BulkWriteOperations = Com.Zoho.Crm.API.BulkWrite.BulkWriteOperations;
using CallBack = Com.Zoho.Crm.API.BulkWrite.CallBack;
using DefaultValue = Com.Zoho.Crm.API.BulkWrite.DefaultValue;
using FieldMapping = Com.Zoho.Crm.API.BulkWrite.FieldMapping;
using RequestWrapper = Com.Zoho.Crm.API.BulkWrite.RequestWrapper;
using Resource = Com.Zoho.Crm.API.BulkWrite.Resource;
using SuccessResponse = Com.Zoho.Crm.API.BulkWrite.SuccessResponse;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using MinifiedModule = Com.Zoho.Crm.API.Modules.MinifiedModule;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.Bulkwrite
{
    public class CreateBulkWriteJob
    {
        public static void CreateBulkWriteJob_1(string moduleAPIName, string fileId)
        {
            BulkWriteOperations bulkWriteOperations = new BulkWriteOperations();
            RequestWrapper requestWrapper = new RequestWrapper();
            CallBack callback = new CallBack();
            callback.Url = "https://www.example.com/callback";
            callback.Method = new Choice<string>("post");
            requestWrapper.Callback = callback;
            requestWrapper.CharacterEncoding = "UTF-8";
            requestWrapper.Operation = new Choice<string>("insert");
            List<Resource> resource = new List<Resource>();
            Resource resourceIns = new Resource();
            resourceIns.Type = new Choice<string>("data");
            resourceIns.FileId = fileId;
            resourceIns.IgnoreEmpty = true;
            //resourceIns.FindBy = "Email";
            MinifiedModule module = new MinifiedModule();
            module.APIName = moduleAPIName;
            resourceIns.Module = module;
            List<FieldMapping> fieldMappings = new List<FieldMapping>();
            FieldMapping fieldMapping;
            fieldMapping = new FieldMapping();
            fieldMapping.APIName = "Last_Name";
            fieldMapping.Index = 0;
            fieldMappings.Add(fieldMapping);
            fieldMapping = new FieldMapping();
            fieldMapping.APIName = "Email";
            fieldMapping.Index = 1;
            fieldMappings.Add(fieldMapping);
            fieldMapping = new FieldMapping();
            fieldMapping.APIName = "Company";
            fieldMapping.Index = 2;
            fieldMappings.Add(fieldMapping);
            fieldMapping = new FieldMapping();
            fieldMapping.APIName = "Phone";
            fieldMapping.Index = 3;
            fieldMappings.Add(fieldMapping);
            fieldMapping = new FieldMapping();
            fieldMapping.APIName = "Website";
            // fieldMapping.Format = "";
            // fieldMapping.FindBy = "";
            DefaultValue defaultValue = new DefaultValue();
            defaultValue.Value = "https://www.zohoapis.com";
            fieldMapping.DefaultValue = defaultValue;
            fieldMappings.Add(fieldMapping);
            resourceIns.FieldMappings = fieldMappings;
            resource.Add(resourceIns);
            requestWrapper.Resource = resource;
            APIResponse<ActionResponse> response = bulkWriteOperations.CreateBulkWriteJob(requestWrapper);
            if (response != null)
            {
                Console.WriteLine("Status Code: " + response.StatusCode);
                if (response.IsExpected)
                {
                    ActionResponse actionResponse = response.Object;
                    if (actionResponse is SuccessResponse)
                    {
                        SuccessResponse successResponse = (SuccessResponse)actionResponse;
                        Console.WriteLine("Status: " + successResponse.Status.Value);
                        Console.WriteLine("Code: " + successResponse.Code.Value);
                        Console.WriteLine("Details: ");
                        foreach (KeyValuePair<string, object> entry in successResponse.Details)
                        {
                            Console.WriteLine(entry.Key + ": " + entry.Value);
                        }
                        Console.WriteLine("Message: " + successResponse.Message.Value);
                    }
                    else if (actionResponse is APIException)
                    {
                        APIException exception = (APIException)actionResponse;
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
                string moduleAPIName = "Leads";
                string fileId = "34770611727001";
                CreateBulkWriteJob_1(moduleAPIName, fileId);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}