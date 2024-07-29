using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Definition
{

	public class MinifiedProperty : Model
	{
		private bool? readOnly;
		private string apiName;
		private string dataType;
		private int? length;
		private bool? required;
		private List<MinifiedProperty> properties;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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