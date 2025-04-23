using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.UsersTerritories;
using Com.Zoho.Crm.API.Util;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection;

namespace Samples.UsersTerritories
{
    public class RemoveTerritoryFromUser
    {
        public static void RemoveTerritoryFromUser_1(long userId, long territory)
        {
            UsersTerritoriesOperations usersTerritoriesOperations = new UsersTerritoriesOperations(userId);
            APIResponse<ActionHandler> response = usersTerritoriesOperations.RemoveTerritoryFromUser(territory);
            if (response != null)
            {
                Console.WriteLine("Status Code: " + response.StatusCode);
                if (response.IsExpected)
                {
                    ActionHandler actionHandler = response.Object;
                    if (actionHandler is ActionWrapper)
                    {
                        ActionWrapper actionWrapper = (ActionWrapper)actionHandler;
                        List<ActionResponse> actionresponses = actionWrapper.Territories;
                        foreach (ActionResponse actionresponse in actionresponses)
                        {
                            if (actionresponse is SuccessResponse)
                            {
                                SuccessResponse successresponse = (SuccessResponse)actionresponse;
                                Console.WriteLine("Status: " + successresponse.Status.Value);
                                Console.WriteLine("Code: " + successresponse.Code.Value);
                                Console.WriteLine("Details: ");
                                foreach (KeyValuePair<string, object> entry in successresponse.Details)
                                {
                                    Console.WriteLine(entry.Key + ": " + entry.Value);
                                }
                                Console.WriteLine("Message: " + successresponse.Message);
                            }
                            else if (actionresponse is APIException)
                            {
                                APIException exception = (APIException)actionresponse;
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
                        Console.WriteLine("Message: " + exception.Message);
                    }
                }
                else
                {
                    Model responseObject = response.Model;
                    System.Type type = responseObject.GetType();
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
                long userId = 34770626323001;
                long territory = 34770626321;
                RemoveTerritoryFromUser_1(userId, territory);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}
