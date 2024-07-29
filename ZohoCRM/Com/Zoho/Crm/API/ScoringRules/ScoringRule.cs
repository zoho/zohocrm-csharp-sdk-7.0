using Com.Zoho.Crm.API.Modules;
using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ScoringRules
{

	public class ScoringRule : Model
	{
		private string name;
		private string description;
		private string id;
		private Layout layout;
		private string createdTime;
		private string modifiedTime;
		private Modules.Modules module;
		private Users.MinifiedUser modifiedBy;
		private bool? active;
		private Users.MinifiedUser createdBy;
		private List<FieldRule> fieldRules;
		private List<SignalRule> signalRules;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public string Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>string representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">string</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

			}
		}

		public Layout Layout
		{
			/// <summary>The method to get the layout</summary>
			/// <returns>Instance of Layout</returns>
			get
			{
				return  this.layout;

			}
			/// <summary>The method to set the value to layout</summary>
			/// <param name="layout">Instance of Layout</param>
			set
			{
				 this.layout=value;

				 this.keyModified["layout"] = 1;

			}
		}

		public string CreatedTime
		{
			/// <summary>The method to get the createdTime</summary>
			/// <returns>string representing the createdTime</returns>
			get
			{
				return  this.createdTime;

			}
			/// <summary>The method to set the value to createdTime</summary>
			/// <param name="createdTime">string</param>
			set
			{
				 this.createdTime=value;

				 this.keyModified["created_time"] = 1;

			}
		}

		public string ModifiedTime
		{
			/// <summary>The method to get the modifiedTime</summary>
			/// <returns>string representing the modifiedTime</returns>
			get
			{
				return  this.modifiedTime;

			}
			/// <summary>The method to set the value to modifiedTime</summary>
			/// <param name="modifiedTime">string</param>
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

		public List<FieldRule> FieldRules
		{
			/// <summary>The method to get the fieldRules</summary>
			/// <returns>Instance of List<FieldRule></returns>
			get
			{
				return  this.fieldRules;

			}
			/// <summary>The method to set the value to fieldRules</summary>
			/// <param name="fieldRules">Instance of List<FieldRule></param>
			set
			{
				 this.fieldRules=value;

				 this.keyModified["field_rules"] = 1;

			}
		}

		public List<SignalRule> SignalRules
		{
			/// <summary>The method to get the signalRules</summary>
			/// <returns>Instance of List<SignalRule></returns>
			get
			{
				return  this.signalRules;

			}
			/// <summary>The method to set the value to signalRules</summary>
			/// <param name="signalRules">Instance of List<SignalRule></param>
			set
			{
				 this.signalRules=value;

				 this.keyModified["signal_rules"] = 1;

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