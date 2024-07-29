using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailDrafts
{

	public class ScheduleDetails : Model
	{
		private DateTimeOffset? time;
		private TimeZoneInfo timezone;
		private string source;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public DateTimeOffset? Time
		{
			/// <summary>The method to get the time</summary>
			/// <returns>DateTimeOffset? representing the time</returns>
			get
			{
				return  this.time;

			}
			/// <summary>The method to set the value to time</summary>
			/// <param name="time">DateTimeOffset?</param>
			set
			{
				 this.time=value;

				 this.keyModified["time"] = 1;

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

		public string Source
		{
			/// <summary>The method to get the source</summary>
			/// <returns>string representing the source</returns>
			get
			{
				return  this.source;

			}
			/// <summary>The method to set the value to source</summary>
			/// <param name="source">string</param>
			set
			{
				 this.source=value;

				 this.keyModified["source"] = 1;

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