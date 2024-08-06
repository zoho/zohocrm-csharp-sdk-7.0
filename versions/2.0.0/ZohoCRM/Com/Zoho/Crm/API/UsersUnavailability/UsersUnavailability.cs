using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UsersUnavailability
{

	public class UsersUnavailability : Model
	{
		private string service;
		private string title;
		private bool? allDay;
		private string tpCalendarId;
		private string tpEventId;
		private string comments;
		private DateTimeOffset? from;
		private long? id;
		private DateTimeOffset? to;
		private User user;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Service
		{
			/// <summary>The method to get the service</summary>
			/// <returns>string representing the service</returns>
			get
			{
				return  this.service;

			}
			/// <summary>The method to set the value to service</summary>
			/// <param name="service">string</param>
			set
			{
				 this.service=value;

				 this.keyModified["service"] = 1;

			}
		}

		public string Title
		{
			/// <summary>The method to get the title</summary>
			/// <returns>string representing the title</returns>
			get
			{
				return  this.title;

			}
			/// <summary>The method to set the value to title</summary>
			/// <param name="title">string</param>
			set
			{
				 this.title=value;

				 this.keyModified["title"] = 1;

			}
		}

		public bool? AllDay
		{
			/// <summary>The method to get the allDay</summary>
			/// <returns>bool? representing the allDay</returns>
			get
			{
				return  this.allDay;

			}
			/// <summary>The method to set the value to allDay</summary>
			/// <param name="allDay">bool?</param>
			set
			{
				 this.allDay=value;

				 this.keyModified["all_day"] = 1;

			}
		}

		public string TpCalendarId
		{
			/// <summary>The method to get the tpCalendarId</summary>
			/// <returns>string representing the tpCalendarId</returns>
			get
			{
				return  this.tpCalendarId;

			}
			/// <summary>The method to set the value to tpCalendarId</summary>
			/// <param name="tpCalendarId">string</param>
			set
			{
				 this.tpCalendarId=value;

				 this.keyModified["tp_calendar_id"] = 1;

			}
		}

		public string TpEventId
		{
			/// <summary>The method to get the tpEventId</summary>
			/// <returns>string representing the tpEventId</returns>
			get
			{
				return  this.tpEventId;

			}
			/// <summary>The method to set the value to tpEventId</summary>
			/// <param name="tpEventId">string</param>
			set
			{
				 this.tpEventId=value;

				 this.keyModified["tp_event_id"] = 1;

			}
		}

		public string Comments
		{
			/// <summary>The method to get the comments</summary>
			/// <returns>string representing the comments</returns>
			get
			{
				return  this.comments;

			}
			/// <summary>The method to set the value to comments</summary>
			/// <param name="comments">string</param>
			set
			{
				 this.comments=value;

				 this.keyModified["comments"] = 1;

			}
		}

		public DateTimeOffset? From
		{
			/// <summary>The method to get the from</summary>
			/// <returns>DateTimeOffset? representing the from</returns>
			get
			{
				return  this.from;

			}
			/// <summary>The method to set the value to from</summary>
			/// <param name="from">DateTimeOffset?</param>
			set
			{
				 this.from=value;

				 this.keyModified["from"] = 1;

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

		public DateTimeOffset? To
		{
			/// <summary>The method to get the to</summary>
			/// <returns>DateTimeOffset? representing the to</returns>
			get
			{
				return  this.to;

			}
			/// <summary>The method to set the value to to</summary>
			/// <param name="to">DateTimeOffset?</param>
			set
			{
				 this.to=value;

				 this.keyModified["to"] = 1;

			}
		}

		public User User
		{
			/// <summary>The method to get the user</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.user;

			}
			/// <summary>The method to set the value to user</summary>
			/// <param name="user">Instance of User</param>
			set
			{
				 this.user=value;

				 this.keyModified["user"] = 1;

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