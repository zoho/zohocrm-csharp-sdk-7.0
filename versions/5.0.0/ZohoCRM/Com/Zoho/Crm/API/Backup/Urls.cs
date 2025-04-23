using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Backup
{

	public class Urls : Model
	{
		private List<string> dataLinks;
		private List<string> attachmentLinks;
		private DateTimeOffset? expiryDate;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<string> DataLinks
		{
			/// <summary>The method to get the dataLinks</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.dataLinks;

			}
			/// <summary>The method to set the value to dataLinks</summary>
			/// <param name="dataLinks">Instance of List<string></param>
			set
			{
				 this.dataLinks=value;

				 this.keyModified["data_links"] = 1;

			}
		}

		public List<string> AttachmentLinks
		{
			/// <summary>The method to get the attachmentLinks</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.attachmentLinks;

			}
			/// <summary>The method to set the value to attachmentLinks</summary>
			/// <param name="attachmentLinks">Instance of List<string></param>
			set
			{
				 this.attachmentLinks=value;

				 this.keyModified["attachment_links"] = 1;

			}
		}

		public DateTimeOffset? ExpiryDate
		{
			/// <summary>The method to get the expiryDate</summary>
			/// <returns>DateTimeOffset? representing the expiryDate</returns>
			get
			{
				return  this.expiryDate;

			}
			/// <summary>The method to set the value to expiryDate</summary>
			/// <param name="expiryDate">DateTimeOffset?</param>
			set
			{
				 this.expiryDate=value;

				 this.keyModified["expiry_date"] = 1;

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