using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Record
{

	public class MultiSelectLookup : Model
	{
		private long? id;
		private Dictionary<string, object> fieldname;
		private Dictionary<string, object> hasMore;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public Dictionary<string, object> Fieldname
		{
			/// <summary>The method to get the fieldname</summary>
			/// <returns>Dictionary representing the fieldname<String,Object></returns>
			get
			{
				return  this.fieldname;

			}
			/// <summary>The method to set the value to fieldname</summary>
			/// <param name="fieldname">Dictionary<string,object></param>
			set
			{
				 this.fieldname=value;

				 this.keyModified["fieldName"] = 1;

			}
		}

		public Dictionary<string, object> HasMore
		{
			/// <summary>The method to get the hasMore</summary>
			/// <returns>Dictionary representing the hasMore<String,Object></returns>
			get
			{
				return  this.hasMore;

			}
			/// <summary>The method to set the value to hasMore</summary>
			/// <param name="hasMore">Dictionary<string,object></param>
			set
			{
				 this.hasMore=value;

				 this.keyModified["$has_more"] = 1;

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