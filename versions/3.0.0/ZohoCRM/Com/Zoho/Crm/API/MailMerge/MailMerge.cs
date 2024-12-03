using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.MailMerge
{

	public class MailMerge : Model
	{
		private MailMergeTemplate mailMergeTemplate;
		private Address fromAddress;
		private List<Address> toAddress;
		private List<Address> ccEmail;
		private List<Address> bccEmail;
		private string subject;
		private string message;
		private string type;
		private string attachmentName;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public MailMergeTemplate MailMergeTemplate
		{
			/// <summary>The method to get the mailMergeTemplate</summary>
			/// <returns>Instance of MailMergeTemplate</returns>
			get
			{
				return  this.mailMergeTemplate;

			}
			/// <summary>The method to set the value to mailMergeTemplate</summary>
			/// <param name="mailMergeTemplate">Instance of MailMergeTemplate</param>
			set
			{
				 this.mailMergeTemplate=value;

				 this.keyModified["mail_merge_template"] = 1;

			}
		}

		public Address FromAddress
		{
			/// <summary>The method to get the fromAddress</summary>
			/// <returns>Instance of Address</returns>
			get
			{
				return  this.fromAddress;

			}
			/// <summary>The method to set the value to fromAddress</summary>
			/// <param name="fromAddress">Instance of Address</param>
			set
			{
				 this.fromAddress=value;

				 this.keyModified["from_address"] = 1;

			}
		}

		public List<Address> ToAddress
		{
			/// <summary>The method to get the toAddress</summary>
			/// <returns>Instance of List<Address></returns>
			get
			{
				return  this.toAddress;

			}
			/// <summary>The method to set the value to toAddress</summary>
			/// <param name="toAddress">Instance of List<Address></param>
			set
			{
				 this.toAddress=value;

				 this.keyModified["to_address"] = 1;

			}
		}

		public List<Address> CcEmail
		{
			/// <summary>The method to get the ccEmail</summary>
			/// <returns>Instance of List<Address></returns>
			get
			{
				return  this.ccEmail;

			}
			/// <summary>The method to set the value to ccEmail</summary>
			/// <param name="ccEmail">Instance of List<Address></param>
			set
			{
				 this.ccEmail=value;

				 this.keyModified["cc_email"] = 1;

			}
		}

		public List<Address> BccEmail
		{
			/// <summary>The method to get the bccEmail</summary>
			/// <returns>Instance of List<Address></returns>
			get
			{
				return  this.bccEmail;

			}
			/// <summary>The method to set the value to bccEmail</summary>
			/// <param name="bccEmail">Instance of List<Address></param>
			set
			{
				 this.bccEmail=value;

				 this.keyModified["bcc_email"] = 1;

			}
		}

		public string Subject
		{
			/// <summary>The method to get the subject</summary>
			/// <returns>string representing the subject</returns>
			get
			{
				return  this.subject;

			}
			/// <summary>The method to set the value to subject</summary>
			/// <param name="subject">string</param>
			set
			{
				 this.subject=value;

				 this.keyModified["subject"] = 1;

			}
		}

		public string Message
		{
			/// <summary>The method to get the message</summary>
			/// <returns>string representing the message</returns>
			get
			{
				return  this.message;

			}
			/// <summary>The method to set the value to message</summary>
			/// <param name="message">string</param>
			set
			{
				 this.message=value;

				 this.keyModified["message"] = 1;

			}
		}

		public string Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>string representing the type</returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">string</param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

		public string AttachmentName
		{
			/// <summary>The method to get the attachmentName</summary>
			/// <returns>string representing the attachmentName</returns>
			get
			{
				return  this.attachmentName;

			}
			/// <summary>The method to set the value to attachmentName</summary>
			/// <param name="attachmentName">string</param>
			set
			{
				 this.attachmentName=value;

				 this.keyModified["attachment_name"] = 1;

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