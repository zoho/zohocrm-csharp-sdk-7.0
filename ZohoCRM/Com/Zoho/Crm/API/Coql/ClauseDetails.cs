using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Coql
{

	public class ClauseDetails : Model, DetailsWrapper
	{
		private string clause;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Clause
		{
			/// <summary>The method to get the clause</summary>
			/// <returns>string representing the clause</returns>
			get
			{
				return  this.clause;

			}
			/// <summary>The method to set the value to clause</summary>
			/// <param name="clause">string</param>
			set
			{
				 this.clause=value;

				 this.keyModified["clause"] = 1;

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