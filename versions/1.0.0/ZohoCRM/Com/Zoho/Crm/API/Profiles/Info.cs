using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Profiles
{

	public class Info : Model
	{
		private int? licenseLimit;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? LicenseLimit
		{
			/// <summary>The method to get the licenseLimit</summary>
			/// <returns>int? representing the licenseLimit</returns>
			get
			{
				return  this.licenseLimit;

			}
			/// <summary>The method to set the value to licenseLimit</summary>
			/// <param name="licenseLimit">int?</param>
			set
			{
				 this.licenseLimit=value;

				 this.keyModified["license_limit"] = 1;

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