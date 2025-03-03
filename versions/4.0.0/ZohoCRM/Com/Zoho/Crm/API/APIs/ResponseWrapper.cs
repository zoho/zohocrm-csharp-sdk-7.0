using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.APIs
{

	public class ResponseWrapper : Model, ResponseHandler
	{
		private List<SupportedAPI> apis;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<SupportedAPI> Apis
		{
			/// <summary>The method to get the apis</summary>
			/// <returns>Instance of List<SupportedAPI></returns>
			get
			{
				return  this.apis;

			}
			/// <summary>The method to set the value to apis</summary>
			/// <param name="apis">Instance of List<SupportedAPI></param>
			set
			{
				 this.apis=value;

				 this.keyModified["__apis"] = 1;

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