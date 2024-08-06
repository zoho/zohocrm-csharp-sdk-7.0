using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserGroups
{

	public class UnAssignedActionWrapper : Model
	{
		private UnAssignedActionResponse getUnassigned;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public UnAssignedActionResponse Unassigned
		{
			/// <summary>The method to get the getUnassigned</summary>
			/// <returns>Instance of UnAssignedActionResponse</returns>
			get
			{
				return  this.getUnassigned;

			}
			/// <summary>The method to set the value to getUnassigned</summary>
			/// <param name="getUnassigned">Instance of UnAssignedActionResponse</param>
			set
			{
				 this.getUnassigned=value;

				 this.keyModified["get_unassigned"] = 1;

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