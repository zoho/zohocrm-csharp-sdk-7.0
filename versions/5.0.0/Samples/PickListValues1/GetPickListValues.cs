using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.Crm.API.PickListValues;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;
using System.Reflection;

namespace Samples.PickListValues1
{
    public class GetPickListValues
    {
        public static void GetPickListValues_1(long fieldId, string moduleAPIName)
        {
            PickListValuesOperations pickListValuesOperations = new PickListValuesOperations(fieldId, moduleAPIName);
            APIResponse<ResponseHandler> response = pickListValuesOperations.GetPickListValues();
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
                        List<PickListValues> pickListValues = responseWrapper.PickListValues;
                        if (pickListValues != null)
                        {
                            foreach (PickListValues pickListValue in pickListValues)
                            {
                                Console.WriteLine("PickListValues SequenceNumber : " + pickListValue.SequenceNumber);
                                Console.WriteLine("PickListValues DisplayValue : " + pickListValue.DisplayValue);
                                Console.WriteLine("PickListValues ReferenceValue : " + pickListValue.ReferenceValue);
                                Console.WriteLine("PickListValues ColourCode( : " + pickListValue.ColourCode);
                                Console.WriteLine("PickListValues ActualValue : " + pickListValue.ActualValue);
                                Console.WriteLine("PickListValues Id : " + pickListValue.Id);
                                Console.WriteLine("PickListValues Type : " + pickListValue.Type);
                                List<LayoutAssociation> layoutAssociations = pickListValue.LayoutAssociations;
                                if (layoutAssociations != null)
                                {
                                    foreach (LayoutAssociation layoutAssociation in layoutAssociations)
                                    {
                                        Console.WriteLine("PickListValues LayoutAssociation Id : " + layoutAssociation.Id);
                                        Console.WriteLine("PickListValues LayoutAssociation Name : " + layoutAssociation.Name);
                                        Console.WriteLine("PickListValues LayoutAssociation APIName : " + layoutAssociation.APIName);
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
                        Console.WriteLine("Message: " + exception.Message);
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
                string moduleAPIName = "Leads";
                long fieldId = 347702619;
                GetPickListValues_1(fieldId, moduleAPIName);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}

