using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Timelines
{

	public class FieldHistoryValue : Model
	{
		private string new1;
		private string old;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string New
		{
			/// <summary>The method to get the new</summary>
			/// <returns>string representing the new1</returns>
			get
			{
				return  this.new1;

			}
			/// <summary>The method to set the value to new</summary>
			/// <param name="new1">string</param>
			set
			{
				 this.new1=value;

				 this.keyModified["new"] = 1;

			}
		}

		public string Old
		{
			/// <summary>The method to get the old</summary>
			/// <returns>string representing the old</returns>
			get
			{
				return  this.old;

			}
			/// <summary>The method to set the value to old</summary>
			/// <param name="old">string</param>
			set
			{
				 this.old=value;

				 this.keyModified["old"] = 1;

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