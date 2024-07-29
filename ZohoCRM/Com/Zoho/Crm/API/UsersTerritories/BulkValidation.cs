using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UsersTerritories
{

	public class BulkValidation : Model, ValidationGroup
	{
		private bool? alert;
		private bool? assignment;
		private bool? criteria;
		private string name;
		private long? id;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? Alert
		{
			/// <summary>The method to get the alert</summary>
			/// <returns>bool? representing the alert</returns>
			get
			{
				return  this.alert;

			}
			/// <summary>The method to set the value to alert</summary>
			/// <param name="alert">bool?</param>
			set
			{
				 this.alert=value;

				 this.keyModified["alert"] = 1;

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