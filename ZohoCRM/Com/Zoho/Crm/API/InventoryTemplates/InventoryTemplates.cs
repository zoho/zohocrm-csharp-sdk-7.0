using Com.Zoho.Crm.API.SendMail;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.InventoryTemplates
{

	public class InventoryTemplates : Template, Model
	{
		private DateTimeOffset? createdTime;
		private DateTimeOffset? modifiedTime;
		private DateTimeOffset? lastUsageTime;
		private Folder folder;
		private ModuleMap module;
		private User createdBy;
		private User modifiedBy;
		private string name;
		private long? id;
		private string editorMode;
		private string category;
		private bool? favorite;
		private string content;
		private bool? active;
		private string mailContent;
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

		public DateTimeOffset? LastUsageTime
		{
			/// <summary>The method to get the lastUsageTime</summary>
			/// <returns>DateTimeOffset? representing the lastUsageTime</returns>
			get
			{
				return  this.lastUsageTime;

			}
			/// <summary>The method to set the value to lastUsageTime</summary>
			/// <param name="lastUsageTime">DateTimeOffset?</param>
			set
			{
				 this.lastUsageTime=value;

				 this.keyModified["last_usage_time"] = 1;

			}
		}

		public Folder Folder
		{
			/// <summary>The method to get the folder</summary>
			/// <returns>Instance of Folder</returns>
			get
			{
				return  this.folder;

			}
			/// <summary>The method to set the value to folder</summary>
			/// <param name="folder">Instance of Folder</param>
			set
			{
				 this.folder=value;

				 this.keyModified["folder"] = 1;

			}
		}

		public ModuleMap Module
		{
			/// <summary>The method to get the module</summary>
			/// <returns>Instance of ModuleMap</returns>
			get
			{
				return  this.module;

			}
			/// <summary>The method to set the value to module</summary>
			/// <param name="module">Instance of ModuleMap</param>
			set
			{
				 this.module=value;

				 this.keyModified["module"] = 1;

			}
		}

		public User CreatedBy
		{
			/// <summary>The method to get the createdBy</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.createdBy;

			}
			/// <summary>The method to set the value to createdBy</summary>
			/// <param name="createdBy">Instance of User</param>
			set
			{
				 this.createdBy=value;

				 this.keyModified["created_by"] = 1;

			}
		}

		public User ModifiedBy
		{
			/// <summary>The method to get the modifiedBy</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.modifiedBy;

			}
			/// <summary>The method to set the value to modifiedBy</summary>
			/// <param name="modifiedBy">Instance of User</param>
			set
			{
				 this.modifiedBy=value;

				 this.keyModified["modified_by"] = 1;

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

		public string EditorMode
		{
			/// <summary>The method to get the editorMode</summary>
			/// <returns>string representing the editorMode</returns>
			get
			{
				return  this.editorMode;

			}
			/// <summary>The method to set the value to editorMode</summary>
			/// <param name="editorMode">string</param>
			set
			{
				 this.editorMode=value;

				 this.keyModified["editor_mode"] = 1;

			}
		}

		public string Category
		{
			/// <summary>The method to get the category</summary>
			/// <returns>string representing the category</returns>
			get
			{
				return  this.category;

			}
			/// <summary>The method to set the value to category</summary>
			/// <param name="category">string</param>
			set
			{
				 this.category=value;

				 this.keyModified["category"] = 1;

			}
		}

		public bool? Favorite
		{
			/// <summary>The method to get the favorite</summary>
			/// <returns>bool? representing the favorite</returns>
			get
			{
				return  this.favorite;

			}
			/// <summary>The method to set the value to favorite</summary>
			/// <param name="favorite">bool?</param>
			set
			{
				 this.favorite=value;

				 this.keyModified["favorite"] = 1;

			}
		}

		public string Content
		{
			/// <summary>The method to get the content</summary>
			/// <returns>string representing the content</returns>
			get
			{
				return  this.content;

			}
			/// <summary>The method to set the value to content</summary>
			/// <param name="content">string</param>
			set
			{
				 this.content=value;

				 this.keyModified["content"] = 1;

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

		public string MailContent
		{
			/// <summary>The method to get the mailContent</summary>
			/// <returns>string representing the mailContent</returns>
			get
			{
				return  this.mailContent;

			}
			/// <summary>The method to set the value to mailContent</summary>
			/// <param name="mailContent">string</param>
			set
			{
				 this.mailContent=value;

				 this.keyModified["mail_content"] = 1;

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