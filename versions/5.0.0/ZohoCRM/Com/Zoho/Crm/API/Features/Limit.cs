using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Features
{

	public class Limit : Model
	{
		private int? total;
		private int? editionLimit;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? Total
		{
			/// <summary>The method to get the total</summary>
			/// <returns>int? representing the total</returns>
			get
			{
				return  this.total;

			}
			/// <summary>The method to set the value to total</summary>
			/// <param name="total">int?</param>
			set
			{
				 this.total=value;

				 this.keyModified["total"] = 1;

			}
		}

		public int? EditionLimit
		{
			/// <summary>The method to get the editionLimit</summary>
			/// <returns>int? representing the editionLimit</returns>
			get
			{
				return  this.editionLimit;

			}
			/// <summary>The method to set the value to editionLimit</summary>
			/// <param name="editionLimit">int?</param>
			set
			{
				 this.editionLimit=value;

				 this.keyModified["edition_limit"] = 1;

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