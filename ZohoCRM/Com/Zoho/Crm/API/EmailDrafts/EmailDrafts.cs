using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailDrafts
{

	public class EmailDrafts : Model
	{
		private string id;
		private DateTimeOffset? modifiedTime;
		private DateTimeOffset? createdTime;
		private string from;
		private List<To> to;
		private string replyTo;
		private List<To> cc;
		private List<To> bcc;
		private Template template;
		private InventoryDetails inventoryDetails;
		private List<Attachments> attachments;
		private ScheduleDetails scheduleDetails;
		private bool? richText;
		private bool? emailOptOut;
		private string subject;
		private string content;
		private string summary;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>string representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">string</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

			}
		}

		public DateTimeOffset? ModifiedTime
		{
			/// <summary>The method to get the modifiedTime</summary>
			/// <returns>DateTimeOffset? representing the modifiedTime</returns>
			get
			{
				return  this.modifiedTime;

			}
			/// <summary>The method to set the value to modifiedTime</summary>
			/// <param name="modifiedTime">DateTimeOffset?</param>
			set
			{
				 this.modifiedTime=value;

				 this.keyModified["modified_time"] = 1;

			}
		}

		public DateTimeOffset? CreatedTime
		{
			/// <summary>The method to get the createdTime</summary>
			/// <returns>DateTimeOffset? representing the createdTime</returns>
			get
			{
				return  this.createdTime;

			}
			/// <summary>The method to set the value to createdTime</summary>
			/// <param name="createdTime">DateTimeOffset?</param>
			set
			{
				 this.createdTime=value;

				 this.keyModified["created_time"] = 1;

			}
		}

		public string From
		{
			/// <summary>The method to get the from</summary>
			/// <returns>string representing the from</returns>
			get
			{
				return  this.from;

			}
			/// <summary>The method to set the value to from</summary>
			/// <param name="from">string</param>
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

		public string ReplyTo
		{
			/// <summary>The method to get the replyTo</summary>
			/// <returns>string representing the replyTo</returns>
			get
			{
				return  this.replyTo;

			}
			/// <summary>The method to set the value to replyTo</summary>
			/// <param name="replyTo">string</param>
			set
			{
				 this.replyTo=value;

				 this.keyModified["reply_to"] = 1;

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

		public ScheduleDetails ScheduleDetails
		{
			/// <summary>The method to get the scheduleDetails</summary>
			/// <returns>Instance of ScheduleDetails</returns>
			get
			{
				return  this.scheduleDetails;

			}
			/// <summary>The method to set the value to scheduleDetails</summary>
			/// <param name="scheduleDetails">Instance of ScheduleDetails</param>
			set
			{
				 this.scheduleDetails=value;

				 this.keyModified["schedule_details"] = 1;

			}
		}

		public bool? RichText
		{
			/// <summary>The method to get the richText</summary>
			/// <returns>bool? representing the richText</returns>
			get
			{
				return  this.richText;

			}
			/// <summary>The method to set the value to richText</summary>
			/// <param name="richText">bool?</param>
			set
			{
				 this.richText=value;

				 this.keyModified["rich_text"] = 1;

			}
		}

		public bool? EmailOptOut
		{
			/// <summary>The method to get the emailOptOut</summary>
			/// <returns>bool? representing the emailOptOut</returns>
			get
			{
				return  this.emailOptOut;

			}
			/// <summary>The method to set the value to emailOptOut</summary>
			/// <param name="emailOptOut">bool?</param>
			set
			{
				 this.emailOptOut=value;

				 this.keyModified["email_opt_out"] = 1;

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

		public string Summary
		{
			/// <summary>The method to get the summary</summary>
			/// <returns>string representing the summary</returns>
			get
			{
				return  this.summary;

			}
			/// <summary>The method to set the value to summary</summary>
			/// <param name="summary">string</param>
			set
			{
				 this.summary=value;

				 this.keyModified["summary"] = 1;

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