using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Territories
{

	public class Territories : Model
	{
		private DateTimeOffset? createdTime;
		private DateTimeOffset? modifiedTime;
		private Manager manager;
		private ReportingTo reportingTo;
		private Choice<string> permissionType;
		private Users.MinifiedUser modifiedBy;
		private string description;
		private long? id;
		private Users.MinifiedUser createdBy;
		private Criteria accountRuleCriteria;
		private Criteria dealRuleCriteria;
		private Criteria leadRuleCriteria;
		private string name;
		private string apiName;
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

		public Manager Manager
		{
			/// <summary>The method to get the manager</summary>
			/// <returns>Instance of Manager</returns>
			get
			{
				return  this.manager;

			}
			/// <summary>The method to set the value to manager</summary>
			/// <param name="manager">Instance of Manager</param>
			set
			{
				 this.manager=value;

				 this.keyModified["manager"] = 1;

			}
		}

		public ReportingTo ReportingTo
		{
			/// <summary>The method to get the reportingTo</summary>
			/// <returns>Instance of ReportingTo</returns>
			get
			{
				return  this.reportingTo;

			}
			/// <summary>The method to set the value to reportingTo</summary>
			/// <param name="reportingTo">Instance of ReportingTo</param>
			set
			{
				 this.reportingTo=value;

				 this.keyModified["reporting_to"] = 1;

			}
		}

		public Choice<string> PermissionType
		{
			/// <summary>The method to get the permissionType</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.permissionType;

			}
			/// <summary>The method to set the value to permissionType</summary>
			/// <param name="permissionType">Instance of Choice<string></param>
			set
			{
				 this.permissionType=value;

				 this.keyModified["permission_type"] = 1;

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

		public string Description
		{
			/// <summary>The method to get the description</summary>
			/// <returns>string representing the description</returns>
			get
			{
				return  this.description;

			}
			/// <summary>The method to set the value to description</summary>
			/// <param name="description">string</param>
			set
			{
				 this.description=value;

				 this.keyModified["description"] = 1;

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

		public Criteria AccountRuleCriteria
		{
			/// <summary>The method to get the accountRuleCriteria</summary>
			/// <returns>Instance of Criteria</returns>
			get
			{
				return  this.accountRuleCriteria;

			}
			/// <summary>The method to set the value to accountRuleCriteria</summary>
			/// <param name="accountRuleCriteria">Instance of Criteria</param>
			set
			{
				 this.accountRuleCriteria=value;

				 this.keyModified["account_rule_criteria"] = 1;

			}
		}

		public Criteria DealRuleCriteria
		{
			/// <summary>The method to get the dealRuleCriteria</summary>
			/// <returns>Instance of Criteria</returns>
			get
			{
				return  this.dealRuleCriteria;

			}
			/// <summary>The method to set the value to dealRuleCriteria</summary>
			/// <param name="dealRuleCriteria">Instance of Criteria</param>
			set
			{
				 this.dealRuleCriteria=value;

				 this.keyModified["deal_rule_criteria"] = 1;

			}
		}

		public Criteria LeadRuleCriteria
		{
			/// <summary>The method to get the leadRuleCriteria</summary>
			/// <returns>Instance of Criteria</returns>
			get
			{
				return  this.leadRuleCriteria;

			}
			/// <summary>The method to set the value to leadRuleCriteria</summary>
			/// <param name="leadRuleCriteria">Instance of Criteria</param>
			set
			{
				 this.leadRuleCriteria=value;

				 this.keyModified["lead_rule_criteria"] = 1;

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

		public string APIName
		{
			/// <summary>The method to get the aPIName</summary>
			/// <returns>string representing the apiName</returns>
			get
			{
				return  this.apiName;

			}
			/// <summary>The method to set the value to aPIName</summary>
			/// <param name="apiName">string</param>
			set
			{
				 this.apiName=value;

				 this.keyModified["api_name"] = 1;

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