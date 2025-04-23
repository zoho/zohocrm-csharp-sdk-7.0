using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Profiles
{

	public class Profile : Model
	{
		private DefaultView defaultview;
		private string name;
		private string description;
		private long? id;
		private bool? default1;
		private bool? delete;
		private string permissionType;
		private bool? custom;
		private string displayLabel;
		private Choice<string> type;
		private List<PermissionDetail> permissionsDetails;
		private List<Section> sections;
		private DateTimeOffset? createdTime;
		private DateTimeOffset? modifiedTime;
		private Users.MinifiedUser modifiedBy;
		private bool? category;
		private Users.MinifiedUser createdBy;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public DefaultView Defaultview
		{
			/// <summary>The method to get the defaultview</summary>
			/// <returns>Instance of DefaultView</returns>
			get
			{
				return  this.defaultview;

			}
			/// <summary>The method to set the value to defaultview</summary>
			/// <param name="defaultview">Instance of DefaultView</param>
			set
			{
				 this.defaultview=value;

				 this.keyModified["_default_view"] = 1;

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

		public bool? Delete
		{
			/// <summary>The method to get the delete</summary>
			/// <returns>bool? representing the delete</returns>
			get
			{
				return  this.delete;

			}
			/// <summary>The method to set the value to delete</summary>
			/// <param name="delete">bool?</param>
			set
			{
				 this.delete=value;

				 this.keyModified["_delete"] = 1;

			}
		}

		public string PermissionType
		{
			/// <summary>The method to get the permissionType</summary>
			/// <returns>string representing the permissionType</returns>
			get
			{
				return  this.permissionType;

			}
			/// <summary>The method to set the value to permissionType</summary>
			/// <param name="permissionType">string</param>
			set
			{
				 this.permissionType=value;

				 this.keyModified["permission_type"] = 1;

			}
		}

		public bool? Custom
		{
			/// <summary>The method to get the custom</summary>
			/// <returns>bool? representing the custom</returns>
			get
			{
				return  this.custom;

			}
			/// <summary>The method to set the value to custom</summary>
			/// <param name="custom">bool?</param>
			set
			{
				 this.custom=value;

				 this.keyModified["custom"] = 1;

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

		public Choice<string> Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">Instance of Choice<string></param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

		public List<PermissionDetail> PermissionsDetails
		{
			/// <summary>The method to get the permissionsDetails</summary>
			/// <returns>Instance of List<PermissionDetail></returns>
			get
			{
				return  this.permissionsDetails;

			}
			/// <summary>The method to set the value to permissionsDetails</summary>
			/// <param name="permissionsDetails">Instance of List<PermissionDetail></param>
			set
			{
				 this.permissionsDetails=value;

				 this.keyModified["permissions_details"] = 1;

			}
		}

		public List<Section> Sections
		{
			/// <summary>The method to get the sections</summary>
			/// <returns>Instance of List<Section></returns>
			get
			{
				return  this.sections;

			}
			/// <summary>The method to set the value to sections</summary>
			/// <param name="sections">Instance of List<Section></param>
			set
			{
				 this.sections=value;

				 this.keyModified["sections"] = 1;

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

		public bool? Category
		{
			/// <summary>The method to get the category</summary>
			/// <returns>bool? representing the category</returns>
			get
			{
				return  this.category;

			}
			/// <summary>The method to set the value to category</summary>
			/// <param name="category">bool?</param>
			set
			{
				 this.category=value;

				 this.keyModified["category"] = 1;

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