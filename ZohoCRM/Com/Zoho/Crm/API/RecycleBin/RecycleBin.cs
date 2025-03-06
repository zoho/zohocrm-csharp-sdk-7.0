using Com.Zoho.Crm.API.Modules;
using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.RecycleBin
{

	public class RecycleBin : Model
	{
		private string displayName;
		private DateTimeOffset? deletedTime;
		private Users.MinifiedUser owner;
		private Modules.MinifiedModule module;
		private Users.MinifiedUser deletedBy;
		private long? id;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string DisplayName
		{
			/// <summary>The method to get the displayName</summary>
			/// <returns>string representing the displayName</returns>
			get
			{
				return  this.displayName;

			}
			/// <summary>The method to set the value to displayName</summary>
			/// <param name="displayName">string</param>
			set
			{
				 this.displayName=value;

				 this.keyModified["display_name"] = 1;

			}
		}

		public DateTimeOffset? DeletedTime
		{
			/// <summary>The method to get the deletedTime</summary>
			/// <returns>DateTimeOffset? representing the deletedTime</returns>
			get
			{
				return  this.deletedTime;

			}
			/// <summary>The method to set the value to deletedTime</summary>
			/// <param name="deletedTime">DateTimeOffset?</param>
			set
			{
				 this.deletedTime=value;

				 this.keyModified["deleted_time"] = 1;

			}
		}

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

				 this.keyModified["owner"] = 1;

			}
		}

		public Modules.MinifiedModule Module
		{
			/// <summary>The method to get the module</summary>
			/// <returns>Instance of MinifiedModule</returns>
			get
			{
				return  this.module;

			}
			/// <summary>The method to set the value to module</summary>
			/// <param name="module">Instance of MinifiedModule</param>
			set
			{
				 this.module=value;

				 this.keyModified["module"] = 1;

			}
		}

		public Users.MinifiedUser DeletedBy
		{
			/// <summary>The method to get the deletedBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.deletedBy;

			}
			/// <summary>The method to set the value to deletedBy</summary>
			/// <param name="deletedBy">Instance of MinifiedUser</param>
			set
			{
				 this.deletedBy=value;

				 this.keyModified["deleted_by"] = 1;

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