using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailRelatedRecords
{

	public class Info : Model
	{
		private int? count;
		private string nextIndex;
		private string prevIndex;
		private int? perPage;
		private bool? moreRecords;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? Count
		{
			/// <summary>The method to get the count</summary>
			/// <returns>int? representing the count</returns>
			get
			{
				return  this.count;

			}
			/// <summary>The method to set the value to count</summary>
			/// <param name="count">int?</param>
			set
			{
				 this.count=value;

				 this.keyModified["count"] = 1;

			}
		}

		public string NextIndex
		{
			/// <summary>The method to get the nextIndex</summary>
			/// <returns>string representing the nextIndex</returns>
			get
			{
				return  this.nextIndex;

			}
			/// <summary>The method to set the value to nextIndex</summary>
			/// <param name="nextIndex">string</param>
			set
			{
				 this.nextIndex=value;

				 this.keyModified["next_index"] = 1;

			}
		}

		public string PrevIndex
		{
			/// <summary>The method to get the prevIndex</summary>
			/// <returns>string representing the prevIndex</returns>
			get
			{
				return  this.prevIndex;

			}
			/// <summary>The method to set the value to prevIndex</summary>
			/// <param name="prevIndex">string</param>
			set
			{
				 this.prevIndex=value;

				 this.keyModified["prev_index"] = 1;

			}
		}

		public int? PerPage
		{
			/// <summary>The method to get the perPage</summary>
			/// <returns>int? representing the perPage</returns>
			get
			{
				return  this.perPage;

			}
			/// <summary>The method to set the value to perPage</summary>
			/// <param name="perPage">int?</param>
			set
			{
				 this.perPage=value;

				 this.keyModified["per_page"] = 1;

			}
		}

		public bool? MoreRecords
		{
			/// <summary>The method to get the moreRecords</summary>
			/// <returns>bool? representing the moreRecords</returns>
			get
			{
				return  this.moreRecords;

			}
			/// <summary>The method to set the value to moreRecords</summary>
			/// <param name="moreRecords">bool?</param>
			set
			{
				 this.moreRecords=value;

				 this.keyModified["more_records"] = 1;

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