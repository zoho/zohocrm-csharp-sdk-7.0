using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UnsubscribeLinks
{

	public class UnsubscribeLinks : Model
	{
		private long? id;
		private string name;
		private Choice<string> pageType;
		private string customLocationUrl;
		private string standardPageMessage;
		private Choice<string> submissionActionType;
		private string submissionMessage;
		private string submissionRedirectUrl;
		private string locationUrlType;
		private string actionOnUnsubscribe;
		private User createdBy;
		private User modifiedBy;
		private DateTimeOffset? modifiedTime;
		private DateTimeOffset? createdTime;
		private string landingUrl;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public long? Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>long? representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">long?</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

			}
		}

		public string Name
		{
			/// <summary>The method to get the name</summary>
			/// <returns>string representing the name</returns>
			get
			{
				return  this.name;

			}
			/// <summary>The method to set the value to name</summary>
			/// <param name="name">string</param>
			set
			{
				 this.name=value;

				 this.keyModified["name"] = 1;

			}
		}

		public Choice<string> PageType
		{
			/// <summary>The method to get the pageType</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.pageType;

			}
			/// <summary>The method to set the value to pageType</summary>
			/// <param name="pageType">Instance of Choice<string></param>
			set
			{
				 this.pageType=value;

				 this.keyModified["page_type"] = 1;

			}
		}

		public string CustomLocationUrl
		{
			/// <summary>The method to get the customLocationUrl</summary>
			/// <returns>string representing the customLocationUrl</returns>
			get
			{
				return  this.customLocationUrl;

			}
			/// <summary>The method to set the value to customLocationUrl</summary>
			/// <param name="customLocationUrl">string</param>
			set
			{
				 this.customLocationUrl=value;

				 this.keyModified["custom_location_url"] = 1;

			}
		}

		public string StandardPageMessage
		{
			/// <summary>The method to get the standardPageMessage</summary>
			/// <returns>string representing the standardPageMessage</returns>
			get
			{
				return  this.standardPageMessage;

			}
			/// <summary>The method to set the value to standardPageMessage</summary>
			/// <param name="standardPageMessage">string</param>
			set
			{
				 this.standardPageMessage=value;

				 this.keyModified["standard_page_message"] = 1;

			}
		}

		public Choice<string> SubmissionActionType
		{
			/// <summary>The method to get the submissionActionType</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.submissionActionType;

			}
			/// <summary>The method to set the value to submissionActionType</summary>
			/// <param name="submissionActionType">Instance of Choice<string></param>
			set
			{
				 this.submissionActionType=value;

				 this.keyModified["submission_action_type"] = 1;

			}
		}

		public string SubmissionMessage
		{
			/// <summary>The method to get the submissionMessage</summary>
			/// <returns>string representing the submissionMessage</returns>
			get
			{
				return  this.submissionMessage;

			}
			/// <summary>The method to set the value to submissionMessage</summary>
			/// <param name="submissionMessage">string</param>
			set
			{
				 this.submissionMessage=value;

				 this.keyModified["submission_message"] = 1;

			}
		}

		public string SubmissionRedirectUrl
		{
			/// <summary>The method to get the submissionRedirectUrl</summary>
			/// <returns>string representing the submissionRedirectUrl</returns>
			get
			{
				return  this.submissionRedirectUrl;

			}
			/// <summary>The method to set the value to submissionRedirectUrl</summary>
			/// <param name="submissionRedirectUrl">string</param>
			set
			{
				 this.submissionRedirectUrl=value;

				 this.keyModified["submission_redirect_url"] = 1;

			}
		}

		public string LocationUrlType
		{
			/// <summary>The method to get the locationUrlType</summary>
			/// <returns>string representing the locationUrlType</returns>
			get
			{
				return  this.locationUrlType;

			}
			/// <summary>The method to set the value to locationUrlType</summary>
			/// <param name="locationUrlType">string</param>
			set
			{
				 this.locationUrlType=value;

				 this.keyModified["location_url_type"] = 1;

			}
		}

		public string ActionOnUnsubscribe
		{
			/// <summary>The method to get the actionOnUnsubscribe</summary>
			/// <returns>string representing the actionOnUnsubscribe</returns>
			get
			{
				return  this.actionOnUnsubscribe;

			}
			/// <summary>The method to set the value to actionOnUnsubscribe</summary>
			/// <param name="actionOnUnsubscribe">string</param>
			set
			{
				 this.actionOnUnsubscribe=value;

				 this.keyModified["action_on_unsubscribe"] = 1;

			}
		}

		public User CreatedBy
		{
			/// <summary>The method to get the createdBy</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.createdBy;

			}
			/// <summary>The method to set the value to createdBy</summary>
			/// <param name="createdBy">Instance of User</param>
			set
			{
				 this.createdBy=value;

				 this.keyModified["created_by"] = 1;

			}
		}

		public User ModifiedBy
		{
			/// <summary>The method to get the modifiedBy</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.modifiedBy;

			}
			/// <summary>The method to set the value to modifiedBy</summary>
			/// <param name="modifiedBy">Instance of User</param>
			set
			{
				 this.modifiedBy=value;

				 this.keyModified["modified_by"] = 1;

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

		public string LandingUrl
		{
			/// <summary>The method to get the landingUrl</summary>
			/// <returns>string representing the landingUrl</returns>
			get
			{
				return  this.landingUrl;

			}
			/// <summary>The method to set the value to landingUrl</summary>
			/// <param name="landingUrl">string</param>
			set
			{
				 this.landingUrl=value;

				 this.keyModified["landing_url"] = 1;

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