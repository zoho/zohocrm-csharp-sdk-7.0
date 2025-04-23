using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Digest
{

	public class BodyWrapper : Model
	{
		private List<Digest> digest;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<Digest> Digest
		{
			/// <summary>The method to get the digest</summary>
			/// <returns>Instance of List<Digest></returns>
			get
			{
				return  this.digest;

			}
			/// <summary>The method to set the value to digest</summary>
			/// <param name="digest">Instance of List<Digest></param>
			set
			{
				 this.digest=value;

				 this.keyModified["__digest"] = 1;

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