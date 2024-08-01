using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using APIException = Com.Zoho.Crm.API.Blueprint.APIException;
using ActionHandler = Com.Zoho.Crm.API.Blueprint.ActionHandler;
using BlueprintOperations = Com.Zoho.Crm.API.Blueprint.BlueprintOperations;
using BodyWrapper = Com.Zoho.Crm.API.Blueprint.BodyWrapper;
using Escalation = Com.Zoho.Crm.API.Blueprint.Escalation;
using NextTransition = Com.Zoho.Crm.API.Blueprint.NextTransition;
using ProcessInfo = Com.Zoho.Crm.API.Blueprint.ProcessInfo;
using SuccessResponse = Com.Zoho.Crm.API.Blueprint.SuccessResponse;
using Transition = Com.Zoho.Crm.API.Blueprint.Transition;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.Blueprint
{
    public class UpdateBlueprint
    {
        public static void UpdateBlueprint_1(string moduleAPIName, string recordId, string transitionId)
        {
            BlueprintOperations bluePrintOperations = new BlueprintOperations(recordId, moduleAPIName);
            BodyWrapper bodyWrapper = new BodyWrapper();
            List<Com.Zoho.Crm.API.Blueprint.BluePrint> bluePrintList = new List<Com.Zoho.Crm.API.Blueprint.BluePrint>();
            Com.Zoho.Crm.API.Blueprint.BluePrint bluePrint = new Com.Zoho.Crm.API.Blueprint.BluePrint();
            bluePrint.TransitionId = transitionId;
            Com.Zoho.Crm.API.Record.Record data = new Com.Zoho.Crm.API.Record.Record();
            Dictionary<string, object> lookup = new Dictionary<string, object>();
            lookup.Add("Phone", "8972937");
            lookup.Add("id", "8972937");
            data.AddKeyValue("Phone", "892937");
            data.AddKeyValue("Notes", "Updated via blueprint");
            Dictionary<string, object> attachments = new Dictionary<string, object>();
            List<string> fileIds = new List<string>();
            fileIds.Add("blojtd2d13b5f044e4041a3315793fb21ef");
            attachments.Add("file_id", fileIds);
            attachments.Add("link_url", "ww.zoho.com");
            //		data.AddKeyValue("Attachments", attachments);
            List<Dictionary<string, object>> listings = new List<Dictionary<string, object>>();
            Dictionary<string, object> interested_listings = new Dictionary<string, object>();
            interested_listings.Add("id", 36521978005L);
            listings.Add(interested_listings);
            //		data.AddKeyValue("Listings", listings);
            List<Dictionary<string, object>> multiuser = new List<Dictionary<string, object>>();
            Dictionary<string, object> multi_user = new Dictionary<string, object>();
            multi_user.Add("name", "givenname");
            multi_user.Add("id", 36527186017L);
            multiuser.Add(multi_user);
            //		data.AddKeyValue("Multi_user", multiuser);
            ProcessInfo processinfo = new ProcessInfo();
            processinfo.APIName = "apiname";
            processinfo.ColumnName = "columnname";
            processinfo.Continuous = false;
            processinfo.FieldId = 323243l;
            processinfo.FieldLabel = "fieldlabel";
            processinfo.FieldName = "field_name";
            processinfo.Id = "32900132223";
            processinfo.IsContinuous = false;
            processinfo.Name = "name";
            Escalation escalation = new Escalation();
            escalation.Days = 1;
            escalation.Status = "overdue";
            processinfo.Escalation = escalation;
            //		bluePrint.ProcessInfo = processinfo;
            List<Transition> transitions = new List<Transition>();
            Transition transition = new Transition();
            transition.Type = "manual";
            List<NextTransition> nextTransitions = new List<NextTransition>();
            NextTransition nexttransition = new NextTransition();
            nexttransition.Id = "36523973921103";
            nexttransition.Name = "call later";
            nexttransition.Type = "manual";
            nexttransition.CriteriaMatched = false;
            nextTransitions.Add(nexttransition);
            transition.NextTransitions = nextTransitions;
            transitions.Add(transition);
            //		bluePrint.Transitions = transitions;
            List<Dictionary<string, object>> checkLists = new List<Dictionary<string, object>>();
            Dictionary<string, object> checkListItem = new Dictionary<string, object>();
            checkListItem.Add("list 1", true);
            checkLists.Add(checkListItem);
            checkListItem = new Dictionary<string, object>();
            checkListItem.Add("list 2", true);
            checkLists.Add(checkListItem);
            checkListItem = new Dictionary<string, object>();
            checkListItem.Add("list 3", true);
            checkLists.Add(checkListItem);
            //		data.AddKeyValue("CheckLists", checkLists);
            Dictionary<string, object> tasks = new Dictionary<string, object>();
            tasks.Add("Subject", "Event");
            //		data.AddKeyValue("Tasks", tasks);
            bluePrint.Data = data;
            bluePrintList.Add(bluePrint);
            bodyWrapper.Blueprint = bluePrintList;
            APIResponse<ActionHandler> response = bluePrintOperations.UpdateBlueprint(bodyWrapper);
            if (response != null)
            {
                Console.WriteLine("Status Code: " + response.StatusCode);
                if (response.IsExpected)
                {
                    ActionHandler actionResponse = response.Object;
                    if (actionResponse is SuccessResponse)
                    {
                        SuccessResponse successResponse = (SuccessResponse)actionResponse;
                        Console.WriteLine("Status: " + successResponse.Status.Value);
                        Console.WriteLine("Code: " + successResponse.Code.Value);
                        Console.WriteLine("Details: ");
                        if (successResponse.Details != null)
                        {
                            foreach (KeyValuePair<string, object> entry in successResponse.Details)
                            {
                                Console.WriteLine(entry.Key + ": " + entry.Value);
                            }
                        }
                        Console.WriteLine("Message: " + successResponse.Message.Value);
                    }
                    else if (actionResponse is APIException)
                    {
                        APIException exception = (APIException)actionResponse;
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
                IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").RedirectURL("Redirect_URL").Build();
                new Initializer.Builder().Environment(environment).Token(token).Initialize();
                string moduleAPIName = "Leads";
                string recordId = "34770611002";
                string transitionId = "343122189321";
                UpdateBlueprint_1(moduleAPIName, recordId, transitionId);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}