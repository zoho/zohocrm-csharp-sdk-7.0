using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.FindAndMerge
{

	public class Merge : Model
	{
		private long? jobId;
		private string status;
		private List<MergeData> data;
		private List<MasterRecordFields> masterRecordFields;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public List<MergeData> Data
		{
			/// <summary>The method to get the data</summary>
			/// <returns>Instance of List<MergeData></returns>
			get
			{
				return  this.data;

			}
			/// <summary>The method to set the value to data</summary>
			/// <param name="data">Instance of List<MergeData></param>
			set
			{
				 this.data=value;

				 this.keyModified["data"] = 1;

			}
		}

		public List<MasterRecordFields> MasterRecordFields
		{
			/// <summary>The method to get the masterRecordFields</summary>
			/// <returns>Instance of List<MasterRecordFields></returns>
			get
			{
				return  this.masterRecordFields;

			}
			/// <summary>The method to set the value to masterRecordFields</summary>
			/// <param name="masterRecordFields">Instance of List<MasterRecordFields></param>
			set
			{
				 this.masterRecordFields=value;

				 this.keyModified["master_record_fields"] = 1;

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