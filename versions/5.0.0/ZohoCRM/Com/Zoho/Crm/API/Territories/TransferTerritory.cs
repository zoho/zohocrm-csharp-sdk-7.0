using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Territories
{

	public class TransferTerritory : Model
	{
		private long? id;
		private long? transferToId;
		private bool? deletePreviousForecasts;
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

		public long? TransferToId
		{
			/// <summary>The method to get the transferToId</summary>
			/// <returns>long? representing the transferToId</returns>
			get
			{
				return  this.transferToId;

			}
			/// <summary>The method to set the value to transferToId</summary>
			/// <param name="transferToId">long?</param>
			set
			{
				 this.transferToId=value;

				 this.keyModified["transfer_to_id"] = 1;

			}
		}

		public bool? DeletePreviousForecasts
		{
			/// <summary>The method to get the deletePreviousForecasts</summary>
			/// <returns>bool? representing the deletePreviousForecasts</returns>
			get
			{
				return  this.deletePreviousForecasts;

			}
			/// <summary>The method to set the value to deletePreviousForecasts</summary>
			/// <param name="deletePreviousForecasts">bool?</param>
			set
			{
				 this.deletePreviousForecasts=value;

				 this.keyModified["delete_previous_forecasts"] = 1;

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