using Com.Zoho.Crm.API.Modules;
using Com.Zoho.Crm.API.Profiles;
using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Wizards
{

	public class Wizard : Model
	{
		private DateTimeOffset? createdTime;
		private DateTimeOffset? modifiedTime;
		private Modules.Modules module;
		private string name;
		private Users.MinifiedUser modifiedBy;
		private List<Profiles.Profile> profiles;
		private bool? active;
		private List<Container> containers;
		private long? id;
		private Users.MinifiedUser createdBy;
		private List<PortalUserType> portalUserTypes;
		private List<ExemptedPortalUserType> exemptedPortalUserTypes;
		private Wizard parentWizard;
		private bool? draft;
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

		public Modules.Modules Module
		{
			/// <summary>The method to get the module</summary>
			/// <returns>Instance of Modules</returns>
			get
			{
				return  this.module;

			}
			/// <summary>The method to set the value to module</summary>
			/// <param name="module">Instance of Modules</param>
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

		public List<Profiles.Profile> Profiles
		{
			/// <summary>The method to get the profiles</summary>
			/// <returns>Instance of List<Profile></returns>
			get
			{
				return  this.profiles;

			}
			/// <summary>The method to set the value to profiles</summary>
			/// <param name="profiles">Instance of List<Profile></param>
			set
			{
				 this.profiles=value;

				 this.keyModified["profiles"] = 1;

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

		public List<Container> Containers
		{
			/// <summary>The method to get the containers</summary>
			/// <returns>Instance of List<Container></returns>
			get
			{
				return  this.containers;

			}
			/// <summary>The method to set the value to containers</summary>
			/// <param name="containers">Instance of List<Container></param>
			set
			{
				 this.containers=value;

				 this.keyModified["containers"] = 1;

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

		public List<PortalUserType> PortalUserTypes
		{
			/// <summary>The method to get the portalUserTypes</summary>
			/// <returns>Instance of List<PortalUserType></returns>
			get
			{
				return  this.portalUserTypes;

			}
			/// <summary>The method to set the value to portalUserTypes</summary>
			/// <param name="portalUserTypes">Instance of List<PortalUserType></param>
			set
			{
				 this.portalUserTypes=value;

				 this.keyModified["portal_user_types"] = 1;

			}
		}

		public List<ExemptedPortalUserType> ExemptedPortalUserTypes
		{
			/// <summary>The method to get the exemptedPortalUserTypes</summary>
			/// <returns>Instance of List<ExemptedPortalUserType></returns>
			get
			{
				return  this.exemptedPortalUserTypes;

			}
			/// <summary>The method to set the value to exemptedPortalUserTypes</summary>
			/// <param name="exemptedPortalUserTypes">Instance of List<ExemptedPortalUserType></param>
			set
			{
				 this.exemptedPortalUserTypes=value;

				 this.keyModified["exempted_portal_user_types"] = 1;

			}
		}

		public Wizard ParentWizard
		{
			/// <summary>The method to get the parentWizard</summary>
			/// <returns>Instance of Wizard</returns>
			get
			{
				return  this.parentWizard;

			}
			/// <summary>The method to set the value to parentWizard</summary>
			/// <param name="parentWizard">Instance of Wizard</param>
			set
			{
				 this.parentWizard=value;

				 this.keyModified["parent_wizard"] = 1;

			}
		}

		public bool? Draft
		{
			/// <summary>The method to get the draft</summary>
			/// <returns>bool? representing the draft</returns>
			get
			{
				return  this.draft;

			}
			/// <summary>The method to set the value to draft</summary>
			/// <param name="draft">bool?</param>
			set
			{
				 this.draft=value;

				 this.keyModified["draft"] = 1;

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