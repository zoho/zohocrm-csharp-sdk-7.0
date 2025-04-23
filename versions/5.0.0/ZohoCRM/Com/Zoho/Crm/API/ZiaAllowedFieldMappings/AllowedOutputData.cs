using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaAllowedFieldMappings
{

	public class AllowedOutputData : Model
	{
		private EnrichField enrichField;
		private List<CrmField> crmFields;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public EnrichField EnrichField
		{
			/// <summary>The method to get the enrichField</summary>
			/// <returns>Instance of EnrichField</returns>
			get
			{
				return  this.enrichField;

			}
			/// <summary>The method to set the value to enrichField</summary>
			/// <param name="enrichField">Instance of EnrichField</param>
			set
			{
				 this.enrichField=value;

				 this.keyModified["enrich_field"] = 1;

			}
		}

		public List<CrmField> CrmFields
		{
			/// <summary>The method to get the crmFields</summary>
			/// <returns>Instance of List<CrmField></returns>
			get
			{
				return  this.crmFields;

			}
			/// <summary>The method to set the value to crmFields</summary>
			/// <param name="crmFields">Instance of List<CrmField></param>
			set
			{
				 this.crmFields=value;

				 this.keyModified["crm_fields"] = 1;

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