using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ShiftHours
{

	public class ShiftCustomTiming : Model
	{
		private string days;
		private List<TimeSpan> shiftTiming;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Days
		{
			/// <summary>The method to get the days</summary>
			/// <returns>string representing the days</returns>
			get
			{
				return  this.days;

			}
			/// <summary>The method to set the value to days</summary>
			/// <param name="days">string</param>
			set
			{
				 this.days=value;

				 this.keyModified["days"] = 1;

			}
		}

		public List<TimeSpan> ShiftTiming
		{
			/// <summary>The method to get the shiftTiming</summary>
			/// <returns>Instance of List<LocalTime></returns>
			get
			{
				return  this.shiftTiming;

			}
			/// <summary>The method to set the value to shiftTiming</summary>
			/// <param name="shiftTiming">Instance of List<TimeSpan></param>
			set
			{
				 this.shiftTiming=value;

				 this.keyModified["shift_timing"] = 1;

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