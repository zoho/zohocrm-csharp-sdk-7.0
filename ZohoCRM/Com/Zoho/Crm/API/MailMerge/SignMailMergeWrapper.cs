using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.MailMerge
{

	public class SignMailMergeWrapper : Model
	{
		private List<SignMailMerge> signMailMerge;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<SignMailMerge> SignMailMerge
		{
			/// <summary>The method to get the signMailMerge</summary>
			/// <returns>Instance of List<SignMailMerge></returns>
			get
			{
				return  this.signMailMerge;

			}
			/// <summary>The method to set the value to signMailMerge</summary>
			/// <param name="signMailMerge">Instance of List<SignMailMerge></param>
			set
			{
				 this.signMailMerge=value;

				 this.keyModified["sign_mail_merge"] = 1;

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