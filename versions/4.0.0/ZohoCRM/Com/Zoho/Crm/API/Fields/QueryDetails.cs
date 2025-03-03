using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Fields
{

	public class QueryDetails : Model
	{
		private long? queryId;
		private Criteria criteria;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public long? QueryId
		{
			/// <summary>The method to get the queryId</summary>
			/// <returns>long? representing the queryId</returns>
			get
			{
				return  this.queryId;

			}
			/// <summary>The method to set the value to queryId</summary>
			/// <param name="queryId">long?</param>
			set
			{
				 this.queryId=value;

				 this.keyModified["query_id"] = 1;

			}
		}

		public Criteria Criteria
		{
			/// <summary>The method to get the criteria</summary>
			/// <returns>Instance of Criteria</returns>
			get
			{
				return  this.criteria;

			}
			/// <summary>The method to set the value to criteria</summary>
			/// <param name="criteria">Instance of Criteria</param>
			set
			{
				 this.criteria=value;

				 this.keyModified["criteria"] = 1;

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