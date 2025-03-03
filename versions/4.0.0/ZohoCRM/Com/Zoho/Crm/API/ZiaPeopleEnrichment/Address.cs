using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaPeopleEnrichment
{

	public class Address : Model
	{
		private string continent;
		private string country;
		private string name;
		private string region;
		private bool? primary;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Continent
		{
			/// <summary>The method to get the continent</summary>
			/// <returns>string representing the continent</returns>
			get
			{
				return  this.continent;

			}
			/// <summary>The method to set the value to continent</summary>
			/// <param name="continent">string</param>
			set
			{
				 this.continent=value;

				 this.keyModified["continent"] = 1;

			}
		}

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

		public string Region
		{
			/// <summary>The method to get the region</summary>
			/// <returns>string representing the region</returns>
			get
			{
				return  this.region;

			}
			/// <summary>The method to set the value to region</summary>
			/// <param name="region">string</param>
			set
			{
				 this.region=value;

				 this.keyModified["region"] = 1;

			}
		}

		public bool? Primary
		{
			/// <summary>The method to get the primary</summary>
			/// <returns>bool? representing the primary</returns>
			get
			{
				return  this.primary;

			}
			/// <summary>The method to set the value to primary</summary>
			/// <param name="primary">bool?</param>
			set
			{
				 this.primary=value;

				 this.keyModified["primary"] = 1;

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