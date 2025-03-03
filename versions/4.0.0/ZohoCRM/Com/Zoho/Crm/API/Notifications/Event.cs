using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Notifications
{

	public class Event : Model
	{
		private string resourceName;
		private DateTimeOffset? channelExpiry;
		private long? resourceId;
		private string resourceUri;
		private string channelId;
		private List<NotificationCondition> notificationCondition;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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