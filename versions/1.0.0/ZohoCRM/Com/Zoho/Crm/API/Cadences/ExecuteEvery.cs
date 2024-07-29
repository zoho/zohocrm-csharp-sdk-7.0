using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Cadences
{

	public class ExecuteEvery : Model
	{
		private int? unit;
		private string period;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? Unit
		{
			/// <summary>The method to get the unit</summary>
			/// <returns>int? representing the unit</returns>
			get
			{
				return  this.unit;

			}
			/// <summary>The method to set the value to unit</summary>
			/// <param name="unit">int?</param>
			set
			{
				 this.unit=value;

				 this.keyModified["unit"] = 1;

			}
		}

		public string Period
		{
			/// <summary>The method to get the period</summary>
			/// <returns>string representing the period</returns>
			get
			{
				return  this.period;

			}
			/// <summary>The method to set the value to period</summary>
			/// <param name="period">string</param>
			set
			{
				 this.period=value;

				 this.keyModified["period"] = 1;

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