using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Profiles
{

	public class PermissionDetail : Model
	{
		private string id;
		private bool? enabled;
		private string name;
		private string displayLabel;
		private bool? customizable;
		private List<long?> parentPermissions;
		private string module;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public bool? Enabled
		{
			/// <summary>The method to get the enabled</summary>
			/// <returns>bool? representing the enabled</returns>
			get
			{
				return  this.enabled;

			}
			/// <summary>The method to set the value to enabled</summary>
			/// <param name="enabled">bool?</param>
			set
			{
				 this.enabled=value;

				 this.keyModified["enabled"] = 1;

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

		public bool? Customizable
		{
			/// <summary>The method to get the customizable</summary>
			/// <returns>bool? representing the customizable</returns>
			get
			{
				return  this.customizable;

			}
			/// <summary>The method to set the value to customizable</summary>
			/// <param name="customizable">bool?</param>
			set
			{
				 this.customizable=value;

				 this.keyModified["customizable"] = 1;

			}
		}

		public List<long?> ParentPermissions
		{
			/// <summary>The method to get the parentPermissions</summary>
			/// <returns>Instance of List<Long></returns>
			get
			{
				return  this.parentPermissions;

			}
			/// <summary>The method to set the value to parentPermissions</summary>
			/// <param name="parentPermissions">Instance of List<long?></param>
			set
			{
				 this.parentPermissions=value;

				 this.keyModified["parent_permissions"] = 1;

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