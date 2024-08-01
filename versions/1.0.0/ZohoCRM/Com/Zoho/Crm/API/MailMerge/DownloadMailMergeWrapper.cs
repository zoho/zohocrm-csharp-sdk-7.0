using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.MailMerge
{

	public class DownloadMailMergeWrapper : Model
	{
		private List<DownloadMailMerge> downloadMailMerge;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<DownloadMailMerge> DownloadMailMerge
		{
			/// <summary>The method to get the downloadMailMerge</summary>
			/// <returns>Instance of List<DownloadMailMerge></returns>
			get
			{
				return  this.downloadMailMerge;

			}
			/// <summary>The method to set the value to downloadMailMerge</summary>
			/// <param name="downloadMailMerge">Instance of List<DownloadMailMerge></param>
			set
			{
				 this.downloadMailMerge=value;

				 this.keyModified["download_mail_merge"] = 1;

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