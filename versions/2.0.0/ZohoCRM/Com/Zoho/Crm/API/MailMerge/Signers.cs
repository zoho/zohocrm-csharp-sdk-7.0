using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.MailMerge
{

	public class Signers : Model
	{
		private string recipientName;
		private Choice<string> actionType;
		private Address recipient;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string RecipientName
		{
			/// <summary>The method to get the recipientName</summary>
			/// <returns>string representing the recipientName</returns>
			get
			{
				return  this.recipientName;

			}
			/// <summary>The method to set the value to recipientName</summary>
			/// <param name="recipientName">string</param>
			set
			{
				 this.recipientName=value;

				 this.keyModified["recipient_name"] = 1;

			}
		}

		public Choice<string> ActionType
		{
			/// <summary>The method to get the actionType</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.actionType;

			}
			/// <summary>The method to set the value to actionType</summary>
			/// <param name="actionType">Instance of Choice<string></param>
			set
			{
				 this.actionType=value;

				 this.keyModified["action_type"] = 1;

			}
		}

		public Address Recipient
		{
			/// <summary>The method to get the recipient</summary>
			/// <returns>Instance of Address</returns>
			get
			{
				return  this.recipient;

			}
			/// <summary>The method to set the value to recipient</summary>
			/// <param name="recipient">Instance of Address</param>
			set
			{
				 this.recipient=value;

				 this.keyModified["recipient"] = 1;

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