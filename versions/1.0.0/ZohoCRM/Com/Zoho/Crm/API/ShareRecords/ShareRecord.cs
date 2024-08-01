using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ShareRecords
{

	public class ShareRecord : Model
	{
		private Users.Users sharedWith;
		private bool? shareRelatedRecords;
		private SharedThrough sharedThrough;
		private DateTimeOffset? sharedTime;
		private string permission;
		private Users.Users sharedBy;
		private Users.Users user;
		private Choice<string> type;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Users.Users SharedWith
		{
			/// <summary>The method to get the sharedWith</summary>
			/// <returns>Instance of Users</returns>
			get
			{
				return  this.sharedWith;

			}
			/// <summary>The method to set the value to sharedWith</summary>
			/// <param name="sharedWith">Instance of Users</param>
			set
			{
				 this.sharedWith=value;

				 this.keyModified["shared_with"] = 1;

			}
		}

		public bool? ShareRelatedRecords
		{
			/// <summary>The method to get the shareRelatedRecords</summary>
			/// <returns>bool? representing the shareRelatedRecords</returns>
			get
			{
				return  this.shareRelatedRecords;

			}
			/// <summary>The method to set the value to shareRelatedRecords</summary>
			/// <param name="shareRelatedRecords">bool?</param>
			set
			{
				 this.shareRelatedRecords=value;

				 this.keyModified["share_related_records"] = 1;

			}
		}

		public SharedThrough SharedThrough
		{
			/// <summary>The method to get the sharedThrough</summary>
			/// <returns>Instance of SharedThrough</returns>
			get
			{
				return  this.sharedThrough;

			}
			/// <summary>The method to set the value to sharedThrough</summary>
			/// <param name="sharedThrough">Instance of SharedThrough</param>
			set
			{
				 this.sharedThrough=value;

				 this.keyModified["shared_through"] = 1;

			}
		}

		public DateTimeOffset? SharedTime
		{
			/// <summary>The method to get the sharedTime</summary>
			/// <returns>DateTimeOffset? representing the sharedTime</returns>
			get
			{
				return  this.sharedTime;

			}
			/// <summary>The method to set the value to sharedTime</summary>
			/// <param name="sharedTime">DateTimeOffset?</param>
			set
			{
				 this.sharedTime=value;

				 this.keyModified["shared_time"] = 1;

			}
		}

		public string Permission
		{
			/// <summary>The method to get the permission</summary>
			/// <returns>string representing the permission</returns>
			get
			{
				return  this.permission;

			}
			/// <summary>The method to set the value to permission</summary>
			/// <param name="permission">string</param>
			set
			{
				 this.permission=value;

				 this.keyModified["permission"] = 1;

			}
		}

		public Users.Users SharedBy
		{
			/// <summary>The method to get the sharedBy</summary>
			/// <returns>Instance of Users</returns>
			get
			{
				return  this.sharedBy;

			}
			/// <summary>The method to set the value to sharedBy</summary>
			/// <param name="sharedBy">Instance of Users</param>
			set
			{
				 this.sharedBy=value;

				 this.keyModified["shared_by"] = 1;

			}
		}

		public Users.Users User
		{
			/// <summary>The method to get the user</summary>
			/// <returns>Instance of Users</returns>
			get
			{
				return  this.user;

			}
			/// <summary>The method to set the value to user</summary>
			/// <param name="user">Instance of Users</param>
			set
			{
				 this.user=value;

				 this.keyModified["user"] = 1;

			}
		}

		public Choice<string> Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">Instance of Choice<string></param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

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