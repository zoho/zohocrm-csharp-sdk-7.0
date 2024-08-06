using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserGroups
{

	public class Assign : Model
	{
		private Choice<string> feature;
		private long? relatedEntityId;
		private int? page;
		private int? perPage;
		private long? id;
		private Criteria filters;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Choice<string> Feature
		{
			/// <summary>The method to get the feature</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.feature;

			}
			/// <summary>The method to set the value to feature</summary>
			/// <param name="feature">Instance of Choice<string></param>
			set
			{
				 this.feature=value;

				 this.keyModified["feature"] = 1;

			}
		}

		public long? RelatedEntityId
		{
			/// <summary>The method to get the relatedEntityId</summary>
			/// <returns>long? representing the relatedEntityId</returns>
			get
			{
				return  this.relatedEntityId;

			}
			/// <summary>The method to set the value to relatedEntityId</summary>
			/// <param name="relatedEntityId">long?</param>
			set
			{
				 this.relatedEntityId=value;

				 this.keyModified["related_entity_id"] = 1;

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

		public Criteria Filters
		{
			/// <summary>The method to get the filters</summary>
			/// <returns>Instance of Criteria</returns>
			get
			{
				return  this.filters;

			}
			/// <summary>The method to set the value to filters</summary>
			/// <param name="filters">Instance of Criteria</param>
			set
			{
				 this.filters=value;

				 this.keyModified["filters"] = 1;

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