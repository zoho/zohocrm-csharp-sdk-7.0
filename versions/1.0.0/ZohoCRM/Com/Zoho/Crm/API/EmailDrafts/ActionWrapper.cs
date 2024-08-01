using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailDrafts
{

	public class ActionWrapper : Model
	{
		private List<ActionResponse> emaildrafts;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<ActionResponse> Emaildrafts
		{
			/// <summary>The method to get the emaildrafts</summary>
			/// <returns>Instance of List<ActionResponse></returns>
			get
			{
				return  this.emaildrafts;

			}
			/// <summary>The method to set the value to emaildrafts</summary>
			/// <param name="emaildrafts">Instance of List<ActionResponse></param>
			set
			{
				 this.emaildrafts=value;

				 this.keyModified["__email_drafts"] = 1;

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