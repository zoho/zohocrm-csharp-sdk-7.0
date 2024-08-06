using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UsersTransferDelete
{

	public class TransferAndDelete : Model
	{
		private long? id;
		private Transfer transfer;
		private MoveSubordinate moveSubordinate;
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

		public Transfer Transfer
		{
			/// <summary>The method to get the transfer</summary>
			/// <returns>Instance of Transfer</returns>
			get
			{
				return  this.transfer;

			}
			/// <summary>The method to set the value to transfer</summary>
			/// <param name="transfer">Instance of Transfer</param>
			set
			{
				 this.transfer=value;

				 this.keyModified["transfer"] = 1;

			}
		}

		public MoveSubordinate MoveSubordinate
		{
			/// <summary>The method to get the moveSubordinate</summary>
			/// <returns>Instance of MoveSubordinate</returns>
			get
			{
				return  this.moveSubordinate;

			}
			/// <summary>The method to set the value to moveSubordinate</summary>
			/// <param name="moveSubordinate">Instance of MoveSubordinate</param>
			set
			{
				 this.moveSubordinate=value;

				 this.keyModified["move_subordinate"] = 1;

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