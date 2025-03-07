using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.AuditLogExport;
using Com.Zoho.Crm.API.Util;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Samples.AuditLogExport1
{
    public class DownloadExportAuditLogResult
    {
        public static void DownloadExportAuditLogResult_1(String downloadUrl, String destinationFolder)
        {
            AuditLogExportOperations auditLogExportOperations = new AuditLogExportOperations();
            APIResponse<ResponseHandler> response = auditLogExportOperations.DownloadExportAuditLogResult(downloadUrl);
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
                    ResponseHandler responseHandler = response.Object;
                    if (responseHandler is FileBodyWrapper)
                    {
                        FileBodyWrapper fileBodyWrapper = (FileBodyWrapper)responseHandler;
                        StreamWrapper streamWrapper = fileBodyWrapper.File;
                        Stream file = streamWrapper.Stream;
                        string fullFilePath = Path.Combine(destinationFolder, streamWrapper.Name);
                        using (FileStream outputFileStream = new FileStream(fullFilePath, FileMode.Create))
                        {
                            file.CopyTo(outputFileStream);
                        }
                    }
                    else if (responseHandler is APIException)
                    {
                        APIException exception = (APIException)responseHandler;
                        if (exception.Status != null)
                        {
                            Console.WriteLine("Status: " + exception.Status.Value);
                        }
                        if (exception.Code != null)
                        {
                            Console.WriteLine("Code: " + exception.Code.Value);
                        }
                        if (exception.Details != null)
                        {
                            Console.WriteLine("Details: ");
                            foreach (KeyValuePair<string, object> entry in exception.Details)
                            {
                                Console.WriteLine(entry.Key + ": " + entry.Value);
                            }
                        }
                        if (exception.Message != null)
                        {
                            Console.WriteLine("Message: " + exception.Message);
                        }
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
                IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").Build();
                new Initializer.Builder().Environment(environment).Token(token).Initialize();
                String downloadUrl = "https://download-accl.zoho.com/v2/crm/xxxxx/auditlog/3477725001/AuditLog.csv";
                string destinationFolder = "/users/zohocrm-csharp-sdk-sample/file";
                DownloadExportAuditLogResult_1(downloadUrl, destinationFolder);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}