using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaOrgEnrichment
{

	public class ZiaOrgEnrichment : Model
	{
		private EnrichedData enrichedData;
		private string createdTime;
		private long? id;
		private User createdBy;
		private string status;
		private EnrichBasedOn enrichBasedOn;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public EnrichedData EnrichedData
		{
			/// <summary>The method to get the enrichedData</summary>
			/// <returns>Instance of EnrichedData</returns>
			get
			{
				return  this.enrichedData;

			}
			/// <summary>The method to set the value to enrichedData</summary>
			/// <param name="enrichedData">Instance of EnrichedData</param>
			set
			{
				 this.enrichedData=value;

				 this.keyModified["enriched_data"] = 1;

			}
		}

		public string CreatedTime
		{
			/// <summary>The method to get the createdTime</summary>
			/// <returns>string representing the createdTime</returns>
			get
			{
				return  this.createdTime;

			}
			/// <summary>The method to set the value to createdTime</summary>
			/// <param name="createdTime">string</param>
			set
			{
				 this.createdTime=value;

				 this.keyModified["created_time"] = 1;

			}
		}

		public long? Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>long? representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">long?</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

			}
		}

		public User CreatedBy
		{
			/// <summary>The method to get the createdBy</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.createdBy;

			}
			/// <summary>The method to set the value to createdBy</summary>
			/// <param name="createdBy">Instance of User</param>
			set
			{
				 this.createdBy=value;

				 this.keyModified["created_by"] = 1;

			}
		}

		public string Status
		{
			/// <summary>The method to get the status</summary>
			/// <returns>string representing the status</returns>
			get
			{
				return  this.status;

			}
			/// <summary>The method to set the value to status</summary>
			/// <param name="status">string</param>
			set
			{
				 this.status=value;

				 this.keyModified["status"] = 1;

			}
		}

		public EnrichBasedOn EnrichBasedOn
		{
			/// <summary>The method to get the enrichBasedOn</summary>
			/// <returns>Instance of EnrichBasedOn</returns>
			get
			{
				return  this.enrichBasedOn;

			}
			/// <summary>The method to set the value to enrichBasedOn</summary>
			/// <param name="enrichBasedOn">Instance of EnrichBasedOn</param>
			set
			{
				 this.enrichBasedOn=value;

				 this.keyModified["enrich_based_on"] = 1;

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