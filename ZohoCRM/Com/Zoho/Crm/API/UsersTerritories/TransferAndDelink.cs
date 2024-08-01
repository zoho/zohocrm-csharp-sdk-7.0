using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UsersTerritories
{

	public class TransferAndDelink : Model
	{
		private long? id;
		private TransferToUser transferToUser;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public long? Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>long? representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">long?</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

			}
		}

		public TransferToUser TransferToUser
		{
			/// <summary>The method to get the transferToUser</summary>
			/// <returns>Instance of TransferToUser</returns>
			get
			{
				return  this.transferToUser;

			}
			/// <summary>The method to set the value to transferToUser</summary>
			/// <param name="transferToUser">Instance of TransferToUser</param>
			set
			{
				 this.transferToUser=value;

				 this.keyModified["transfer_to_user"] = 1;

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