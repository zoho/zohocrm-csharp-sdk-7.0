using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.CadencesExecution
{

	public class BodyWrapper : Model
	{
		private List<string> cadencesIds;
		private List<string> ids;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<string> CadencesIds
		{
			/// <summary>The method to get the cadencesIds</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.cadencesIds;

			}
			/// <summary>The method to set the value to cadencesIds</summary>
			/// <param name="cadencesIds">Instance of List<string></param>
			set
			{
				 this.cadencesIds=value;

				 this.keyModified["cadences_ids"] = 1;

			}
		}

		public List<string> Ids
		{
			/// <summary>The method to get the ids</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.ids;

			}
			/// <summary>The method to set the value to ids</summary>
			/// <param name="ids">Instance of List<string></param>
			set
			{
				 this.ids=value;

				 this.keyModified["ids"] = 1;

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