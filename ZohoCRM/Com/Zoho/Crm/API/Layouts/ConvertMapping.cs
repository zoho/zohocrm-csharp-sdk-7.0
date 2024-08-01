using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Layouts
{

	public class ConvertMapping : Model
	{
		private MinifiedLayout contacts;
		private DealLayoutMapping deals;
		private MinifiedLayout accounts;
		private MinifiedLayout invoices;
		private MinifiedLayout salesorders;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public MinifiedLayout Contacts
		{
			/// <summary>The method to get the contacts</summary>
			/// <returns>Instance of MinifiedLayout</returns>
			get
			{
				return  this.contacts;

			}
			/// <summary>The method to set the value to contacts</summary>
			/// <param name="contacts">Instance of MinifiedLayout</param>
			set
			{
				 this.contacts=value;

				 this.keyModified["Contacts"] = 1;

			}
		}

		public DealLayoutMapping Deals
		{
			/// <summary>The method to get the deals</summary>
			/// <returns>Instance of DealLayoutMapping</returns>
			get
			{
				return  this.deals;

			}
			/// <summary>The method to set the value to deals</summary>
			/// <param name="deals">Instance of DealLayoutMapping</param>
			set
			{
				 this.deals=value;

				 this.keyModified["Deals"] = 1;

			}
		}

		public MinifiedLayout Accounts
		{
			/// <summary>The method to get the accounts</summary>
			/// <returns>Instance of MinifiedLayout</returns>
			get
			{
				return  this.accounts;

			}
			/// <summary>The method to set the value to accounts</summary>
			/// <param name="accounts">Instance of MinifiedLayout</param>
			set
			{
				 this.accounts=value;

				 this.keyModified["Accounts"] = 1;

			}
		}

		public MinifiedLayout Invoices
		{
			/// <summary>The method to get the invoices</summary>
			/// <returns>Instance of MinifiedLayout</returns>
			get
			{
				return  this.invoices;

			}
			/// <summary>The method to set the value to invoices</summary>
			/// <param name="invoices">Instance of MinifiedLayout</param>
			set
			{
				 this.invoices=value;

				 this.keyModified["Invoices"] = 1;

			}
		}

		public MinifiedLayout Salesorders
		{
			/// <summary>The method to get the salesorders</summary>
			/// <returns>Instance of MinifiedLayout</returns>
			get
			{
				return  this.salesorders;

			}
			/// <summary>The method to set the value to salesorders</summary>
			/// <param name="salesorders">Instance of MinifiedLayout</param>
			set
			{
				 this.salesorders=value;

				 this.keyModified["SalesOrders"] = 1;

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