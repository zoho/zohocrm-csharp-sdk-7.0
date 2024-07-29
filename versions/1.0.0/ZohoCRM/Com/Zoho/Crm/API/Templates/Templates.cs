using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Templates
{

	public class Templates : Model
	{
		private Folder folder;
		private Folder modifiedBy;
		private string module;
		private DateTimeOffset? modifiedTime;
		private string subject;
		private string name;
		private bool? consentLinked;
		private bool? favourite;
		private bool? attachmentPresent;
		private long? id;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public Folder ModifiedBy
		{
			/// <summary>The method to get the modifiedBy</summary>
			/// <returns>Instance of Folder</returns>
			get
			{
				return  this.modifiedBy;

			}
			/// <summary>The method to set the value to modifiedBy</summary>
			/// <param name="modifiedBy">Instance of Folder</param>
			set
			{
				 this.modifiedBy=value;

				 this.keyModified["modified_by"] = 1;

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

		public string Subject
		{
			/// <summary>The method to get the subject</summary>
			/// <returns>string representing the subject</returns>
			get
			{
				return  this.subject;

			}
			/// <summary>The method to set the value to subject</summary>
			/// <param name="subject">string</param>
			set
			{
				 this.subject=value;

				 this.keyModified["subject"] = 1;

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

		public bool? ConsentLinked
		{
			/// <summary>The method to get the consentLinked</summary>
			/// <returns>bool? representing the consentLinked</returns>
			get
			{
				return  this.consentLinked;

			}
			/// <summary>The method to set the value to consentLinked</summary>
			/// <param name="consentLinked">bool?</param>
			set
			{
				 this.consentLinked=value;

				 this.keyModified["consent_linked"] = 1;

			}
		}

		public bool? Favourite
		{
			/// <summary>The method to get the favourite</summary>
			/// <returns>bool? representing the favourite</returns>
			get
			{
				return  this.favourite;

			}
			/// <summary>The method to set the value to favourite</summary>
			/// <param name="favourite">bool?</param>
			set
			{
				 this.favourite=value;

				 this.keyModified["favourite"] = 1;

			}
		}

		public bool? AttachmentPresent
		{
			/// <summary>The method to get the attachmentPresent</summary>
			/// <returns>bool? representing the attachmentPresent</returns>
			get
			{
				return  this.attachmentPresent;

			}
			/// <summary>The method to set the value to attachmentPresent</summary>
			/// <param name="attachmentPresent">bool?</param>
			set
			{
				 this.attachmentPresent=value;

				 this.keyModified["attachment_present"] = 1;

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