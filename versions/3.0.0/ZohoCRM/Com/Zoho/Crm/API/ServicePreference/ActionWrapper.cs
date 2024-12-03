using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ServicePreference
{

	public class ActionWrapper : Model, ActionHandler
	{
		private ActionResponse servicePreferences;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public ActionResponse ServicePreferences
		{
			/// <summary>The method to get the servicePreferences</summary>
			/// <returns>Instance of ActionResponse</returns>
			get
			{
				return  this.servicePreferences;

			}
			/// <summary>The method to set the value to servicePreferences</summary>
			/// <param name="servicePreferences">Instance of ActionResponse</param>
			set
			{
				 this.servicePreferences=value;

				 this.keyModified["service_preferences"] = 1;

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