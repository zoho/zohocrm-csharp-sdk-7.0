using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.BusinessHours
{

	public class BodyWrapper : Model
	{
		private BusinessHours businessHours;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public BusinessHours BusinessHours
		{
			/// <summary>The method to get the businessHours</summary>
			/// <returns>Instance of BusinessHours</returns>
			get
			{
				return  this.businessHours;

			}
			/// <summary>The method to set the value to businessHours</summary>
			/// <param name="businessHours">Instance of BusinessHours</param>
			set
			{
				 this.businessHours=value;

				 this.keyModified["business_hours"] = 1;

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