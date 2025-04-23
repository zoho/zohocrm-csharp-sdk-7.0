using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using HeaderMap = Com.Zoho.Crm.API.HeaderMap;
using Initializer = Com.Zoho.Crm.API.Initializer;
using APIException = Com.Zoho.Crm.API.BulkWrite.APIException;
using ActionResponse = Com.Zoho.Crm.API.BulkWrite.ActionResponse;
using BulkWriteOperations = Com.Zoho.Crm.API.BulkWrite.BulkWriteOperations;
using SuccessResponse = Com.Zoho.Crm.API.BulkWrite.SuccessResponse;
using UploadFileHeader = Com.Zoho.Crm.API.BulkWrite.BulkWriteOperations.UploadFileHeader;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.Bulkwrite
{
    public class UploadFile
    {
        public static void UploadFile_1(string orgID, string absoluteFilePath)
        {
            BulkWriteOperations bulkWriteOperations = new BulkWriteOperations();
            Com.Zoho.Crm.API.BulkWrite.FileBodyWrapper fileBodyWrapper = new Com.Zoho.Crm.API.BulkWrite.FileBodyWrapper();
            StreamWrapper streamWrapper = new StreamWrapper(absoluteFilePath);
            // FileInputStream stream = new FileInputStream(absoluteFilePath);
            // StreamWrapper streamWrapper = new StreamWrapper("Leads.zip", stream);
            fileBodyWrapper.File = streamWrapper;
            HeaderMap headerInstance = new HeaderMap();
            headerInstance.Add(UploadFileHeader.FEATURE, "bulk-write");
            headerInstance.Add(UploadFileHeader.X_CRM_ORG, orgID);
            APIResponse<ActionResponse> response = bulkWriteOperations.UploadFile(fileBodyWrapper, headerInstance);
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
                        if (exception.Status != null)
                        {
                            Console.WriteLine("Status: " + exception.Status.Value);
                        }
                        if (exception.Code != null)
                        {
                            Console.WriteLine("Code: " + exception.Code.Value);
                        }
                        if (exception.Message != null)
                        {
                            Console.WriteLine("Message: " + exception.Message.Value);
                        }
                        Console.WriteLine("Details: ");
                        if (exception.Details != null)
                        {
                            foreach (KeyValuePair<string, object> entry in exception.Details)
                            {
                                Console.WriteLine(entry.Key + ": " + entry.Value);
                            }
                        }
                        if (exception.ErrorMessage != null)
                        {
                            Console.WriteLine("ErrorMessage: " + exception.ErrorMessage.Value);
                        }
                        Console.WriteLine("ErrorCode: " + exception.ErrorCode);
                        if (exception.XError != null)
                        {
                            Console.WriteLine("XError: " + exception.XError.Value);
                        }
                        if (exception.Info != null)
                        {
                            Console.WriteLine("Info: " + exception.Info.Value);
                        }
                        if (exception.XInfo != null)
                        {
                            Console.WriteLine("XInfo: " + exception.XInfo.Value);
                        }
                        Console.WriteLine("HttpStatus: " + exception.HttpStatus);
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
                string orgID = "673573045";
                string absoluteFilePath = "/Users/Documents/CRM_SDK/Leads.zip";
                UploadFile_1(orgID, absoluteFilePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}