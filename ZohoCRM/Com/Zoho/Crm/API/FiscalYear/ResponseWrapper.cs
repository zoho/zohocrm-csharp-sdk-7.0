using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.FiscalYear
{

	public class ResponseWrapper : Model, ResponseHandler
	{
		private Year fiscalYear;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Year FiscalYear
		{
			/// <summary>The method to get the fiscalYear</summary>
			/// <returns>Instance of Year</returns>
			get
			{
				return  this.fiscalYear;

			}
			/// <summary>The method to set the value to fiscalYear</summary>
			/// <param name="fiscalYear">Instance of Year</param>
			set
			{
				 this.fiscalYear=value;

				 this.keyModified["fiscal_year"] = 1;

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