using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.FieldMapDependency
{

	public class ActionWrapper : Model, ActionHandler
	{
		private List<ActionResponse> mapDependency;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<ActionResponse> MapDependency
		{
			/// <summary>The method to get the mapDependency</summary>
			/// <returns>Instance of List<ActionResponse></returns>
			get
			{
				return  this.mapDependency;

			}
			/// <summary>The method to set the value to mapDependency</summary>
			/// <param name="mapDependency">Instance of List<ActionResponse></param>
			set
			{
				 this.mapDependency=value;

				 this.keyModified["map_dependency"] = 1;

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