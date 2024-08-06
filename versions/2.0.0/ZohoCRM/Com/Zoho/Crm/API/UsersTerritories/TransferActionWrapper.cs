using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UsersTerritories
{

	public class TransferActionWrapper : Model, TransferActionHandler
	{
		private List<TransferActionResponse> transferAndDelink;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<TransferActionResponse> TransferAndDelink
		{
			/// <summary>The method to get the transferAndDelink</summary>
			/// <returns>Instance of List<TransferActionResponse></returns>
			get
			{
				return  this.transferAndDelink;

			}
			/// <summary>The method to set the value to transferAndDelink</summary>
			/// <param name="transferAndDelink">Instance of List<TransferActionResponse></param>
			set
			{
				 this.transferAndDelink=value;

				 this.keyModified["transfer_and_delink"] = 1;

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