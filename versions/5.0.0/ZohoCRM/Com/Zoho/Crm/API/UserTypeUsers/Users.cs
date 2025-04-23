using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserTypeUsers
{

	public class Users : Model
	{
		private long? personalityId;
		private bool? confirm;
		private string statusReasonS;
		private DateTimeOffset? invitedTime;
		private string module;
		private string name;
		private bool? active;
		private string email;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public long? PersonalityId
		{
			/// <summary>The method to get the personalityId</summary>
			/// <returns>long? representing the personalityId</returns>
			get
			{
				return  this.personalityId;

			}
			/// <summary>The method to set the value to personalityId</summary>
			/// <param name="personalityId">long?</param>
			set
			{
				 this.personalityId=value;

				 this.keyModified["personality_id"] = 1;

			}
		}

		public bool? Confirm
		{
			/// <summary>The method to get the confirm</summary>
			/// <returns>bool? representing the confirm</returns>
			get
			{
				return  this.confirm;

			}
			/// <summary>The method to set the value to confirm</summary>
			/// <param name="confirm">bool?</param>
			set
			{
				 this.confirm=value;

				 this.keyModified["confirm"] = 1;

			}
		}

		public string StatusReasonS
		{
			/// <summary>The method to get the statusReasonS</summary>
			/// <returns>string representing the statusReasonS</returns>
			get
			{
				return  this.statusReasonS;

			}
			/// <summary>The method to set the value to statusReasonS</summary>
			/// <param name="statusReasonS">string</param>
			set
			{
				 this.statusReasonS=value;

				 this.keyModified["status_reason__s"] = 1;

			}
		}

		public DateTimeOffset? InvitedTime
		{
			/// <summary>The method to get the invitedTime</summary>
			/// <returns>DateTimeOffset? representing the invitedTime</returns>
			get
			{
				return  this.invitedTime;

			}
			/// <summary>The method to set the value to invitedTime</summary>
			/// <param name="invitedTime">DateTimeOffset?</param>
			set
			{
				 this.invitedTime=value;

				 this.keyModified["invited_time"] = 1;

			}
		}

		public string Module
		{
			/// <summary>The method to get the module</summary>
			/// <returns>string representing the module</returns>
			get
			{
				return  this.module;

			}
			/// <summary>The method to set the value to module</summary>
			/// <param name="module">string</param>
			set
			{
				 this.module=value;

				 this.keyModified["module"] = 1;

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

		public bool? Active
		{
			/// <summary>The method to get the active</summary>
			/// <returns>bool? representing the active</returns>
			get
			{
				return  this.active;

			}
			/// <summary>The method to set the value to active</summary>
			/// <param name="active">bool?</param>
			set
			{
				 this.active=value;

				 this.keyModified["active"] = 1;

			}
		}

		public string Email
		{
			/// <summary>The method to get the email</summary>
			/// <returns>string representing the email</returns>
			get
			{
				return  this.email;

			}
			/// <summary>The method to set the value to email</summary>
			/// <param name="email">string</param>
			set
			{
				 this.email=value;

				 this.keyModified["email"] = 1;

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