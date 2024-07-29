using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.AssociateEmail
{

	public class Available : Model
	{
		private bool? available;
		private Record record;
		private LinkedRecord linkedRecord;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? Available_1
		{
			/// <summary>The method to get the available</summary>
			/// <returns>bool? representing the available</returns>
			get
			{
				return  this.available;

			}
			/// <summary>The method to set the value to available</summary>
			/// <param name="available">bool?</param>
			set
			{
				 this.available=value;

				 this.keyModified["available"] = 1;

			}
		}

		public Record Record
		{
			/// <summary>The method to get the record</summary>
			/// <returns>Instance of Record</returns>
			get
			{
				return  this.record;

			}
			/// <summary>The method to set the value to record</summary>
			/// <param name="record">Instance of Record</param>
			set
			{
				 this.record=value;

				 this.keyModified["record"] = 1;

			}
		}

		public LinkedRecord LinkedRecord
		{
			/// <summary>The method to get the linkedRecord</summary>
			/// <returns>Instance of LinkedRecord</returns>
			get
			{
				return  this.linkedRecord;

			}
			/// <summary>The method to set the value to linkedRecord</summary>
			/// <param name="linkedRecord">Instance of LinkedRecord</param>
			set
			{
				 this.linkedRecord=value;

				 this.keyModified["linked_record"] = 1;

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