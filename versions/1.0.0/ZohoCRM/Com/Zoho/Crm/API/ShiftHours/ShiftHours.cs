using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ShiftHours
{

	public class ShiftHours : Model
	{
		private bool? sameAsEveryday;
		private List<string> shiftDays;
		private List<TimeSpan> dailyTiming;
		private List<ShiftCustomTiming> customTiming;
		private long? id;
		private List<BreakHours> breakHours;
		private List<Users> users;
		private List<Holidays> holidays;
		private int? usersCount;
		private TimeZoneInfo timezone;
		private string name;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public List<string> ShiftDays
		{
			/// <summary>The method to get the shiftDays</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.shiftDays;

			}
			/// <summary>The method to set the value to shiftDays</summary>
			/// <param name="shiftDays">Instance of List<string></param>
			set
			{
				 this.shiftDays=value;

				 this.keyModified["shift_days"] = 1;

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

		public List<ShiftCustomTiming> CustomTiming
		{
			/// <summary>The method to get the customTiming</summary>
			/// <returns>Instance of List<ShiftCustomTiming></returns>
			get
			{
				return  this.customTiming;

			}
			/// <summary>The method to set the value to customTiming</summary>
			/// <param name="customTiming">Instance of List<ShiftCustomTiming></param>
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

		public List<BreakHours> BreakHours
		{
			/// <summary>The method to get the breakHours</summary>
			/// <returns>Instance of List<BreakHours></returns>
			get
			{
				return  this.breakHours;

			}
			/// <summary>The method to set the value to breakHours</summary>
			/// <param name="breakHours">Instance of List<BreakHours></param>
			set
			{
				 this.breakHours=value;

				 this.keyModified["break_hours"] = 1;

			}
		}

		public List<Users> Users
		{
			/// <summary>The method to get the users</summary>
			/// <returns>Instance of List<Users></returns>
			get
			{
				return  this.users;

			}
			/// <summary>The method to set the value to users</summary>
			/// <param name="users">Instance of List<Users></param>
			set
			{
				 this.users=value;

				 this.keyModified["users"] = 1;

			}
		}

		public List<Holidays> Holidays
		{
			/// <summary>The method to get the holidays</summary>
			/// <returns>Instance of List<Holidays></returns>
			get
			{
				return  this.holidays;

			}
			/// <summary>The method to set the value to holidays</summary>
			/// <param name="holidays">Instance of List<Holidays></param>
			set
			{
				 this.holidays=value;

				 this.keyModified["holidays"] = 1;

			}
		}

		public int? UsersCount
		{
			/// <summary>The method to get the usersCount</summary>
			/// <returns>int? representing the usersCount</returns>
			get
			{
				return  this.usersCount;

			}
			/// <summary>The method to set the value to usersCount</summary>
			/// <param name="usersCount">int?</param>
			set
			{
				 this.usersCount=value;

				 this.keyModified["users_count"] = 1;

			}
		}

		public TimeZoneInfo Timezone
		{
			/// <summary>The method to get the timezone</summary>
			/// <returns>TimeZoneInfo representing the timezone</returns>
			get
			{
				return  this.timezone;

			}
			/// <summary>The method to set the value to timezone</summary>
			/// <param name="timezone">TimeZoneInfo</param>
			set
			{
				 this.timezone=value;

				 this.keyModified["timezone"] = 1;

			}
		}

		public string Name
		{
			/// <summary>The method to get the name</summary>
			/// <returns>string representing the name</returns>
			get
			{
				return  this.name;

			}
			/// <summary>The method to set the value to name</summary>
			/// <param name="name">string</param>
			set
			{
				 this.name=value;

				 this.keyModified["name"] = 1;

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