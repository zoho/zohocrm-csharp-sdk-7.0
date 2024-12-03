using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Fields
{

	public class EmailParser : Model
	{
		private bool? fieldsUpdateSupported;
		private bool? recordOperationsSupported;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? FieldsUpdateSupported
		{
			/// <summary>The method to get the fieldsUpdateSupported</summary>
			/// <returns>bool? representing the fieldsUpdateSupported</returns>
			get
			{
				return  this.fieldsUpdateSupported;

			}
			/// <summary>The method to set the value to fieldsUpdateSupported</summary>
			/// <param name="fieldsUpdateSupported">bool?</param>
			set
			{
				 this.fieldsUpdateSupported=value;

				 this.keyModified["fields_update_supported"] = 1;

			}
		}

		public bool? RecordOperationsSupported
		{
			/// <summary>The method to get the recordOperationsSupported</summary>
			/// <returns>bool? representing the recordOperationsSupported</returns>
			get
			{
				return  this.recordOperationsSupported;

			}
			/// <summary>The method to set the value to recordOperationsSupported</summary>
			/// <param name="recordOperationsSupported">bool?</param>
			set
			{
				 this.recordOperationsSupported=value;

				 this.keyModified["record_operations_supported"] = 1;

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