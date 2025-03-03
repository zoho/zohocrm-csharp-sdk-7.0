using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Record
{

	public class TimeRange : Model
	{
		private string from;
		private string to;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string From
		{
			/// <summary>The method to get the from</summary>
			/// <returns>string representing the from</returns>
			get
			{
				return  this.from;

			}
			/// <summary>The method to set the value to from</summary>
			/// <param name="from">string</param>
			set
			{
				 this.from=value;

				 this.keyModified["From"] = 1;

			}
		}

		public string To
		{
			/// <summary>The method to get the to</summary>
			/// <returns>string representing the to</returns>
			get
			{
				return  this.to;

			}
			/// <summary>The method to set the value to to</summary>
			/// <param name="to">string</param>
			set
			{
				 this.to=value;

				 this.keyModified["To"] = 1;

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