using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaOrgEnrichment
{

	public class Description : Model
	{
		private string title;
		private string description;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Title
		{
			/// <summary>The method to get the title</summary>
			/// <returns>string representing the title</returns>
			get
			{
				return  this.title;

			}
			/// <summary>The method to set the value to title</summary>
			/// <param name="title">string</param>
			set
			{
				 this.title=value;

				 this.keyModified["title"] = 1;

			}
		}

		public string Description_1
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