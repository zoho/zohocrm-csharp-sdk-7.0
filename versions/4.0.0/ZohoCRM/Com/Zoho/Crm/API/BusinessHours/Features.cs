using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.BusinessHours
{

	public class Features : Model
	{
		private string name;
		private List<Resources> resources;
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

		public List<Resources> Resources
		{
			/// <summary>The method to get the resources</summary>
			/// <returns>Instance of List<Resources></returns>
			get
			{
				return  this.resources;

			}
			/// <summary>The method to set the value to resources</summary>
			/// <param name="resources">Instance of List<Resources></param>
			set
			{
				 this.resources=value;

				 this.keyModified["resources"] = 1;

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