using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailComposeMeta
{

	public class Signature : Model
	{
		private int? mode;
		private string sign;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? Mode
		{
			/// <summary>The method to get the mode</summary>
			/// <returns>int? representing the mode</returns>
			get
			{
				return  this.mode;

			}
			/// <summary>The method to set the value to mode</summary>
			/// <param name="mode">int?</param>
			set
			{
				 this.mode=value;

				 this.keyModified["mode"] = 1;

			}
		}

		public string Sign
		{
			/// <summary>The method to get the sign</summary>
			/// <returns>string representing the sign</returns>
			get
			{
				return  this.sign;

			}
			/// <summary>The method to set the value to sign</summary>
			/// <param name="sign">string</param>
			set
			{
				 this.sign=value;

				 this.keyModified["sign"] = 1;

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