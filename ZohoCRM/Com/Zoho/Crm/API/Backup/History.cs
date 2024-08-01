using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Backup
{

	public class History : Model
	{
		private long? id;
		private DateTimeOffset? logTime;
		private string action;
		private string repeatType;
		private int? count;
		private string fileName;
		private string state;
		private Requester doneBy;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public DateTimeOffset? LogTime
		{
			/// <summary>The method to get the logTime</summary>
			/// <returns>DateTimeOffset? representing the logTime</returns>
			get
			{
				return  this.logTime;

			}
			/// <summary>The method to set the value to logTime</summary>
			/// <param name="logTime">DateTimeOffset?</param>
			set
			{
				 this.logTime=value;

				 this.keyModified["log_time"] = 1;

			}
		}

		public string Action
		{
			/// <summary>The method to get the action</summary>
			/// <returns>string representing the action</returns>
			get
			{
				return  this.action;

			}
			/// <summary>The method to set the value to action</summary>
			/// <param name="action">string</param>
			set
			{
				 this.action=value;

				 this.keyModified[Constants.REQUEST_CATEGORY_ACTION] = 1;

			}
		}

		public string RepeatType
		{
			/// <summary>The method to get the repeatType</summary>
			/// <returns>string representing the repeatType</returns>
			get
			{
				return  this.repeatType;

			}
			/// <summary>The method to set the value to repeatType</summary>
			/// <param name="repeatType">string</param>
			set
			{
				 this.repeatType=value;

				 this.keyModified["repeat_type"] = 1;

			}
		}

		public int? Count
		{
			/// <summary>The method to get the count</summary>
			/// <returns>int? representing the count</returns>
			get
			{
				return  this.count;

			}
			/// <summary>The method to set the value to count</summary>
			/// <param name="count">int?</param>
			set
			{
				 this.count=value;

				 this.keyModified["count"] = 1;

			}
		}

		public string FileName
		{
			/// <summary>The method to get the fileName</summary>
			/// <returns>string representing the fileName</returns>
			get
			{
				return  this.fileName;

			}
			/// <summary>The method to set the value to fileName</summary>
			/// <param name="fileName">string</param>
			set
			{
				 this.fileName=value;

				 this.keyModified["file_name"] = 1;

			}
		}

		public string State
		{
			/// <summary>The method to get the state</summary>
			/// <returns>string representing the state</returns>
			get
			{
				return  this.state;

			}
			/// <summary>The method to set the value to state</summary>
			/// <param name="state">string</param>
			set
			{
				 this.state=value;

				 this.keyModified["state"] = 1;

			}
		}

		public Requester DoneBy
		{
			/// <summary>The method to get the doneBy</summary>
			/// <returns>Instance of Requester</returns>
			get
			{
				return  this.doneBy;

			}
			/// <summary>The method to set the value to doneBy</summary>
			/// <param name="doneBy">Instance of Requester</param>
			set
			{
				 this.doneBy=value;

				 this.keyModified["done_by"] = 1;

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