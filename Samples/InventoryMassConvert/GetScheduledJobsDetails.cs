using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.InventoryMassConvert;
using Com.Zoho.Crm.API;
using static Com.Zoho.Crm.API.InventoryMassConvert.InventoryMassConvertOperations;
using Com.Zoho.Crm.API.Util;
using System.Reflection;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Samples.InventoryMassConvert
{
    public class GetScheduledJobsDetails
    {
        public static void GetScheduledJobsDetails_1(long jobId, String moduleAPIName)
        {
            InventoryMassConvertOperations inventoryMassConvertOperations = new InventoryMassConvertOperations(moduleAPIName);
            ParameterMap paramInstance = new ParameterMap();
            paramInstance.Add(GetScheduledJobsDetailsParam.JOB_ID, jobId);
            APIResponse<ResponseHandler> response = inventoryMassConvertOperations.GetScheduledJobsDetails(paramInstance);
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
                    if (responseHandler is ResponseWrapper)
                    {
                        ResponseWrapper responseWrapper = (ResponseWrapper)responseHandler;
                        List<Status> status = responseWrapper.Data;
                        foreach(Status status1 in status)
                        {
                            Console.WriteLine("MassConvert TotalCount: " + status1.TotalCount);
                            Console.WriteLine("MassConvert ConvertedCount: " + status1.ConvertedCount);
                            Console.WriteLine("MassConvert NotConvertedCount: " + status1.NotConvertedCount);
                            Console.WriteLine("MassConvert FailedCount: " + status1.FailedCount);
                            Console.WriteLine("MassConvert Status: " + status1.Status_1);
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
                        Console.WriteLine("Message: " + exception.Message);
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
                long jobId = 34770626323001;
                String moduleAPIName = "Quotes";
                GetScheduledJobsDetails_1(jobId, moduleAPIName);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}