using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserGroups
{

	public class AssociatedUser : Model
	{
		private UserGroup userGroup;
		private int? count;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public UserGroup UserGroup
		{
			/// <summary>The method to get the userGroup</summary>
			/// <returns>Instance of UserGroup</returns>
			get
			{
				return  this.userGroup;

			}
			/// <summary>The method to set the value to userGroup</summary>
			/// <param name="userGroup">Instance of UserGroup</param>
			set
			{
				 this.userGroup=value;

				 this.keyModified["user_group"] = 1;

			}
		}

		public int? Count
		{
			/// <summary>The method to get the count</summary>
			/// <returns>int? representing the count</returns>
			get
			{
				return  this.count;

			}
			/// <summary>The method to set the value to count</summary>
			/// <param name="count">int?</param>
			set
			{
				 this.count=value;

				 this.keyModified["count"] = 1;

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