using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Record
{

	public class Info : Model
	{
		private bool? call;
		private int? perPage;
		private string nextPageToken;
		private int? count;
		private int? page;
		private string previousPageToken;
		private DateTimeOffset? pageTokenExpiry;
		private bool? email;
		private bool? moreRecords;
		private string sortBy;
		private string sortOrder;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? Call
		{
			/// <summary>The method to get the call</summary>
			/// <returns>bool? representing the call</returns>
			get
			{
				return  this.call;

			}
			/// <summary>The method to set the value to call</summary>
			/// <param name="call">bool?</param>
			set
			{
				 this.call=value;

				 this.keyModified["call"] = 1;

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

		public string NextPageToken
		{
			/// <summary>The method to get the nextPageToken</summary>
			/// <returns>string representing the nextPageToken</returns>
			get
			{
				return  this.nextPageToken;

			}
			/// <summary>The method to set the value to nextPageToken</summary>
			/// <param name="nextPageToken">string</param>
			set
			{
				 this.nextPageToken=value;

				 this.keyModified["next_page_token"] = 1;

			}
		}

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

		public int? Page
		{
			/// <summary>The method to get the page</summary>
			/// <returns>int? representing the page</returns>
			get
			{
				return  this.page;

			}
			/// <summary>The method to set the value to page</summary>
			/// <param name="page">int?</param>
			set
			{
				 this.page=value;

				 this.keyModified["page"] = 1;

			}
		}

		public string PreviousPageToken
		{
			/// <summary>The method to get the previousPageToken</summary>
			/// <returns>string representing the previousPageToken</returns>
			get
			{
				return  this.previousPageToken;

			}
			/// <summary>The method to set the value to previousPageToken</summary>
			/// <param name="previousPageToken">string</param>
			set
			{
				 this.previousPageToken=value;

				 this.keyModified["previous_page_token"] = 1;

			}
		}

		public DateTimeOffset? PageTokenExpiry
		{
			/// <summary>The method to get the pageTokenExpiry</summary>
			/// <returns>DateTimeOffset? representing the pageTokenExpiry</returns>
			get
			{
				return  this.pageTokenExpiry;

			}
			/// <summary>The method to set the value to pageTokenExpiry</summary>
			/// <param name="pageTokenExpiry">DateTimeOffset?</param>
			set
			{
				 this.pageTokenExpiry=value;

				 this.keyModified["page_token_expiry"] = 1;

			}
		}

		public bool? Email
		{
			/// <summary>The method to get the email</summary>
			/// <returns>bool? representing the email</returns>
			get
			{
				return  this.email;

			}
			/// <summary>The method to set the value to email</summary>
			/// <param name="email">bool?</param>
			set
			{
				 this.email=value;

				 this.keyModified["email"] = 1;

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

		public string SortBy
		{
			/// <summary>The method to get the sortBy</summary>
			/// <returns>string representing the sortBy</returns>
			get
			{
				return  this.sortBy;

			}
			/// <summary>The method to set the value to sortBy</summary>
			/// <param name="sortBy">string</param>
			set
			{
				 this.sortBy=value;

				 this.keyModified["sort_by"] = 1;

			}
		}

		public string SortOrder
		{
			/// <summary>The method to get the sortOrder</summary>
			/// <returns>string representing the sortOrder</returns>
			get
			{
				return  this.sortOrder;

			}
			/// <summary>The method to set the value to sortOrder</summary>
			/// <param name="sortOrder">string</param>
			set
			{
				 this.sortOrder=value;

				 this.keyModified["sort_order"] = 1;

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