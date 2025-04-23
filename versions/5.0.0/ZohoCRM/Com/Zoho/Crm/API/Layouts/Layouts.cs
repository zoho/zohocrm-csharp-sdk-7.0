using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Layouts
{

	public class Layouts : Model
	{
		private int? displayType;
		private string apiName;
		private bool? hasMoreProfiles;
		private DateTimeOffset? createdTime;
		private DateTimeOffset? modifiedTime;
		private bool? visible;
		private string source;
		private long? id;
		private string name;
		private string displayLabel;
		private string mode;
		private SubformProperty subformProperties;
		private string status;
		private bool? showBusinessCard;
		private string generatedType;
		private Users.MinifiedUser createdFor;
		private ConvertMapping convertMapping;
		private Users.MinifiedUser modifiedBy;
		private List<Profiles> profiles;
		private Users.MinifiedUser createdBy;
		private List<Sections> sections;
		private ActionsAllowed actionsAllowed;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? DisplayType
		{
			/// <summary>The method to get the displayType</summary>
			/// <returns>int? representing the displayType</returns>
			get
			{
				return  this.displayType;

			}
			/// <summary>The method to set the value to displayType</summary>
			/// <param name="displayType">int?</param>
			set
			{
				 this.displayType=value;

				 this.keyModified["display_type"] = 1;

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

		public bool? HasMoreProfiles
		{
			/// <summary>The method to get the hasMoreProfiles</summary>
			/// <returns>bool? representing the hasMoreProfiles</returns>
			get
			{
				return  this.hasMoreProfiles;

			}
			/// <summary>The method to set the value to hasMoreProfiles</summary>
			/// <param name="hasMoreProfiles">bool?</param>
			set
			{
				 this.hasMoreProfiles=value;

				 this.keyModified["has_more_profiles"] = 1;

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

		public bool? Visible
		{
			/// <summary>The method to get the visible</summary>
			/// <returns>bool? representing the visible</returns>
			get
			{
				return  this.visible;

			}
			/// <summary>The method to set the value to visible</summary>
			/// <param name="visible">bool?</param>
			set
			{
				 this.visible=value;

				 this.keyModified["visible"] = 1;

			}
		}

		public string Source
		{
			/// <summary>The method to get the source</summary>
			/// <returns>string representing the source</returns>
			get
			{
				return  this.source;

			}
			/// <summary>The method to set the value to source</summary>
			/// <param name="source">string</param>
			set
			{
				 this.source=value;

				 this.keyModified["source"] = 1;

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

		public string DisplayLabel
		{
			/// <summary>The method to get the displayLabel</summary>
			/// <returns>string representing the displayLabel</returns>
			get
			{
				return  this.displayLabel;

			}
			/// <summary>The method to set the value to displayLabel</summary>
			/// <param name="displayLabel">string</param>
			set
			{
				 this.displayLabel=value;

				 this.keyModified["display_label"] = 1;

			}
		}

		public string Mode
		{
			/// <summary>The method to get the mode</summary>
			/// <returns>string representing the mode</returns>
			get
			{
				return  this.mode;

			}
			/// <summary>The method to set the value to mode</summary>
			/// <param name="mode">string</param>
			set
			{
				 this.mode=value;

				 this.keyModified["mode"] = 1;

			}
		}

		public SubformProperty SubformProperties
		{
			/// <summary>The method to get the subformProperties</summary>
			/// <returns>Instance of SubformProperty</returns>
			get
			{
				return  this.subformProperties;

			}
			/// <summary>The method to set the value to subformProperties</summary>
			/// <param name="subformProperties">Instance of SubformProperty</param>
			set
			{
				 this.subformProperties=value;

				 this.keyModified["subform_properties"] = 1;

			}
		}

		public string Status
		{
			/// <summary>The method to get the status</summary>
			/// <returns>string representing the status</returns>
			get
			{
				return  this.status;

			}
			/// <summary>The method to set the value to status</summary>
			/// <param name="status">string</param>
			set
			{
				 this.status=value;

				 this.keyModified["status"] = 1;

			}
		}

		public bool? ShowBusinessCard
		{
			/// <summary>The method to get the showBusinessCard</summary>
			/// <returns>bool? representing the showBusinessCard</returns>
			get
			{
				return  this.showBusinessCard;

			}
			/// <summary>The method to set the value to showBusinessCard</summary>
			/// <param name="showBusinessCard">bool?</param>
			set
			{
				 this.showBusinessCard=value;

				 this.keyModified["show_business_card"] = 1;

			}
		}

		public string GeneratedType
		{
			/// <summary>The method to get the generatedType</summary>
			/// <returns>string representing the generatedType</returns>
			get
			{
				return  this.generatedType;

			}
			/// <summary>The method to set the value to generatedType</summary>
			/// <param name="generatedType">string</param>
			set
			{
				 this.generatedType=value;

				 this.keyModified["generated_type"] = 1;

			}
		}

		public Users.MinifiedUser CreatedFor
		{
			/// <summary>The method to get the createdFor</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.createdFor;

			}
			/// <summary>The method to set the value to createdFor</summary>
			/// <param name="createdFor">Instance of MinifiedUser</param>
			set
			{
				 this.createdFor=value;

				 this.keyModified["created_for"] = 1;

			}
		}

		public ConvertMapping ConvertMapping
		{
			/// <summary>The method to get the convertMapping</summary>
			/// <returns>Instance of ConvertMapping</returns>
			get
			{
				return  this.convertMapping;

			}
			/// <summary>The method to set the value to convertMapping</summary>
			/// <param name="convertMapping">Instance of ConvertMapping</param>
			set
			{
				 this.convertMapping=value;

				 this.keyModified["convert_mapping"] = 1;

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

		public List<Profiles> Profiles
		{
			/// <summary>The method to get the profiles</summary>
			/// <returns>Instance of List<Profiles></returns>
			get
			{
				return  this.profiles;

			}
			/// <summary>The method to set the value to profiles</summary>
			/// <param name="profiles">Instance of List<Profiles></param>
			set
			{
				 this.profiles=value;

				 this.keyModified["profiles"] = 1;

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

		public List<Sections> Sections
		{
			/// <summary>The method to get the sections</summary>
			/// <returns>Instance of List<Sections></returns>
			get
			{
				return  this.sections;

			}
			/// <summary>The method to set the value to sections</summary>
			/// <param name="sections">Instance of List<Sections></param>
			set
			{
				 this.sections=value;

				 this.keyModified["sections"] = 1;

			}
		}

		public ActionsAllowed ActionsAllowed
		{
			/// <summary>The method to get the actionsAllowed</summary>
			/// <returns>Instance of ActionsAllowed</returns>
			get
			{
				return  this.actionsAllowed;

			}
			/// <summary>The method to set the value to actionsAllowed</summary>
			/// <param name="actionsAllowed">Instance of ActionsAllowed</param>
			set
			{
				 this.actionsAllowed=value;

				 this.keyModified["actions_allowed"] = 1;

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