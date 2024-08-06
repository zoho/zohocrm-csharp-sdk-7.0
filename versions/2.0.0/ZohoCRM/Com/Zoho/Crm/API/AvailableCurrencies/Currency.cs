using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.AvailableCurrencies
{

	public class Currency : Model
	{
		private string displayValue;
		private string decimalSeparator;
		private string symbol;
		private string thousandSeparator;
		private string displayName;
		private string isoCode;
		private string decimalPlaces;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string DisplayValue
		{
			/// <summary>The method to get the displayValue</summary>
			/// <returns>string representing the displayValue</returns>
			get
			{
				return  this.displayValue;

			}
			/// <summary>The method to set the value to displayValue</summary>
			/// <param name="displayValue">string</param>
			set
			{
				 this.displayValue=value;

				 this.keyModified["display_value"] = 1;

			}
		}

		public string DecimalSeparator
		{
			/// <summary>The method to get the decimalSeparator</summary>
			/// <returns>string representing the decimalSeparator</returns>
			get
			{
				return  this.decimalSeparator;

			}
			/// <summary>The method to set the value to decimalSeparator</summary>
			/// <param name="decimalSeparator">string</param>
			set
			{
				 this.decimalSeparator=value;

				 this.keyModified["decimal_separator"] = 1;

			}
		}

		public string Symbol
		{
			/// <summary>The method to get the symbol</summary>
			/// <returns>string representing the symbol</returns>
			get
			{
				return  this.symbol;

			}
			/// <summary>The method to set the value to symbol</summary>
			/// <param name="symbol">string</param>
			set
			{
				 this.symbol=value;

				 this.keyModified["symbol"] = 1;

			}
		}

		public string ThousandSeparator
		{
			/// <summary>The method to get the thousandSeparator</summary>
			/// <returns>string representing the thousandSeparator</returns>
			get
			{
				return  this.thousandSeparator;

			}
			/// <summary>The method to set the value to thousandSeparator</summary>
			/// <param name="thousandSeparator">string</param>
			set
			{
				 this.thousandSeparator=value;

				 this.keyModified["thousand_separator"] = 1;

			}
		}

		public string DisplayName
		{
			/// <summary>The method to get the displayName</summary>
			/// <returns>string representing the displayName</returns>
			get
			{
				return  this.displayName;

			}
			/// <summary>The method to set the value to displayName</summary>
			/// <param name="displayName">string</param>
			set
			{
				 this.displayName=value;

				 this.keyModified["display_name"] = 1;

			}
		}

		public string IsoCode
		{
			/// <summary>The method to get the isoCode</summary>
			/// <returns>string representing the isoCode</returns>
			get
			{
				return  this.isoCode;

			}
			/// <summary>The method to set the value to isoCode</summary>
			/// <param name="isoCode">string</param>
			set
			{
				 this.isoCode=value;

				 this.keyModified["iso_code"] = 1;

			}
		}

		public string DecimalPlaces
		{
			/// <summary>The method to get the decimalPlaces</summary>
			/// <returns>string representing the decimalPlaces</returns>
			get
			{
				return  this.decimalPlaces;

			}
			/// <summary>The method to set the value to decimalPlaces</summary>
			/// <param name="decimalPlaces">string</param>
			set
			{
				 this.decimalPlaces=value;

				 this.keyModified["decimal_places"] = 1;

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