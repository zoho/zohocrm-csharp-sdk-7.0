using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserGroups
{

	public class AssignedActionWrapper : Model
	{
		private AssignedActionResponse getAssigned;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public AssignedActionResponse Assigned
		{
			/// <summary>The method to get the getAssigned</summary>
			/// <returns>Instance of AssignedActionResponse</returns>
			get
			{
				return  this.getAssigned;

			}
			/// <summary>The method to set the value to getAssigned</summary>
			/// <param name="getAssigned">Instance of AssignedActionResponse</param>
			set
			{
				 this.getAssigned=value;

				 this.keyModified["get_assigned"] = 1;

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