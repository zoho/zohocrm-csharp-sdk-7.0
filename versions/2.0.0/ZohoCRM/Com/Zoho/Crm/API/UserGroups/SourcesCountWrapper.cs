using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserGroups
{

	public class SourcesCountWrapper : Model, ResponseHandler
	{
		private List<SourcesCount> sourcesCount;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<SourcesCount> SourcesCount
		{
			/// <summary>The method to get the sourcesCount</summary>
			/// <returns>Instance of List<SourcesCount></returns>
			get
			{
				return  this.sourcesCount;

			}
			/// <summary>The method to set the value to sourcesCount</summary>
			/// <param name="sourcesCount">Instance of List<SourcesCount></param>
			set
			{
				 this.sourcesCount=value;

				 this.keyModified["sources_count"] = 1;

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