using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.FromAddresses
{

	public class ResponseWrapper : Model, ResponseHandler
	{
		private List<Address> fromAddresses;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<Address> FromAddresses
		{
			/// <summary>The method to get the fromAddresses</summary>
			/// <returns>Instance of List<Address></returns>
			get
			{
				return  this.fromAddresses;

			}
			/// <summary>The method to set the value to fromAddresses</summary>
			/// <param name="fromAddresses">Instance of List<Address></param>
			set
			{
				 this.fromAddresses=value;

				 this.keyModified["from_addresses"] = 1;

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