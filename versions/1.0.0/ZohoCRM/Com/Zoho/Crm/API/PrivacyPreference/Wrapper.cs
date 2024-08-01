using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PrivacyPreference
{

	public class Wrapper : Model
	{
		private List<PrivacyPreference> privacypreference;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<PrivacyPreference> Privacypreference
		{
			/// <summary>The method to get the privacypreference</summary>
			/// <returns>Instance of List<PrivacyPreference></returns>
			get
			{
				return  this.privacypreference;

			}
			/// <summary>The method to set the value to privacypreference</summary>
			/// <param name="privacypreference">Instance of List<PrivacyPreference></param>
			set
			{
				 this.privacypreference=value;

				 this.keyModified["privacyPreference"] = 1;

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