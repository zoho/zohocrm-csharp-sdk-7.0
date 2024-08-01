using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.SendMail
{

	public class Cc : Model
	{
		private string userName;
		private string email;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string UserName
		{
			/// <summary>The method to get the userName</summary>
			/// <returns>string representing the userName</returns>
			get
			{
				return  this.userName;

			}
			/// <summary>The method to set the value to userName</summary>
			/// <param name="userName">string</param>
			set
			{
				 this.userName=value;

				 this.keyModified["user_name"] = 1;

			}
		}

		public string Email
		{
			/// <summary>The method to get the email</summary>
			/// <returns>string representing the email</returns>
			get
			{
				return  this.email;

			}
			/// <summary>The method to set the value to email</summary>
			/// <param name="email">string</param>
			set
			{
				 this.email=value;

				 this.keyModified["email"] = 1;

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