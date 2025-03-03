using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.HipaaCompliance
{

	public class HipaaCompliance : Model
	{
		private bool? enabled;
		private List<Modules> enabledForModules;
		private bool? restrictToZohoApps;
		private bool? restrictDataAccessThroughAPI;
		private bool? restrictDataInExport;
		private List<string> restrictToThirdPartyApps;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? Enabled
		{
			/// <summary>The method to get the enabled</summary>
			/// <returns>bool? representing the enabled</returns>
			get
			{
				return  this.enabled;

			}
			/// <summary>The method to set the value to enabled</summary>
			/// <param name="enabled">bool?</param>
			set
			{
				 this.enabled=value;

				 this.keyModified["enabled"] = 1;

			}
		}

		public List<Modules> EnabledForModules
		{
			/// <summary>The method to get the enabledForModules</summary>
			/// <returns>Instance of List<Modules></returns>
			get
			{
				return  this.enabledForModules;

			}
			/// <summary>The method to set the value to enabledForModules</summary>
			/// <param name="enabledForModules">Instance of List<Modules></param>
			set
			{
				 this.enabledForModules=value;

				 this.keyModified["enabled_for_modules"] = 1;

			}
		}

		public bool? RestrictToZohoApps
		{
			/// <summary>The method to get the restrictToZohoApps</summary>
			/// <returns>bool? representing the restrictToZohoApps</returns>
			get
			{
				return  this.restrictToZohoApps;

			}
			/// <summary>The method to set the value to restrictToZohoApps</summary>
			/// <param name="restrictToZohoApps">bool?</param>
			set
			{
				 this.restrictToZohoApps=value;

				 this.keyModified["restrict_to_zoho_apps"] = 1;

			}
		}

		public bool? RestrictDataAccessThroughAPI
		{
			/// <summary>The method to get the restrictDataAccessThroughAPI</summary>
			/// <returns>bool? representing the restrictDataAccessThroughAPI</returns>
			get
			{
				return  this.restrictDataAccessThroughAPI;

			}
			/// <summary>The method to set the value to restrictDataAccessThroughAPI</summary>
			/// <param name="restrictDataAccessThroughAPI">bool?</param>
			set
			{
				 this.restrictDataAccessThroughAPI=value;

				 this.keyModified["restrict_data_access_through_api"] = 1;

			}
		}

		public bool? RestrictDataInExport
		{
			/// <summary>The method to get the restrictDataInExport</summary>
			/// <returns>bool? representing the restrictDataInExport</returns>
			get
			{
				return  this.restrictDataInExport;

			}
			/// <summary>The method to set the value to restrictDataInExport</summary>
			/// <param name="restrictDataInExport">bool?</param>
			set
			{
				 this.restrictDataInExport=value;

				 this.keyModified["restrict_data_in_export"] = 1;

			}
		}

		public List<string> RestrictToThirdPartyApps
		{
			/// <summary>The method to get the restrictToThirdPartyApps</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.restrictToThirdPartyApps;

			}
			/// <summary>The method to set the value to restrictToThirdPartyApps</summary>
			/// <param name="restrictToThirdPartyApps">Instance of List<string></param>
			set
			{
				 this.restrictToThirdPartyApps=value;

				 this.keyModified["restrict_to_third_party_apps"] = 1;

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