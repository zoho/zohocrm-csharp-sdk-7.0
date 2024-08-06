using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.Crm.API.DuplicateCheckPreference;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.API.Authenticator;

namespace Samples.DuplicateCheckPreference1
{
    public class UpdateDuplicateCheckPreference
    {
        public static void UpdateDuplicateCheckPreference_1(string moduleAPIName)
        {
            DuplicateCheckPreferenceOperations duplicateCheckPreferenceOperations = new DuplicateCheckPreferenceOperations(moduleAPIName);
            BodyWrapper request = new BodyWrapper();
            DuplicateCheckPreference duplicateCheckPreference = new DuplicateCheckPreference();
            duplicateCheckPreference.Type = new Choice<String>("mapped_module_records");

            List<TypeConfiguration> typeConfigurations = new List<TypeConfiguration>();
            TypeConfiguration typeConfiguration = new TypeConfiguration();
            MappedModule mappedModule = new MappedModule();
            mappedModule.Id = "34770612175";
            mappedModule.APIName = "Leads";
            typeConfiguration.MappedModule = mappedModule;
            List<FieldMappings> fieldMappings = new List<FieldMappings>();
            FieldMappings fieldMapping = new FieldMappings();
            CurrentField currentField = new CurrentField();
            currentField.Id = "347706106570001";
            currentField.APIName = "Email_1";
            fieldMapping.CurrentField = currentField;

            MappedField mappedField = new MappedField();
            mappedField.Id = "347706123537018";
            mappedField.APIName = "Email_2";
            fieldMapping.MappedField = mappedField;

            fieldMappings.Add(fieldMapping);
            typeConfiguration.FieldMappings = fieldMappings;
            typeConfigurations.Add(typeConfiguration);
            duplicateCheckPreference.TypeConfigurations = typeConfigurations;
            request.DuplicateCheckPreference = duplicateCheckPreference;
            APIResponse<ActionHandler> response = duplicateCheckPreferenceOperations.UpdateDuplicateCheckPreference(request);
            if (response != null)
            {
                Console.WriteLine("Status Code: " + response.StatusCode);
                if (response.IsExpected)
                {
                    ActionHandler actionHandler = response.Object;
                    if (actionHandler is ActionWrapper)
                    {
                        ActionWrapper actionWrapper = (ActionWrapper)actionHandler;
                        ActionResponse actionresponse = actionWrapper.DuplicateCheckPreference;
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
                            Console.WriteLine("Message: " + exception.Message.Value);
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
                string moduleAPIName = "Contacts";
                UpdateDuplicateCheckPreference_1(moduleAPIName);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}

