using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.AuditLogExport
{

	public class AuditLogExport : Model
	{
		private Criteria criteria;
		private long? id;
		private string status;
		private User createdBy;
		private List<string> downloadLinks;
		private DateTimeOffset? jobStartTime;
		private DateTimeOffset? jobEndTime;
		private DateTimeOffset? expiryDate;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Criteria Criteria
		{
			/// <summary>The method to get the criteria</summary>
			/// <returns>Instance of Criteria</returns>
			get
			{
				return  this.criteria;

			}
			/// <summary>The method to set the value to criteria</summary>
			/// <param name="criteria">Instance of Criteria</param>
			set
			{
				 this.criteria=value;

				 this.keyModified["criteria"] = 1;

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

		public User CreatedBy
		{
			/// <summary>The method to get the createdBy</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.createdBy;

			}
			/// <summary>The method to set the value to createdBy</summary>
			/// <param name="createdBy">Instance of User</param>
			set
			{
				 this.createdBy=value;

				 this.keyModified["created_by"] = 1;

			}
		}

		public List<string> DownloadLinks
		{
			/// <summary>The method to get the downloadLinks</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.downloadLinks;

			}
			/// <summary>The method to set the value to downloadLinks</summary>
			/// <param name="downloadLinks">Instance of List<string></param>
			set
			{
				 this.downloadLinks=value;

				 this.keyModified["download_links"] = 1;

			}
		}

		public DateTimeOffset? JobStartTime
		{
			/// <summary>The method to get the jobStartTime</summary>
			/// <returns>DateTimeOffset? representing the jobStartTime</returns>
			get
			{
				return  this.jobStartTime;

			}
			/// <summary>The method to set the value to jobStartTime</summary>
			/// <param name="jobStartTime">DateTimeOffset?</param>
			set
			{
				 this.jobStartTime=value;

				 this.keyModified["job_start_time"] = 1;

			}
		}

		public DateTimeOffset? JobEndTime
		{
			/// <summary>The method to get the jobEndTime</summary>
			/// <returns>DateTimeOffset? representing the jobEndTime</returns>
			get
			{
				return  this.jobEndTime;

			}
			/// <summary>The method to set the value to jobEndTime</summary>
			/// <param name="jobEndTime">DateTimeOffset?</param>
			set
			{
				 this.jobEndTime=value;

				 this.keyModified["job_end_time"] = 1;

			}
		}

		public DateTimeOffset? ExpiryDate
		{
			/// <summary>The method to get the expiryDate</summary>
			/// <returns>DateTimeOffset? representing the expiryDate</returns>
			get
			{
				return  this.expiryDate;

			}
			/// <summary>The method to set the value to expiryDate</summary>
			/// <param name="expiryDate">DateTimeOffset?</param>
			set
			{
				 this.expiryDate=value;

				 this.keyModified["expiry_date"] = 1;

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