using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.RecordLockingConfiguration
{

	public class LockingRules : Model
	{
		private string name;
		private long? id;
		private bool? lockExistingRecords;
		private Criteria criteria;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Name
		{
			/// <summary>The method to get the name</summary>
			/// <returns>string representing the name</returns>
			get
			{
				return  this.name;

			}
			/// <summary>The method to set the value to name</summary>
			/// <param name="name">string</param>
			set
			{
				 this.name=value;

				 this.keyModified["name"] = 1;

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

		public bool? LockExistingRecords
		{
			/// <summary>The method to get the lockExistingRecords</summary>
			/// <returns>bool? representing the lockExistingRecords</returns>
			get
			{
				return  this.lockExistingRecords;

			}
			/// <summary>The method to set the value to lockExistingRecords</summary>
			/// <param name="lockExistingRecords">bool?</param>
			set
			{
				 this.lockExistingRecords=value;

				 this.keyModified["lock_existing_records"] = 1;

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