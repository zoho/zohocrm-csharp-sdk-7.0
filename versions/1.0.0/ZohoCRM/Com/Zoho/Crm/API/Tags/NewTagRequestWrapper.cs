using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Tags
{

	public class NewTagRequestWrapper : Model
	{
		private List<Tag> tags;
		private bool? overWrite;
		private List<long?> ids;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<Tag> Tags
		{
			/// <summary>The method to get the tags</summary>
			/// <returns>Instance of List<Tag></returns>
			get
			{
				return  this.tags;

			}
			/// <summary>The method to set the value to tags</summary>
			/// <param name="tags">Instance of List<Tag></param>
			set
			{
				 this.tags=value;

				 this.keyModified["tags"] = 1;

			}
		}

		public bool? OverWrite
		{
			/// <summary>The method to get the overWrite</summary>
			/// <returns>bool? representing the overWrite</returns>
			get
			{
				return  this.overWrite;

			}
			/// <summary>The method to set the value to overWrite</summary>
			/// <param name="overWrite">bool?</param>
			set
			{
				 this.overWrite=value;

				 this.keyModified["over_write"] = 1;

			}
		}

		public List<long?> Ids
		{
			/// <summary>The method to get the ids</summary>
			/// <returns>Instance of List<Long></returns>
			get
			{
				return  this.ids;

			}
			/// <summary>The method to set the value to ids</summary>
			/// <param name="ids">Instance of List<long?></param>
			set
			{
				 this.ids=value;

				 this.keyModified["ids"] = 1;

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