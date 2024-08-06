using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.GlobalPicklists
{

	public class ReplacePicklistValues : Model
	{
		private ReplacePicklistValue newValue;
		private ReplacePicklistValue oldValue;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public ReplacePicklistValue NewValue
		{
			/// <summary>The method to get the newValue</summary>
			/// <returns>Instance of ReplacePicklistValue</returns>
			get
			{
				return  this.newValue;

			}
			/// <summary>The method to set the value to newValue</summary>
			/// <param name="newValue">Instance of ReplacePicklistValue</param>
			set
			{
				 this.newValue=value;

				 this.keyModified["new_value"] = 1;

			}
		}

		public ReplacePicklistValue OldValue
		{
			/// <summary>The method to get the oldValue</summary>
			/// <returns>Instance of ReplacePicklistValue</returns>
			get
			{
				return  this.oldValue;

			}
			/// <summary>The method to set the value to oldValue</summary>
			/// <param name="oldValue">Instance of ReplacePicklistValue</param>
			set
			{
				 this.oldValue=value;

				 this.keyModified["old_value"] = 1;

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