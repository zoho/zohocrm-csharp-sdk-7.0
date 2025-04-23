using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.SendMail
{

	public class Data : Model
	{
		private From from;
		private List<To> to;
		private List<Cc> cc;
		private List<Cc> bcc;
		private To replyTo;
		private bool? orgEmail;
		private DateTimeOffset? scheduledTime;
		private Choice<string> mailFormat;
		private bool? consentEmail;
		private string content;
		private string subject;
		private InReplyTo inReplyTo;
		private Template template;
		private InventoryDetails inventoryDetails;
		private DataSubjectRequest dataSubjectRequest;
		private List<Attachment> attachments;
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

		public List<Cc> Cc
		{
			/// <summary>The method to get the cc</summary>
			/// <returns>Instance of List<Cc></returns>
			get
			{
				return  this.cc;

			}
			/// <summary>The method to set the value to cc</summary>
			/// <param name="cc">Instance of List<Cc></param>
			set
			{
				 this.cc=value;

				 this.keyModified["cc"] = 1;

			}
		}

		public List<Cc> Bcc
		{
			/// <summary>The method to get the bcc</summary>
			/// <returns>Instance of List<Cc></returns>
			get
			{
				return  this.bcc;

			}
			/// <summary>The method to set the value to bcc</summary>
			/// <param name="bcc">Instance of List<Cc></param>
			set
			{
				 this.bcc=value;

				 this.keyModified["bcc"] = 1;

			}
		}

		public To ReplyTo
		{
			/// <summary>The method to get the replyTo</summary>
			/// <returns>Instance of To</returns>
			get
			{
				return  this.replyTo;

			}
			/// <summary>The method to set the value to replyTo</summary>
			/// <param name="replyTo">Instance of To</param>
			set
			{
				 this.replyTo=value;

				 this.keyModified["reply_to"] = 1;

			}
		}

		public bool? OrgEmail
		{
			/// <summary>The method to get the orgEmail</summary>
			/// <returns>bool? representing the orgEmail</returns>
			get
			{
				return  this.orgEmail;

			}
			/// <summary>The method to set the value to orgEmail</summary>
			/// <param name="orgEmail">bool?</param>
			set
			{
				 this.orgEmail=value;

				 this.keyModified["org_email"] = 1;

			}
		}

		public DateTimeOffset? ScheduledTime
		{
			/// <summary>The method to get the scheduledTime</summary>
			/// <returns>DateTimeOffset? representing the scheduledTime</returns>
			get
			{
				return  this.scheduledTime;

			}
			/// <summary>The method to set the value to scheduledTime</summary>
			/// <param name="scheduledTime">DateTimeOffset?</param>
			set
			{
				 this.scheduledTime=value;

				 this.keyModified["scheduled_time"] = 1;

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

		public bool? ConsentEmail
		{
			/// <summary>The method to get the consentEmail</summary>
			/// <returns>bool? representing the consentEmail</returns>
			get
			{
				return  this.consentEmail;

			}
			/// <summary>The method to set the value to consentEmail</summary>
			/// <param name="consentEmail">bool?</param>
			set
			{
				 this.consentEmail=value;

				 this.keyModified["consent_email"] = 1;

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

		public InReplyTo InReplyTo
		{
			/// <summary>The method to get the inReplyTo</summary>
			/// <returns>Instance of InReplyTo</returns>
			get
			{
				return  this.inReplyTo;

			}
			/// <summary>The method to set the value to inReplyTo</summary>
			/// <param name="inReplyTo">Instance of InReplyTo</param>
			set
			{
				 this.inReplyTo=value;

				 this.keyModified["in_reply_to"] = 1;

			}
		}

		public Template Template
		{
			/// <summary>The method to get the template</summary>
			/// <returns>Instance of Template</returns>
			get
			{
				return  this.template;

			}
			/// <summary>The method to set the value to template</summary>
			/// <param name="template">Instance of Template</param>
			set
			{
				 this.template=value;

				 this.keyModified["template"] = 1;

			}
		}

		public InventoryDetails InventoryDetails
		{
			/// <summary>The method to get the inventoryDetails</summary>
			/// <returns>Instance of InventoryDetails</returns>
			get
			{
				return  this.inventoryDetails;

			}
			/// <summary>The method to set the value to inventoryDetails</summary>
			/// <param name="inventoryDetails">Instance of InventoryDetails</param>
			set
			{
				 this.inventoryDetails=value;

				 this.keyModified["inventory_details"] = 1;

			}
		}

		public DataSubjectRequest DataSubjectRequest
		{
			/// <summary>The method to get the dataSubjectRequest</summary>
			/// <returns>Instance of DataSubjectRequest</returns>
			get
			{
				return  this.dataSubjectRequest;

			}
			/// <summary>The method to set the value to dataSubjectRequest</summary>
			/// <param name="dataSubjectRequest">Instance of DataSubjectRequest</param>
			set
			{
				 this.dataSubjectRequest=value;

				 this.keyModified["data_subject_request"] = 1;

			}
		}

		public List<Attachment> Attachments
		{
			/// <summary>The method to get the attachments</summary>
			/// <returns>Instance of List<Attachment></returns>
			get
			{
				return  this.attachments;

			}
			/// <summary>The method to set the value to attachments</summary>
			/// <param name="attachments">Instance of List<Attachment></param>
			set
			{
				 this.attachments=value;

				 this.keyModified["attachments"] = 1;

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