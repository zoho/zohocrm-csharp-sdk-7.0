using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PrivacyPreference
{

	public class PrivacyPreference : Model
	{
		private Preference preference;
		private Config config;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Preference Preference
		{
			/// <summary>The method to get the preference</summary>
			/// <returns>Instance of Preference</returns>
			get
			{
				return  this.preference;

			}
			/// <summary>The method to set the value to preference</summary>
			/// <param name="preference">Instance of Preference</param>
			set
			{
				 this.preference=value;

				 this.keyModified["preference"] = 1;

			}
		}

		public Config Config
		{
			/// <summary>The method to get the config</summary>
			/// <returns>Instance of Config</returns>
			get
			{
				return  this.config;

			}
			/// <summary>The method to set the value to config</summary>
			/// <param name="config">Instance of Config</param>
			set
			{
				 this.config=value;

				 this.keyModified["config"] = 1;

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