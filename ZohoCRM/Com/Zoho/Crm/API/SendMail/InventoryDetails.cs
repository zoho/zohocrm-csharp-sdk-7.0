using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.SendMail
{

	public class InventoryDetails : Model
	{
		private InventoryTemplate inventoryTemplate;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public InventoryTemplate InventoryTemplate
		{
			/// <summary>The method to get the inventoryTemplate</summary>
			/// <returns>Instance of InventoryTemplate</returns>
			get
			{
				return  this.inventoryTemplate;

			}
			/// <summary>The method to set the value to inventoryTemplate</summary>
			/// <param name="inventoryTemplate">Instance of InventoryTemplate</param>
			set
			{
				 this.inventoryTemplate=value;

				 this.keyModified["inventory_template"] = 1;

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