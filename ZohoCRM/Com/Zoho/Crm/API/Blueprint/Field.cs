using Com.Zoho.Crm.API.Fields;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Blueprint
{

	public class Field : Model
	{
		private Fields.External external;
		private Choice<int?> displayType;
		private bool? filterable;
		private bool? pickListValuesSortedLexically;
		private bool? sortable;
		private int? uiType;
		private Fields.Private private1;
		private bool? systemMandatory;
		private bool? webhook;
		private string jsonType;
		private Crypt crypt;
		private string fieldLabel;
		private ToolTip tooltip;
		private string createdSource;
		private Layout layouts;
		private bool? fieldReadOnly;
		private string content;
		private string displayLabel;
		private string validationRule;
		private bool? readOnly;
		private AssociationDetails associationDetails;
		private Fields.MultiModuleLookup multiModuleLookup;
		private Currency currency;
		private string id;
		private bool? customField;
		private Module lookup;
		private Dictionary<string, object> convertMapping;
		private bool? visible;
		private int? length;
		private string columnName;
		private string type;
		private ViewType viewType;
		private int? transitionSequence;
		private string apiName;
		private Fields.Unique unique;
		private bool? historyTracking;
		private string dataType;
		private Formula formula;
		private string decimalPlace;
		private MultiSelectLookup multiselectlookup;
		private List<Fields.PickListValue> pickListValues;
		private AutoNumber autoNumber;
		private string personalityName;
		private bool? mandatory;
		private long? quickSequenceNumber;
		private List<Profile> profiles;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public Choice<int?> DisplayType
		{
			/// <summary>The method to get the displayType</summary>
			/// <returns>Instance of Choice<Integer></returns>
			get
			{
				return  this.displayType;

			}
			/// <summary>The method to set the value to displayType</summary>
			/// <param name="displayType">Instance of Choice<int?></param>
			set
			{
				 this.displayType=value;

				 this.keyModified["display_type"] = 1;

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

		public Crypt Crypt
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

		public ToolTip Tooltip
		{
			/// <summary>The method to get the tooltip</summary>
			/// <returns>Instance of ToolTip</returns>
			get
			{
				return  this.tooltip;

			}
			/// <summary>The method to set the value to tooltip</summary>
			/// <param name="tooltip">Instance of ToolTip</param>
			set
			{
				 this.tooltip=value;

				 this.keyModified["tooltip"] = 1;

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

		public Layout Layouts
		{
			/// <summary>The method to get the layouts</summary>
			/// <returns>Instance of Layout</returns>
			get
			{
				return  this.layouts;

			}
			/// <summary>The method to set the value to layouts</summary>
			/// <param name="layouts">Instance of Layout</param>
			set
			{
				 this.layouts=value;

				 this.keyModified["layouts"] = 1;

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

		public string Content
		{
			/// <summary>The method to get the content</summary>
			/// <returns>string representing the content</returns>
			get
			{
				return  this.content;

			}
			/// <summary>The method to set the value to content</summary>
			/// <param name="content">string</param>
			set
			{
				 this.content=value;

				 this.keyModified["content"] = 1;

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

		public string ValidationRule
		{
			/// <summary>The method to get the validationRule</summary>
			/// <returns>string representing the validationRule</returns>
			get
			{
				return  this.validationRule;

			}
			/// <summary>The method to set the value to validationRule</summary>
			/// <param name="validationRule">string</param>
			set
			{
				 this.validationRule=value;

				 this.keyModified["validation_rule"] = 1;

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

		public AssociationDetails AssociationDetails
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

		public Currency Currency
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

		public string Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>string representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">string</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

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

		public Module Lookup
		{
			/// <summary>The method to get the lookup</summary>
			/// <returns>Instance of Module</returns>
			get
			{
				return  this.lookup;

			}
			/// <summary>The method to set the value to lookup</summary>
			/// <param name="lookup">Instance of Module</param>
			set
			{
				 this.lookup=value;

				 this.keyModified["lookup"] = 1;

			}
		}

		public Dictionary<string, object> ConvertMapping
		{
			/// <summary>The method to get the convertMapping</summary>
			/// <returns>Dictionary representing the convertMapping<String,Object></returns>
			get
			{
				return  this.convertMapping;

			}
			/// <summary>The method to set the value to convertMapping</summary>
			/// <param name="convertMapping">Dictionary<string,object></param>
			set
			{
				 this.convertMapping=value;

				 this.keyModified["convert_mapping"] = 1;

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

				 this.keyModified["_type"] = 1;

			}
		}

		public ViewType ViewType
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

		public int? TransitionSequence
		{
			/// <summary>The method to get the transitionSequence</summary>
			/// <returns>int? representing the transitionSequence</returns>
			get
			{
				return  this.transitionSequence;

			}
			/// <summary>The method to set the value to transitionSequence</summary>
			/// <param name="transitionSequence">int?</param>
			set
			{
				 this.transitionSequence=value;

				 this.keyModified["transition_sequence"] = 1;

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

		public bool? HistoryTracking
		{
			/// <summary>The method to get the historyTracking</summary>
			/// <returns>bool? representing the historyTracking</returns>
			get
			{
				return  this.historyTracking;

			}
			/// <summary>The method to set the value to historyTracking</summary>
			/// <param name="historyTracking">bool?</param>
			set
			{
				 this.historyTracking=value;

				 this.keyModified["history_tracking"] = 1;

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

		public Formula Formula
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

		public string DecimalPlace
		{
			/// <summary>The method to get the decimalPlace</summary>
			/// <returns>string representing the decimalPlace</returns>
			get
			{
				return  this.decimalPlace;

			}
			/// <summary>The method to set the value to decimalPlace</summary>
			/// <param name="decimalPlace">string</param>
			set
			{
				 this.decimalPlace=value;

				 this.keyModified["decimal_place"] = 1;

			}
		}

		public MultiSelectLookup Multiselectlookup
		{
			/// <summary>The method to get the multiselectlookup</summary>
			/// <returns>Instance of MultiSelectLookup</returns>
			get
			{
				return  this.multiselectlookup;

			}
			/// <summary>The method to set the value to multiselectlookup</summary>
			/// <param name="multiselectlookup">Instance of MultiSelectLookup</param>
			set
			{
				 this.multiselectlookup=value;

				 this.keyModified["multiselectlookup"] = 1;

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

		public AutoNumber AutoNumber
		{
			/// <summary>The method to get the autoNumber</summary>
			/// <returns>Instance of AutoNumber</returns>
			get
			{
				return  this.autoNumber;

			}
			/// <summary>The method to set the value to autoNumber</summary>
			/// <param name="autoNumber">Instance of AutoNumber</param>
			set
			{
				 this.autoNumber=value;

				 this.keyModified["auto_number"] = 1;

			}
		}

		public string PersonalityName
		{
			/// <summary>The method to get the personalityName</summary>
			/// <returns>string representing the personalityName</returns>
			get
			{
				return  this.personalityName;

			}
			/// <summary>The method to set the value to personalityName</summary>
			/// <param name="personalityName">string</param>
			set
			{
				 this.personalityName=value;

				 this.keyModified["personality_name"] = 1;

			}
		}

		public bool? Mandatory
		{
			/// <summary>The method to get the mandatory</summary>
			/// <returns>bool? representing the mandatory</returns>
			get
			{
				return  this.mandatory;

			}
			/// <summary>The method to set the value to mandatory</summary>
			/// <param name="mandatory">bool?</param>
			set
			{
				 this.mandatory=value;

				 this.keyModified["mandatory"] = 1;

			}
		}

		public long? QuickSequenceNumber
		{
			/// <summary>The method to get the quickSequenceNumber</summary>
			/// <returns>long? representing the quickSequenceNumber</returns>
			get
			{
				return  this.quickSequenceNumber;

			}
			/// <summary>The method to set the value to quickSequenceNumber</summary>
			/// <param name="quickSequenceNumber">long?</param>
			set
			{
				 this.quickSequenceNumber=value;

				 this.keyModified["quick_sequence_number"] = 1;

			}
		}

		public List<Profile> Profiles
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