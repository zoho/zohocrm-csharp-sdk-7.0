using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ConversionOption
{

	public class PreferenceFieldMatchedValue : Model
	{
		private List<PreferenceFieldMatch> contacts;
		private List<PreferenceFieldMatch> accounts;
		private List<PreferenceFieldMatch> deals;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<PreferenceFieldMatch> Contacts
		{
			/// <summary>The method to get the contacts</summary>
			/// <returns>Instance of List<PreferenceFieldMatch></returns>
			get
			{
				return  this.contacts;

			}
			/// <summary>The method to set the value to contacts</summary>
			/// <param name="contacts">Instance of List<PreferenceFieldMatch></param>
			set
			{
				 this.contacts=value;

				 this.keyModified["Contacts"] = 1;

			}
		}

		public List<PreferenceFieldMatch> Accounts
		{
			/// <summary>The method to get the accounts</summary>
			/// <returns>Instance of List<PreferenceFieldMatch></returns>
			get
			{
				return  this.accounts;

			}
			/// <summary>The method to set the value to accounts</summary>
			/// <param name="accounts">Instance of List<PreferenceFieldMatch></param>
			set
			{
				 this.accounts=value;

				 this.keyModified["Accounts"] = 1;

			}
		}

		public List<PreferenceFieldMatch> Deals
		{
			/// <summary>The method to get the deals</summary>
			/// <returns>Instance of List<PreferenceFieldMatch></returns>
			get
			{
				return  this.deals;

			}
			/// <summary>The method to set the value to deals</summary>
			/// <param name="deals">Instance of List<PreferenceFieldMatch></param>
			set
			{
				 this.deals=value;

				 this.keyModified["Deals"] = 1;

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