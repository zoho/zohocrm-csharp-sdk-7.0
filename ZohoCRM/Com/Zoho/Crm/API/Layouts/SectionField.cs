using Com.Zoho.Crm.API.Fields;
using Com.Zoho.Crm.API.Modules;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Layouts
{

	public class SectionField : Fields.Fields , Model
	{
		private bool? required;
		private Dictionary<string, object> validationRule;
		private string defaultValue;
		private int? sequenceNumber;
		private int? sectionId;
		private bool? blueprintSupported;
		private string jsonType;
		private int? length;
		private int? decimalPlace;
		private Fields.MultiModuleLookup multiModuleLookup;
		private Modules.SharingProperties sharingProperties;
		private Fields.Currency currency;
		private List<Fields.FileUpoladOption> fileUpoladOptionlist;
		private Fields.Lookup lookup;
		private Fields.Subform subform;
		private Fields.Formula formula;
		private Fields.Multiselectlookup multiselectlookup;
		private Fields.Multiselectlookup multiuserlookup;
		private List<Fields.PickListValue> pickListValues;
		private List<Modules.MinifiedModule> allowedModules;
		private bool? hipaaComplianceEnabled;
		private Fields.HipaaCompliance hipaaCompliance;
		private List<StaticValues> staticValues;
		private bool? staticField;
		private List<Fields.LayoutAssociation> layoutAssociations;
		private Delete1 delete;
		private Modules.MinifiedModule associatedModule;
		private string dataType;
		private Fields.OperationType operationType;
		private bool? systemMandatory;
		private bool? webhook;
		private bool? virtualField;
		private bool? fieldReadOnly;
		private List<string> customizableProperties;
		private bool? readOnly;
		private bool? customField;
		private bool? businesscardSupported;
		private bool? filterable;
		private bool? visible;
		private bool? availableInUserLayout;
		private bool? displayField;
		private bool? pickListValuesSortedLexically;
		private bool? sortable;
		private bool? separator;
		private bool? searchable;
		private bool? enableColourCode;
		private bool? massUpdate;
		private string createdSource;
		private string type;
		private string displayLabel;
		private string columnName;
		private string apiName;
		private int? displayType;
		private int? uiType;
		private bool? colourCodeEnabledBySystem;
		private string quickSequenceNumber;
		private Fields.EmailParser emailParser;
		private Fields.RollupSummary rollupSummary;
		private Fields.ReferFromField referFromField;
		private DateTimeOffset? createdTime;
		private DateTimeOffset? modifiedTime;
		private int? showType;
		private int? category;
		private long? id;
		private List<Fields.Profile> profiles;
		private Fields.ViewType viewType;
		private Fields.Unique unique;
		private Modules.MinifiedModule subModule;
		private Fields.External external;
		private Fields.Private private1;
		private Fields.ConvertMapping convertMapping;
		private Fields.AutoNumber autonumber;
		private Fields.AutoNumber autoNumber71;
		private Fields.Crypt crypt;
		private Fields.Tooltip tooltip;
		private Fields.HistoryTracking historyTracking;
		private Fields.AssociationDetails associationDetails;
		private string additionalColumn;
		private string fieldLabel;
		private object globalPicklist;
		private bool? updateexistingrecords;
		private bool? numberSeparator;
		private Fields.Textarea textarea;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? Required
		{
			/// <summary>The method to get the required</summary>
			/// <returns>bool? representing the required</returns>
			get
			{
				return  this.required;

			}
			/// <summary>The method to set the value to required</summary>
			/// <param name="required">bool?</param>
			set
			{
				 this.required=value;

				 this.keyModified["required"] = 1;

			}
		}

		public Dictionary<string, object> ValidationRule
		{
			/// <summary>The method to get the validationRule</summary>
			/// <returns>Dictionary representing the validationRule<String,Object></returns>
			get
			{
				return  this.validationRule;

			}
			/// <summary>The method to set the value to validationRule</summary>
			/// <param name="validationRule">Dictionary<string,object></param>
			set
			{
				 this.validationRule=value;

				 this.keyModified["validation_rule"] = 1;

			}
		}

		public string DefaultValue
		{
			/// <summary>The method to get the defaultValue</summary>
			/// <returns>string representing the defaultValue</returns>
			get
			{
				return  this.defaultValue;

			}
			/// <summary>The method to set the value to defaultValue</summary>
			/// <param name="defaultValue">string</param>
			set
			{
				 this.defaultValue=value;

				 this.keyModified["default_value"] = 1;

			}
		}

		public int? SequenceNumber
		{
			/// <summary>The method to get the sequenceNumber</summary>
			/// <returns>int? representing the sequenceNumber</returns>
			get
			{
				return  this.sequenceNumber;

			}
			/// <summary>The method to set the value to sequenceNumber</summary>
			/// <param name="sequenceNumber">int?</param>
			set
			{
				 this.sequenceNumber=value;

				 this.keyModified["sequence_number"] = 1;

			}
		}

		public int? SectionId
		{
			/// <summary>The method to get the sectionId</summary>
			/// <returns>int? representing the sectionId</returns>
			get
			{
				return  this.sectionId;

			}
			/// <summary>The method to set the value to sectionId</summary>
			/// <param name="sectionId">int?</param>
			set
			{
				 this.sectionId=value;

				 this.keyModified["section_id"] = 1;

			}
		}

		public bool? BlueprintSupported
		{
			/// <summary>The method to get the blueprintSupported</summary>
			/// <returns>bool? representing the blueprintSupported</returns>
			get
			{
				return  this.blueprintSupported;

			}
			/// <summary>The method to set the value to blueprintSupported</summary>
			/// <param name="blueprintSupported">bool?</param>
			set
			{
				 this.blueprintSupported=value;

				 this.keyModified["blueprint_supported"] = 1;

			}
		}

		public string JsonType
		{
			/// <summary>The method to get the jsonType</summary>
			/// <returns>string representing the jsonType</returns>
			get
			{
				return  this.jsonType;

			}
			/// <summary>The method to set the value to jsonType</summary>
			/// <param name="jsonType">string</param>
			set
			{
				 this.jsonType=value;

				 this.keyModified["json_type"] = 1;

			}
		}

		public int? Length
		{
			/// <summary>The method to get the length</summary>
			/// <returns>int? representing the length</returns>
			get
			{
				return  this.length;

			}
			/// <summary>The method to set the value to length</summary>
			/// <param name="length">int?</param>
			set
			{
				 this.length=value;

				 this.keyModified["length"] = 1;

			}
		}

		public int? DecimalPlace
		{
			/// <summary>The method to get the decimalPlace</summary>
			/// <returns>int? representing the decimalPlace</returns>
			get
			{
				return  this.decimalPlace;

			}
			/// <summary>The method to set the value to decimalPlace</summary>
			/// <param name="decimalPlace">int?</param>
			set
			{
				 this.decimalPlace=value;

				 this.keyModified["decimal_place"] = 1;

			}
		}

		public Fields.MultiModuleLookup MultiModuleLookup
		{
			/// <summary>The method to get the multiModuleLookup</summary>
			/// <returns>Instance of MultiModuleLookup</returns>
			get
			{
				return  this.multiModuleLookup;

			}
			/// <summary>The method to set the value to multiModuleLookup</summary>
			/// <param name="multiModuleLookup">Instance of MultiModuleLookup</param>
			set
			{
				 this.multiModuleLookup=value;

				 this.keyModified["multi_module_lookup"] = 1;

			}
		}

		public Modules.SharingProperties SharingProperties
		{
			/// <summary>The method to get the sharingProperties</summary>
			/// <returns>Instance of SharingProperties</returns>
			get
			{
				return  this.sharingProperties;

			}
			/// <summary>The method to set the value to sharingProperties</summary>
			/// <param name="sharingProperties">Instance of SharingProperties</param>
			set
			{
				 this.sharingProperties=value;

				 this.keyModified["sharing_properties"] = 1;

			}
		}

		public Fields.Currency Currency
		{
			/// <summary>The method to get the currency</summary>
			/// <returns>Instance of Currency</returns>
			get
			{
				return  this.currency;

			}
			/// <summary>The method to set the value to currency</summary>
			/// <param name="currency">Instance of Currency</param>
			set
			{
				 this.currency=value;

				 this.keyModified["currency"] = 1;

			}
		}

		public List<Fields.FileUpoladOption> FileUpoladOptionlist
		{
			/// <summary>The method to get the fileUpoladOptionlist</summary>
			/// <returns>Instance of List<FileUpoladOption></returns>
			get
			{
				return  this.fileUpoladOptionlist;

			}
			/// <summary>The method to set the value to fileUpoladOptionlist</summary>
			/// <param name="fileUpoladOptionlist">Instance of List<FileUpoladOption></param>
			set
			{
				 this.fileUpoladOptionlist=value;

				 this.keyModified["file_upolad_optionlist"] = 1;

			}
		}

		public Fields.Lookup Lookup
		{
			/// <summary>The method to get the lookup</summary>
			/// <returns>Instance of Lookup</returns>
			get
			{
				return  this.lookup;

			}
			/// <summary>The method to set the value to lookup</summary>
			/// <param name="lookup">Instance of Lookup</param>
			set
			{
				 this.lookup=value;

				 this.keyModified["lookup"] = 1;

			}
		}

		public Fields.Subform Subform
		{
			/// <summary>The method to get the subform</summary>
			/// <returns>Instance of Subform</returns>
			get
			{
				return  this.subform;

			}
			/// <summary>The method to set the value to subform</summary>
			/// <param name="subform">Instance of Subform</param>
			set
			{
				 this.subform=value;

				 this.keyModified["subform"] = 1;

			}
		}

		public Fields.Formula Formula
		{
			/// <summary>The method to get the formula</summary>
			/// <returns>Instance of Formula</returns>
			get
			{
				return  this.formula;

			}
			/// <summary>The method to set the value to formula</summary>
			/// <param name="formula">Instance of Formula</param>
			set
			{
				 this.formula=value;

				 this.keyModified["formula"] = 1;

			}
		}

		public Fields.Multiselectlookup Multiselectlookup
		{
			/// <summary>The method to get the multiselectlookup</summary>
			/// <returns>Instance of Multiselectlookup</returns>
			get
			{
				return  this.multiselectlookup;

			}
			/// <summary>The method to set the value to multiselectlookup</summary>
			/// <param name="multiselectlookup">Instance of Multiselectlookup</param>
			set
			{
				 this.multiselectlookup=value;

				 this.keyModified["multiselectlookup"] = 1;

			}
		}

		public Fields.Multiselectlookup Multiuserlookup
		{
			/// <summary>The method to get the multiuserlookup</summary>
			/// <returns>Instance of Multiselectlookup</returns>
			get
			{
				return  this.multiuserlookup;

			}
			/// <summary>The method to set the value to multiuserlookup</summary>
			/// <param name="multiuserlookup">Instance of Multiselectlookup</param>
			set
			{
				 this.multiuserlookup=value;

				 this.keyModified["multiuserlookup"] = 1;

			}
		}

		public List<Fields.PickListValue> PickListValues
		{
			/// <summary>The method to get the pickListValues</summary>
			/// <returns>Instance of List<PickListValue></returns>
			get
			{
				return  this.pickListValues;

			}
			/// <summary>The method to set the value to pickListValues</summary>
			/// <param name="pickListValues">Instance of List<PickListValue></param>
			set
			{
				 this.pickListValues=value;

				 this.keyModified["pick_list_values"] = 1;

			}
		}

		public List<Modules.MinifiedModule> AllowedModules
		{
			/// <summary>The method to get the allowedModules</summary>
			/// <returns>Instance of List<MinifiedModule></returns>
			get
			{
				return  this.allowedModules;

			}
			/// <summary>The method to set the value to allowedModules</summary>
			/// <param name="allowedModules">Instance of List<MinifiedModule></param>
			set
			{
				 this.allowedModules=value;

				 this.keyModified["allowed_modules"] = 1;

			}
		}

		public bool? HipaaComplianceEnabled
		{
			/// <summary>The method to get the hipaaComplianceEnabled</summary>
			/// <returns>bool? representing the hipaaComplianceEnabled</returns>
			get
			{
				return  this.hipaaComplianceEnabled;

			}
			/// <summary>The method to set the value to hipaaComplianceEnabled</summary>
			/// <param name="hipaaComplianceEnabled">bool?</param>
			set
			{
				 this.hipaaComplianceEnabled=value;

				 this.keyModified["hipaa_compliance_enabled"] = 1;

			}
		}

		public Fields.HipaaCompliance HipaaCompliance
		{
			/// <summary>The method to get the hipaaCompliance</summary>
			/// <returns>Instance of HipaaCompliance</returns>
			get
			{
				return  this.hipaaCompliance;

			}
			/// <summary>The method to set the value to hipaaCompliance</summary>
			/// <param name="hipaaCompliance">Instance of HipaaCompliance</param>
			set
			{
				 this.hipaaCompliance=value;

				 this.keyModified["hipaa_compliance"] = 1;

			}
		}

		public List<StaticValues> StaticValues
		{
			/// <summary>The method to get the staticValues</summary>
			/// <returns>Instance of List<StaticValues></returns>
			get
			{
				return  this.staticValues;

			}
			/// <summary>The method to set the value to staticValues</summary>
			/// <param name="staticValues">Instance of List<StaticValues></param>
			set
			{
				 this.staticValues=value;

				 this.keyModified["static_values"] = 1;

			}
		}

		public bool? StaticField
		{
			/// <summary>The method to get the staticField</summary>
			/// <returns>bool? representing the staticField</returns>
			get
			{
				return  this.staticField;

			}
			/// <summary>The method to set the value to staticField</summary>
			/// <param name="staticField">bool?</param>
			set
			{
				 this.staticField=value;

				 this.keyModified["static_field"] = 1;

			}
		}

		public List<Fields.LayoutAssociation> LayoutAssociations
		{
			/// <summary>The method to get the layoutAssociations</summary>
			/// <returns>Instance of List<LayoutAssociation></returns>
			get
			{
				return  this.layoutAssociations;

			}
			/// <summary>The method to set the value to layoutAssociations</summary>
			/// <param name="layoutAssociations">Instance of List<LayoutAssociation></param>
			set
			{
				 this.layoutAssociations=value;

				 this.keyModified["layout_associations"] = 1;

			}
		}

		public Delete1 Delete
		{
			/// <summary>The method to get the delete</summary>
			/// <returns>Instance of Delete1</returns>
			get
			{
				return  this.delete;

			}
			/// <summary>The method to set the value to delete</summary>
			/// <param name="delete">Instance of Delete1</param>
			set
			{
				 this.delete=value;

				 this.keyModified["_delete"] = 1;

			}
		}

		public Modules.MinifiedModule AssociatedModule
		{
			/// <summary>The method to get the associatedModule</summary>
			/// <returns>Instance of MinifiedModule</returns>
			get
			{
				return  this.associatedModule;

			}
			/// <summary>The method to set the value to associatedModule</summary>
			/// <param name="associatedModule">Instance of MinifiedModule</param>
			set
			{
				 this.associatedModule=value;

				 this.keyModified["associated_module"] = 1;

			}
		}

		public string DataType
		{
			/// <summary>The method to get the dataType</summary>
			/// <returns>string representing the dataType</returns>
			get
			{
				return  this.dataType;

			}
			/// <summary>The method to set the value to dataType</summary>
			/// <param name="dataType">string</param>
			set
			{
				 this.dataType=value;

				 this.keyModified["data_type"] = 1;

			}
		}

		public Fields.OperationType OperationType
		{
			/// <summary>The method to get the operationType</summary>
			/// <returns>Instance of OperationType</returns>
			get
			{
				return  this.operationType;

			}
			/// <summary>The method to set the value to operationType</summary>
			/// <param name="operationType">Instance of OperationType</param>
			set
			{
				 this.operationType=value;

				 this.keyModified["operation_type"] = 1;

			}
		}

		public bool? SystemMandatory
		{
			/// <summary>The method to get the systemMandatory</summary>
			/// <returns>bool? representing the systemMandatory</returns>
			get
			{
				return  this.systemMandatory;

			}
			/// <summary>The method to set the value to systemMandatory</summary>
			/// <param name="systemMandatory">bool?</param>
			set
			{
				 this.systemMandatory=value;

				 this.keyModified["system_mandatory"] = 1;

			}
		}

		public bool? Webhook
		{
			/// <summary>The method to get the webhook</summary>
			/// <returns>bool? representing the webhook</returns>
			get
			{
				return  this.webhook;

			}
			/// <summary>The method to set the value to webhook</summary>
			/// <param name="webhook">bool?</param>
			set
			{
				 this.webhook=value;

				 this.keyModified["webhook"] = 1;

			}
		}

		public bool? VirtualField
		{
			/// <summary>The method to get the virtualField</summary>
			/// <returns>bool? representing the virtualField</returns>
			get
			{
				return  this.virtualField;

			}
			/// <summary>The method to set the value to virtualField</summary>
			/// <param name="virtualField">bool?</param>
			set
			{
				 this.virtualField=value;

				 this.keyModified["virtual_field"] = 1;

			}
		}

		public bool? FieldReadOnly
		{
			/// <summary>The method to get the fieldReadOnly</summary>
			/// <returns>bool? representing the fieldReadOnly</returns>
			get
			{
				return  this.fieldReadOnly;

			}
			/// <summary>The method to set the value to fieldReadOnly</summary>
			/// <param name="fieldReadOnly">bool?</param>
			set
			{
				 this.fieldReadOnly=value;

				 this.keyModified["field_read_only"] = 1;

			}
		}

		public List<string> CustomizableProperties
		{
			/// <summary>The method to get the customizableProperties</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.customizableProperties;

			}
			/// <summary>The method to set the value to customizableProperties</summary>
			/// <param name="customizableProperties">Instance of List<string></param>
			set
			{
				 this.customizableProperties=value;

				 this.keyModified["customizable_properties"] = 1;

			}
		}

		public bool? ReadOnly
		{
			/// <summary>The method to get the readOnly</summary>
			/// <returns>bool? representing the readOnly</returns>
			get
			{
				return  this.readOnly;

			}
			/// <summary>The method to set the value to readOnly</summary>
			/// <param name="readOnly">bool?</param>
			set
			{
				 this.readOnly=value;

				 this.keyModified["read_only"] = 1;

			}
		}

		public bool? CustomField
		{
			/// <summary>The method to get the customField</summary>
			/// <returns>bool? representing the customField</returns>
			get
			{
				return  this.customField;

			}
			/// <summary>The method to set the value to customField</summary>
			/// <param name="customField">bool?</param>
			set
			{
				 this.customField=value;

				 this.keyModified["custom_field"] = 1;

			}
		}

		public bool? BusinesscardSupported
		{
			/// <summary>The method to get the businesscardSupported</summary>
			/// <returns>bool? representing the businesscardSupported</returns>
			get
			{
				return  this.businesscardSupported;

			}
			/// <summary>The method to set the value to businesscardSupported</summary>
			/// <param name="businesscardSupported">bool?</param>
			set
			{
				 this.businesscardSupported=value;

				 this.keyModified["businesscard_supported"] = 1;

			}
		}

		public bool? Filterable
		{
			/// <summary>The method to get the filterable</summary>
			/// <returns>bool? representing the filterable</returns>
			get
			{
				return  this.filterable;

			}
			/// <summary>The method to set the value to filterable</summary>
			/// <param name="filterable">bool?</param>
			set
			{
				 this.filterable=value;

				 this.keyModified["filterable"] = 1;

			}
		}

		public bool? Visible
		{
			/// <summary>The method to get the visible</summary>
			/// <returns>bool? representing the visible</returns>
			get
			{
				return  this.visible;

			}
			/// <summary>The method to set the value to visible</summary>
			/// <param name="visible">bool?</param>
			set
			{
				 this.visible=value;

				 this.keyModified["visible"] = 1;

			}
		}

		public bool? AvailableInUserLayout
		{
			/// <summary>The method to get the availableInUserLayout</summary>
			/// <returns>bool? representing the availableInUserLayout</returns>
			get
			{
				return  this.availableInUserLayout;

			}
			/// <summary>The method to set the value to availableInUserLayout</summary>
			/// <param name="availableInUserLayout">bool?</param>
			set
			{
				 this.availableInUserLayout=value;

				 this.keyModified["available_in_user_layout"] = 1;

			}
		}

		public bool? DisplayField
		{
			/// <summary>The method to get the displayField</summary>
			/// <returns>bool? representing the displayField</returns>
			get
			{
				return  this.displayField;

			}
			/// <summary>The method to set the value to displayField</summary>
			/// <param name="displayField">bool?</param>
			set
			{
				 this.displayField=value;

				 this.keyModified["display_field"] = 1;

			}
		}

		public bool? PickListValuesSortedLexically
		{
			/// <summary>The method to get the pickListValuesSortedLexically</summary>
			/// <returns>bool? representing the pickListValuesSortedLexically</returns>
			get
			{
				return  this.pickListValuesSortedLexically;

			}
			/// <summary>The method to set the value to pickListValuesSortedLexically</summary>
			/// <param name="pickListValuesSortedLexically">bool?</param>
			set
			{
				 this.pickListValuesSortedLexically=value;

				 this.keyModified["pick_list_values_sorted_lexically"] = 1;

			}
		}

		public bool? Sortable
		{
			/// <summary>The method to get the sortable</summary>
			/// <returns>bool? representing the sortable</returns>
			get
			{
				return  this.sortable;

			}
			/// <summary>The method to set the value to sortable</summary>
			/// <param name="sortable">bool?</param>
			set
			{
				 this.sortable=value;

				 this.keyModified["sortable"] = 1;

			}
		}

		public bool? Separator
		{
			/// <summary>The method to get the separator</summary>
			/// <returns>bool? representing the separator</returns>
			get
			{
				return  this.separator;

			}
			/// <summary>The method to set the value to separator</summary>
			/// <param name="separator">bool?</param>
			set
			{
				 this.separator=value;

				 this.keyModified["separator"] = 1;

			}
		}

		public bool? Searchable
		{
			/// <summary>The method to get the searchable</summary>
			/// <returns>bool? representing the searchable</returns>
			get
			{
				return  this.searchable;

			}
			/// <summary>The method to set the value to searchable</summary>
			/// <param name="searchable">bool?</param>
			set
			{
				 this.searchable=value;

				 this.keyModified["searchable"] = 1;

			}
		}

		public bool? EnableColourCode
		{
			/// <summary>The method to get the enableColourCode</summary>
			/// <returns>bool? representing the enableColourCode</returns>
			get
			{
				return  this.enableColourCode;

			}
			/// <summary>The method to set the value to enableColourCode</summary>
			/// <param name="enableColourCode">bool?</param>
			set
			{
				 this.enableColourCode=value;

				 this.keyModified["enable_colour_code"] = 1;

			}
		}

		public bool? MassUpdate
		{
			/// <summary>The method to get the massUpdate</summary>
			/// <returns>bool? representing the massUpdate</returns>
			get
			{
				return  this.massUpdate;

			}
			/// <summary>The method to set the value to massUpdate</summary>
			/// <param name="massUpdate">bool?</param>
			set
			{
				 this.massUpdate=value;

				 this.keyModified["mass_update"] = 1;

			}
		}

		public string CreatedSource
		{
			/// <summary>The method to get the createdSource</summary>
			/// <returns>string representing the createdSource</returns>
			get
			{
				return  this.createdSource;

			}
			/// <summary>The method to set the value to createdSource</summary>
			/// <param name="createdSource">string</param>
			set
			{
				 this.createdSource=value;

				 this.keyModified["created_source"] = 1;

			}
		}

		public string Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>string representing the type</returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">string</param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

		public string DisplayLabel
		{
			/// <summary>The method to get the displayLabel</summary>
			/// <returns>string representing the displayLabel</returns>
			get
			{
				return  this.displayLabel;

			}
			/// <summary>The method to set the value to displayLabel</summary>
			/// <param name="displayLabel">string</param>
			set
			{
				 this.displayLabel=value;

				 this.keyModified["display_label"] = 1;

			}
		}

		public string ColumnName
		{
			/// <summary>The method to get the columnName</summary>
			/// <returns>string representing the columnName</returns>
			get
			{
				return  this.columnName;

			}
			/// <summary>The method to set the value to columnName</summary>
			/// <param name="columnName">string</param>
			set
			{
				 this.columnName=value;

				 this.keyModified["column_name"] = 1;

			}
		}

		public string APIName
		{
			/// <summary>The method to get the aPIName</summary>
			/// <returns>string representing the apiName</returns>
			get
			{
				return  this.apiName;

			}
			/// <summary>The method to set the value to aPIName</summary>
			/// <param name="apiName">string</param>
			set
			{
				 this.apiName=value;

				 this.keyModified["api_name"] = 1;

			}
		}

		public int? DisplayType
		{
			/// <summary>The method to get the displayType</summary>
			/// <returns>int? representing the displayType</returns>
			get
			{
				return  this.displayType;

			}
			/// <summary>The method to set the value to displayType</summary>
			/// <param name="displayType">int?</param>
			set
			{
				 this.displayType=value;

				 this.keyModified["display_type"] = 1;

			}
		}

		public int? UiType
		{
			/// <summary>The method to get the uiType</summary>
			/// <returns>int? representing the uiType</returns>
			get
			{
				return  this.uiType;

			}
			/// <summary>The method to set the value to uiType</summary>
			/// <param name="uiType">int?</param>
			set
			{
				 this.uiType=value;

				 this.keyModified["ui_type"] = 1;

			}
		}

		public bool? ColourCodeEnabledBySystem
		{
			/// <summary>The method to get the colourCodeEnabledBySystem</summary>
			/// <returns>bool? representing the colourCodeEnabledBySystem</returns>
			get
			{
				return  this.colourCodeEnabledBySystem;

			}
			/// <summary>The method to set the value to colourCodeEnabledBySystem</summary>
			/// <param name="colourCodeEnabledBySystem">bool?</param>
			set
			{
				 this.colourCodeEnabledBySystem=value;

				 this.keyModified["colour_code_enabled_by_system"] = 1;

			}
		}

		public string QuickSequenceNumber
		{
			/// <summary>The method to get the quickSequenceNumber</summary>
			/// <returns>string representing the quickSequenceNumber</returns>
			get
			{
				return  this.quickSequenceNumber;

			}
			/// <summary>The method to set the value to quickSequenceNumber</summary>
			/// <param name="quickSequenceNumber">string</param>
			set
			{
				 this.quickSequenceNumber=value;

				 this.keyModified["quick_sequence_number"] = 1;

			}
		}

		public Fields.EmailParser EmailParser
		{
			/// <summary>The method to get the emailParser</summary>
			/// <returns>Instance of EmailParser</returns>
			get
			{
				return  this.emailParser;

			}
			/// <summary>The method to set the value to emailParser</summary>
			/// <param name="emailParser">Instance of EmailParser</param>
			set
			{
				 this.emailParser=value;

				 this.keyModified["email_parser"] = 1;

			}
		}

		public Fields.RollupSummary RollupSummary
		{
			/// <summary>The method to get the rollupSummary</summary>
			/// <returns>Instance of RollupSummary</returns>
			get
			{
				return  this.rollupSummary;

			}
			/// <summary>The method to set the value to rollupSummary</summary>
			/// <param name="rollupSummary">Instance of RollupSummary</param>
			set
			{
				 this.rollupSummary=value;

				 this.keyModified["rollup_summary"] = 1;

			}
		}

		public Fields.ReferFromField ReferFromField
		{
			/// <summary>The method to get the referFromField</summary>
			/// <returns>Instance of ReferFromField</returns>
			get
			{
				return  this.referFromField;

			}
			/// <summary>The method to set the value to referFromField</summary>
			/// <param name="referFromField">Instance of ReferFromField</param>
			set
			{
				 this.referFromField=value;

				 this.keyModified["refer_from_field"] = 1;

			}
		}

		public DateTimeOffset? CreatedTime
		{
			/// <summary>The method to get the createdTime</summary>
			/// <returns>DateTimeOffset? representing the createdTime</returns>
			get
			{
				return  this.createdTime;

			}
			/// <summary>The method to set the value to createdTime</summary>
			/// <param name="createdTime">DateTimeOffset?</param>
			set
			{
				 this.createdTime=value;

				 this.keyModified["created_time"] = 1;

			}
		}

		public DateTimeOffset? ModifiedTime
		{
			/// <summary>The method to get the modifiedTime</summary>
			/// <returns>DateTimeOffset? representing the modifiedTime</returns>
			get
			{
				return  this.modifiedTime;

			}
			/// <summary>The method to set the value to modifiedTime</summary>
			/// <param name="modifiedTime">DateTimeOffset?</param>
			set
			{
				 this.modifiedTime=value;

				 this.keyModified["modified_time"] = 1;

			}
		}

		public int? ShowType
		{
			/// <summary>The method to get the showType</summary>
			/// <returns>int? representing the showType</returns>
			get
			{
				return  this.showType;

			}
			/// <summary>The method to set the value to showType</summary>
			/// <param name="showType">int?</param>
			set
			{
				 this.showType=value;

				 this.keyModified["show_type"] = 1;

			}
		}

		public int? Category
		{
			/// <summary>The method to get the category</summary>
			/// <returns>int? representing the category</returns>
			get
			{
				return  this.category;

			}
			/// <summary>The method to set the value to category</summary>
			/// <param name="category">int?</param>
			set
			{
				 this.category=value;

				 this.keyModified["category"] = 1;

			}
		}

		public long? Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>long? representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">long?</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

			}
		}

		public List<Fields.Profile> Profiles
		{
			/// <summary>The method to get the profiles</summary>
			/// <returns>Instance of List<Profile></returns>
			get
			{
				return  this.profiles;

			}
			/// <summary>The method to set the value to profiles</summary>
			/// <param name="profiles">Instance of List<Profile></param>
			set
			{
				 this.profiles=value;

				 this.keyModified["profiles"] = 1;

			}
		}

		public Fields.ViewType ViewType
		{
			/// <summary>The method to get the viewType</summary>
			/// <returns>Instance of ViewType</returns>
			get
			{
				return  this.viewType;

			}
			/// <summary>The method to set the value to viewType</summary>
			/// <param name="viewType">Instance of ViewType</param>
			set
			{
				 this.viewType=value;

				 this.keyModified["view_type"] = 1;

			}
		}

		public Fields.Unique Unique
		{
			/// <summary>The method to get the unique</summary>
			/// <returns>Instance of Unique</returns>
			get
			{
				return  this.unique;

			}
			/// <summary>The method to set the value to unique</summary>
			/// <param name="unique">Instance of Unique</param>
			set
			{
				 this.unique=value;

				 this.keyModified["unique"] = 1;

			}
		}

		public Modules.MinifiedModule SubModule
		{
			/// <summary>The method to get the subModule</summary>
			/// <returns>Instance of MinifiedModule</returns>
			get
			{
				return  this.subModule;

			}
			/// <summary>The method to set the value to subModule</summary>
			/// <param name="subModule">Instance of MinifiedModule</param>
			set
			{
				 this.subModule=value;

				 this.keyModified["sub_module"] = 1;

			}
		}

		public Fields.External External
		{
			/// <summary>The method to get the external</summary>
			/// <returns>Instance of External</returns>
			get
			{
				return  this.external;

			}
			/// <summary>The method to set the value to external</summary>
			/// <param name="external">Instance of External</param>
			set
			{
				 this.external=value;

				 this.keyModified["external"] = 1;

			}
		}

		public Fields.Private Private
		{
			/// <summary>The method to get the private</summary>
			/// <returns>Instance of Private</returns>
			get
			{
				return  this.private1;

			}
			/// <summary>The method to set the value to private</summary>
			/// <param name="private1">Instance of Private</param>
			set
			{
				 this.private1=value;

				 this.keyModified["private"] = 1;

			}
		}

		public Fields.ConvertMapping ConvertMapping
		{
			/// <summary>The method to get the convertMapping</summary>
			/// <returns>Instance of ConvertMapping</returns>
			get
			{
				return  this.convertMapping;

			}
			/// <summary>The method to set the value to convertMapping</summary>
			/// <param name="convertMapping">Instance of ConvertMapping</param>
			set
			{
				 this.convertMapping=value;

				 this.keyModified["convert_mapping"] = 1;

			}
		}

		public Fields.AutoNumber Autonumber
		{
			/// <summary>The method to get the autonumber</summary>
			/// <returns>Instance of AutoNumber</returns>
			get
			{
				return  this.autonumber;

			}
			/// <summary>The method to set the value to autonumber</summary>
			/// <param name="autonumber">Instance of AutoNumber</param>
			set
			{
				 this.autonumber=value;

				 this.keyModified["autonumber"] = 1;

			}
		}

		public Fields.AutoNumber AutoNumber71
		{
			/// <summary>The method to get the autoNumber71</summary>
			/// <returns>Instance of AutoNumber</returns>
			get
			{
				return  this.autoNumber71;

			}
			/// <summary>The method to set the value to autoNumber71</summary>
			/// <param name="autoNumber71">Instance of AutoNumber</param>
			set
			{
				 this.autoNumber71=value;

				 this.keyModified["auto_number"] = 1;

			}
		}

		public Fields.Crypt Crypt
		{
			/// <summary>The method to get the crypt</summary>
			/// <returns>Instance of Crypt</returns>
			get
			{
				return  this.crypt;

			}
			/// <summary>The method to set the value to crypt</summary>
			/// <param name="crypt">Instance of Crypt</param>
			set
			{
				 this.crypt=value;

				 this.keyModified["crypt"] = 1;

			}
		}

		public Fields.Tooltip Tooltip
		{
			/// <summary>The method to get the tooltip</summary>
			/// <returns>Instance of Tooltip</returns>
			get
			{
				return  this.tooltip;

			}
			/// <summary>The method to set the value to tooltip</summary>
			/// <param name="tooltip">Instance of Tooltip</param>
			set
			{
				 this.tooltip=value;

				 this.keyModified["tooltip"] = 1;

			}
		}

		public Fields.HistoryTracking HistoryTracking
		{
			/// <summary>The method to get the historyTracking</summary>
			/// <returns>Instance of HistoryTracking</returns>
			get
			{
				return  this.historyTracking;

			}
			/// <summary>The method to set the value to historyTracking</summary>
			/// <param name="historyTracking">Instance of HistoryTracking</param>
			set
			{
				 this.historyTracking=value;

				 this.keyModified["history_tracking"] = 1;

			}
		}

		public Fields.AssociationDetails AssociationDetails
		{
			/// <summary>The method to get the associationDetails</summary>
			/// <returns>Instance of AssociationDetails</returns>
			get
			{
				return  this.associationDetails;

			}
			/// <summary>The method to set the value to associationDetails</summary>
			/// <param name="associationDetails">Instance of AssociationDetails</param>
			set
			{
				 this.associationDetails=value;

				 this.keyModified["association_details"] = 1;

			}
		}

		public string AdditionalColumn
		{
			/// <summary>The method to get the additionalColumn</summary>
			/// <returns>string representing the additionalColumn</returns>
			get
			{
				return  this.additionalColumn;

			}
			/// <summary>The method to set the value to additionalColumn</summary>
			/// <param name="additionalColumn">string</param>
			set
			{
				 this.additionalColumn=value;

				 this.keyModified["additional_column"] = 1;

			}
		}

		public string FieldLabel
		{
			/// <summary>The method to get the fieldLabel</summary>
			/// <returns>string representing the fieldLabel</returns>
			get
			{
				return  this.fieldLabel;

			}
			/// <summary>The method to set the value to fieldLabel</summary>
			/// <param name="fieldLabel">string</param>
			set
			{
				 this.fieldLabel=value;

				 this.keyModified["field_label"] = 1;

			}
		}

		public object GlobalPicklist
		{
			/// <summary>The method to get the globalPicklist</summary>
			/// <returns>object representing the globalPicklist</returns>
			get
			{
				return  this.globalPicklist;

			}
			/// <summary>The method to set the value to globalPicklist</summary>
			/// <param name="globalPicklist">object</param>
			set
			{
				 this.globalPicklist=value;

				 this.keyModified["global_picklist"] = 1;

			}
		}

		public bool? Updateexistingrecords
		{
			/// <summary>The method to get the updateexistingrecords</summary>
			/// <returns>bool? representing the updateexistingrecords</returns>
			get
			{
				return  this.updateexistingrecords;

			}
			/// <summary>The method to set the value to updateexistingrecords</summary>
			/// <param name="updateexistingrecords">bool?</param>
			set
			{
				 this.updateexistingrecords=value;

				 this.keyModified["_update_existing_records"] = 1;

			}
		}

		public bool? NumberSeparator
		{
			/// <summary>The method to get the numberSeparator</summary>
			/// <returns>bool? representing the numberSeparator</returns>
			get
			{
				return  this.numberSeparator;

			}
			/// <summary>The method to set the value to numberSeparator</summary>
			/// <param name="numberSeparator">bool?</param>
			set
			{
				 this.numberSeparator=value;

				 this.keyModified["number_separator"] = 1;

			}
		}

		public Fields.Textarea Textarea
		{
			/// <summary>The method to get the textarea</summary>
			/// <returns>Instance of Textarea</returns>
			get
			{
				return  this.textarea;

			}
			/// <summary>The method to set the value to textarea</summary>
			/// <param name="textarea">Instance of Textarea</param>
			set
			{
				 this.textarea=value;

				 this.keyModified["textarea"] = 1;

			}
		}

		/// <summary>The method to check if the user has modified the given key</summary>
		/// <param name="key">string</param>
		/// <returns>int? representing the modification</returns>
		public int? IsKeyModified(string key)
		{
			if((( this.keyModified.ContainsKey(key))))
			{
				return  this.keyModified[key];

			}
			return null;


		}

		/// <summary>The method to mark the given key as modified</summary>
		/// <param name="key">string</param>
		/// <param name="modification">int?</param>
		public void SetKeyModified(string key, int? modification)
		{
			 this.keyModified[key] = modification;


		}


	}
}