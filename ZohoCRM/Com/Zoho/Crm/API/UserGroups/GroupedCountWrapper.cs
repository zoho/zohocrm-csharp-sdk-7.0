using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserGroups
{

	public class GroupedCountWrapper : Model, ResponseHandler
	{
		private List<GroupedCount> groupedCounts;
		private Info info;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<GroupedCount> GroupedCounts
		{
			/// <summary>The method to get the groupedCounts</summary>
			/// <returns>Instance of List<GroupedCount></returns>
			get
			{
				return  this.groupedCounts;

			}
			/// <summary>The method to set the value to groupedCounts</summary>
			/// <param name="groupedCounts">Instance of List<GroupedCount></param>
			set
			{
				 this.groupedCounts=value;

				 this.keyModified["grouped_counts"] = 1;

			}
		}

		public Info Info
		{
			/// <summary>The method to get the info</summary>
			/// <returns>Instance of Info</returns>
			get
			{
				return  this.info;

			}
			/// <summary>The method to set the value to info</summary>
			/// <param name="info">Instance of Info</param>
			set
			{
				 this.info=value;

				 this.keyModified["info"] = 1;

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