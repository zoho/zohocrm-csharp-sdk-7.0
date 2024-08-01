using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Webforms
{

	public class SpamControll : Model
	{
		private string status;
		private string excludeScore;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public string ExcludeScore
		{
			/// <summary>The method to get the excludeScore</summary>
			/// <returns>string representing the excludeScore</returns>
			get
			{
				return  this.excludeScore;

			}
			/// <summary>The method to set the value to excludeScore</summary>
			/// <param name="excludeScore">string</param>
			set
			{
				 this.excludeScore=value;

				 this.keyModified["exclude_score"] = 1;

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