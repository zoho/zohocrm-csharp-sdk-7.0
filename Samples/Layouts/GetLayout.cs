using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Com.Zoho.Crm.API;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using AssociationDetails = Com.Zoho.Crm.API.Fields.AssociationDetails;
using AutoNumber = Com.Zoho.Crm.API.Fields.AutoNumber;
using Crypt = Com.Zoho.Crm.API.Fields.Crypt;
using Currency = Com.Zoho.Crm.API.Fields.Currency;
using Formula = Com.Zoho.Crm.API.Fields.Formula;
using HistoryTracking = Com.Zoho.Crm.API.Fields.HistoryTracking;
using HistoryTrackingModule = Com.Zoho.Crm.API.Fields.HistoryTrackingModule;
using Lookup = Com.Zoho.Crm.API.Fields.Lookup;
using Maps = Com.Zoho.Crm.API.Fields.Maps;
using Multiselectlookup = Com.Zoho.Crm.API.Fields.Multiselectlookup;
using PickListValue = Com.Zoho.Crm.API.Fields.PickListValue;
using Private = Com.Zoho.Crm.API.Fields.Private;
using Unique = Com.Zoho.Crm.API.Fields.Unique;
using ViewType = Com.Zoho.Crm.API.Fields.ViewType;
using APIException = Com.Zoho.Crm.API.Layouts.APIException;
using ConvertMapping = Com.Zoho.Crm.API.Layouts.ConvertMapping;
using DealLayoutMapping = Com.Zoho.Crm.API.Layouts.DealLayoutMapping;
using DefaultView = Com.Zoho.Crm.API.Layouts.DefaultView;
using LayoutsOperations = Com.Zoho.Crm.API.Layouts.LayoutsOperations;
using GetLayoutsParam = Com.Zoho.Crm.API.Layouts.LayoutsOperations.GetLayoutsParam;
using MinifiedLayout = Com.Zoho.Crm.API.Layouts.MinifiedLayout;
using Profiles = Com.Zoho.Crm.API.Layouts.Profiles;
using Properties = Com.Zoho.Crm.API.Layouts.Properties;
using ResponseHandler = Com.Zoho.Crm.API.Layouts.ResponseHandler;
using ResponseWrapper = Com.Zoho.Crm.API.Layouts.ResponseWrapper;
using Sections = Com.Zoho.Crm.API.Layouts.Sections;
using SectionField = Com.Zoho.Crm.API.Layouts.SectionField;
using Tooltip = Com.Zoho.Crm.API.Layouts.Tooltip;
using MinifiedModule = Com.Zoho.Crm.API.Modules.MinifiedModule;
using MinifiedUser = Com.Zoho.Crm.API.Users.MinifiedUser;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.Layouts
{
    public class GetLayout
    {
        public static void GetLayout_1(string moduleAPIName, long layoutId)
        {
            LayoutsOperations layoutsOperations = new LayoutsOperations();
            ParameterMap paramInstance = new ParameterMap();
            paramInstance.Add(GetLayoutsParam.MODULE, moduleAPIName);
            APIResponse<ResponseHandler> response = layoutsOperations.GetLayout(layoutId, paramInstance);
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
                        List<Com.Zoho.Crm.API.Layouts.Layouts> layouts = responseWrapper.Layouts;
                        foreach (Com.Zoho.Crm.API.Layouts.Layouts layout in layouts)
                        {
                            if (layout.CreatedTime != null)
                            {
                                Console.WriteLine("Layout CreatedTime: " + layout.CreatedTime);
                            }
                            if (layout.ConvertMapping != null)
                            {
                                ConvertMapping convertMapping = layout.ConvertMapping;
                                MinifiedLayout accounts = convertMapping.Accounts;
                                MinifiedLayout contacts = convertMapping.Contacts;
                                DealLayoutMapping deals = convertMapping.Deals;
                            }
                            Console.WriteLine("Layout Visible: " + layout.Visible);
                            MinifiedUser createdFor = layout.CreatedFor;
                            if (createdFor != null)
                            {
                                Console.WriteLine("Layout CreatedFor User-Name: " + createdFor.Name);
                                Console.WriteLine("Layout CreatedFor User-ID: " + createdFor.Id);
                                Console.WriteLine("Layout CreatedFor User-Email: " + createdFor.Email);
                            }
                            List<Profiles> profiles = layout.Profiles;
                            if (profiles != null)
                            {
                                foreach (Profiles profile in profiles)
                                {
                                    Console.WriteLine("Layout Profile Default: " + profile.Default);
                                    Console.WriteLine("Layout Profile Name: " + profile.Name);
                                    Console.WriteLine("Layout Profile ID: " + profile.Id);
                                    DefaultView defaultView = profile.Defaultview;
                                    if (defaultView != null)
                                    {
                                        Console.WriteLine("Layout Profile DefaultView Name: " + defaultView.Name);
                                        Console.WriteLine("Layout Profile DefaultView ID: " + defaultView.Id);
                                        Console.WriteLine("Layout Profile DefaultView Type: " + defaultView.Type);
                                    }
                                }
                            }
                            MinifiedUser createdBy = layout.CreatedBy;
                            if (createdBy != null)
                            {
                                Console.WriteLine("Layout CreatedBy User-Name: " + createdBy.Name);
                                Console.WriteLine("Layout CreatedBy User-ID: " + createdBy.Id);
                                Console.WriteLine("Layout CreatedBy User-Email: " + createdBy.Email);
                            }
                            List<Sections> sections = layout.Sections;
                            if (sections != null)
                            {
                                foreach (Sections section in sections)
                                {
                                    Console.WriteLine("Layout Section DisplayLabel: " + section.DisplayLabel);
                                    Console.WriteLine("Layout Section SequenceNumber: " + section.SequenceNumber);
                                    Console.WriteLine("Layout Section IsSubformSection: " + section.Issubformsection);
                                    Console.WriteLine("Layout Section TabTraversal: " + section.TabTraversal);
                                    Console.WriteLine("Layout Section APIName: " + section.APIName);
                                    Console.WriteLine("Layout Section ColumnCount: " + section.ColumnCount);
                                    Console.WriteLine("Layout Section Name: " + section.Name);
                                    Console.WriteLine("Layout Section GeneratedType: " + section.GeneratedType);
                                    Console.WriteLine("Layout Section Type: " + section.Type);
                                    List<SectionField> fields = section.Fields;
                                    if (fields != null)
                                    {
                                        foreach (Com.Zoho.Crm.API.Fields.Fields field in fields)
                                        {
                                            PrintField(field);
                                        }
                                    }
                                    Properties properties = section.Properties;
                                    if (properties != null)
                                    {
                                        Console.WriteLine("Layout Section Properties ReorderRows: " + properties.ReorderRows);
                                        Tooltip tooltip = properties.Tooltip;
                                        if (tooltip != null)
                                        {
                                            Console.WriteLine("Layout Section Properties ToolTip Name: " + tooltip.Name);
                                            Console.WriteLine("Layout Section Properties ToolTip Value: " + tooltip.Value);
                                        }
                                        Console.WriteLine("Layout Section Properties MaximumRows: " + properties.MaximumRows);
                                    }
                                }
                            }
                            Console.WriteLine("Layout buisness card: " + layout.ShowBusinessCard);
                            if (layout.ModifiedTime != null)
                            {
                                Console.WriteLine("Layout ModifiedTime: " + layout.ModifiedTime);
                            }
                            Console.WriteLine("Layout Name: " + layout.Name);
                            MinifiedUser modifiedBy = layout.ModifiedBy;
                            if (modifiedBy != null)
                            {
                                Console.WriteLine("Layout ModifiedBy User-Name: " + modifiedBy.Name);
                                Console.WriteLine("Layout ModifiedBy User-ID: " + modifiedBy.Id);
                                Console.WriteLine("Layout ModifiedBy User-Email: " + modifiedBy.Email);
                            }
                            Console.WriteLine("Layout ID: " + layout.Id);
                            Console.WriteLine("Layout Status: " + layout.Status);
                            Console.WriteLine("Layout DisplayType : " + layout.DisplayType);
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
        private static void PrintField(Com.Zoho.Crm.API.Fields.Fields field)
        {
            Console.WriteLine("Field SystemMandatory: " + field.SystemMandatory);
            Console.WriteLine("Field Webhook: " + field.Webhook);
            Console.WriteLine("Field JsonType: " + field.JsonType);
            Private privateInfo = field.Private;
            if (privateInfo != null)
            {
                Console.WriteLine("Private Details");
                Console.WriteLine("Field Private Type: " + privateInfo.Type);
                Console.WriteLine("Field Private Export: " + privateInfo.Export);
                Console.WriteLine("Field Private Restricted: " + privateInfo.Restricted);
            }
            Crypt crypt = field.Crypt;
            if (crypt != null)
            {
                Console.WriteLine("Field Crypt Mode: " + crypt.Mode);
                Console.WriteLine("Field Crypt Column: " + crypt.Column);
                Console.WriteLine("Field Crypt Table: " + crypt.Table);
                Console.WriteLine("Field Crypt Status: " + crypt.Status);
                List<string> encFldIds = crypt.Encfldids;
                if (encFldIds != null)
                {
                    Console.WriteLine("EncFldIds : ");
                    foreach (string encFldId in encFldIds)
                    {
                        Console.WriteLine(encFldId);
                    }
                }
                Console.WriteLine("Field Crypt Notify: " + crypt.Notify);
            }
            Console.WriteLine("Field FieldLabel: " + field.FieldLabel);
            Com.Zoho.Crm.API.Fields.Tooltip tooltip = field.Tooltip;
            if (tooltip != null)
            {
                Console.WriteLine("Field ToolTip Name: " + tooltip.Name);
                Console.WriteLine("Field ToolTip Value: " + tooltip.Value);
            }
            Console.WriteLine("Field CreatedSource: " + field.CreatedSource);
            Console.WriteLine("Field FieldReadOnly: " + field.FieldReadOnly);
            Console.WriteLine("Field DisplayLabel: " + field.DisplayLabel);
            Console.WriteLine("Field ReadOnly: " + field.ReadOnly);
            AssociationDetails associationDetails = field.AssociationDetails;
            if (associationDetails != null)
            {
                MinifiedModule lookupField = associationDetails.LookupField;
                if (lookupField != null)
                {
                    Console.WriteLine("Field AssociationDetails LookupField ID: " + lookupField.Id);
                    Console.WriteLine("Field AssociationDetails LookupField Name: " + lookupField.APIName);
                }
                MinifiedModule relatedField = associationDetails.RelatedField;
                if (relatedField != null)
                {
                    Console.WriteLine("Field AssociationDetails RelatedField ID: " + relatedField.Id);
                    Console.WriteLine("Field AssociationDetails RelatedField Name: " + relatedField.APIName);
                }
            }
            Console.WriteLine("Field Filterable: " + field.Filterable);
            if (field.ConvertMapping != null)
            {
                if (field.ConvertMapping != null)
                {
                    Com.Zoho.Crm.API.Fields.ConvertMapping convertMapping = field.ConvertMapping;
                    Console.WriteLine(convertMapping.Accounts);
                    Console.WriteLine(convertMapping.Contacts);
                    Console.WriteLine(convertMapping.Deals);
                }
            }
            if (field.HistoryTracking != null)
            {
                HistoryTracking historytracking = field.HistoryTracking;
                HistoryTrackingModule module = historytracking.Module;
                if (module != null)
                {
                    Com.Zoho.Crm.API.Layouts.Layouts moduleLayout = module.Layout;
                    if (moduleLayout != null)
                    {
                        Console.WriteLine("Module layout id" + moduleLayout.Id);
                    }
                    Console.WriteLine("Module layout display label" + module.DisplayLabel);
                    Console.WriteLine("Module layout api name" + module.APIName);
                    Console.WriteLine("Module layout module" + module.Id);
                    Console.WriteLine("Module layout id" + module.Module);
                    Console.WriteLine("Module layout module name" + module.ModuleName);
                }
                MinifiedModule durationConfigured = historytracking.DurationConfiguredField;
                if (durationConfigured != null)
                {
                    Console.WriteLine("historytracking duration configured field" + durationConfigured.Id);
                }
            }
            Console.WriteLine("Field BusinesscardSupported: " + field.BusinesscardSupported);
            Currency currency = field.Currency;
            if (currency != null)
            {
                Console.WriteLine("Field Currency RoundingOption: " + currency.RoundingOption);
                if (currency.Precision != null)
                {
                    Console.WriteLine("Field Currency Precision: " + currency.Precision);
                }
            }
            Console.WriteLine("Field ID: " + field.Id);
            if (field.CustomField != null)
            {
                Console.WriteLine("Field CustomField: " + field.CustomField);
            }
            Lookup lookup = field.Lookup;
            if (lookup != null)
            {
                Console.WriteLine("Field ModuleLookup DisplayLabel: " + lookup.DisplayLabel);
                Console.WriteLine("Field ModuleLookup APIName: " + lookup.APIName);
                Console.WriteLine("Field ModuleLookup Module: " + lookup.Module);
                if (lookup.Id != null)
                {
                    Console.WriteLine("Field ModuleLookup ID: " + lookup.Id);
                }
            }
            if (field.Visible != null)
            {
                Console.WriteLine("Field Visible: " + field.Visible);
            }
            if (field.PickListValuesSortedLexically != null)
            {
                Console.WriteLine("Field pick list values lexically sorted: " + field.PickListValuesSortedLexically);
            }
            if (field.Sortable != null)
            {
                Console.WriteLine("Field sortable " + field.Sortable);
            }
            if (field.UiType != null)
            {
                Console.WriteLine("Field UI tyle " + field.UiType);
            }
            if (field.SequenceNumber != null)
            {
                Console.WriteLine("Field sequence number " + field.SequenceNumber);
            }
            List<Com.Zoho.Crm.API.Fields.Profile> fieldProfiles = field.Profiles;
            if(fieldProfiles != null)
            {
                foreach (Com.Zoho.Crm.API.Fields.Profile fieldProfile in fieldProfiles)
                {
                    Console.WriteLine("Profile permission Type " + fieldProfile.PermissionType);
                    Console.WriteLine("Profile Name  " + fieldProfile.Name);
                    Console.WriteLine("Profile ID  " + fieldProfile.Id);
                }
            }
            if (field.Length != null)
            {
                Console.WriteLine("Field Length: " + field.Length);
            }
            ViewType viewType = field.ViewType;
            if (viewType != null)
            {
                Console.WriteLine("Field ViewType View: " + viewType.View);
                Console.WriteLine("Field ViewType Edit: " + viewType.Edit);
                Console.WriteLine("Field ViewType Create: " + viewType.Create);
                Console.WriteLine("Field ViewType QuickCreate: " + viewType.QuickCreate);
            }
            MinifiedModule subform = field.AssociatedModule;
            if (subform != null)
            {
                Console.WriteLine("Field Subform Module: " + subform.Module);
                Console.WriteLine("Field Subform ID: " + subform.Id);
            }
            Console.WriteLine("Field APIName: " + field.APIName);
            object unique1 = field.Unique;
            if (unique1 != null)
            {
                if (unique1 is Unique)
                {
                    Unique unique = (Unique)unique1;
                    Console.WriteLine("Field Unique Casesensitive : " + unique.Casesensitive);
                }
                else
                {
                    Console.WriteLine("Field Unique : " + unique1);
                }
            }
            Console.WriteLine("Field DataType: " + field.DataType);
            Formula formula = field.Formula;
            if (formula != null)
            {
                Console.WriteLine("Field Formula ReturnType : " + formula.ReturnType);
                if (formula.Expression != null)
                {
                    Console.WriteLine("Field Formula Expression : " + formula.Expression);
                }
            }
            if (field.DecimalPlace != null)
            {
                Console.WriteLine("Field DecimalPlace: " + field.DecimalPlace);
            }
            Console.WriteLine("Field MassUpdate: " + field.MassUpdate);
            if (field.BlueprintSupported != null)
            {
                Console.WriteLine("Field BlueprintSupported: " + field.BlueprintSupported);
            }
            Multiselectlookup multiSelectLookup = field.Multiselectlookup;
            if (multiSelectLookup != null)
            {
                Console.WriteLine("Field MultiSelectLookup DisplayLabel: " + multiSelectLookup.DisplayLabel);
                Console.WriteLine("Field MultiSelectLookup LinkingModule: " + multiSelectLookup.LinkingModule);
                Console.WriteLine("Field MultiSelectLookup LookupApiname: " + multiSelectLookup.LookupApiname);
                Console.WriteLine("Field MultiSelectLookup APIName: " + multiSelectLookup.APIName);
                Console.WriteLine("Field MultiSelectLookup ConnectedlookupApiname: " + multiSelectLookup.ConnectedlookupApiname);
                Console.WriteLine("Field MultiSelectLookup ID: " + multiSelectLookup.Id);
                Console.WriteLine("Field MultiSelectLookup connected module: " + multiSelectLookup.ConnectedModule);
            }
            List<PickListValue> pickListValues = field.PickListValues;
            if (pickListValues != null)
            {
                foreach (PickListValue pickListValue in pickListValues)
                {
                    PrintPickListValue(pickListValue);
                }
            }
            AutoNumber autoNumber = field.Autonumber;
            if (autoNumber != null)
            {
                Console.WriteLine("Field AutoNumber Prefix: " + autoNumber.Prefix);
                Console.WriteLine("Field AutoNumber Suffix: " + autoNumber.Suffix);
                if (autoNumber.StartNumber != null)
                {
                    Console.WriteLine("Field AutoNumber StartNumber: " + autoNumber.StartNumber);
                }
            }
            if (field.DefaultValue != null)
            {
                Console.WriteLine("Field DefaultValue: " + field.DefaultValue);
            }
            if (field.DisplayType != null)
            {
                Console.WriteLine("Field display type : " + field.DisplayType);
            }
            Console.WriteLine("Get field type" + field.Type);
            if (field.External != null)
            {
                Console.WriteLine("Get External show " + field.External.Show);
                Console.WriteLine("Get External type" + field.External.Type);
                Console.WriteLine("allow multiple config" + field.External.AllowMultipleConfig);
            }
            if (field.Multiuserlookup != null)
            {
                Multiselectlookup multiuserlookup = field.Multiuserlookup;
                Console.WriteLine("Get Multiselectlookup DisplayLabel" + multiuserlookup.DisplayLabel);
                Console.WriteLine("Get Multiselectlookup LinkingModule" + multiuserlookup.LinkingModule);
                Console.WriteLine("Get Multiselectlookup LookupAPIName" + multiuserlookup.LookupApiname);
                Console.WriteLine("Get Multiselectlookup APIName" + multiuserlookup.APIName);
                Console.WriteLine("Get Multiselectlookup Id" + multiuserlookup.Id);
                Console.WriteLine("Get Multiselectlookup ConnectedModule" + multiuserlookup.ConnectedModule);
                Console.WriteLine("Get Multiselectlookup ConnectedlookupAPIName" + multiuserlookup.ConnectedlookupApiname);
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
                        Console.WriteLine(plv);
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
                long layoutId = 4402480167l;
                GetLayout_1(moduleAPIName, layoutId);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}