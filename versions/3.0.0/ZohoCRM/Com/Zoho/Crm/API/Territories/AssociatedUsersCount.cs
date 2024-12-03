using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Territories
{

	public class AssociatedUsersCount : Model
	{
		private string count;
		private MinifiedTerritory territory;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Count
		{
			/// <summary>The method to get the count</summary>
			/// <returns>string representing the count</returns>
			get
			{
				return  this.count;

			}
			/// <summary>The method to set the value to count</summary>
			/// <param name="count">string</param>
			set
			{
				 this.count=value;

				 this.keyModified["count"] = 1;

			}
		}

		public MinifiedTerritory Territory
		{
			/// <summary>The method to get the territory</summary>
			/// <returns>Instance of MinifiedTerritory</returns>
			get
			{
				return  this.territory;

			}
			/// <summary>The method to set the value to territory</summary>
			/// <param name="territory">Instance of MinifiedTerritory</param>
			set
			{
				 this.territory=value;

				 this.keyModified["territory"] = 1;

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