using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UsersTerritories
{

	public class ActionWrapper : Model, ActionHandler
	{
		private List<ActionResponse> transferAndDelink;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();
		private List<ActionResponse> territories;

		public List<ActionResponse> TransferAndDelink
		{
			/// <summary>The method to get the transferAndDelink</summary>
			/// <returns>Instance of List<ActionResponse></returns>
			get
			{
				return  this.transferAndDelink;

			}
			/// <summary>The method to set the value to transferAndDelink</summary>
			/// <param name="transferAndDelink">Instance of List<ActionResponse></param>
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

		public List<ActionResponse> Territories
		{
			/// <summary>The method to get the territories</summary>
			/// <returns>Instance of List<ActionResponse></returns>
			get
			{
				return  this.territories;

			}
			/// <summary>The method to set the value to territories</summary>
			/// <param name="territories">Instance of List<ActionResponse></param>
			set
			{
				 this.territories=value;

				 this.keyModified["territories"] = 1;

			}
		}


	}
}