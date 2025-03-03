using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.CadencesExecution
{

	public class AnalyticsCall : Model
	{
		private int? createdCallsCount;
		private int? cancelledCallsCount;
		private int? failedCallsCount;
		private int? completedCallsCount;
		private int? scheduledCallsCount;
		private int? callsCount;
		private int? overdueCallsCount;
		private int? missedCallsCount;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? CreatedCallsCount
		{
			/// <summary>The method to get the createdCallsCount</summary>
			/// <returns>int? representing the createdCallsCount</returns>
			get
			{
				return  this.createdCallsCount;

			}
			/// <summary>The method to set the value to createdCallsCount</summary>
			/// <param name="createdCallsCount">int?</param>
			set
			{
				 this.createdCallsCount=value;

				 this.keyModified["created_calls_count"] = 1;

			}
		}

		public int? CancelledCallsCount
		{
			/// <summary>The method to get the cancelledCallsCount</summary>
			/// <returns>int? representing the cancelledCallsCount</returns>
			get
			{
				return  this.cancelledCallsCount;

			}
			/// <summary>The method to set the value to cancelledCallsCount</summary>
			/// <param name="cancelledCallsCount">int?</param>
			set
			{
				 this.cancelledCallsCount=value;

				 this.keyModified["cancelled_calls_count"] = 1;

			}
		}

		public int? FailedCallsCount
		{
			/// <summary>The method to get the failedCallsCount</summary>
			/// <returns>int? representing the failedCallsCount</returns>
			get
			{
				return  this.failedCallsCount;

			}
			/// <summary>The method to set the value to failedCallsCount</summary>
			/// <param name="failedCallsCount">int?</param>
			set
			{
				 this.failedCallsCount=value;

				 this.keyModified["failed_calls_count"] = 1;

			}
		}

		public int? CompletedCallsCount
		{
			/// <summary>The method to get the completedCallsCount</summary>
			/// <returns>int? representing the completedCallsCount</returns>
			get
			{
				return  this.completedCallsCount;

			}
			/// <summary>The method to set the value to completedCallsCount</summary>
			/// <param name="completedCallsCount">int?</param>
			set
			{
				 this.completedCallsCount=value;

				 this.keyModified["completed_calls_count"] = 1;

			}
		}

		public int? ScheduledCallsCount
		{
			/// <summary>The method to get the scheduledCallsCount</summary>
			/// <returns>int? representing the scheduledCallsCount</returns>
			get
			{
				return  this.scheduledCallsCount;

			}
			/// <summary>The method to set the value to scheduledCallsCount</summary>
			/// <param name="scheduledCallsCount">int?</param>
			set
			{
				 this.scheduledCallsCount=value;

				 this.keyModified["scheduled_calls_count"] = 1;

			}
		}

		public int? CallsCount
		{
			/// <summary>The method to get the callsCount</summary>
			/// <returns>int? representing the callsCount</returns>
			get
			{
				return  this.callsCount;

			}
			/// <summary>The method to set the value to callsCount</summary>
			/// <param name="callsCount">int?</param>
			set
			{
				 this.callsCount=value;

				 this.keyModified["calls_count"] = 1;

			}
		}

		public int? OverdueCallsCount
		{
			/// <summary>The method to get the overdueCallsCount</summary>
			/// <returns>int? representing the overdueCallsCount</returns>
			get
			{
				return  this.overdueCallsCount;

			}
			/// <summary>The method to set the value to overdueCallsCount</summary>
			/// <param name="overdueCallsCount">int?</param>
			set
			{
				 this.overdueCallsCount=value;

				 this.keyModified["overdue_calls_count"] = 1;

			}
		}

		public int? MissedCallsCount
		{
			/// <summary>The method to get the missedCallsCount</summary>
			/// <returns>int? representing the missedCallsCount</returns>
			get
			{
				return  this.missedCallsCount;

			}
			/// <summary>The method to set the value to missedCallsCount</summary>
			/// <param name="missedCallsCount">int?</param>
			set
			{
				 this.missedCallsCount=value;

				 this.keyModified["missed_calls_count"] = 1;

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