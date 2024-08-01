using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Functions
{

	public class BodyWrapper : Model
	{
		private Dictionary<string, object> body;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Dictionary<string, object> Body
		{
			/// <summary>The method to get the body</summary>
			/// <returns>Dictionary representing the body<String,Object></returns>
			get
			{
				return  this.body;

			}
			/// <summary>The method to set the value to body</summary>
			/// <param name="body">Dictionary<string,object></param>
			set
			{
				 this.body=value;

				 this.keyModified["body"] = 1;

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