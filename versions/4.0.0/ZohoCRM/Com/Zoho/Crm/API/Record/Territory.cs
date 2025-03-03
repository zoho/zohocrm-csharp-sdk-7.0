using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Record
{

	public class Territory : Model
	{
		private string assigned;
		private string name;
		private long? id;
		private DateTimeOffset? assignedTime;
		private Users.MinifiedUser assignedBy;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Assigned
		{
			/// <summary>The method to get the assigned</summary>
			/// <returns>string representing the assigned</returns>
			get
			{
				return  this.assigned;

			}
			/// <summary>The method to set the value to assigned</summary>
			/// <param name="assigned">string</param>
			set
			{
				 this.assigned=value;

				 this.keyModified["$assigned"] = 1;

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

				 this.keyModified["Name"] = 1;

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

		public DateTimeOffset? AssignedTime
		{
			/// <summary>The method to get the assignedTime</summary>
			/// <returns>DateTimeOffset? representing the assignedTime</returns>
			get
			{
				return  this.assignedTime;

			}
			/// <summary>The method to set the value to assignedTime</summary>
			/// <param name="assignedTime">DateTimeOffset?</param>
			set
			{
				 this.assignedTime=value;

				 this.keyModified["$assigned_time"] = 1;

			}
		}

		public Users.MinifiedUser AssignedBy
		{
			/// <summary>The method to get the assignedBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.assignedBy;

			}
			/// <summary>The method to set the value to assignedBy</summary>
			/// <param name="assignedBy">Instance of MinifiedUser</param>
			set
			{
				 this.assignedBy=value;

				 this.keyModified["$assigned_by"] = 1;

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