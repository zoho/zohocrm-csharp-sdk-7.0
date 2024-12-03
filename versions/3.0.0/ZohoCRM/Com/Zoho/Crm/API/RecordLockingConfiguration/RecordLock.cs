using Com.Zoho.Crm.API.Fields;
using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.RecordLockingConfiguration
{

	public class RecordLock : Model
	{
		private DateTimeOffset? createdTime;
		private string lockedFor;
		private List<Fields.MinifiedField> excludedFields;
		private Users.MinifiedUser createdBy;
		private string featureType;
		private List<LockingRules> lockingRules;
		private List<string> restrictedActions;
		private bool? lockForPortalUsers;
		private DateTimeOffset? modifiedTime;
		private List<string> restrictedCommunications;
		private bool? systemDefined;
		private Users.MinifiedUser modifiedBy;
		private long? id;
		private Choice<string> lockType;
		private List<RestrictedCustomButton> restrictedCustomButtons;
		private List<LockExcludedProfile> lockExcludedProfiles;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public string LockedFor
		{
			/// <summary>The method to get the lockedFor</summary>
			/// <returns>string representing the lockedFor</returns>
			get
			{
				return  this.lockedFor;

			}
			/// <summary>The method to set the value to lockedFor</summary>
			/// <param name="lockedFor">string</param>
			set
			{
				 this.lockedFor=value;

				 this.keyModified["locked_for"] = 1;

			}
		}

		public List<Fields.MinifiedField> ExcludedFields
		{
			/// <summary>The method to get the excludedFields</summary>
			/// <returns>Instance of List<MinifiedField></returns>
			get
			{
				return  this.excludedFields;

			}
			/// <summary>The method to set the value to excludedFields</summary>
			/// <param name="excludedFields">Instance of List<MinifiedField></param>
			set
			{
				 this.excludedFields=value;

				 this.keyModified["excluded_fields"] = 1;

			}
		}

		public Users.MinifiedUser CreatedBy
		{
			/// <summary>The method to get the createdBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.createdBy;

			}
			/// <summary>The method to set the value to createdBy</summary>
			/// <param name="createdBy">Instance of MinifiedUser</param>
			set
			{
				 this.createdBy=value;

				 this.keyModified["created_by"] = 1;

			}
		}

		public string FeatureType
		{
			/// <summary>The method to get the featureType</summary>
			/// <returns>string representing the featureType</returns>
			get
			{
				return  this.featureType;

			}
			/// <summary>The method to set the value to featureType</summary>
			/// <param name="featureType">string</param>
			set
			{
				 this.featureType=value;

				 this.keyModified["feature_type"] = 1;

			}
		}

		public List<LockingRules> LockingRules
		{
			/// <summary>The method to get the lockingRules</summary>
			/// <returns>Instance of List<LockingRules></returns>
			get
			{
				return  this.lockingRules;

			}
			/// <summary>The method to set the value to lockingRules</summary>
			/// <param name="lockingRules">Instance of List<LockingRules></param>
			set
			{
				 this.lockingRules=value;

				 this.keyModified["locking_rules"] = 1;

			}
		}

		public List<string> RestrictedActions
		{
			/// <summary>The method to get the restrictedActions</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.restrictedActions;

			}
			/// <summary>The method to set the value to restrictedActions</summary>
			/// <param name="restrictedActions">Instance of List<string></param>
			set
			{
				 this.restrictedActions=value;

				 this.keyModified["restricted_actions"] = 1;

			}
		}

		public bool? LockForPortalUsers
		{
			/// <summary>The method to get the lockForPortalUsers</summary>
			/// <returns>bool? representing the lockForPortalUsers</returns>
			get
			{
				return  this.lockForPortalUsers;

			}
			/// <summary>The method to set the value to lockForPortalUsers</summary>
			/// <param name="lockForPortalUsers">bool?</param>
			set
			{
				 this.lockForPortalUsers=value;

				 this.keyModified["lock_for_portal_users"] = 1;

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

		public List<string> RestrictedCommunications
		{
			/// <summary>The method to get the restrictedCommunications</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.restrictedCommunications;

			}
			/// <summary>The method to set the value to restrictedCommunications</summary>
			/// <param name="restrictedCommunications">Instance of List<string></param>
			set
			{
				 this.restrictedCommunications=value;

				 this.keyModified["restricted_communications"] = 1;

			}
		}

		public bool? SystemDefined
		{
			/// <summary>The method to get the systemDefined</summary>
			/// <returns>bool? representing the systemDefined</returns>
			get
			{
				return  this.systemDefined;

			}
			/// <summary>The method to set the value to systemDefined</summary>
			/// <param name="systemDefined">bool?</param>
			set
			{
				 this.systemDefined=value;

				 this.keyModified["system_defined"] = 1;

			}
		}

		public Users.MinifiedUser ModifiedBy
		{
			/// <summary>The method to get the modifiedBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.modifiedBy;

			}
			/// <summary>The method to set the value to modifiedBy</summary>
			/// <param name="modifiedBy">Instance of MinifiedUser</param>
			set
			{
				 this.modifiedBy=value;

				 this.keyModified["modified_by"] = 1;

			}
		}

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

		public Choice<string> LockType
		{
			/// <summary>The method to get the lockType</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.lockType;

			}
			/// <summary>The method to set the value to lockType</summary>
			/// <param name="lockType">Instance of Choice<string></param>
			set
			{
				 this.lockType=value;

				 this.keyModified["lock_type"] = 1;

			}
		}

		public List<RestrictedCustomButton> RestrictedCustomButtons
		{
			/// <summary>The method to get the restrictedCustomButtons</summary>
			/// <returns>Instance of List<RestrictedCustomButton></returns>
			get
			{
				return  this.restrictedCustomButtons;

			}
			/// <summary>The method to set the value to restrictedCustomButtons</summary>
			/// <param name="restrictedCustomButtons">Instance of List<RestrictedCustomButton></param>
			set
			{
				 this.restrictedCustomButtons=value;

				 this.keyModified["restricted_custom_buttons"] = 1;

			}
		}

		public List<LockExcludedProfile> LockExcludedProfiles
		{
			/// <summary>The method to get the lockExcludedProfiles</summary>
			/// <returns>Instance of List<LockExcludedProfile></returns>
			get
			{
				return  this.lockExcludedProfiles;

			}
			/// <summary>The method to set the value to lockExcludedProfiles</summary>
			/// <param name="lockExcludedProfiles">Instance of List<LockExcludedProfile></param>
			set
			{
				 this.lockExcludedProfiles=value;

				 this.keyModified["lock_excluded_profiles"] = 1;

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