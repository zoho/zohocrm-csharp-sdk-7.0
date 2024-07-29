using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Pipeline
{

	public class Stages : Model
	{
		private long? from;
		private long? to;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public long? From
		{
			/// <summary>The method to get the from</summary>
			/// <returns>long? representing the from</returns>
			get
			{
				return  this.from;

			}
			/// <summary>The method to set the value to from</summary>
			/// <param name="from">long?</param>
			set
			{
				 this.from=value;

				 this.keyModified["from"] = 1;

			}
		}

		public long? To
		{
			/// <summary>The method to get the to</summary>
			/// <returns>long? representing the to</returns>
			get
			{
				return  this.to;

			}
			/// <summary>The method to set the value to to</summary>
			/// <param name="to">long?</param>
			set
			{
				 this.to=value;

				 this.keyModified["to"] = 1;

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