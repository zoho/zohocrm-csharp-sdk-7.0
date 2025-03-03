using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ShiftHours
{

	public class BreakHours : Model
	{
		private List<string> breakDays;
		private bool? sameAsEveryday;
		private List<TimeSpan> dailyTiming;
		private List<BreakCustomTiming> customTiming;
		private long? id;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<string> BreakDays
		{
			/// <summary>The method to get the breakDays</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.breakDays;

			}
			/// <summary>The method to set the value to breakDays</summary>
			/// <param name="breakDays">Instance of List<string></param>
			set
			{
				 this.breakDays=value;

				 this.keyModified["break_days"] = 1;

			}
		}

		public bool? SameAsEveryday
		{
			/// <summary>The method to get the sameAsEveryday</summary>
			/// <returns>bool? representing the sameAsEveryday</returns>
			get
			{
				return  this.sameAsEveryday;

			}
			/// <summary>The method to set the value to sameAsEveryday</summary>
			/// <param name="sameAsEveryday">bool?</param>
			set
			{
				 this.sameAsEveryday=value;

				 this.keyModified["same_as_everyday"] = 1;

			}
		}

		public List<TimeSpan> DailyTiming
		{
			/// <summary>The method to get the dailyTiming</summary>
			/// <returns>Instance of List<LocalTime></returns>
			get
			{
				return  this.dailyTiming;

			}
			/// <summary>The method to set the value to dailyTiming</summary>
			/// <param name="dailyTiming">Instance of List<TimeSpan></param>
			set
			{
				 this.dailyTiming=value;

				 this.keyModified["daily_timing"] = 1;

			}
		}

		public List<BreakCustomTiming> CustomTiming
		{
			/// <summary>The method to get the customTiming</summary>
			/// <returns>Instance of List<BreakCustomTiming></returns>
			get
			{
				return  this.customTiming;

			}
			/// <summary>The method to set the value to customTiming</summary>
			/// <param name="customTiming">Instance of List<BreakCustomTiming></param>
			set
			{
				 this.customTiming=value;

				 this.keyModified["custom_timing"] = 1;

			}
		}

		public long? Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>long? representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">long?</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

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