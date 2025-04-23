using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Attachments
{

	public class Attachment : Model
	{
		private Users.MinifiedUser owner;
		private Users.MinifiedUser modifiedBy;
		private Users.MinifiedUser createdBy;
		private ParentId parentId;
		private string sharingPermission;
		private int? attachmentType;
		private long? id;
		private DateTimeOffset? modifiedTime;
		private DateTimeOffset? createdTime;
		private string fileName;
		private string size;
		private bool? editable;
		private string fileId;
		private string type;
		private string seModule;
		private string state;
		private string linkUrl;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Users.MinifiedUser Owner
		{
			/// <summary>The method to get the owner</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.owner;

			}
			/// <summary>The method to set the value to owner</summary>
			/// <param name="owner">Instance of MinifiedUser</param>
			set
			{
				 this.owner=value;

				 this.keyModified["Owner"] = 1;

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

				 this.keyModified["Modified_By"] = 1;

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

				 this.keyModified["Created_By"] = 1;

			}
		}

		public ParentId ParentId
		{
			/// <summary>The method to get the parentId</summary>
			/// <returns>Instance of ParentId</returns>
			get
			{
				return  this.parentId;

			}
			/// <summary>The method to set the value to parentId</summary>
			/// <param name="parentId">Instance of ParentId</param>
			set
			{
				 this.parentId=value;

				 this.keyModified["Parent_Id"] = 1;

			}
		}

		public string SharingPermission
		{
			/// <summary>The method to get the sharingPermission</summary>
			/// <returns>string representing the sharingPermission</returns>
			get
			{
				return  this.sharingPermission;

			}
			/// <summary>The method to set the value to sharingPermission</summary>
			/// <param name="sharingPermission">string</param>
			set
			{
				 this.sharingPermission=value;

				 this.keyModified["$sharing_permission"] = 1;

			}
		}

		public int? AttachmentType
		{
			/// <summary>The method to get the attachmentType</summary>
			/// <returns>int? representing the attachmentType</returns>
			get
			{
				return  this.attachmentType;

			}
			/// <summary>The method to set the value to attachmentType</summary>
			/// <param name="attachmentType">int?</param>
			set
			{
				 this.attachmentType=value;

				 this.keyModified["$attachment_type"] = 1;

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

				 this.keyModified["Modified_Time"] = 1;

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

				 this.keyModified["Created_Time"] = 1;

			}
		}

		public string FileName
		{
			/// <summary>The method to get the fileName</summary>
			/// <returns>string representing the fileName</returns>
			get
			{
				return  this.fileName;

			}
			/// <summary>The method to set the value to fileName</summary>
			/// <param name="fileName">string</param>
			set
			{
				 this.fileName=value;

				 this.keyModified["File_Name"] = 1;

			}
		}

		public string Size
		{
			/// <summary>The method to get the size</summary>
			/// <returns>string representing the size</returns>
			get
			{
				return  this.size;

			}
			/// <summary>The method to set the value to size</summary>
			/// <param name="size">string</param>
			set
			{
				 this.size=value;

				 this.keyModified["Size"] = 1;

			}
		}

		public bool? Editable
		{
			/// <summary>The method to get the editable</summary>
			/// <returns>bool? representing the editable</returns>
			get
			{
				return  this.editable;

			}
			/// <summary>The method to set the value to editable</summary>
			/// <param name="editable">bool?</param>
			set
			{
				 this.editable=value;

				 this.keyModified["$editable"] = 1;

			}
		}

		public string FileId
		{
			/// <summary>The method to get the fileId</summary>
			/// <returns>string representing the fileId</returns>
			get
			{
				return  this.fileId;

			}
			/// <summary>The method to set the value to fileId</summary>
			/// <param name="fileId">string</param>
			set
			{
				 this.fileId=value;

				 this.keyModified["$file_id"] = 1;

			}
		}

		public string Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>string representing the type</returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">string</param>
			set
			{
				 this.type=value;

				 this.keyModified["$type"] = 1;

			}
		}

		public string SeModule
		{
			/// <summary>The method to get the seModule</summary>
			/// <returns>string representing the seModule</returns>
			get
			{
				return  this.seModule;

			}
			/// <summary>The method to set the value to seModule</summary>
			/// <param name="seModule">string</param>
			set
			{
				 this.seModule=value;

				 this.keyModified["$se_module"] = 1;

			}
		}

		public string State
		{
			/// <summary>The method to get the state</summary>
			/// <returns>string representing the state</returns>
			get
			{
				return  this.state;

			}
			/// <summary>The method to set the value to state</summary>
			/// <param name="state">string</param>
			set
			{
				 this.state=value;

				 this.keyModified["$state"] = 1;

			}
		}

		public string LinkUrl
		{
			/// <summary>The method to get the linkUrl</summary>
			/// <returns>string representing the linkUrl</returns>
			get
			{
				return  this.linkUrl;

			}
			/// <summary>The method to set the value to linkUrl</summary>
			/// <param name="linkUrl">string</param>
			set
			{
				 this.linkUrl=value;

				 this.keyModified["$link_url"] = 1;

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