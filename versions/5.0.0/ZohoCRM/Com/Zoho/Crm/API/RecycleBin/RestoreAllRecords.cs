using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.RecycleBin
{

	public class RestoreAllRecords : Model
	{
		private Choice<bool?> restoreAllRecords;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Choice<bool?> RestoreAllRecords_1
		{
			/// <summary>The method to get the restoreAllRecords</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.restoreAllRecords;

			}
			/// <summary>The method to set the value to restoreAllRecords</summary>
			/// <param name="restoreAllRecords">Instance of Choice<bool?></param>
			set
			{
				 this.restoreAllRecords=value;

				 this.keyModified["restore_all_records"] = 1;

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