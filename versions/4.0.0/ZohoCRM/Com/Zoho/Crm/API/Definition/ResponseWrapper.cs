using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Definition
{

	public class ResponseWrapper : Model
	{
		private Definition definition;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Definition Definition
		{
			/// <summary>The method to get the definition</summary>
			/// <returns>Instance of Definition</returns>
			get
			{
				return  this.definition;

			}
			/// <summary>The method to set the value to definition</summary>
			/// <param name="definition">Instance of Definition</param>
			set
			{
				 this.definition=value;

				 this.keyModified["definition"] = 1;

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