using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ScoringRules
{

	public class Signal : Model
	{
		private string namespace1;
		private long? id;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Namespace
		{
			/// <summary>The method to get the namespace</summary>
			/// <returns>string representing the namespace1</returns>
			get
			{
				return  this.namespace1;

			}
			/// <summary>The method to set the value to namespace</summary>
			/// <param name="namespace1">string</param>
			set
			{
				 this.namespace1=value;

				 this.keyModified["namespace"] = 1;

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