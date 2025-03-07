using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.Modules;
using System.Collections.Generic;
using Com.Zoho.Crm.API.Profiles;
using BodyWrapper = Com.Zoho.Crm.API.Modules.BodyWrapper;
using Com.Zoho.Crm.API.Util;
using ActionHandler = Com.Zoho.Crm.API.Modules.ActionHandler;
using System.Reflection;
using Newtonsoft.Json;
using APIException = Com.Zoho.Crm.API.Modules.APIException;
using ActionWrapper = Com.Zoho.Crm.API.Modules.ActionWrapper;
using ActionResponse = Com.Zoho.Crm.API.Modules.ActionResponse;
using SuccessResponse = Com.Zoho.Crm.API.Modules.SuccessResponse;

namespace Samples.Modules1
{
    public class CreateCustomModules
    {
        public static void CreateCustomModules_1()
        {
            ModulesOperations moduleOperations = new ModulesOperations();
            List<Modules> modules = new List<Modules>();
            List<MinifiedProfile> profiles = new List<MinifiedProfile>();
            Modules module = new Modules();
            module.PluralLabel = "Stocks";
            module.SingularLabel = "Stock";
            MinifiedProfile profile = new MinifiedProfile();
            profile.Id = 3477061277005;
            profiles.Add(profile);
            module.Profiles = profiles;
            module.APIName = "stock";
            Dictionary<string,object> displayField = new Dictionary<string, object>();
            displayField.Add("field_label", "My name field label");
            displayField.Add("data_type", "autonumber");
            Dictionary<string, object> autoNumber = new Dictionary<string, object>();
            autoNumber.Add("prefix", "ZOHOCRM");
            autoNumber.Add("start_number", "1003");
            autoNumber.Add("suffix", "BRANCH");
            displayField.Add("auto_number", autoNumber);
            module.DisplayField = displayField;
            modules.Add(module);
            BodyWrapper request = new BodyWrapper();
            request.Modules = modules;
            APIResponse<ActionHandler> response = moduleOperations.CreateCustomModules(request);
            if (response != null)
            {
                Console.WriteLine("Status Code: " + response.StatusCode);
                if (response.IsExpected)
                {
                    ActionHandler actionHandler = response.Object;
                    if (actionHandler is ActionWrapper)
                    {
                        ActionWrapper actionWrapper = (ActionWrapper)actionHandler;
                        List<ActionResponse> actionresponses = actionWrapper.Modules;
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
                                Console.WriteLine("Message: " + successresponse.Message.Value);
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
                CreateCustomModules_1();
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}