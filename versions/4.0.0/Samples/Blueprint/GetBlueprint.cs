using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using APIException = Com.Zoho.Crm.API.Blueprint.APIException;
using BlueprintOperations = Com.Zoho.Crm.API.Blueprint.BlueprintOperations;
using Currency = Com.Zoho.Crm.API.Blueprint.Currency;
using Escalation = Com.Zoho.Crm.API.Blueprint.Escalation;
using Field = Com.Zoho.Crm.API.Blueprint.Field;
using Layout = Com.Zoho.Crm.API.Blueprint.Layout;
using NextTransition = Com.Zoho.Crm.API.Blueprint.NextTransition;
using ProcessInfo = Com.Zoho.Crm.API.Blueprint.ProcessInfo;
using ResponseHandler = Com.Zoho.Crm.API.Blueprint.ResponseHandler;
using ResponseWrapper = Com.Zoho.Crm.API.Blueprint.ResponseWrapper;
using Transition = Com.Zoho.Crm.API.Blueprint.Transition;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using External = Com.Zoho.Crm.API.Fields.External;
using Maps = Com.Zoho.Crm.API.Fields.Maps;
using Module = Com.Zoho.Crm.API.Blueprint.Module;
using MultiModuleLookup = Com.Zoho.Crm.API.Fields.MultiModuleLookup;
using PickListValue = Com.Zoho.Crm.API.Fields.PickListValue;
using MultiSelectLookup = Com.Zoho.Crm.API.Blueprint.MultiSelectLookup;
using ToolTip = Com.Zoho.Crm.API.Blueprint.ToolTip;
using Unique = Com.Zoho.Crm.API.Fields.Unique;
using ViewType = Com.Zoho.Crm.API.Blueprint.ViewType;
using Record = Com.Zoho.Crm.API.Record.Record;
using MinifiedUser = Com.Zoho.Crm.API.Users.MinifiedUser;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.Blueprint
{
    public class GetBlueprint
    {
        public static void GetBlueprint_1(string moduleAPIName, string recordId)
        {
            BlueprintOperations bluePrintOperations = new BlueprintOperations(recordId, moduleAPIName);
            APIResponse<ResponseHandler> response = bluePrintOperations.GetBlueprint();
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
                        Com.Zoho.Crm.API.Blueprint.BluePrint bluePrint = responseWrapper.Blueprint;
                        ProcessInfo processInfo = bluePrint.ProcessInfo;
                        if (processInfo != null)
                        {
                            Console.WriteLine("ProcessInfo Field-ID: " + processInfo.FieldId);
                            Escalation escalation = processInfo.Escalation;
                            if (escalation != null)
                            {
                                Console.WriteLine("Escalation days: " + escalation.Days);
                                Console.WriteLine("Escalation status: " + escalation.Status);
                            }
                            Console.WriteLine("ProcessInfo isContinuous: " + processInfo.IsContinuous);
                            Console.WriteLine("ProcessInfo API Name: " + processInfo.APIName);
                            Console.WriteLine("ProcessInfo Continuous: " + processInfo.Continuous);
                            Console.WriteLine("ProcessInfo FieldLabel: " + processInfo.FieldLabel);
                            Console.WriteLine("ProcessInfo Name: " + processInfo.Name);
                            Console.WriteLine("ProcessInfo ColumnName: " + processInfo.ColumnName);
                            Console.WriteLine("ProcessInfo FieldValue: " + processInfo.FieldValue);
                            Console.WriteLine("ProcessInfo ID: " + processInfo.Id);
                            Console.WriteLine("ProcessInfo FieldName: " + processInfo.FieldName);
                        }
                        List<Transition> transitions = bluePrint.Transitions;
                        foreach (Transition transition in transitions)
                        {
                            List<NextTransition> nextTransitions = transition.NextTransitions;
                            foreach (NextTransition nextTransition in nextTransitions)
                            {
                                Console.WriteLine("NextTransition ID: " + nextTransition.Id);
                                Console.WriteLine("NextTransition criteria_matched: " + nextTransition.CriteriaMatched);
                                Console.WriteLine("NextTransition Name: " + nextTransition.Name);
                                Console.WriteLine("NextTransition type: " + nextTransition.Type);
                            }
                            Transition parentTransition = transition.ParentTransition;
                            if (parentTransition != null)
                            {
                                Console.WriteLine("Parenttransition ID: " + parentTransition.Id);
                            }
                            Com.Zoho.Crm.API.Record.Record data = transition.Data;
                            Console.WriteLine("Record ID: " + data.Id);
                            MinifiedUser createdBy = data.CreatedBy;
                            if (createdBy != null)
                            {
                                Console.WriteLine("Record Created By User-ID: " + createdBy.Id);
                                Console.WriteLine("Record Created By User-Name: " + createdBy.Name);
                            }
                            if (data.CreatedTime != null)
                            {
                                Console.WriteLine("Record Created Time: " + data.CreatedTime);
                            }
                            if (data.ModifiedTime != null)
                            {
                                Console.WriteLine("Record Modified Time: " + data.ModifiedTime);
                            }
                            MinifiedUser modifiedBy = data.ModifiedBy;
                            if (modifiedBy != null)
                            {
                                Console.WriteLine("Record Modified By User-ID: " + modifiedBy.Id);
                                Console.WriteLine("Record Modified By user-Name: " + modifiedBy.Name);
                            }
                            foreach (KeyValuePair<string, object> entry in data.GetKeyValues())
                            {
                                Console.WriteLine(entry.Key + ": " + entry.Value);
                            }
                            Console.WriteLine("Transition NextFieldValue: " + transition.NextFieldValue);
                            Console.WriteLine("Transition Name: " + transition.Name);
                            Console.WriteLine("Transition CriteriaMatched: " + transition.CriteriaMatched);
                            Console.WriteLine("Transition ID: " + transition.Id);
                            Console.WriteLine("Transition Fields: ");
                            List<Field> fields = transition.Fields;
                            foreach (Field fieldHandler in fields)
                            {
                                Field field = (Field)fieldHandler;
                                if (field.SystemMandatory != null)
                                {
                                    Console.WriteLine("Field is SystemMandatory: " + field.SystemMandatory);
                                }
                                Console.WriteLine("Field is Private" + field.Private);
                                Console.WriteLine("Transition Fields Webhook: " + field.Webhook);
                                Console.WriteLine("Transition Fields JsonType: " + field.JsonType);
                                Console.WriteLine("Transition Fields DisplayLabel: " + field.DisplayLabel);
                                Console.WriteLine("Transition Fields UiType: " + field.UiType);
                                Console.WriteLine("Transition Fields ValidationRule: " + field.ValidationRule);
                                Console.WriteLine("Transition Fields DataType: " + field.DataType);
                                Console.WriteLine("Transition Fields Type: " + field.Type);
                                Console.WriteLine("Transition Fields ColumnName: " + field.ColumnName);
                                Console.WriteLine("Transition Fields PersonalityName: " + field.PersonalityName);
                                Console.WriteLine("Transition Fields ID: " + field.Id);
                                Console.WriteLine("Transition Fields TransitionSequence: " + field.TransitionSequence);
                                if (field.Mandatory != null)
                                {
                                    Console.WriteLine("Transition Fields Mandatory: " + field.Mandatory);
                                }
                                Layout layout = field.Layouts;
                                if (layout != null)
                                {
                                    Console.WriteLine("Transition Fields Layout ID: " + layout.Id);
                                    Console.WriteLine("Transition Fields Layout Name: " + layout.Name);
                                }
                                Console.WriteLine("Field PickListValuesSortedLexically: " + field.PickListValuesSortedLexically);
                                Console.WriteLine("Field Sortable: " + field.Sortable);
                                Console.WriteLine("Field TransitionSequence: " + field.TransitionSequence);
                                External external = field.External;
                                if (external != null)
                                {
                                    Console.WriteLine("Field External Show: " + external.Show);
                                    Console.WriteLine("Field External Type: " + external.Type);
                                    Console.WriteLine("Field External AllowMultipleConfig: " + external.AllowMultipleConfig);
                                }
                                Unique unique = field.Unique;
                                if (unique != null)
                                {
                                    Console.WriteLine("Field Unique Casesensitive : " + unique.Casesensitive);
                                }
                                if (field.HistoryTracking != null)
                                {
                                    Console.WriteLine("Field HistoryTracking: " + field.HistoryTracking);
                                }
                                Console.WriteLine("Field DataType: " + field.DataType);
                                Console.WriteLine("Transition Fields APIName: " + field.APIName);
                                Console.WriteLine("Transition Fields Content: " + field.Content);
                                if (field.SystemMandatory != null)
                                {
                                    Console.WriteLine("Transition Fields SystemMandatory: " + field.SystemMandatory);
                                }
                                Console.WriteLine("Transition Fields FieldLabel: " + field.FieldLabel);
                                MultiModuleLookup multiModuleLookup = field.MultiModuleLookup;
                                if (multiModuleLookup != null)
                                {
                                    Console.WriteLine("Field MultiModuleLookup APIName: " + multiModuleLookup.APIName);
                                    Console.WriteLine("Field MultiModuleLookup DisplayLabel: " + multiModuleLookup.DisplayLabel);
                                    if(multiModuleLookup.Modules != null)
                                    {
                                        foreach (Com.Zoho.Crm.API.Modules.MinifiedModule module in multiModuleLookup.Modules)
                                        {
                                            Console.WriteLine("Field MultiModuleLookup Module ID: " + module.Id);
                                            Console.WriteLine("Field MultiModuleLookup Module APIName: " + module.APIName);
                                        }
                                    }
                                }
                                Currency currency = field.Currency;
                                if (currency != null)
                                {
                                    Console.WriteLine("Field Currency RoundingOption: " + currency.RoundingOption);
                                    if (currency.Precision != null)
                                    {
                                        Console.WriteLine("Field Currency Precision: " + currency.Precision);
                                    }
                                }
                                ToolTip toolTip = field.Tooltip;
                                if (toolTip != null)
                                {
                                    Console.WriteLine("Transition Fields Tooltip Name: " + toolTip.Name);
                                    Console.WriteLine("Transition Fields Tooltip Value: " + toolTip.Value);
                                }
                                Console.WriteLine("Transition Fields CreatedSource: " + field.CreatedSource);
                                if (field.FieldReadOnly != null)
                                {
                                    Console.WriteLine("Transition Fields FieldReadOnly: " + field.FieldReadOnly);
                                }
                                if (field.DisplayType != null)
                                {
                                    Console.WriteLine("Transition Fields DisplayType: " + field.DisplayType);
                                }
                                if (field.ReadOnly != null)
                                {
                                    Console.WriteLine("Transition Fields ReadOnly: " + field.ReadOnly);
                                }
                                Console.WriteLine("Transition Fields AssociationDetails: " + field.AssociationDetails);
                                if (field.QuickSequenceNumber != null)
                                {
                                    Console.WriteLine("Transition Fields QuickSequenceNumber: " + field.QuickSequenceNumber);
                                }
                                if (field.CustomField != null)
                                {
                                    Console.WriteLine("Transition Fields CustomField: " + field.CustomField);
                                }
                                Module lookup = field.Lookup;
                                if (lookup != null)
                                {
                                    Console.WriteLine("Field ModuleLookup DisplayLabel: " + lookup.DisplayLabel);
                                    Console.WriteLine("Field ModuleLookup APIName: " + lookup.APIName);
                                    Console.WriteLine("Field ModuleLookup Module: " + lookup.Module_1);
                                    if (lookup.Id != null)
                                    {
                                        Console.WriteLine("Field ModuleLookup ID: " + lookup.Id);
                                    }
                                }
                                Console.WriteLine("Field Filterable: " + field.Filterable);
                                if (field.Visible != null)
                                {
                                    Console.WriteLine("Transition Fields Visible: " + field.Visible);
                                }
                                List<Com.Zoho.Crm.API.Blueprint.Profile> profiles = field.Profiles;
                                if (profiles != null)
                                {
                                    foreach (Com.Zoho.Crm.API.Blueprint.Profile profile in profiles)
                                    {
                                        Console.WriteLine("Field Profile PermissionType: " + profile.PermissionType);
                                        Console.WriteLine("Field Profile Name: " + profile.Name);
                                        Console.WriteLine("Field Profile Id: " + profile.Id);
                                    }
                                }
                                if (field.Formula != null)
                                {
                                    if (field.Formula.Expression != null)
                                    {
                                        Console.WriteLine("Field Formula Expression :  " + field.Formula.Expression);
                                    }
                                }
                                if (field.DecimalPlace != null)
                                {
                                    Console.WriteLine("Field DecimalPlace: " + field.DecimalPlace);
                                }
                                if (field.Length != null)
                                {
                                    Console.WriteLine("Transition Fields Length: " + field.Length);
                                }
                                Console.WriteLine("Transition Fields DecimalPlace: " + field.DecimalPlace);
                                ViewType viewType = field.ViewType;
                                if (viewType != null)
                                {
                                    Console.WriteLine("Transition Fields ViewType View: " + viewType.View);
                                    Console.WriteLine("Transition Fields ViewType Edit: " + viewType.Edit);
                                    Console.WriteLine("Transition Fields ViewType Create: " + viewType.Create);
                                    Console.WriteLine("Transition Fields ViewType QuickCreate: " + viewType.QuickCreate);
                                }
                                List<PickListValue> pickListValues = field.PickListValues;
                                if (pickListValues != null)
                                {
                                    foreach (PickListValue pickListValue in pickListValues)
                                    {
                                        PrintPickListValue(pickListValue);
                                    }
                                }
                                MultiSelectLookup multiSelectLookup = field.Multiselectlookup;
                                if (multiSelectLookup != null)
                                {
                                    Console.WriteLine("Transition Fields MultiSelectLookup DisplayLabel: " + multiSelectLookup.DisplayLabel);
                                    Console.WriteLine("Transition Fields MultiSelectLookup LinkingModule: " + multiSelectLookup.LinkingModule);
                                    Console.WriteLine("Transition Fields MultiSelectLookup LookupApiname: " + multiSelectLookup.LookupApiname);
                                    Console.WriteLine("Transition Fields MultiSelectLookup APIName: " + multiSelectLookup.APIName);
                                    Console.WriteLine("Transition Fields MultiSelectLookup ConnectedlookupApiname: " + multiSelectLookup.ConnectedlookupApiname);
                                    Console.WriteLine("Transition Fields MultiSelectLookup ID: " + multiSelectLookup.Id);
                                }
                                Com.Zoho.Crm.API.Blueprint.AutoNumber autoNumber = field.AutoNumber;
                                if (autoNumber != null)
                                {
                                    Console.WriteLine("Transition Fields AutoNumber Prefix: " + autoNumber.Prefix);
                                    Console.WriteLine("Transition Fields AutoNumber Suffix: " + autoNumber.Suffix);
                                    if (autoNumber.StartNumber != null)
                                    {
                                        Console.WriteLine("Transition Fields Auto StartNumber: " + autoNumber.StartNumber);
                                    }
                                }
                                Console.WriteLine("Transition Fields ConvertMapping: ");
                                if (field.ConvertMapping != null)
                                {
                                    foreach (KeyValuePair<string, object> entry in field.ConvertMapping)
                                    {
                                        Console.WriteLine(entry.Key + ": " + entry.Value);
                                    }
                                }
                            }
                            Console.WriteLine("Transition CriteriaMessage: " + transition.CriteriaMessage);
                            Console.WriteLine("Transition PercentPartialSave: " + transition.PercentPartialSave);
                            Console.WriteLine("Transition ExecutionTime: " + transition.ExecutionTime);
                            Console.WriteLine("Transition Type: " + transition.Type);
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
        public static void PrintPickListValue(PickListValue pickListValue)
        {
            Console.WriteLine(" Fields PickListValue DisplayValue: " + pickListValue.DisplayValue);
            Console.WriteLine(" Fields PickListValue SequenceNumber: " + pickListValue.SequenceNumber);
            Console.WriteLine(" Fields PickListValue ExpectedDataType: " + pickListValue.ExpectedDataType);
            Console.WriteLine(" Fields PickListValue ActualValue: " + pickListValue.ActualValue);
            Console.WriteLine(" Fields PickListValue SysRefName: " + pickListValue.SysRefName);
            Console.WriteLine(" Fields PickListValue Type: " + pickListValue.Type);
            Console.WriteLine(" Fields PickListValue Id: " + pickListValue.Id);
            foreach (Maps map in pickListValue.Maps)
            {
                Console.WriteLine(map);
                List<PickListValue> pickListValues = map.PickListValues;
                if (pickListValues != null)
                {
                    foreach (PickListValue plv in pickListValues)
                    {
                        PrintPickListValue(plv);
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
                string recordId = "3473121042";
                GetBlueprint_1(moduleAPIName, recordId);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}