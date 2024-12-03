using Com.Zoho.Crm.API.Modules;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Fields
{

	public class HistoryTracking : Model
	{
		private HistoryTrackingModule module;
		private Modules.MinifiedModule durationConfiguredField;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public HistoryTrackingModule Module
		{
			/// <summary>The method to get the module</summary>
			/// <returns>Instance of HistoryTrackingModule</returns>
			get
			{
				return  this.module;

			}
			/// <summary>The method to set the value to module</summary>
			/// <param name="module">Instance of HistoryTrackingModule</param>
			set
			{
				 this.module=value;

				 this.keyModified["module"] = 1;

			}
		}

		public Modules.MinifiedModule DurationConfiguredField
		{
			/// <summary>The method to get the durationConfiguredField</summary>
			/// <returns>Instance of MinifiedModule</returns>
			get
			{
				return  this.durationConfiguredField;

			}
			/// <summary>The method to set the value to durationConfiguredField</summary>
			/// <param name="durationConfiguredField">Instance of MinifiedModule</param>
			set
			{
				 this.durationConfiguredField=value;

				 this.keyModified["duration_configured_field"] = 1;

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