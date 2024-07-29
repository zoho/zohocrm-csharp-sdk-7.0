using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Features
{

	public class Detail : Model
	{
		private Limit availableCount;
		private Limit limits;
		private Limit usedCount;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Limit AvailableCount
		{
			/// <summary>The method to get the availableCount</summary>
			/// <returns>Instance of Limit</returns>
			get
			{
				return  this.availableCount;

			}
			/// <summary>The method to set the value to availableCount</summary>
			/// <param name="availableCount">Instance of Limit</param>
			set
			{
				 this.availableCount=value;

				 this.keyModified["available_count"] = 1;

			}
		}

		public Limit Limits
		{
			/// <summary>The method to get the limits</summary>
			/// <returns>Instance of Limit</returns>
			get
			{
				return  this.limits;

			}
			/// <summary>The method to set the value to limits</summary>
			/// <param name="limits">Instance of Limit</param>
			set
			{
				 this.limits=value;

				 this.keyModified["limits"] = 1;

			}
		}

		public Limit UsedCount
		{
			/// <summary>The method to get the usedCount</summary>
			/// <returns>Instance of Limit</returns>
			get
			{
				return  this.usedCount;

			}
			/// <summary>The method to set the value to usedCount</summary>
			/// <param name="usedCount">Instance of Limit</param>
			set
			{
				 this.usedCount=value;

				 this.keyModified["used_count"] = 1;

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