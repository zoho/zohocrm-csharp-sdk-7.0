using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserGroups
{

	public class GroupedCount : Model
	{
		private Choice<string> status;
		private int? count;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Choice<string> Status
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

				 this.keyModified["status"] = 1;

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