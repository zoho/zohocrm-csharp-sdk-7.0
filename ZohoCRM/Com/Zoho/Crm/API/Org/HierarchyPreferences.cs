using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Org
{

	public class HierarchyPreferences : Model
	{
		private Choice<string> type;
		private bool? strictlyReporting;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Choice<string> Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">Instance of Choice<string></param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

		public bool? StrictlyReporting
		{
			/// <summary>The method to get the strictlyReporting</summary>
			/// <returns>bool? representing the strictlyReporting</returns>
			get
			{
				return  this.strictlyReporting;

			}
			/// <summary>The method to set the value to strictlyReporting</summary>
			/// <param name="strictlyReporting">bool?</param>
			set
			{
				 this.strictlyReporting=value;

				 this.keyModified["strictly_reporting"] = 1;

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