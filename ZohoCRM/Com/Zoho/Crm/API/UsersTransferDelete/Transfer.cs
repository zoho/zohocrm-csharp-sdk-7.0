using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UsersTransferDelete
{

	public class Transfer : Model
	{
		private bool? records;
		private bool? assignment;
		private bool? criteria;
		private long? id;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? Records
		{
			/// <summary>The method to get the records</summary>
			/// <returns>bool? representing the records</returns>
			get
			{
				return  this.records;

			}
			/// <summary>The method to set the value to records</summary>
			/// <param name="records">bool?</param>
			set
			{
				 this.records=value;

				 this.keyModified["records"] = 1;

			}
		}

		public bool? Assignment
		{
			/// <summary>The method to get the assignment</summary>
			/// <returns>bool? representing the assignment</returns>
			get
			{
				return  this.assignment;

			}
			/// <summary>The method to set the value to assignment</summary>
			/// <param name="assignment">bool?</param>
			set
			{
				 this.assignment=value;

				 this.keyModified["assignment"] = 1;

			}
		}

		public bool? Criteria
		{
			/// <summary>The method to get the criteria</summary>
			/// <returns>bool? representing the criteria</returns>
			get
			{
				return  this.criteria;

			}
			/// <summary>The method to set the value to criteria</summary>
			/// <param name="criteria">bool?</param>
			set
			{
				 this.criteria=value;

				 this.keyModified["criteria"] = 1;

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