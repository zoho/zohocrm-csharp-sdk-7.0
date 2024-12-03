using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserGroups
{

	public class Users : Model
	{
		private int? inactive;
		private int? deleted;
		private int? active;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? Inactive
		{
			/// <summary>The method to get the inactive</summary>
			/// <returns>int? representing the inactive</returns>
			get
			{
				return  this.inactive;

			}
			/// <summary>The method to set the value to inactive</summary>
			/// <param name="inactive">int?</param>
			set
			{
				 this.inactive=value;

				 this.keyModified["inactive"] = 1;

			}
		}

		public int? Deleted
		{
			/// <summary>The method to get the deleted</summary>
			/// <returns>int? representing the deleted</returns>
			get
			{
				return  this.deleted;

			}
			/// <summary>The method to set the value to deleted</summary>
			/// <param name="deleted">int?</param>
			set
			{
				 this.deleted=value;

				 this.keyModified["deleted"] = 1;

			}
		}

		public int? Active
		{
			/// <summary>The method to get the active</summary>
			/// <returns>int? representing the active</returns>
			get
			{
				return  this.active;

			}
			/// <summary>The method to set the value to active</summary>
			/// <param name="active">int?</param>
			set
			{
				 this.active=value;

				 this.keyModified["active"] = 1;

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