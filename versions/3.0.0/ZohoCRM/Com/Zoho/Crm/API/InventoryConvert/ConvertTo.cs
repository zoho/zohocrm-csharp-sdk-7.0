using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.InventoryConvert
{

	public class ConvertTo : Model
	{
		private Module module;
		private bool? carryOverTags;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Module Module
		{
			/// <summary>The method to get the module</summary>
			/// <returns>Instance of Module</returns>
			get
			{
				return  this.module;

			}
			/// <summary>The method to set the value to module</summary>
			/// <param name="module">Instance of Module</param>
			set
			{
				 this.module=value;

				 this.keyModified["module"] = 1;

			}
		}

		public bool? CarryOverTags
		{
			/// <summary>The method to get the carryOverTags</summary>
			/// <returns>bool? representing the carryOverTags</returns>
			get
			{
				return  this.carryOverTags;

			}
			/// <summary>The method to set the value to carryOverTags</summary>
			/// <param name="carryOverTags">bool?</param>
			set
			{
				 this.carryOverTags=value;

				 this.keyModified["carry_over_tags"] = 1;

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