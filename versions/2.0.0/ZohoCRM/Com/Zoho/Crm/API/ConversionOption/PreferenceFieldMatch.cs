using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ConversionOption
{

	public class PreferenceFieldMatch : Model
	{
		private Field field;
		private string matchedLeadValue;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Field Field
		{
			/// <summary>The method to get the field</summary>
			/// <returns>Instance of Field</returns>
			get
			{
				return  this.field;

			}
			/// <summary>The method to set the value to field</summary>
			/// <param name="field">Instance of Field</param>
			set
			{
				 this.field=value;

				 this.keyModified["field"] = 1;

			}
		}

		public string MatchedLeadValue
		{
			/// <summary>The method to get the matchedLeadValue</summary>
			/// <returns>string representing the matchedLeadValue</returns>
			get
			{
				return  this.matchedLeadValue;

			}
			/// <summary>The method to set the value to matchedLeadValue</summary>
			/// <param name="matchedLeadValue">string</param>
			set
			{
				 this.matchedLeadValue=value;

				 this.keyModified["matched_lead_value"] = 1;

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