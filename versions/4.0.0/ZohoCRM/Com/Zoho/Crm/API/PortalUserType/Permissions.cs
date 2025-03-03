using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PortalUserType
{

	public class Permissions : Model
	{
		private bool? view;
		private bool? edit;
		private bool? editSharedRecords;
		private bool? create;
		private bool? delete;
		private bool? deleteAttachment;
		private bool? createAttachment;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? View
		{
			/// <summary>The method to get the view</summary>
			/// <returns>bool? representing the view</returns>
			get
			{
				return  this.view;

			}
			/// <summary>The method to set the value to view</summary>
			/// <param name="view">bool?</param>
			set
			{
				 this.view=value;

				 this.keyModified["view"] = 1;

			}
		}

		public bool? Edit
		{
			/// <summary>The method to get the edit</summary>
			/// <returns>bool? representing the edit</returns>
			get
			{
				return  this.edit;

			}
			/// <summary>The method to set the value to edit</summary>
			/// <param name="edit">bool?</param>
			set
			{
				 this.edit=value;

				 this.keyModified["edit"] = 1;

			}
		}

		public bool? EditSharedRecords
		{
			/// <summary>The method to get the editSharedRecords</summary>
			/// <returns>bool? representing the editSharedRecords</returns>
			get
			{
				return  this.editSharedRecords;

			}
			/// <summary>The method to set the value to editSharedRecords</summary>
			/// <param name="editSharedRecords">bool?</param>
			set
			{
				 this.editSharedRecords=value;

				 this.keyModified["edit_shared_records"] = 1;

			}
		}

		public bool? Create
		{
			/// <summary>The method to get the create</summary>
			/// <returns>bool? representing the create</returns>
			get
			{
				return  this.create;

			}
			/// <summary>The method to set the value to create</summary>
			/// <param name="create">bool?</param>
			set
			{
				 this.create=value;

				 this.keyModified[Constants.REQUEST_CATEGORY_CREATE] = 1;

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

				 this.keyModified[Constants.REQUEST_METHOD_DELETE] = 1;

			}
		}

		public bool? DeleteAttachment
		{
			/// <summary>The method to get the deleteAttachment</summary>
			/// <returns>bool? representing the deleteAttachment</returns>
			get
			{
				return  this.deleteAttachment;

			}
			/// <summary>The method to set the value to deleteAttachment</summary>
			/// <param name="deleteAttachment">bool?</param>
			set
			{
				 this.deleteAttachment=value;

				 this.keyModified["delete_attachment"] = 1;

			}
		}

		public bool? CreateAttachment
		{
			/// <summary>The method to get the createAttachment</summary>
			/// <returns>bool? representing the createAttachment</returns>
			get
			{
				return  this.createAttachment;

			}
			/// <summary>The method to set the value to createAttachment</summary>
			/// <param name="createAttachment">bool?</param>
			set
			{
				 this.createAttachment=value;

				 this.keyModified["create_attachment"] = 1;

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