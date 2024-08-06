using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaPeopleEnrichment
{

	public class CompanyInfo : Model
	{
		private string name;
		private List<Industry> industries;
		private List<Experience> experiences;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public List<Industry> Industries
		{
			/// <summary>The method to get the industries</summary>
			/// <returns>Instance of List<Industry></returns>
			get
			{
				return  this.industries;

			}
			/// <summary>The method to set the value to industries</summary>
			/// <param name="industries">Instance of List<Industry></param>
			set
			{
				 this.industries=value;

				 this.keyModified["industries"] = 1;

			}
		}

		public List<Experience> Experiences
		{
			/// <summary>The method to get the experiences</summary>
			/// <returns>Instance of List<Experience></returns>
			get
			{
				return  this.experiences;

			}
			/// <summary>The method to set the value to experiences</summary>
			/// <param name="experiences">Instance of List<Experience></param>
			set
			{
				 this.experiences=value;

				 this.keyModified["experiences"] = 1;

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