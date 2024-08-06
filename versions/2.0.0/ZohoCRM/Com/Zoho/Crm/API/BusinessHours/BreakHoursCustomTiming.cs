using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.BusinessHours
{

	public class BreakHoursCustomTiming : Model
	{
		private Choice<string> days;
		private List<string> businessTiming;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Choice<string> Days
		{
			/// <summary>The method to get the days</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.days;

			}
			/// <summary>The method to set the value to days</summary>
			/// <param name="days">Instance of Choice<string></param>
			set
			{
				 this.days=value;

				 this.keyModified["days"] = 1;

			}
		}

		public List<string> BusinessTiming
		{
			/// <summary>The method to get the businessTiming</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.businessTiming;

			}
			/// <summary>The method to set the value to businessTiming</summary>
			/// <param name="businessTiming">Instance of List<string></param>
			set
			{
				 this.businessTiming=value;

				 this.keyModified["business_timing"] = 1;

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