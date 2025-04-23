using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Webforms
{

	public class AnalyticsData : Model
	{
		private string iframeUrlTrackingCode;
		private bool? urlAnalyticsEnabled;
		private bool? analyticsEnabled;
		private DateTimeOffset? analyticsEnabledTime;
		private string trackingCode;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string IframeUrlTrackingCode
		{
			/// <summary>The method to get the iframeUrlTrackingCode</summary>
			/// <returns>string representing the iframeUrlTrackingCode</returns>
			get
			{
				return  this.iframeUrlTrackingCode;

			}
			/// <summary>The method to set the value to iframeUrlTrackingCode</summary>
			/// <param name="iframeUrlTrackingCode">string</param>
			set
			{
				 this.iframeUrlTrackingCode=value;

				 this.keyModified["iframe_url_tracking_code"] = 1;

			}
		}

		public bool? UrlAnalyticsEnabled
		{
			/// <summary>The method to get the urlAnalyticsEnabled</summary>
			/// <returns>bool? representing the urlAnalyticsEnabled</returns>
			get
			{
				return  this.urlAnalyticsEnabled;

			}
			/// <summary>The method to set the value to urlAnalyticsEnabled</summary>
			/// <param name="urlAnalyticsEnabled">bool?</param>
			set
			{
				 this.urlAnalyticsEnabled=value;

				 this.keyModified["url_analytics_enabled"] = 1;

			}
		}

		public bool? AnalyticsEnabled
		{
			/// <summary>The method to get the analyticsEnabled</summary>
			/// <returns>bool? representing the analyticsEnabled</returns>
			get
			{
				return  this.analyticsEnabled;

			}
			/// <summary>The method to set the value to analyticsEnabled</summary>
			/// <param name="analyticsEnabled">bool?</param>
			set
			{
				 this.analyticsEnabled=value;

				 this.keyModified["analytics_enabled"] = 1;

			}
		}

		public DateTimeOffset? AnalyticsEnabledTime
		{
			/// <summary>The method to get the analyticsEnabledTime</summary>
			/// <returns>DateTimeOffset? representing the analyticsEnabledTime</returns>
			get
			{
				return  this.analyticsEnabledTime;

			}
			/// <summary>The method to set the value to analyticsEnabledTime</summary>
			/// <param name="analyticsEnabledTime">DateTimeOffset?</param>
			set
			{
				 this.analyticsEnabledTime=value;

				 this.keyModified["analytics_enabled_time"] = 1;

			}
		}

		public string TrackingCode
		{
			/// <summary>The method to get the trackingCode</summary>
			/// <returns>string representing the trackingCode</returns>
			get
			{
				return  this.trackingCode;

			}
			/// <summary>The method to set the value to trackingCode</summary>
			/// <param name="trackingCode">string</param>
			set
			{
				 this.trackingCode=value;

				 this.keyModified["tracking_code"] = 1;

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