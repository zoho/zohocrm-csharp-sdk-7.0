using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Timelines
{

	public class FieldHistory : Model
	{
		private string dataType;
		private bool? enableColourCode;
		private List<PicklistDetail> pickListValues;
		private string fieldLabel;
		private string apiName;
		private long? id;
		private FieldHistoryValue value;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public List<PicklistDetail> PickListValues
		{
			/// <summary>The method to get the pickListValues</summary>
			/// <returns>Instance of List<PicklistDetail></returns>
			get
			{
				return  this.pickListValues;

			}
			/// <summary>The method to set the value to pickListValues</summary>
			/// <param name="pickListValues">Instance of List<PicklistDetail></param>
			set
			{
				 this.pickListValues=value;

				 this.keyModified["pick_list_values"] = 1;

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

		public FieldHistoryValue Value
		{
			/// <summary>The method to get the value</summary>
			/// <returns>Instance of FieldHistoryValue</returns>
			get
			{
				return  this.value;

			}
			/// <summary>The method to set the value to value</summary>
			/// <param name="value">Instance of FieldHistoryValue</param>
			set
			{
				 this.value=value;

				 this.keyModified["_value"] = 1;

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