using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Backup
{

	public class Backup : Model
	{
		private string rrule;
		private long? id;
		private DateTimeOffset? startDate;
		private DateTimeOffset? scheduledDate;
		private string status;
		private Requester requester;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Rrule
		{
			/// <summary>The method to get the rrule</summary>
			/// <returns>string representing the rrule</returns>
			get
			{
				return  this.rrule;

			}
			/// <summary>The method to set the value to rrule</summary>
			/// <param name="rrule">string</param>
			set
			{
				 this.rrule=value;

				 this.keyModified["rrule"] = 1;

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

		public DateTimeOffset? StartDate
		{
			/// <summary>The method to get the startDate</summary>
			/// <returns>DateTimeOffset? representing the startDate</returns>
			get
			{
				return  this.startDate;

			}
			/// <summary>The method to set the value to startDate</summary>
			/// <param name="startDate">DateTimeOffset?</param>
			set
			{
				 this.startDate=value;

				 this.keyModified["start_date"] = 1;

			}
		}

		public DateTimeOffset? ScheduledDate
		{
			/// <summary>The method to get the scheduledDate</summary>
			/// <returns>DateTimeOffset? representing the scheduledDate</returns>
			get
			{
				return  this.scheduledDate;

			}
			/// <summary>The method to set the value to scheduledDate</summary>
			/// <param name="scheduledDate">DateTimeOffset?</param>
			set
			{
				 this.scheduledDate=value;

				 this.keyModified["scheduled_date"] = 1;

			}
		}

		public string Status
		{
			/// <summary>The method to get the status</summary>
			/// <returns>string representing the status</returns>
			get
			{
				return  this.status;

			}
			/// <summary>The method to set the value to status</summary>
			/// <param name="status">string</param>
			set
			{
				 this.status=value;

				 this.keyModified["status"] = 1;

			}
		}

		public Requester Requester
		{
			/// <summary>The method to get the requester</summary>
			/// <returns>Instance of Requester</returns>
			get
			{
				return  this.requester;

			}
			/// <summary>The method to set the value to requester</summary>
			/// <param name="requester">Instance of Requester</param>
			set
			{
				 this.requester=value;

				 this.keyModified["requester"] = 1;

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