using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailRelatedRecords
{

	public class Status : Model
	{
		private DateTimeOffset? firstOpen;
		private string count;
		private string type;
		private DateTimeOffset? lastOpen;
		private DateTimeOffset? bouncedTime;
		private string bouncedReason;
		private string category;
		private string subCategory;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public DateTimeOffset? FirstOpen
		{
			/// <summary>The method to get the firstOpen</summary>
			/// <returns>DateTimeOffset? representing the firstOpen</returns>
			get
			{
				return  this.firstOpen;

			}
			/// <summary>The method to set the value to firstOpen</summary>
			/// <param name="firstOpen">DateTimeOffset?</param>
			set
			{
				 this.firstOpen=value;

				 this.keyModified["first_open"] = 1;

			}
		}

		public string Count
		{
			/// <summary>The method to get the count</summary>
			/// <returns>string representing the count</returns>
			get
			{
				return  this.count;

			}
			/// <summary>The method to set the value to count</summary>
			/// <param name="count">string</param>
			set
			{
				 this.count=value;

				 this.keyModified["count"] = 1;

			}
		}

		public string Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>string representing the type</returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">string</param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

		public DateTimeOffset? LastOpen
		{
			/// <summary>The method to get the lastOpen</summary>
			/// <returns>DateTimeOffset? representing the lastOpen</returns>
			get
			{
				return  this.lastOpen;

			}
			/// <summary>The method to set the value to lastOpen</summary>
			/// <param name="lastOpen">DateTimeOffset?</param>
			set
			{
				 this.lastOpen=value;

				 this.keyModified["last_open"] = 1;

			}
		}

		public DateTimeOffset? BouncedTime
		{
			/// <summary>The method to get the bouncedTime</summary>
			/// <returns>DateTimeOffset? representing the bouncedTime</returns>
			get
			{
				return  this.bouncedTime;

			}
			/// <summary>The method to set the value to bouncedTime</summary>
			/// <param name="bouncedTime">DateTimeOffset?</param>
			set
			{
				 this.bouncedTime=value;

				 this.keyModified["bounced_time"] = 1;

			}
		}

		public string BouncedReason
		{
			/// <summary>The method to get the bouncedReason</summary>
			/// <returns>string representing the bouncedReason</returns>
			get
			{
				return  this.bouncedReason;

			}
			/// <summary>The method to set the value to bouncedReason</summary>
			/// <param name="bouncedReason">string</param>
			set
			{
				 this.bouncedReason=value;

				 this.keyModified["bounced_reason"] = 1;

			}
		}

		public string Category
		{
			/// <summary>The method to get the category</summary>
			/// <returns>string representing the category</returns>
			get
			{
				return  this.category;

			}
			/// <summary>The method to set the value to category</summary>
			/// <param name="category">string</param>
			set
			{
				 this.category=value;

				 this.keyModified["category"] = 1;

			}
		}

		public string SubCategory
		{
			/// <summary>The method to get the subCategory</summary>
			/// <returns>string representing the subCategory</returns>
			get
			{
				return  this.subCategory;

			}
			/// <summary>The method to set the value to subCategory</summary>
			/// <param name="subCategory">string</param>
			set
			{
				 this.subCategory=value;

				 this.keyModified["sub_category"] = 1;

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