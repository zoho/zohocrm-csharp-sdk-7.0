using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Taxes
{

	public class ActionWrapper : Model, ActionHandler
	{
		private ActionResponse orgTaxes;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public ActionResponse OrgTaxes
		{
			/// <summary>The method to get the orgTaxes</summary>
			/// <returns>Instance of ActionResponse</returns>
			get
			{
				return  this.orgTaxes;

			}
			/// <summary>The method to set the value to orgTaxes</summary>
			/// <param name="orgTaxes">Instance of ActionResponse</param>
			set
			{
				 this.orgTaxes=value;

				 this.keyModified["org_taxes"] = 1;

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