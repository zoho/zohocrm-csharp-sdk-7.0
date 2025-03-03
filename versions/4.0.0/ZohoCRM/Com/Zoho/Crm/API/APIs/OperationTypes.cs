using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.APIs
{

	public class OperationTypes : Model
	{
		private string method;
		private string oauthScope;
		private int? maxCredits;
		private int? minCredits;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Method
		{
			/// <summary>The method to get the method</summary>
			/// <returns>string representing the method</returns>
			get
			{
				return  this.method;

			}
			/// <summary>The method to set the value to method</summary>
			/// <param name="method">string</param>
			set
			{
				 this.method=value;

				 this.keyModified["method"] = 1;

			}
		}

		public string OauthScope
		{
			/// <summary>The method to get the oauthScope</summary>
			/// <returns>string representing the oauthScope</returns>
			get
			{
				return  this.oauthScope;

			}
			/// <summary>The method to set the value to oauthScope</summary>
			/// <param name="oauthScope">string</param>
			set
			{
				 this.oauthScope=value;

				 this.keyModified["oauth_scope"] = 1;

			}
		}

		public int? MaxCredits
		{
			/// <summary>The method to get the maxCredits</summary>
			/// <returns>int? representing the maxCredits</returns>
			get
			{
				return  this.maxCredits;

			}
			/// <summary>The method to set the value to maxCredits</summary>
			/// <param name="maxCredits">int?</param>
			set
			{
				 this.maxCredits=value;

				 this.keyModified["max_credits"] = 1;

			}
		}

		public int? MinCredits
		{
			/// <summary>The method to get the minCredits</summary>
			/// <returns>int? representing the minCredits</returns>
			get
			{
				return  this.minCredits;

			}
			/// <summary>The method to set the value to minCredits</summary>
			/// <param name="minCredits">int?</param>
			set
			{
				 this.minCredits=value;

				 this.keyModified["min_credits"] = 1;

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