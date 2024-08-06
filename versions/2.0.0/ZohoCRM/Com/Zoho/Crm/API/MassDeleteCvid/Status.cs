using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.MassDeleteCvid
{

	public class Status : Model
	{
		private Choice<string> status;
		private int? failedCount;
		private int? deletedCount;
		private int? totalCount;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Choice<string> Status_1
		{
			/// <summary>The method to get the status</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.status;

			}
			/// <summary>The method to set the value to status</summary>
			/// <param name="status">Instance of Choice<string></param>
			set
			{
				 this.status=value;

				 this.keyModified["Status"] = 1;

			}
		}

		public int? FailedCount
		{
			/// <summary>The method to get the failedCount</summary>
			/// <returns>int? representing the failedCount</returns>
			get
			{
				return  this.failedCount;

			}
			/// <summary>The method to set the value to failedCount</summary>
			/// <param name="failedCount">int?</param>
			set
			{
				 this.failedCount=value;

				 this.keyModified["Failed_Count"] = 1;

			}
		}

		public int? DeletedCount
		{
			/// <summary>The method to get the deletedCount</summary>
			/// <returns>int? representing the deletedCount</returns>
			get
			{
				return  this.deletedCount;

			}
			/// <summary>The method to set the value to deletedCount</summary>
			/// <param name="deletedCount">int?</param>
			set
			{
				 this.deletedCount=value;

				 this.keyModified["Deleted_Count"] = 1;

			}
		}

		public int? TotalCount
		{
			/// <summary>The method to get the totalCount</summary>
			/// <returns>int? representing the totalCount</returns>
			get
			{
				return  this.totalCount;

			}
			/// <summary>The method to set the value to totalCount</summary>
			/// <param name="totalCount">int?</param>
			set
			{
				 this.totalCount=value;

				 this.keyModified["Total_Count"] = 1;

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