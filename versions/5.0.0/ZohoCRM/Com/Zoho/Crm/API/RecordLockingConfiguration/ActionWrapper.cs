using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.RecordLockingConfiguration
{

	public class ActionWrapper : Model, ActionHandler
	{
		private List<ActionResponse> recordLockingConfigurations;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<ActionResponse> RecordLockingConfigurations
		{
			/// <summary>The method to get the recordLockingConfigurations</summary>
			/// <returns>Instance of List<ActionResponse></returns>
			get
			{
				return  this.recordLockingConfigurations;

			}
			/// <summary>The method to set the value to recordLockingConfigurations</summary>
			/// <param name="recordLockingConfigurations">Instance of List<ActionResponse></param>
			set
			{
				 this.recordLockingConfigurations=value;

				 this.keyModified["record_locking_configurations"] = 1;

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