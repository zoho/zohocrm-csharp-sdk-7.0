using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.AvailableCurrencies
{

	public class ResponseWrapper : Model, ResponseHandler
	{
		private List<Currency> availableCurrencies;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<Currency> AvailableCurrencies
		{
			/// <summary>The method to get the availableCurrencies</summary>
			/// <returns>Instance of List<Currency></returns>
			get
			{
				return  this.availableCurrencies;

			}
			/// <summary>The method to set the value to availableCurrencies</summary>
			/// <param name="availableCurrencies">Instance of List<Currency></param>
			set
			{
				 this.availableCurrencies=value;

				 this.keyModified["available_currencies"] = 1;

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