using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using System.Collections.Generic;
using Com.Zoho.Crm.API.InventoryMassConvert;
using Com.Zoho.Crm.API.Util;
using System.Reflection;
using Module = Com.Zoho.Crm.API.InventoryMassConvert.Module;
using Newtonsoft.Json;

namespace Samples.InventoryMassConvert
{
    public class MassInventoryConvert
    {
        public static void MassInventoryConvert_1(String moduleAPIName)
        {
            InventoryMassConvertOperations inventoryMassConvertOperations = new InventoryMassConvertOperations(moduleAPIName);
            BodyWrapper bodyWrapper = new BodyWrapper();

            List<ConvertTo> convertToList = new List<ConvertTo>();
            ConvertTo convertTo = new ConvertTo();
            Module module = new Module();
            module.APIName = "Sales_Orders";
            module.Id = 3477002221;
            convertTo.Module = module;
            convertTo.CarryOverTags = false;
            convertToList.Add(convertTo);
            bodyWrapper.ConvertTo = convertToList;

            User assignTo = new User();
            assignTo.Id = 34770173021;
            bodyWrapper.AssignTo = assignTo;

            List<RelatedModules> relatedModules = new List<RelatedModules>();

            RelatedModules relatedModule = new RelatedModules();
            relatedModule.APIName = "347700033015";
            relatedModule.Id = 34770613015;
            relatedModules.Add(relatedModule);

            relatedModule = new RelatedModules();
            relatedModule.APIName = "Tasks";
            relatedModule.Id = 3477002193;
            relatedModules.Add(relatedModule);

            bodyWrapper.RelatedModules = relatedModules;

            bodyWrapper.Ids = new List<long?>() { 347704001, 34770087 };

            APIResponse<ActionResponse> response = inventoryMassConvertOperations.MassInventoryConvert(bodyWrapper);
            if (response != null)
            {
                Console.WriteLine("Status Code: " + response.StatusCode);
                if (response.IsExpected)
                {
                    ActionResponse actionHandler = response.Object;
                    if (actionHandler is SuccessResponse)
                    {
                        SuccessResponse successResponse = (SuccessResponse)actionHandler;
                        Console.WriteLine("Status: " + successResponse.Status.Value);
                        Console.WriteLine("Code: " + successResponse.Code.Value);
                        Console.WriteLine("Details: ");
                        foreach (KeyValuePair<string, object> entry in successResponse.Details)
                        {
                            Console.WriteLine(entry.Key + ": " + entry.Value);
                        }
                        Console.WriteLine("Message: " + successResponse.Message.Value);
                    }
                    else if (actionHandler is APIException)
                    {
                        APIException exception = (APIException)actionHandler;
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
                IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").Build();
                new Initializer.Builder().Environment(environment).Token(token).Initialize();
                String moduleAPIName = "Quotes";
                MassInventoryConvert_1(moduleAPIName);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}