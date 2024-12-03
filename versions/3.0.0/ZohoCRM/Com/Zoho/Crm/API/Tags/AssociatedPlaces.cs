using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Tags
{

	public class AssociatedPlaces : Model
	{
		private string type;
		private List<string> resources;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>string representing the type</returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">string</param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

		public List<string> Resources
		{
			/// <summary>The method to get the resources</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.resources;

			}
			/// <summary>The method to set the value to resources</summary>
			/// <param name="resources">Instance of List<string></param>
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