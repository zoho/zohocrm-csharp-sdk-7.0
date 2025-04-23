using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.InventoryConvert
{

	public class InventoryConverter : Model
	{
		private List<ConvertTo> convertTo;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<ConvertTo> ConvertTo
		{
			/// <summary>The method to get the convertTo</summary>
			/// <returns>Instance of List<ConvertTo></returns>
			get
			{
				return  this.convertTo;

			}
			/// <summary>The method to set the value to convertTo</summary>
			/// <param name="convertTo">Instance of List<ConvertTo></param>
			set
			{
				 this.convertTo=value;

				 this.keyModified["convert_to"] = 1;

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