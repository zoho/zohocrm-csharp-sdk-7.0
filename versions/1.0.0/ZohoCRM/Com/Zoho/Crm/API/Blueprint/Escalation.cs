using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Blueprint
{

	public class Escalation : Model
	{
		private int? days;
		private string status;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? Days
		{
			/// <summary>The method to get the days</summary>
			/// <returns>int? representing the days</returns>
			get
			{
				return  this.days;

			}
			/// <summary>The method to set the value to days</summary>
			/// <param name="days">int?</param>
			set
			{
				 this.days=value;

				 this.keyModified["days"] = 1;

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