using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ServicePreference
{

	public class ServicePreference : Model
	{
		private bool? jobSheetEnabled;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? JobSheetEnabled
		{
			/// <summary>The method to get the jobSheetEnabled</summary>
			/// <returns>bool? representing the jobSheetEnabled</returns>
			get
			{
				return  this.jobSheetEnabled;

			}
			/// <summary>The method to set the value to jobSheetEnabled</summary>
			/// <param name="jobSheetEnabled">bool?</param>
			set
			{
				 this.jobSheetEnabled=value;

				 this.keyModified["job_sheet_enabled"] = 1;

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