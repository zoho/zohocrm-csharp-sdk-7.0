using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.SendMail
{

	public class InReplyTo : Model
	{
		private string messageId;
		private Owner owner;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string MessageId
		{
			/// <summary>The method to get the messageId</summary>
			/// <returns>string representing the messageId</returns>
			get
			{
				return  this.messageId;

			}
			/// <summary>The method to set the value to messageId</summary>
			/// <param name="messageId">string</param>
			set
			{
				 this.messageId=value;

				 this.keyModified["message_id"] = 1;

			}
		}

		public Owner Owner
		{
			/// <summary>The method to get the owner</summary>
			/// <returns>Instance of Owner</returns>
			get
			{
				return  this.owner;

			}
			/// <summary>The method to set the value to owner</summary>
			/// <param name="owner">Instance of Owner</param>
			set
			{
				 this.owner=value;

				 this.keyModified["owner"] = 1;

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