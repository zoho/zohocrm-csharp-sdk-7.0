using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Cadences
{

	public class Summary : Model
	{
		private int? taskFollowUpCount;
		private int? callFollowUpCount;
		private int? emailFollowUpCount;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? TaskFollowUpCount
		{
			/// <summary>The method to get the taskFollowUpCount</summary>
			/// <returns>int? representing the taskFollowUpCount</returns>
			get
			{
				return  this.taskFollowUpCount;

			}
			/// <summary>The method to set the value to taskFollowUpCount</summary>
			/// <param name="taskFollowUpCount">int?</param>
			set
			{
				 this.taskFollowUpCount=value;

				 this.keyModified["task_follow_up_count"] = 1;

			}
		}

		public int? CallFollowUpCount
		{
			/// <summary>The method to get the callFollowUpCount</summary>
			/// <returns>int? representing the callFollowUpCount</returns>
			get
			{
				return  this.callFollowUpCount;

			}
			/// <summary>The method to set the value to callFollowUpCount</summary>
			/// <param name="callFollowUpCount">int?</param>
			set
			{
				 this.callFollowUpCount=value;

				 this.keyModified["call_follow_up_count"] = 1;

			}
		}

		public int? EmailFollowUpCount
		{
			/// <summary>The method to get the emailFollowUpCount</summary>
			/// <returns>int? representing the emailFollowUpCount</returns>
			get
			{
				return  this.emailFollowUpCount;

			}
			/// <summary>The method to set the value to emailFollowUpCount</summary>
			/// <param name="emailFollowUpCount">int?</param>
			set
			{
				 this.emailFollowUpCount=value;

				 this.keyModified["email_follow_up_count"] = 1;

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