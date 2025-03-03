using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.BusinessHours
{

	public class BusinessHours : Model
	{
		private Choice<string> weekStartsOn;
		private Choice<string> type;
		private long? id;
		private List<Choice<string>> businessDays;
		private bool? sameAsEveryday;
		private List<string> dailyTiming;
		private List<BreakHoursCustomTiming> customTiming;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Choice<string> WeekStartsOn
		{
			/// <summary>The method to get the weekStartsOn</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.weekStartsOn;

			}
			/// <summary>The method to set the value to weekStartsOn</summary>
			/// <param name="weekStartsOn">Instance of Choice<string></param>
			set
			{
				 this.weekStartsOn=value;

				 this.keyModified["week_starts_on"] = 1;

			}
		}

		public Choice<string> Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">Instance of Choice<string></param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

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

		public List<Choice<string>> BusinessDays
		{
			/// <summary>The method to get the businessDays</summary>
			/// <returns>Instance of List<Choice></returns>
			get
			{
				return  this.businessDays;

			}
			/// <summary>The method to set the value to businessDays</summary>
			/// <param name="businessDays">Instance of List<Choice></param>
			set
			{
				 this.businessDays=value;

				 this.keyModified["business_days"] = 1;

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

		public List<string> DailyTiming
		{
			/// <summary>The method to get the dailyTiming</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.dailyTiming;

			}
			/// <summary>The method to set the value to dailyTiming</summary>
			/// <param name="dailyTiming">Instance of List<string></param>
			set
			{
				 this.dailyTiming=value;

				 this.keyModified["daily_timing"] = 1;

			}
		}

		public List<BreakHoursCustomTiming> CustomTiming
		{
			/// <summary>The method to get the customTiming</summary>
			/// <returns>Instance of List<BreakHoursCustomTiming></returns>
			get
			{
				return  this.customTiming;

			}
			/// <summary>The method to set the value to customTiming</summary>
			/// <param name="customTiming">Instance of List<BreakHoursCustomTiming></param>
			set
			{
				 this.customTiming=value;

				 this.keyModified["custom_timing"] = 1;

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