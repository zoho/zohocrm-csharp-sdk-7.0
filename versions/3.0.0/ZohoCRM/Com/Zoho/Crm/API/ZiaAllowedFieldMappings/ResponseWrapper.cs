using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaAllowedFieldMappings
{

	public class ResponseWrapper : Model
	{
		private AllowedFieldMap allowedFieldMappings;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public AllowedFieldMap AllowedFieldMappings
		{
			/// <summary>The method to get the allowedFieldMappings</summary>
			/// <returns>Instance of AllowedFieldMap</returns>
			get
			{
				return  this.allowedFieldMappings;

			}
			/// <summary>The method to set the value to allowedFieldMappings</summary>
			/// <param name="allowedFieldMappings">Instance of AllowedFieldMap</param>
			set
			{
				 this.allowedFieldMappings=value;

				 this.keyModified["allowed_field_mappings"] = 1;

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