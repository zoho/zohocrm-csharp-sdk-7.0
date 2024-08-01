using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserGroups
{

	public class SourcesCount : Model
	{
		private int? territories;
		private int? roles;
		private int? groups;
		private Users users;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? Territories
		{
			/// <summary>The method to get the territories</summary>
			/// <returns>int? representing the territories</returns>
			get
			{
				return  this.territories;

			}
			/// <summary>The method to set the value to territories</summary>
			/// <param name="territories">int?</param>
			set
			{
				 this.territories=value;

				 this.keyModified["territories"] = 1;

			}
		}

		public int? Roles
		{
			/// <summary>The method to get the roles</summary>
			/// <returns>int? representing the roles</returns>
			get
			{
				return  this.roles;

			}
			/// <summary>The method to set the value to roles</summary>
			/// <param name="roles">int?</param>
			set
			{
				 this.roles=value;

				 this.keyModified["roles"] = 1;

			}
		}

		public int? Groups
		{
			/// <summary>The method to get the groups</summary>
			/// <returns>int? representing the groups</returns>
			get
			{
				return  this.groups;

			}
			/// <summary>The method to set the value to groups</summary>
			/// <param name="groups">int?</param>
			set
			{
				 this.groups=value;

				 this.keyModified["groups"] = 1;

			}
		}

		public Users Users
		{
			/// <summary>The method to get the users</summary>
			/// <returns>Instance of Users</returns>
			get
			{
				return  this.users;

			}
			/// <summary>The method to set the value to users</summary>
			/// <param name="users">Instance of Users</param>
			set
			{
				 this.users=value;

				 this.keyModified["users"] = 1;

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