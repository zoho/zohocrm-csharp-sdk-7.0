using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Backup
{

	public class UrlsWrapper : Model, ResponseHandler
	{
		private Urls urls;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Urls Urls
		{
			/// <summary>The method to get the urls</summary>
			/// <returns>Instance of Urls</returns>
			get
			{
				return  this.urls;

			}
			/// <summary>The method to set the value to urls</summary>
			/// <param name="urls">Instance of Urls</param>
			set
			{
				 this.urls=value;

				 this.keyModified["urls"] = 1;

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