using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Layouts
{

	public class ActionsAllowed : Model
	{
		private bool? edit;
		private bool? rename;
		private bool? clone;
		private bool? downgrade;
		private bool? delete;
		private bool? deactivate;
		private bool? setLayoutPermissions;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public bool? Rename
		{
			/// <summary>The method to get the rename</summary>
			/// <returns>bool? representing the rename</returns>
			get
			{
				return  this.rename;

			}
			/// <summary>The method to set the value to rename</summary>
			/// <param name="rename">bool?</param>
			set
			{
				 this.rename=value;

				 this.keyModified["rename"] = 1;

			}
		}

		public bool? Clone
		{
			/// <summary>The method to get the clone</summary>
			/// <returns>bool? representing the clone</returns>
			get
			{
				return  this.clone;

			}
			/// <summary>The method to set the value to clone</summary>
			/// <param name="clone">bool?</param>
			set
			{
				 this.clone=value;

				 this.keyModified["clone"] = 1;

			}
		}

		public bool? Downgrade
		{
			/// <summary>The method to get the downgrade</summary>
			/// <returns>bool? representing the downgrade</returns>
			get
			{
				return  this.downgrade;

			}
			/// <summary>The method to set the value to downgrade</summary>
			/// <param name="downgrade">bool?</param>
			set
			{
				 this.downgrade=value;

				 this.keyModified["downgrade"] = 1;

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

		public bool? Deactivate
		{
			/// <summary>The method to get the deactivate</summary>
			/// <returns>bool? representing the deactivate</returns>
			get
			{
				return  this.deactivate;

			}
			/// <summary>The method to set the value to deactivate</summary>
			/// <param name="deactivate">bool?</param>
			set
			{
				 this.deactivate=value;

				 this.keyModified["deactivate"] = 1;

			}
		}

		public bool? SetLayoutPermissions
		{
			/// <summary>The method to get the setLayoutPermissions</summary>
			/// <returns>bool? representing the setLayoutPermissions</returns>
			get
			{
				return  this.setLayoutPermissions;

			}
			/// <summary>The method to set the value to setLayoutPermissions</summary>
			/// <param name="setLayoutPermissions">bool?</param>
			set
			{
				 this.setLayoutPermissions=value;

				 this.keyModified["set_layout_permissions"] = 1;

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