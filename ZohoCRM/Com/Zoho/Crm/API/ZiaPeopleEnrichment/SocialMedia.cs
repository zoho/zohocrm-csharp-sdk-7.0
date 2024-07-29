using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaPeopleEnrichment
{

	public class SocialMedia : Model
	{
		private string mediaType;
		private List<string> mediaUrl;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string MediaType
		{
			/// <summary>The method to get the mediaType</summary>
			/// <returns>string representing the mediaType</returns>
			get
			{
				return  this.mediaType;

			}
			/// <summary>The method to set the value to mediaType</summary>
			/// <param name="mediaType">string</param>
			set
			{
				 this.mediaType=value;

				 this.keyModified["media_type"] = 1;

			}
		}

		public List<string> MediaUrl
		{
			/// <summary>The method to get the mediaUrl</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.mediaUrl;

			}
			/// <summary>The method to set the value to mediaUrl</summary>
			/// <param name="mediaUrl">Instance of List<string></param>
			set
			{
				 this.mediaUrl=value;

				 this.keyModified["media_url"] = 1;

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