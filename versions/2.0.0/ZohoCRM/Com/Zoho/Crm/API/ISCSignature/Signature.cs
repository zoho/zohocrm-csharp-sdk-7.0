using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ISCSignature
{

	public class Signature : Model
	{
		private object iscSignature;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public object IscSignature
		{
			/// <summary>The method to get the iscSignature</summary>
			/// <returns>object representing the iscSignature</returns>
			get
			{
				return  this.iscSignature;

			}
			/// <summary>The method to set the value to iscSignature</summary>
			/// <param name="iscSignature">object</param>
			set
			{
				 this.iscSignature=value;

				 this.keyModified["isc_signature"] = 1;

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