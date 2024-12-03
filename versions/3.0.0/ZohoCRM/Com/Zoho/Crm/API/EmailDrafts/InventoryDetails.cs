using Com.Zoho.Crm.API.Record;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailDrafts
{

	public class InventoryDetails : Model
	{
		private InventoryTemplate inventoryTemplate;
		private Record.Record record;
		private string paperType;
		private string viewType;
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

		public Record.Record Record
		{
			/// <summary>The method to get the record</summary>
			/// <returns>Instance of Record</returns>
			get
			{
				return  this.record;

			}
			/// <summary>The method to set the value to record</summary>
			/// <param name="record">Instance of Record</param>
			set
			{
				 this.record=value;

				 this.keyModified["record"] = 1;

			}
		}

		public string PaperType
		{
			/// <summary>The method to get the paperType</summary>
			/// <returns>string representing the paperType</returns>
			get
			{
				return  this.paperType;

			}
			/// <summary>The method to set the value to paperType</summary>
			/// <param name="paperType">string</param>
			set
			{
				 this.paperType=value;

				 this.keyModified["paper_type"] = 1;

			}
		}

		public string ViewType
		{
			/// <summary>The method to get the viewType</summary>
			/// <returns>string representing the viewType</returns>
			get
			{
				return  this.viewType;

			}
			/// <summary>The method to set the value to viewType</summary>
			/// <param name="viewType">string</param>
			set
			{
				 this.viewType=value;

				 this.keyModified["view_type"] = 1;

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