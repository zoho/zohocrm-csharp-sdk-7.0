using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.MassDeleteCvid
{

	public class RecordIdBodyWrapper : Model
	{
		private List<long?> ids;
		private Territory territory;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<long?> Ids
		{
			/// <summary>The method to get the ids</summary>
			/// <returns>Instance of List<Long></returns>
			get
			{
				return  this.ids;

			}
			/// <summary>The method to set the value to ids</summary>
			/// <param name="ids">Instance of List<long?></param>
			set
			{
				 this.ids=value;

				 this.keyModified["ids"] = 1;

			}
		}

		public Territory Territory
		{
			/// <summary>The method to get the territory</summary>
			/// <returns>Instance of Territory</returns>
			get
			{
				return  this.territory;

			}
			/// <summary>The method to set the value to territory</summary>
			/// <param name="territory">Instance of Territory</param>
			set
			{
				 this.territory=value;

				 this.keyModified["territory"] = 1;

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