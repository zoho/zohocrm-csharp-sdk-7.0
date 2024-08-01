using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.GlobalPicklists
{

	public class ReplaceBodyWrapper : Model
	{
		private List<ReplacePicklistValues> replacePicklistValues;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<ReplacePicklistValues> ReplacePicklistValues
		{
			/// <summary>The method to get the replacePicklistValues</summary>
			/// <returns>Instance of List<ReplacePicklistValues></returns>
			get
			{
				return  this.replacePicklistValues;

			}
			/// <summary>The method to set the value to replacePicklistValues</summary>
			/// <param name="replacePicklistValues">Instance of List<ReplacePicklistValues></param>
			set
			{
				 this.replacePicklistValues=value;

				 this.keyModified["replace_picklist_values"] = 1;

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