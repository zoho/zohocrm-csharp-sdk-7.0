using Com.Zoho.Crm.API.Record;
using Com.Zoho.Crm.API.Tags;
using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.RecordLocking
{

	public class RecordLock : Record.Record , Model
	{

		public Choice<string> LockSourceS
		{
			/// <summary>The method to get the lockSourceS</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				if((( this.GetKeyValue("lock_source__s")) != (null)))
				{
					return (Choice<string>) this.GetKeyValue("lock_source__s");

				}
					return null;


			}
			/// <summary>The method to set the value to lockSourceS</summary>
			/// <param name="lockSourceS">Instance of Choice<string></param>
			set
			{
				 this.AddKeyValue("lock_source__s", value);

			}
		}

		public Users.MinifiedUser LockedByS
		{
			/// <summary>The method to get the lockedByS</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				if((( this.GetKeyValue("locked_by__s")) != (null)))
				{
					return (Users.MinifiedUser) this.GetKeyValue("locked_by__s");

				}
					return null;


			}
			/// <summary>The method to set the value to lockedByS</summary>
			/// <param name="lockedByS">Instance of MinifiedUser</param>
			set
			{
				 this.AddKeyValue("locked_by__s", value);

			}
		}

		public LockedForS LockedForS
		{
			/// <summary>The method to get the lockedForS</summary>
			/// <returns>Instance of LockedForS</returns>
			get
			{
				if((( this.GetKeyValue("locked_for_s")) != (null)))
				{
					return (LockedForS) this.GetKeyValue("locked_for_s");

				}
					return null;


			}
			/// <summary>The method to set the value to lockedForS</summary>
			/// <param name="lockedForS">Instance of LockedForS</param>
			set
			{
				 this.AddKeyValue("locked_for_s", value);

			}
		}

		public string LockedReasonS
		{
			/// <summary>The method to get the lockedReasonS</summary>
			/// <returns>string representing the lockedReasonS</returns>
			get
			{
				if((( this.GetKeyValue("locked_reason__s")) != (null)))
				{
					return (string) this.GetKeyValue("locked_reason__s");

				}
					return null;


			}
			/// <summary>The method to set the value to lockedReasonS</summary>
			/// <param name="lockedReasonS">string</param>
			set
			{
				 this.AddKeyValue("locked_reason__s", value);

			}
		}

		public string LockedTimeS
		{
			/// <summary>The method to get the lockedTimeS</summary>
			/// <returns>string representing the lockedTimeS</returns>
			get
			{
				if((( this.GetKeyValue("Locked_time__s")) != (null)))
				{
					return (string) this.GetKeyValue("Locked_time__s");

				}
					return null;


			}
			/// <summary>The method to set the value to lockedTimeS</summary>
			/// <param name="lockedTimeS">string</param>
			set
			{
				 this.AddKeyValue("Locked_time__s", value);

			}
		}

		public long? RecordLockingConfigurationIdS
		{
			/// <summary>The method to get the recordLockingConfigurationIdS</summary>
			/// <returns>long? representing the recordLockingConfigurationIdS</returns>
			get
			{
				if((( this.GetKeyValue("record_locking_configuration_id__s")) != (null)))
				{
					return (long?) this.GetKeyValue("record_locking_configuration_id__s");

				}
					return null;


			}
			/// <summary>The method to set the value to recordLockingConfigurationIdS</summary>
			/// <param name="recordLockingConfigurationIdS">long?</param>
			set
			{
				 this.AddKeyValue("record_locking_configuration_id__s", value);

			}
		}

		public long? RecordLockingRuleIdS
		{
			/// <summary>The method to get the recordLockingRuleIdS</summary>
			/// <returns>long? representing the recordLockingRuleIdS</returns>
			get
			{
				if((( this.GetKeyValue("record_locking_rule_id__s")) != (null)))
				{
					return (long?) this.GetKeyValue("record_locking_rule_id__s");

				}
					return null;


			}
			/// <summary>The method to set the value to recordLockingRuleIdS</summary>
			/// <param name="recordLockingRuleIdS">long?</param>
			set
			{
				 this.AddKeyValue("record_locking_rule_id__s", value);

			}
		}

		public long? Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>long? representing the id</returns>
			get
			{
				if((( this.GetKeyValue("id")) != (null)))
				{
					return (long?) this.GetKeyValue("id");

				}
					return null;


			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">long?</param>
			set
			{
				 this.AddKeyValue("id", value);

			}
		}

		public Users.MinifiedUser CreatedBy
		{
			/// <summary>The method to get the createdBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				if((( this.GetKeyValue("Created_By")) != (null)))
				{
					return (Users.MinifiedUser) this.GetKeyValue("Created_By");

				}
					return null;


			}
			/// <summary>The method to set the value to createdBy</summary>
			/// <param name="createdBy">Instance of MinifiedUser</param>
			set
			{
				 this.AddKeyValue("Created_By", value);

			}
		}

		public DateTimeOffset? CreatedTime
		{
			/// <summary>The method to get the createdTime</summary>
			/// <returns>DateTimeOffset? representing the createdTime</returns>
			get
			{
				if((( this.GetKeyValue("Created_Time")) != (null)))
				{
					return (DateTimeOffset?) this.GetKeyValue("Created_Time");

				}
					return null;


			}
			/// <summary>The method to set the value to createdTime</summary>
			/// <param name="createdTime">DateTimeOffset?</param>
			set
			{
				 this.AddKeyValue("Created_Time", value);

			}
		}

		public Users.MinifiedUser ModifiedBy
		{
			/// <summary>The method to get the modifiedBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				if((( this.GetKeyValue("Modified_By")) != (null)))
				{
					return (Users.MinifiedUser) this.GetKeyValue("Modified_By");

				}
					return null;


			}
			/// <summary>The method to set the value to modifiedBy</summary>
			/// <param name="modifiedBy">Instance of MinifiedUser</param>
			set
			{
				 this.AddKeyValue("Modified_By", value);

			}
		}

		public DateTimeOffset? ModifiedTime
		{
			/// <summary>The method to get the modifiedTime</summary>
			/// <returns>DateTimeOffset? representing the modifiedTime</returns>
			get
			{
				if((( this.GetKeyValue("Modified_Time")) != (null)))
				{
					return (DateTimeOffset?) this.GetKeyValue("Modified_Time");

				}
					return null;


			}
			/// <summary>The method to set the value to modifiedTime</summary>
			/// <param name="modifiedTime">DateTimeOffset?</param>
			set
			{
				 this.AddKeyValue("Modified_Time", value);

			}
		}

		public List<Tags.Tag> Tag
		{
			/// <summary>The method to get the tag</summary>
			/// <returns>Instance of List<Tag></returns>
			get
			{
				if((( this.GetKeyValue("Tag")) != (null)))
				{
					return (List<Tags.Tag>) this.GetKeyValue("Tag");

				}
					return null;


			}
			/// <summary>The method to set the value to tag</summary>
			/// <param name="tag">Instance of List<Tag></param>
			set
			{
				 this.AddKeyValue("Tag", value);

			}
		}

		public string Name
		{
			/// <summary>The method to get the name</summary>
			/// <returns>string representing the name</returns>
			get
			{
				if((( this.GetKeyValue("name")) != (null)))
				{
					return (string) this.GetKeyValue("name");

				}
					return null;


			}
			/// <summary>The method to set the value to name</summary>
			/// <param name="name">string</param>
			set
			{
				 this.AddKeyValue("name", value);

			}
		}


	}
}