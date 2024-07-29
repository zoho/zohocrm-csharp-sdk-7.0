using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Holidays
{

	public class ShiftHoliday : Model
	{
		private string name;
		private DateTime? date;
		private Choice<string> type;
		private ShiftHour shiftHour;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public DateTime? Date
		{
			/// <summary>The method to get the date</summary>
			/// <returns>DateTime? representing the date</returns>
			get
			{
				return  this.date;

			}
			/// <summary>The method to set the value to date</summary>
			/// <param name="date">DateTime?</param>
			set
			{
				 this.date=value;

				 this.keyModified["date"] = 1;

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

		public ShiftHour ShiftHour
		{
			/// <summary>The method to get the shiftHour</summary>
			/// <returns>Instance of ShiftHour</returns>
			get
			{
				return  this.shiftHour;

			}
			/// <summary>The method to set the value to shiftHour</summary>
			/// <param name="shiftHour">Instance of ShiftHour</param>
			set
			{
				 this.shiftHour=value;

				 this.keyModified["shift_hour"] = 1;

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