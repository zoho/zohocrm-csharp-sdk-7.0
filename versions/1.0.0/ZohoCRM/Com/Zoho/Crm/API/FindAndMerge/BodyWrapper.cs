using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.FindAndMerge
{

	public class BodyWrapper : Model
	{
		private List<Merge> merge;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<Merge> Merge
		{
			/// <summary>The method to get the merge</summary>
			/// <returns>Instance of List<Merge></returns>
			get
			{
				return  this.merge;

			}
			/// <summary>The method to set the value to merge</summary>
			/// <param name="merge">Instance of List<Merge></param>
			set
			{
				 this.merge=value;

				 this.keyModified["merge"] = 1;

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