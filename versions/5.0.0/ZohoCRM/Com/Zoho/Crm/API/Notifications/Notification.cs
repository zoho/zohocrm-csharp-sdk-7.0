using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Notifications
{

	public class Notification : Event , Model
	{
		private string channelId;
		private string notifyUrl;
		private List<string> events;
		private string token;
		private Dictionary<string, object> fields;
		private bool? notifyOnRelatedAction;
		private bool? returnAffectedFieldValues;
		private Choice<bool?> deleteevents;
		private string resourceName;
		private DateTimeOffset? channelExpiry;
		private long? resourceId;
		private string resourceUri;
		private List<NotificationCondition> notificationCondition;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string ChannelId
		{
			/// <summary>The method to get the channelId</summary>
			/// <returns>string representing the channelId</returns>
			get
			{
				return  this.channelId;

			}
			/// <summary>The method to set the value to channelId</summary>
			/// <param name="channelId">string</param>
			set
			{
				 this.channelId=value;

				 this.keyModified["channel_id"] = 1;

			}
		}

		public string NotifyUrl
		{
			/// <summary>The method to get the notifyUrl</summary>
			/// <returns>string representing the notifyUrl</returns>
			get
			{
				return  this.notifyUrl;

			}
			/// <summary>The method to set the value to notifyUrl</summary>
			/// <param name="notifyUrl">string</param>
			set
			{
				 this.notifyUrl=value;

				 this.keyModified["notify_url"] = 1;

			}
		}

		public List<string> Events
		{
			/// <summary>The method to get the events</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.events;

			}
			/// <summary>The method to set the value to events</summary>
			/// <param name="events">Instance of List<string></param>
			set
			{
				 this.events=value;

				 this.keyModified["events"] = 1;

			}
		}

		public string Token
		{
			/// <summary>The method to get the token</summary>
			/// <returns>string representing the token</returns>
			get
			{
				return  this.token;

			}
			/// <summary>The method to set the value to token</summary>
			/// <param name="token">string</param>
			set
			{
				 this.token=value;

				 this.keyModified["token"] = 1;

			}
		}

		public Dictionary<string, object> Fields
		{
			/// <summary>The method to get the fields</summary>
			/// <returns>Dictionary representing the fields<String,Object></returns>
			get
			{
				return  this.fields;

			}
			/// <summary>The method to set the value to fields</summary>
			/// <param name="fields">Dictionary<string,object></param>
			set
			{
				 this.fields=value;

				 this.keyModified["fields"] = 1;

			}
		}

		public bool? NotifyOnRelatedAction
		{
			/// <summary>The method to get the notifyOnRelatedAction</summary>
			/// <returns>bool? representing the notifyOnRelatedAction</returns>
			get
			{
				return  this.notifyOnRelatedAction;

			}
			/// <summary>The method to set the value to notifyOnRelatedAction</summary>
			/// <param name="notifyOnRelatedAction">bool?</param>
			set
			{
				 this.notifyOnRelatedAction=value;

				 this.keyModified["notify_on_related_action"] = 1;

			}
		}

		public bool? ReturnAffectedFieldValues
		{
			/// <summary>The method to get the returnAffectedFieldValues</summary>
			/// <returns>bool? representing the returnAffectedFieldValues</returns>
			get
			{
				return  this.returnAffectedFieldValues;

			}
			/// <summary>The method to set the value to returnAffectedFieldValues</summary>
			/// <param name="returnAffectedFieldValues">bool?</param>
			set
			{
				 this.returnAffectedFieldValues=value;

				 this.keyModified["return_affected_field_values"] = 1;

			}
		}

		public Choice<bool?> Deleteevents
		{
			/// <summary>The method to get the deleteevents</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.deleteevents;

			}
			/// <summary>The method to set the value to deleteevents</summary>
			/// <param name="deleteevents">Instance of Choice<bool?></param>
			set
			{
				 this.deleteevents=value;

				 this.keyModified["_delete_events"] = 1;

			}
		}

		public string ResourceName
		{
			/// <summary>The method to get the resourceName</summary>
			/// <returns>string representing the resourceName</returns>
			get
			{
				return  this.resourceName;

			}
			/// <summary>The method to set the value to resourceName</summary>
			/// <param name="resourceName">string</param>
			set
			{
				 this.resourceName=value;

				 this.keyModified["resource_name"] = 1;

			}
		}

		public DateTimeOffset? ChannelExpiry
		{
			/// <summary>The method to get the channelExpiry</summary>
			/// <returns>DateTimeOffset? representing the channelExpiry</returns>
			get
			{
				return  this.channelExpiry;

			}
			/// <summary>The method to set the value to channelExpiry</summary>
			/// <param name="channelExpiry">DateTimeOffset?</param>
			set
			{
				 this.channelExpiry=value;

				 this.keyModified["channel_expiry"] = 1;

			}
		}

		public long? ResourceId
		{
			/// <summary>The method to get the resourceId</summary>
			/// <returns>long? representing the resourceId</returns>
			get
			{
				return  this.resourceId;

			}
			/// <summary>The method to set the value to resourceId</summary>
			/// <param name="resourceId">long?</param>
			set
			{
				 this.resourceId=value;

				 this.keyModified["resource_id"] = 1;

			}
		}

		public string ResourceUri
		{
			/// <summary>The method to get the resourceUri</summary>
			/// <returns>string representing the resourceUri</returns>
			get
			{
				return  this.resourceUri;

			}
			/// <summary>The method to set the value to resourceUri</summary>
			/// <param name="resourceUri">string</param>
			set
			{
				 this.resourceUri=value;

				 this.keyModified["resource_uri"] = 1;

			}
		}

		public List<NotificationCondition> NotificationCondition
		{
			/// <summary>The method to get the notificationCondition</summary>
			/// <returns>Instance of List<NotificationCondition></returns>
			get
			{
				return  this.notificationCondition;

			}
			/// <summary>The method to set the value to notificationCondition</summary>
			/// <param name="notificationCondition">Instance of List<NotificationCondition></param>
			set
			{
				 this.notificationCondition=value;

				 this.keyModified["notification_condition"] = 1;

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