using Com.Zoho.Crm.API.Record;
using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ConvertLead
{

	public class LeadConverter : Model
	{
		private bool? overwrite;
		private bool? notifyLeadOwner;
		private bool? notifyNewEntityOwner;
		private MoveAttachmentsTo moveAttachmentsTo;
		private Record.Record accounts;
		private Record.Record contacts;
		private Users.MinifiedUser assignTo;
		private Record.Record deals;
		private Choice<bool?> addToExistingRecord;
		private CarryOverTags carryOverTags;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? Overwrite
		{
			/// <summary>The method to get the overwrite</summary>
			/// <returns>bool? representing the overwrite</returns>
			get
			{
				return  this.overwrite;

			}
			/// <summary>The method to set the value to overwrite</summary>
			/// <param name="overwrite">bool?</param>
			set
			{
				 this.overwrite=value;

				 this.keyModified["overwrite"] = 1;

			}
		}

		public bool? NotifyLeadOwner
		{
			/// <summary>The method to get the notifyLeadOwner</summary>
			/// <returns>bool? representing the notifyLeadOwner</returns>
			get
			{
				return  this.notifyLeadOwner;

			}
			/// <summary>The method to set the value to notifyLeadOwner</summary>
			/// <param name="notifyLeadOwner">bool?</param>
			set
			{
				 this.notifyLeadOwner=value;

				 this.keyModified["notify_lead_owner"] = 1;

			}
		}

		public bool? NotifyNewEntityOwner
		{
			/// <summary>The method to get the notifyNewEntityOwner</summary>
			/// <returns>bool? representing the notifyNewEntityOwner</returns>
			get
			{
				return  this.notifyNewEntityOwner;

			}
			/// <summary>The method to set the value to notifyNewEntityOwner</summary>
			/// <param name="notifyNewEntityOwner">bool?</param>
			set
			{
				 this.notifyNewEntityOwner=value;

				 this.keyModified["notify_new_entity_owner"] = 1;

			}
		}

		public MoveAttachmentsTo MoveAttachmentsTo
		{
			/// <summary>The method to get the moveAttachmentsTo</summary>
			/// <returns>Instance of MoveAttachmentsTo</returns>
			get
			{
				return  this.moveAttachmentsTo;

			}
			/// <summary>The method to set the value to moveAttachmentsTo</summary>
			/// <param name="moveAttachmentsTo">Instance of MoveAttachmentsTo</param>
			set
			{
				 this.moveAttachmentsTo=value;

				 this.keyModified["move_attachments_to"] = 1;

			}
		}

		public Record.Record Accounts
		{
			/// <summary>The method to get the accounts</summary>
			/// <returns>Instance of Record</returns>
			get
			{
				return  this.accounts;

			}
			/// <summary>The method to set the value to accounts</summary>
			/// <param name="accounts">Instance of Record</param>
			set
			{
				 this.accounts=value;

				 this.keyModified["Accounts"] = 1;

			}
		}

		public Record.Record Contacts
		{
			/// <summary>The method to get the contacts</summary>
			/// <returns>Instance of Record</returns>
			get
			{
				return  this.contacts;

			}
			/// <summary>The method to set the value to contacts</summary>
			/// <param name="contacts">Instance of Record</param>
			set
			{
				 this.contacts=value;

				 this.keyModified["Contacts"] = 1;

			}
		}

		public Users.MinifiedUser AssignTo
		{
			/// <summary>The method to get the assignTo</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.assignTo;

			}
			/// <summary>The method to set the value to assignTo</summary>
			/// <param name="assignTo">Instance of MinifiedUser</param>
			set
			{
				 this.assignTo=value;

				 this.keyModified["assign_to"] = 1;

			}
		}

		public Record.Record Deals
		{
			/// <summary>The method to get the deals</summary>
			/// <returns>Instance of Record</returns>
			get
			{
				return  this.deals;

			}
			/// <summary>The method to set the value to deals</summary>
			/// <param name="deals">Instance of Record</param>
			set
			{
				 this.deals=value;

				 this.keyModified["Deals"] = 1;

			}
		}

		public Choice<bool?> AddToExistingRecord
		{
			/// <summary>The method to get the addToExistingRecord</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.addToExistingRecord;

			}
			/// <summary>The method to set the value to addToExistingRecord</summary>
			/// <param name="addToExistingRecord">Instance of Choice<bool?></param>
			set
			{
				 this.addToExistingRecord=value;

				 this.keyModified["add_to_existing_record"] = 1;

			}
		}

		public CarryOverTags CarryOverTags
		{
			/// <summary>The method to get the carryOverTags</summary>
			/// <returns>Instance of CarryOverTags</returns>
			get
			{
				return  this.carryOverTags;

			}
			/// <summary>The method to set the value to carryOverTags</summary>
			/// <param name="carryOverTags">Instance of CarryOverTags</param>
			set
			{
				 this.carryOverTags=value;

				 this.keyModified["carry_over_tags"] = 1;

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