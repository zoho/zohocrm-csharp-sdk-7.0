using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaPeopleEnrichment
{

	public class Social : Model
	{
		private string twitter;
		private string facebook;
		private string linkedin;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Twitter
		{
			/// <summary>The method to get the twitter</summary>
			/// <returns>string representing the twitter</returns>
			get
			{
				return  this.twitter;

			}
			/// <summary>The method to set the value to twitter</summary>
			/// <param name="twitter">string</param>
			set
			{
				 this.twitter=value;

				 this.keyModified["twitter"] = 1;

			}
		}

		public string Facebook
		{
			/// <summary>The method to get the facebook</summary>
			/// <returns>string representing the facebook</returns>
			get
			{
				return  this.facebook;

			}
			/// <summary>The method to set the value to facebook</summary>
			/// <param name="facebook">string</param>
			set
			{
				 this.facebook=value;

				 this.keyModified["facebook"] = 1;

			}
		}

		public string Linkedin
		{
			/// <summary>The method to get the linkedin</summary>
			/// <returns>string representing the linkedin</returns>
			get
			{
				return  this.linkedin;

			}
			/// <summary>The method to set the value to linkedin</summary>
			/// <param name="linkedin">string</param>
			set
			{
				 this.linkedin=value;

				 this.keyModified["linkedin"] = 1;

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