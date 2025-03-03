using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaOrgEnrichment
{

	public class Address : Model
	{
		private string country;
		private string city;
		private string pinCode;
		private string state;
		private string fillAddress;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Country
		{
			/// <summary>The method to get the country</summary>
			/// <returns>string representing the country</returns>
			get
			{
				return  this.country;

			}
			/// <summary>The method to set the value to country</summary>
			/// <param name="country">string</param>
			set
			{
				 this.country=value;

				 this.keyModified["country"] = 1;

			}
		}

		public string City
		{
			/// <summary>The method to get the city</summary>
			/// <returns>string representing the city</returns>
			get
			{
				return  this.city;

			}
			/// <summary>The method to set the value to city</summary>
			/// <param name="city">string</param>
			set
			{
				 this.city=value;

				 this.keyModified["city"] = 1;

			}
		}

		public string PinCode
		{
			/// <summary>The method to get the pinCode</summary>
			/// <returns>string representing the pinCode</returns>
			get
			{
				return  this.pinCode;

			}
			/// <summary>The method to set the value to pinCode</summary>
			/// <param name="pinCode">string</param>
			set
			{
				 this.pinCode=value;

				 this.keyModified["pin_code"] = 1;

			}
		}

		public string State
		{
			/// <summary>The method to get the state</summary>
			/// <returns>string representing the state</returns>
			get
			{
				return  this.state;

			}
			/// <summary>The method to set the value to state</summary>
			/// <param name="state">string</param>
			set
			{
				 this.state=value;

				 this.keyModified["state"] = 1;

			}
		}

		public string FillAddress
		{
			/// <summary>The method to get the fillAddress</summary>
			/// <returns>string representing the fillAddress</returns>
			get
			{
				return  this.fillAddress;

			}
			/// <summary>The method to set the value to fillAddress</summary>
			/// <param name="fillAddress">string</param>
			set
			{
				 this.fillAddress=value;

				 this.keyModified["fill_address"] = 1;

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