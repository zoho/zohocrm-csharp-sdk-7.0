using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.AssociateEmail
{

	public class AssociateEmail : Model
	{
		private From from;
		private List<To> to;
		private List<To> cc;
		private List<To> bcc;
		private List<Attachments> attachments;
		private string content;
		private Choice<string> mailFormat;
		private string subject;
		private string originalMessageId;
		private bool? sent;
		private DateTimeOffset? dateTime;
		private LinkedRecord linkedRecord;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public From From
		{
			/// <summary>The method to get the from</summary>
			/// <returns>Instance of From</returns>
			get
			{
				return  this.from;

			}
			/// <summary>The method to set the value to from</summary>
			/// <param name="from">Instance of From</param>
			set
			{
				 this.from=value;

				 this.keyModified["from"] = 1;

			}
		}

		public List<To> To
		{
			/// <summary>The method to get the to</summary>
			/// <returns>Instance of List<To></returns>
			get
			{
				return  this.to;

			}
			/// <summary>The method to set the value to to</summary>
			/// <param name="to">Instance of List<To></param>
			set
			{
				 this.to=value;

				 this.keyModified["to"] = 1;

			}
		}

		public List<To> Cc
		{
			/// <summary>The method to get the cc</summary>
			/// <returns>Instance of List<To></returns>
			get
			{
				return  this.cc;

			}
			/// <summary>The method to set the value to cc</summary>
			/// <param name="cc">Instance of List<To></param>
			set
			{
				 this.cc=value;

				 this.keyModified["cc"] = 1;

			}
		}

		public List<To> Bcc
		{
			/// <summary>The method to get the bcc</summary>
			/// <returns>Instance of List<To></returns>
			get
			{
				return  this.bcc;

			}
			/// <summary>The method to set the value to bcc</summary>
			/// <param name="bcc">Instance of List<To></param>
			set
			{
				 this.bcc=value;

				 this.keyModified["bcc"] = 1;

			}
		}

		public List<Attachments> Attachments
		{
			/// <summary>The method to get the attachments</summary>
			/// <returns>Instance of List<Attachments></returns>
			get
			{
				return  this.attachments;

			}
			/// <summary>The method to set the value to attachments</summary>
			/// <param name="attachments">Instance of List<Attachments></param>
			set
			{
				 this.attachments=value;

				 this.keyModified["attachments"] = 1;

			}
		}

		public string Content
		{
			/// <summary>The method to get the content</summary>
			/// <returns>string representing the content</returns>
			get
			{
				return  this.content;

			}
			/// <summary>The method to set the value to content</summary>
			/// <param name="content">string</param>
			set
			{
				 this.content=value;

				 this.keyModified["content"] = 1;

			}
		}

		public Choice<string> MailFormat
		{
			/// <summary>The method to get the mailFormat</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.mailFormat;

			}
			/// <summary>The method to set the value to mailFormat</summary>
			/// <param name="mailFormat">Instance of Choice<string></param>
			set
			{
				 this.mailFormat=value;

				 this.keyModified["mail_format"] = 1;

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

		public string OriginalMessageId
		{
			/// <summary>The method to get the originalMessageId</summary>
			/// <returns>string representing the originalMessageId</returns>
			get
			{
				return  this.originalMessageId;

			}
			/// <summary>The method to set the value to originalMessageId</summary>
			/// <param name="originalMessageId">string</param>
			set
			{
				 this.originalMessageId=value;

				 this.keyModified["original_message_id"] = 1;

			}
		}

		public bool? Sent
		{
			/// <summary>The method to get the sent</summary>
			/// <returns>bool? representing the sent</returns>
			get
			{
				return  this.sent;

			}
			/// <summary>The method to set the value to sent</summary>
			/// <param name="sent">bool?</param>
			set
			{
				 this.sent=value;

				 this.keyModified["sent"] = 1;

			}
		}

		public DateTimeOffset? DateTime
		{
			/// <summary>The method to get the dateTime</summary>
			/// <returns>DateTimeOffset? representing the dateTime</returns>
			get
			{
				return  this.dateTime;

			}
			/// <summary>The method to set the value to dateTime</summary>
			/// <param name="dateTime">DateTimeOffset?</param>
			set
			{
				 this.dateTime=value;

				 this.keyModified["date_time"] = 1;

			}
		}

		public LinkedRecord LinkedRecord
		{
			/// <summary>The method to get the linkedRecord</summary>
			/// <returns>Instance of LinkedRecord</returns>
			get
			{
				return  this.linkedRecord;

			}
			/// <summary>The method to set the value to linkedRecord</summary>
			/// <param name="linkedRecord">Instance of LinkedRecord</param>
			set
			{
				 this.linkedRecord=value;

				 this.keyModified["linked_record"] = 1;

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