using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Modules
{

	public class SharingProperties : Model
	{
		private string schedulerStatus;
		private bool? sharePreferenceEnabled;
		private Choice<string> sharePermission;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string SchedulerStatus
		{
			/// <summary>The method to get the schedulerStatus</summary>
			/// <returns>string representing the schedulerStatus</returns>
			get
			{
				return  this.schedulerStatus;

			}
			/// <summary>The method to set the value to schedulerStatus</summary>
			/// <param name="schedulerStatus">string</param>
			set
			{
				 this.schedulerStatus=value;

				 this.keyModified["scheduler_status"] = 1;

			}
		}

		public bool? SharePreferenceEnabled
		{
			/// <summary>The method to get the sharePreferenceEnabled</summary>
			/// <returns>bool? representing the sharePreferenceEnabled</returns>
			get
			{
				return  this.sharePreferenceEnabled;

			}
			/// <summary>The method to set the value to sharePreferenceEnabled</summary>
			/// <param name="sharePreferenceEnabled">bool?</param>
			set
			{
				 this.sharePreferenceEnabled=value;

				 this.keyModified["share_preference_enabled"] = 1;

			}
		}

		public Choice<string> SharePermission
		{
			/// <summary>The method to get the sharePermission</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.sharePermission;

			}
			/// <summary>The method to set the value to sharePermission</summary>
			/// <param name="sharePermission">Instance of Choice<string></param>
			set
			{
				 this.sharePermission=value;

				 this.keyModified["share_permission"] = 1;

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