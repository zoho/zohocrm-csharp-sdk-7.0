using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailRelatedRecords
{

	public class Email : Model
	{
		private List<Attachments> attachments;
		private long? threadId;
		private List<UserDetails> cc;
		private string summary;
		private Users.MinifiedUser owner;
		private bool? read;
		private string content;
		private bool? sent;
		private string subject;
		private object activityInfo;
		private Choice<string> intent;
		private Choice<string> sentimentInfo;
		private string messageId;
		private string source;
		private LinkedRecord linkedRecord;
		private string sentTime;
		private string emotion;
		private UserDetails from;
		private List<UserDetails> to;
		private DateTimeOffset? time;
		private List<Status> status;
		private bool? hasAttachment;
		private bool? hasThreadAttachment;
		private bool? editable;
		private string mailFormat;
		private UserDetails replyTo;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public long? ThreadId
		{
			/// <summary>The method to get the threadId</summary>
			/// <returns>long? representing the threadId</returns>
			get
			{
				return  this.threadId;

			}
			/// <summary>The method to set the value to threadId</summary>
			/// <param name="threadId">long?</param>
			set
			{
				 this.threadId=value;

				 this.keyModified["thread_id"] = 1;

			}
		}

		public List<UserDetails> Cc
		{
			/// <summary>The method to get the cc</summary>
			/// <returns>Instance of List<UserDetails></returns>
			get
			{
				return  this.cc;

			}
			/// <summary>The method to set the value to cc</summary>
			/// <param name="cc">Instance of List<UserDetails></param>
			set
			{
				 this.cc=value;

				 this.keyModified["cc"] = 1;

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

		public Users.MinifiedUser Owner
		{
			/// <summary>The method to get the owner</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.owner;

			}
			/// <summary>The method to set the value to owner</summary>
			/// <param name="owner">Instance of MinifiedUser</param>
			set
			{
				 this.owner=value;

				 this.keyModified["owner"] = 1;

			}
		}

		public bool? Read
		{
			/// <summary>The method to get the read</summary>
			/// <returns>bool? representing the read</returns>
			get
			{
				return  this.read;

			}
			/// <summary>The method to set the value to read</summary>
			/// <param name="read">bool?</param>
			set
			{
				 this.read=value;

				 this.keyModified[Constants.REQUEST_CATEGORY_READ] = 1;

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

		public object ActivityInfo
		{
			/// <summary>The method to get the activityInfo</summary>
			/// <returns>object representing the activityInfo</returns>
			get
			{
				return  this.activityInfo;

			}
			/// <summary>The method to set the value to activityInfo</summary>
			/// <param name="activityInfo">object</param>
			set
			{
				 this.activityInfo=value;

				 this.keyModified["activity_info"] = 1;

			}
		}

		public Choice<string> Intent
		{
			/// <summary>The method to get the intent</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.intent;

			}
			/// <summary>The method to set the value to intent</summary>
			/// <param name="intent">Instance of Choice<string></param>
			set
			{
				 this.intent=value;

				 this.keyModified["intent"] = 1;

			}
		}

		public Choice<string> SentimentInfo
		{
			/// <summary>The method to get the sentimentInfo</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.sentimentInfo;

			}
			/// <summary>The method to set the value to sentimentInfo</summary>
			/// <param name="sentimentInfo">Instance of Choice<string></param>
			set
			{
				 this.sentimentInfo=value;

				 this.keyModified["sentiment_info"] = 1;

			}
		}

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

		public string Source
		{
			/// <summary>The method to get the source</summary>
			/// <returns>string representing the source</returns>
			get
			{
				return  this.source;

			}
			/// <summary>The method to set the value to source</summary>
			/// <param name="source">string</param>
			set
			{
				 this.source=value;

				 this.keyModified["source"] = 1;

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

		public string SentTime
		{
			/// <summary>The method to get the sentTime</summary>
			/// <returns>string representing the sentTime</returns>
			get
			{
				return  this.sentTime;

			}
			/// <summary>The method to set the value to sentTime</summary>
			/// <param name="sentTime">string</param>
			set
			{
				 this.sentTime=value;

				 this.keyModified["sent_time"] = 1;

			}
		}

		public string Emotion
		{
			/// <summary>The method to get the emotion</summary>
			/// <returns>string representing the emotion</returns>
			get
			{
				return  this.emotion;

			}
			/// <summary>The method to set the value to emotion</summary>
			/// <param name="emotion">string</param>
			set
			{
				 this.emotion=value;

				 this.keyModified["emotion"] = 1;

			}
		}

		public UserDetails From
		{
			/// <summary>The method to get the from</summary>
			/// <returns>Instance of UserDetails</returns>
			get
			{
				return  this.from;

			}
			/// <summary>The method to set the value to from</summary>
			/// <param name="from">Instance of UserDetails</param>
			set
			{
				 this.from=value;

				 this.keyModified["from"] = 1;

			}
		}

		public List<UserDetails> To
		{
			/// <summary>The method to get the to</summary>
			/// <returns>Instance of List<UserDetails></returns>
			get
			{
				return  this.to;

			}
			/// <summary>The method to set the value to to</summary>
			/// <param name="to">Instance of List<UserDetails></param>
			set
			{
				 this.to=value;

				 this.keyModified["to"] = 1;

			}
		}

		public DateTimeOffset? Time
		{
			/// <summary>The method to get the time</summary>
			/// <returns>DateTimeOffset? representing the time</returns>
			get
			{
				return  this.time;

			}
			/// <summary>The method to set the value to time</summary>
			/// <param name="time">DateTimeOffset?</param>
			set
			{
				 this.time=value;

				 this.keyModified["time"] = 1;

			}
		}

		public List<Status> Status
		{
			/// <summary>The method to get the status</summary>
			/// <returns>Instance of List<Status></returns>
			get
			{
				return  this.status;

			}
			/// <summary>The method to set the value to status</summary>
			/// <param name="status">Instance of List<Status></param>
			set
			{
				 this.status=value;

				 this.keyModified["status"] = 1;

			}
		}

		public bool? HasAttachment
		{
			/// <summary>The method to get the hasAttachment</summary>
			/// <returns>bool? representing the hasAttachment</returns>
			get
			{
				return  this.hasAttachment;

			}
			/// <summary>The method to set the value to hasAttachment</summary>
			/// <param name="hasAttachment">bool?</param>
			set
			{
				 this.hasAttachment=value;

				 this.keyModified["has_attachment"] = 1;

			}
		}

		public bool? HasThreadAttachment
		{
			/// <summary>The method to get the hasThreadAttachment</summary>
			/// <returns>bool? representing the hasThreadAttachment</returns>
			get
			{
				return  this.hasThreadAttachment;

			}
			/// <summary>The method to set the value to hasThreadAttachment</summary>
			/// <param name="hasThreadAttachment">bool?</param>
			set
			{
				 this.hasThreadAttachment=value;

				 this.keyModified["has_thread_attachment"] = 1;

			}
		}

		public bool? Editable
		{
			/// <summary>The method to get the editable</summary>
			/// <returns>bool? representing the editable</returns>
			get
			{
				return  this.editable;

			}
			/// <summary>The method to set the value to editable</summary>
			/// <param name="editable">bool?</param>
			set
			{
				 this.editable=value;

				 this.keyModified["editable"] = 1;

			}
		}

		public string MailFormat
		{
			/// <summary>The method to get the mailFormat</summary>
			/// <returns>string representing the mailFormat</returns>
			get
			{
				return  this.mailFormat;

			}
			/// <summary>The method to set the value to mailFormat</summary>
			/// <param name="mailFormat">string</param>
			set
			{
				 this.mailFormat=value;

				 this.keyModified["mail_format"] = 1;

			}
		}

		public UserDetails ReplyTo
		{
			/// <summary>The method to get the replyTo</summary>
			/// <returns>Instance of UserDetails</returns>
			get
			{
				return  this.replyTo;

			}
			/// <summary>The method to set the value to replyTo</summary>
			/// <param name="replyTo">Instance of UserDetails</param>
			set
			{
				 this.replyTo=value;

				 this.keyModified["reply_to"] = 1;

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