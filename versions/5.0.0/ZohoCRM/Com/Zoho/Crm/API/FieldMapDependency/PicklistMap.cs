using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.FieldMapDependency
{

	public class PicklistMap : Model
	{
		private long? id;
		private string actualValue;
		private string displayValue;
		private bool? delete;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public string ActualValue
		{
			/// <summary>The method to get the actualValue</summary>
			/// <returns>string representing the actualValue</returns>
			get
			{
				return  this.actualValue;

			}
			/// <summary>The method to set the value to actualValue</summary>
			/// <param name="actualValue">string</param>
			set
			{
				 this.actualValue=value;

				 this.keyModified["actual_value"] = 1;

			}
		}

		public string DisplayValue
		{
			/// <summary>The method to get the displayValue</summary>
			/// <returns>string representing the displayValue</returns>
			get
			{
				return  this.displayValue;

			}
			/// <summary>The method to set the value to displayValue</summary>
			/// <param name="displayValue">string</param>
			set
			{
				 this.displayValue=value;

				 this.keyModified["display_value"] = 1;

			}
		}

		public bool? Delete
		{
			/// <summary>The method to get the delete</summary>
			/// <returns>bool? representing the delete</returns>
			get
			{
				return  this.delete;

			}
			/// <summary>The method to set the value to delete</summary>
			/// <param name="delete">bool?</param>
			set
			{
				 this.delete=value;

				 this.keyModified["_delete"] = 1;

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