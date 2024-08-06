using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.AppointmentPreference
{

	public class BodyWrapper : Model
	{
		private AppointmentPreference appointmentPreferences;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public AppointmentPreference AppointmentPreferences
		{
			/// <summary>The method to get the appointmentPreferences</summary>
			/// <returns>Instance of AppointmentPreference</returns>
			get
			{
				return  this.appointmentPreferences;

			}
			/// <summary>The method to set the value to appointmentPreferences</summary>
			/// <param name="appointmentPreferences">Instance of AppointmentPreference</param>
			set
			{
				 this.appointmentPreferences=value;

				 this.keyModified["appointment_preferences"] = 1;

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