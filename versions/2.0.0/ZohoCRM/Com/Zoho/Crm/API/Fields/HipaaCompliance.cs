using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Fields
{

	public class HipaaCompliance : Model
	{
		private bool? restrictedInExport;
		private bool? restricted;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? RestrictedInExport
		{
			/// <summary>The method to get the restrictedInExport</summary>
			/// <returns>bool? representing the restrictedInExport</returns>
			get
			{
				return  this.restrictedInExport;

			}
			/// <summary>The method to set the value to restrictedInExport</summary>
			/// <param name="restrictedInExport">bool?</param>
			set
			{
				 this.restrictedInExport=value;

				 this.keyModified["restricted_in_export"] = 1;

			}
		}

		public bool? Restricted
		{
			/// <summary>The method to get the restricted</summary>
			/// <returns>bool? representing the restricted</returns>
			get
			{
				return  this.restricted;

			}
			/// <summary>The method to set the value to restricted</summary>
			/// <param name="restricted">bool?</param>
			set
			{
				 this.restricted=value;

				 this.keyModified["restricted"] = 1;

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