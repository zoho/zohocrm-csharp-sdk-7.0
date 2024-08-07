using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Cadences
{

	public class Cadences : Model
	{
		private Summary summary;
		private string createdTime;
		private Module module;
		private bool? active;
		private ExecutionDetail executionDetails;
		private bool? published;
		private string type;
		private User createdBy;
		private string modifiedTime;
		private string name;
		private User modifiedBy;
		private long? id;
		private CustomView customView;
		private string status;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Summary Summary
		{
			/// <summary>The method to get the summary</summary>
			/// <returns>Instance of Summary</returns>
			get
			{
				return  this.summary;

			}
			/// <summary>The method to set the value to summary</summary>
			/// <param name="summary">Instance of Summary</param>
			set
			{
				 this.summary=value;

				 this.keyModified["summary"] = 1;

			}
		}

		public string CreatedTime
		{
			/// <summary>The method to get the createdTime</summary>
			/// <returns>string representing the createdTime</returns>
			get
			{
				return  this.createdTime;

			}
			/// <summary>The method to set the value to createdTime</summary>
			/// <param name="createdTime">string</param>
			set
			{
				 this.createdTime=value;

				 this.keyModified["created_time"] = 1;

			}
		}

		public Module Module
		{
			/// <summary>The method to get the module</summary>
			/// <returns>Instance of Module</returns>
			get
			{
				return  this.module;

			}
			/// <summary>The method to set the value to module</summary>
			/// <param name="module">Instance of Module</param>
			set
			{
				 this.module=value;

				 this.keyModified["module"] = 1;

			}
		}

		public bool? Active
		{
			/// <summary>The method to get the active</summary>
			/// <returns>bool? representing the active</returns>
			get
			{
				return  this.active;

			}
			/// <summary>The method to set the value to active</summary>
			/// <param name="active">bool?</param>
			set
			{
				 this.active=value;

				 this.keyModified["active"] = 1;

			}
		}

		public ExecutionDetail ExecutionDetails
		{
			/// <summary>The method to get the executionDetails</summary>
			/// <returns>Instance of ExecutionDetail</returns>
			get
			{
				return  this.executionDetails;

			}
			/// <summary>The method to set the value to executionDetails</summary>
			/// <param name="executionDetails">Instance of ExecutionDetail</param>
			set
			{
				 this.executionDetails=value;

				 this.keyModified["execution_details"] = 1;

			}
		}

		public bool? Published
		{
			/// <summary>The method to get the published</summary>
			/// <returns>bool? representing the published</returns>
			get
			{
				return  this.published;

			}
			/// <summary>The method to set the value to published</summary>
			/// <param name="published">bool?</param>
			set
			{
				 this.published=value;

				 this.keyModified["published"] = 1;

			}
		}

		public string Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>string representing the type</returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">string</param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

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

		public string ModifiedTime
		{
			/// <summary>The method to get the modifiedTime</summary>
			/// <returns>string representing the modifiedTime</returns>
			get
			{
				return  this.modifiedTime;

			}
			/// <summary>The method to set the value to modifiedTime</summary>
			/// <param name="modifiedTime">string</param>
			set
			{
				 this.modifiedTime=value;

				 this.keyModified["modified_time"] = 1;

			}
		}

		public string Name
		{
			/// <summary>The method to get the name</summary>
			/// <returns>string representing the name</returns>
			get
			{
				return  this.name;

			}
			/// <summary>The method to set the value to name</summary>
			/// <param name="name">string</param>
			set
			{
				 this.name=value;

				 this.keyModified["name"] = 1;

			}
		}

		public User ModifiedBy
		{
			/// <summary>The method to get the modifiedBy</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.modifiedBy;

			}
			/// <summary>The method to set the value to modifiedBy</summary>
			/// <param name="modifiedBy">Instance of User</param>
			set
			{
				 this.modifiedBy=value;

				 this.keyModified["modified_by"] = 1;

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

		public CustomView CustomView
		{
			/// <summary>The method to get the customView</summary>
			/// <returns>Instance of CustomView</returns>
			get
			{
				return  this.customView;

			}
			/// <summary>The method to set the value to customView</summary>
			/// <param name="customView">Instance of CustomView</param>
			set
			{
				 this.customView=value;

				 this.keyModified["custom_view"] = 1;

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