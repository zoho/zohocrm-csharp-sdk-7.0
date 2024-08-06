using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaPeopleEnrichment
{

	public class EnrichBasedOn : Model
	{
		private Social social;
		private string name;
		private Company company;
		private string email;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Social Social
		{
			/// <summary>The method to get the social</summary>
			/// <returns>Instance of Social</returns>
			get
			{
				return  this.social;

			}
			/// <summary>The method to set the value to social</summary>
			/// <param name="social">Instance of Social</param>
			set
			{
				 this.social=value;

				 this.keyModified["social"] = 1;

			}
		}

		public string Name
		{
			/// <summary>The method to get the name</summary>
			/// <returns>string representing the name</returns>
			get
			{
				return  this.name;

			}
			/// <summary>The method to set the value to name</summary>
			/// <param name="name">string</param>
			set
			{
				 this.name=value;

				 this.keyModified["name"] = 1;

			}
		}

		public Company Company
		{
			/// <summary>The method to get the company</summary>
			/// <returns>Instance of Company</returns>
			get
			{
				return  this.company;

			}
			/// <summary>The method to set the value to company</summary>
			/// <param name="company">Instance of Company</param>
			set
			{
				 this.company=value;

				 this.keyModified["company"] = 1;

			}
		}

		public string Email
		{
			/// <summary>The method to get the email</summary>
			/// <returns>string representing the email</returns>
			get
			{
				return  this.email;

			}
			/// <summary>The method to set the value to email</summary>
			/// <param name="email">string</param>
			set
			{
				 this.email=value;

				 this.keyModified["email"] = 1;

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