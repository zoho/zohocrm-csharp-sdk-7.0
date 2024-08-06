using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PortalInvite
{

	public class JobResponse : Model
	{
		private List<Data> data;
		private long? jobId;
		private string status;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<Data> Data
		{
			/// <summary>The method to get the data</summary>
			/// <returns>Instance of List<Data></returns>
			get
			{
				return  this.data;

			}
			/// <summary>The method to set the value to data</summary>
			/// <param name="data">Instance of List<Data></param>
			set
			{
				 this.data=value;

				 this.keyModified["data"] = 1;

			}
		}

		public long? JobId
		{
			/// <summary>The method to get the jobId</summary>
			/// <returns>long? representing the jobId</returns>
			get
			{
				return  this.jobId;

			}
			/// <summary>The method to set the value to jobId</summary>
			/// <param name="jobId">long?</param>
			set
			{
				 this.jobId=value;

				 this.keyModified["job_id"] = 1;

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