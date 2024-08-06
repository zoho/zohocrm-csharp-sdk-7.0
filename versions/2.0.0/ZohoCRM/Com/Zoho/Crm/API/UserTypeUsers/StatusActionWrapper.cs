using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserTypeUsers
{

	public class StatusActionWrapper : Model, StatusActionHandler
	{
		private List<StatusActionResponse> changeStatus;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<StatusActionResponse> ChangeStatus
		{
			/// <summary>The method to get the changeStatus</summary>
			/// <returns>Instance of List<StatusActionResponse></returns>
			get
			{
				return  this.changeStatus;

			}
			/// <summary>The method to set the value to changeStatus</summary>
			/// <param name="changeStatus">Instance of List<StatusActionResponse></param>
			set
			{
				 this.changeStatus=value;

				 this.keyModified["change_status"] = 1;

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