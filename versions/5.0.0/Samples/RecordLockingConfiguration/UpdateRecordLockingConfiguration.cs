using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using System.Collections.Generic;
using Com.Zoho.Crm.API.RecordLockingConfiguration;
using BodyWrapper = Com.Zoho.Crm.API.RecordLockingConfiguration.BodyWrapper;
using Criteria = Com.Zoho.Crm.API.RecordLockingConfiguration.Criteria;
using Com.Zoho.Crm.API.Util;
using ActionHandler = Com.Zoho.Crm.API.RecordLockingConfiguration.ActionHandler;
using ActionWrapper = Com.Zoho.Crm.API.RecordLockingConfiguration.ActionWrapper;
using ActionResponse = Com.Zoho.Crm.API.RecordLockingConfiguration.ActionResponse;
using SuccessResponse = Com.Zoho.Crm.API.RecordLockingConfiguration.SuccessResponse;
using APIException = Com.Zoho.Crm.API.RecordLockingConfiguration.APIException;
using Newtonsoft.Json;
using System.Reflection;

namespace Samples.RecordLockingConfiguration
{
    public class UpdateRecordLockingConfiguration
    {
        public static void UpdateRecordLockingConfiguration_1(long id, String moduleName)
        {
            RecordLockingConfigurationOperations recordLockingConfigurationOperations = new RecordLockingConfigurationOperations(moduleName);
            BodyWrapper bodyWrapper = new BodyWrapper();
            List<RecordLock> lockRecords = new List<RecordLock>();
            RecordLock recordLock = new RecordLock();
            recordLock.LockedFor = "all_profiles_except_excluded_profiles";

            List<LockingRules> lockingRules = new List<LockingRules>();

            LockingRules lockingRule = new LockingRules();
            lockingRule.Id = 347709012;
            lockingRule.Delete = true;
            lockingRules.Add(lockingRule);

            lockingRule = new LockingRules();
            lockingRule.Name = "email rule 34";
            lockingRule.Id = 58431766034;
            lockingRule.LockExistingRecords = false;
            Criteria criteria = new Criteria();
            criteria.Comparator = "equal";
            Field field1 = new Field();
            field1.APIName = "Email";
            field1.Id = 34770612599l;
            criteria.Field = field1;
            criteria.Value = "test@gmail.com";
            lockingRule.Criteria = criteria;
            lockingRules.Add(lockingRule);

            lockingRule = new LockingRules();
            lockingRule.Name = "email rule 5";
            lockingRule.LockExistingRecords = false;
            Criteria criteria1 = new Criteria();
            criteria1.Comparator = "equal";
            Field field12 = new Field();
            field12.APIName = "Email";
            field12.Id = 58431042599;
            criteria1.Field = field12;
            criteria1.Value = "test5@gmail.com";
            lockingRule.Criteria = criteria1;
            lockingRules.Add(lockingRule);

            recordLock.LockingRules = lockingRules;

            recordLock.LockForPortalUsers = true;

            List<String> restrictedCommunications = new List<String>() { "send_mail" };
            recordLock.RestrictedCommunications = restrictedCommunications;
            recordLock.SystemDefined = false;
            recordLock.LockType = new Choice<String>("both");

            List<RestrictedCustomButton> restrictedCustomButtons = new List<RestrictedCustomButton>();
            RestrictedCustomButton restrictedCustomButton = new RestrictedCustomButton();
            restrictedCustomButton.Name = "Send with Zoho Sign";
            restrictedCustomButton.Id = 58431485570;
            restrictedCustomButtons.Add(restrictedCustomButton);
            recordLock.RestrictedCustomButtons = restrictedCustomButtons;

            List<LockExcludedProfile> lockExcludedProfiles = new List<LockExcludedProfile>();
            LockExcludedProfile lockExcludedProfile = new LockExcludedProfile();
            lockExcludedProfile.Name = "Administrator";
            lockExcludedProfile.Id = 584310400026011;
            lockExcludedProfiles.Add(lockExcludedProfile);
            recordLock.LockExcludedProfiles = lockExcludedProfiles;

            lockRecords.Add(recordLock);
            bodyWrapper.RecordLockingConfigurations = lockRecords;
            APIResponse<ActionHandler> response = recordLockingConfigurationOperations.UpdateRecordLockingConfiguration(id, bodyWrapper);
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
                long id = 347938001;
                UpdateRecordLockingConfiguration_1(id, moduleAPIName);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}