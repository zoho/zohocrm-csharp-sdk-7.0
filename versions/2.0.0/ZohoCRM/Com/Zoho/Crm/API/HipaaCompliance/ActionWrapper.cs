using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.HipaaCompliance
{

	public class ActionWrapper : Model
	{
		private ActionResponse hipaaCompliance;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public ActionResponse HipaaCompliance
		{
			/// <summary>The method to get the hipaaCompliance</summary>
			/// <returns>Instance of ActionResponse</returns>
			get
			{
				return  this.hipaaCompliance;

			}
			/// <summary>The method to set the value to hipaaCompliance</summary>
			/// <param name="hipaaCompliance">Instance of ActionResponse</param>
			set
			{
				 this.hipaaCompliance=value;

				 this.keyModified["hipaa_compliance"] = 1;

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