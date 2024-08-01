using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Definition
{

	public class Property : Model
	{
		private string displayLabel;
		private List<object> allowedValues;
		private int? uiType;
		private string regex;
		private bool? readOnly;
		private string apiName;
		private string fieldLabel;
		private string dataType;
		private int? length;
		private bool? availableInUserLayout;
		private bool? required;
		private List<MinifiedProperty> properties;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public List<object> AllowedValues
		{
			/// <summary>The method to get the allowedValues</summary>
			/// <returns>Instance of List<Object></returns>
			get
			{
				return  this.allowedValues;

			}
			/// <summary>The method to set the value to allowedValues</summary>
			/// <param name="allowedValues">Instance of List<object></param>
			set
			{
				 this.allowedValues=value;

				 this.keyModified["allowed_values"] = 1;

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

		public string Regex
		{
			/// <summary>The method to get the regex</summary>
			/// <returns>string representing the regex</returns>
			get
			{
				return  this.regex;

			}
			/// <summary>The method to set the value to regex</summary>
			/// <param name="regex">string</param>
			set
			{
				 this.regex=value;

				 this.keyModified["regex"] = 1;

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

		public List<MinifiedProperty> Properties
		{
			/// <summary>The method to get the properties</summary>
			/// <returns>Instance of List<MinifiedProperty></returns>
			get
			{
				return  this.properties;

			}
			/// <summary>The method to set the value to properties</summary>
			/// <param name="properties">Instance of List<MinifiedProperty></param>
			set
			{
				 this.properties=value;

				 this.keyModified["properties"] = 1;

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