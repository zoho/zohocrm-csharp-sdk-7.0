using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PortalUserType
{

	public class UserType : Model
	{
		private PersonalityModule personalityModule;
		private DateTimeOffset? createdTime;
		private DateTimeOffset? modifiedTime;
		private Owner modifiedBy;
		private Owner createdBy;
		private string name;
		private bool? active;
		private bool? default1;
		private int? noOfUsers;
		private long? id;
		private List<Modules> modules;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public PersonalityModule PersonalityModule
		{
			/// <summary>The method to get the personalityModule</summary>
			/// <returns>Instance of PersonalityModule</returns>
			get
			{
				return  this.personalityModule;

			}
			/// <summary>The method to set the value to personalityModule</summary>
			/// <param name="personalityModule">Instance of PersonalityModule</param>
			set
			{
				 this.personalityModule=value;

				 this.keyModified["personality_module"] = 1;

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

		public Owner ModifiedBy
		{
			/// <summary>The method to get the modifiedBy</summary>
			/// <returns>Instance of Owner</returns>
			get
			{
				return  this.modifiedBy;

			}
			/// <summary>The method to set the value to modifiedBy</summary>
			/// <param name="modifiedBy">Instance of Owner</param>
			set
			{
				 this.modifiedBy=value;

				 this.keyModified["modified_by"] = 1;

			}
		}

		public Owner CreatedBy
		{
			/// <summary>The method to get the createdBy</summary>
			/// <returns>Instance of Owner</returns>
			get
			{
				return  this.createdBy;

			}
			/// <summary>The method to set the value to createdBy</summary>
			/// <param name="createdBy">Instance of Owner</param>
			set
			{
				 this.createdBy=value;

				 this.keyModified["created_by"] = 1;

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

		public bool? Default
		{
			/// <summary>The method to get the default</summary>
			/// <returns>bool? representing the default1</returns>
			get
			{
				return  this.default1;

			}
			/// <summary>The method to set the value to default</summary>
			/// <param name="default1">bool?</param>
			set
			{
				 this.default1=value;

				 this.keyModified["default"] = 1;

			}
		}

		public int? NoOfUsers
		{
			/// <summary>The method to get the noOfUsers</summary>
			/// <returns>int? representing the noOfUsers</returns>
			get
			{
				return  this.noOfUsers;

			}
			/// <summary>The method to set the value to noOfUsers</summary>
			/// <param name="noOfUsers">int?</param>
			set
			{
				 this.noOfUsers=value;

				 this.keyModified["no_of_users"] = 1;

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

		public List<Modules> Modules
		{
			/// <summary>The method to get the modules</summary>
			/// <returns>Instance of List<Modules></returns>
			get
			{
				return  this.modules;

			}
			/// <summary>The method to set the value to modules</summary>
			/// <param name="modules">Instance of List<Modules></param>
			set
			{
				 this.modules=value;

				 this.keyModified["modules"] = 1;

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