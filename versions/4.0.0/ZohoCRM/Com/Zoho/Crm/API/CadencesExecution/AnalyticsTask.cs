using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.CadencesExecution
{

	public class AnalyticsTask : Model
	{
		private int? openTasksCount;
		private int? failedTasksCount;
		private string subject;
		private int? completedTasksCount;
		private int? createdTasksCount;
		private int? tasksCount;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? OpenTasksCount
		{
			/// <summary>The method to get the openTasksCount</summary>
			/// <returns>int? representing the openTasksCount</returns>
			get
			{
				return  this.openTasksCount;

			}
			/// <summary>The method to set the value to openTasksCount</summary>
			/// <param name="openTasksCount">int?</param>
			set
			{
				 this.openTasksCount=value;

				 this.keyModified["open_tasks_count"] = 1;

			}
		}

		public int? FailedTasksCount
		{
			/// <summary>The method to get the failedTasksCount</summary>
			/// <returns>int? representing the failedTasksCount</returns>
			get
			{
				return  this.failedTasksCount;

			}
			/// <summary>The method to set the value to failedTasksCount</summary>
			/// <param name="failedTasksCount">int?</param>
			set
			{
				 this.failedTasksCount=value;

				 this.keyModified["failed_tasks_count"] = 1;

			}
		}

		public string Subject
		{
			/// <summary>The method to get the subject</summary>
			/// <returns>string representing the subject</returns>
			get
			{
				return  this.subject;

			}
			/// <summary>The method to set the value to subject</summary>
			/// <param name="subject">string</param>
			set
			{
				 this.subject=value;

				 this.keyModified["subject"] = 1;

			}
		}

		public int? CompletedTasksCount
		{
			/// <summary>The method to get the completedTasksCount</summary>
			/// <returns>int? representing the completedTasksCount</returns>
			get
			{
				return  this.completedTasksCount;

			}
			/// <summary>The method to set the value to completedTasksCount</summary>
			/// <param name="completedTasksCount">int?</param>
			set
			{
				 this.completedTasksCount=value;

				 this.keyModified["completed_tasks_count"] = 1;

			}
		}

		public int? CreatedTasksCount
		{
			/// <summary>The method to get the createdTasksCount</summary>
			/// <returns>int? representing the createdTasksCount</returns>
			get
			{
				return  this.createdTasksCount;

			}
			/// <summary>The method to set the value to createdTasksCount</summary>
			/// <param name="createdTasksCount">int?</param>
			set
			{
				 this.createdTasksCount=value;

				 this.keyModified["created_tasks_count"] = 1;

			}
		}

		public int? TasksCount
		{
			/// <summary>The method to get the tasksCount</summary>
			/// <returns>int? representing the tasksCount</returns>
			get
			{
				return  this.tasksCount;

			}
			/// <summary>The method to set the value to tasksCount</summary>
			/// <param name="tasksCount">int?</param>
			set
			{
				 this.tasksCount=value;

				 this.keyModified["tasks_count"] = 1;

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