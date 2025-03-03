using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Org
{

	public class CheckinPreferences : Model
	{
		private string restrictedEventTypes;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string RestrictedEventTypes
		{
			/// <summary>The method to get the restrictedEventTypes</summary>
			/// <returns>string representing the restrictedEventTypes</returns>
			get
			{
				return  this.restrictedEventTypes;

			}
			/// <summary>The method to set the value to restrictedEventTypes</summary>
			/// <param name="restrictedEventTypes">string</param>
			set
			{
				 this.restrictedEventTypes=value;

				 this.keyModified["restricted_event_types"] = 1;

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