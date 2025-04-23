using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Layouts
{

	public class Delete1 : Model
	{
		private bool? permanent;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? Permanent
		{
			/// <summary>The method to get the permanent</summary>
			/// <returns>bool? representing the permanent</returns>
			get
			{
				return  this.permanent;

			}
			/// <summary>The method to set the value to permanent</summary>
			/// <param name="permanent">bool?</param>
			set
			{
				 this.permanent=value;

				 this.keyModified["permanent"] = 1;

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