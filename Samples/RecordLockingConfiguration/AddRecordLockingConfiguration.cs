using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using System.Collections.Generic;
using System.Reflection;
using Com.Zoho.Crm.API.Fields;
using Com.Zoho.Crm.API.RecordLockingConfiguration;
using Newtonsoft.Json;
using BodyWrapper = Com.Zoho.Crm.API.RecordLockingConfiguration.BodyWrapper;
using Criteria = Com.Zoho.Crm.API.RecordLockingConfiguration.Criteria;
using Com.Zoho.Crm.API.Util;
using ActionHandler = Com.Zoho.Crm.API.RecordLockingConfiguration.ActionHandler;
using ActionWrapper = Com.Zoho.Crm.API.RecordLockingConfiguration.ActionWrapper;
using ActionResponse = Com.Zoho.Crm.API.RecordLockingConfiguration.ActionResponse;
using SuccessResponse = Com.Zoho.Crm.API.RecordLockingConfiguration.SuccessResponse;
using APIException = Com.Zoho.Crm.API.RecordLockingConfiguration.APIException;

namespace Samples.RecordLockingConfiguration
{
    public class AddRecordLockingConfiguration
    {
        public static void AddRecordLockingConfiguration_1(String moduleName)
        {
            RecordLockingConfigurationOperations recordLockingConfigurationOperations = new RecordLockingConfigurationOperations(moduleName);
            BodyWrapper bodyWrapper = new BodyWrapper();
            List<RecordLock> lockRecords = new List<RecordLock>();
            RecordLock recordLock = new RecordLock();
            recordLock.LockedFor = "all_profiles_except_excluded_profiles";

            List<MinifiedField> excludedFields = new List<MinifiedField>();
            MinifiedField excludedField = new MinifiedField();
            excludedField.APIName = "Annual_Revenue";
            excludedField.Id = 347702617;
            excludedFields.Add(excludedField);
            recordLock.ExcludedFields = excludedFields;

            recordLock.FeatureType = "record_locking";

            List<LockingRules> lockingRules = new List<LockingRules>();
            LockingRules lockingRule = new LockingRules();
            lockingRule.Name = "rr";
            lockingRule.LockExistingRecords = false;
            Criteria criteria = new Criteria();
            criteria.Comparator = "equal";

            Field field1 = new Field();
            field1.APIName = "Email";
            field1.Id = 34772599;
            criteria.Field = field1;
            criteria.Value = "test@gmail.co";
            lockingRule.Criteria = criteria;

            lockingRules.Add(lockingRule);
            recordLock.LockingRules = lockingRules;

            List<String> restrictedActions = new List<String>() { "update", "delete", "change_owner" };
            recordLock.RestrictedActions = restrictedActions;
            recordLock.LockForPortalUsers = true;

            List<String> restrictedCommunications = new List<String>() { "send_mail" };
            recordLock.RestrictedCommunications = restrictedCommunications;
            recordLock.SystemDefined = false;
            recordLock.LockType = new Choice<string>("both");

            List<RestrictedCustomButton> restrictedCustomButtons = new List<RestrictedCustomButton>();
            RestrictedCustomButton restrictedCustomButton = new RestrictedCustomButton();
            restrictedCustomButton.Name = "Send Doc";
            restrictedCustomButton.Id = 5843105570;
            restrictedCustomButtons.Add(restrictedCustomButton);
            recordLock.RestrictedCustomButtons = restrictedCustomButtons;

            List<LockExcludedProfile> lockExcludedProfiles = new List<LockExcludedProfile>();
            LockExcludedProfile lockExcludedProfile = new LockExcludedProfile();
            lockExcludedProfile.Name = "Administrator";
            lockExcludedProfile.Id = 347011;
            lockExcludedProfiles.Add(lockExcludedProfile);
            recordLock.LockExcludedProfiles = lockExcludedProfiles;

            lockRecords.Add(recordLock);
            bodyWrapper.RecordLockingConfigurations = lockRecords;
            APIResponse<ActionHandler> response = recordLockingConfigurationOperations.AddRecordLockingConfiguration(bodyWrapper);
            if (response != null)
            {
                Console.WriteLine("Status Code: " + response.StatusCode);
                if (response.IsExpected)
                {
                    ActionHandler actionHandler = response.Object;
                    if (actionHandler is ActionWrapper)
                    {
                        ActionWrapper actionWrapper = (ActionWrapper)actionHandler;
                        List<ActionResponse> actionresponses = actionWrapper.RecordLockingConfigurations;
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
                                Console.WriteLine("Message: " + exception.Message.Value);
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
                        Console.WriteLine("Message: " + exception.Message.Value);
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
                String moduleAPIName = "Deals";
                AddRecordLockingConfiguration_1(moduleAPIName);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}