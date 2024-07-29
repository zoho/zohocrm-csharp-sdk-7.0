using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailDrafts
{

	public class Attachments : Model
	{
		private string serviceName;
		private string fileSize;
		private string id;
		private string fileName;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string ServiceName
		{
			/// <summary>The method to get the serviceName</summary>
			/// <returns>string representing the serviceName</returns>
			get
			{
				return  this.serviceName;

			}
			/// <summary>The method to set the value to serviceName</summary>
			/// <param name="serviceName">string</param>
			set
			{
				 this.serviceName=value;

				 this.keyModified["service_name"] = 1;

			}
		}

		public string FileSize
		{
			/// <summary>The method to get the fileSize</summary>
			/// <returns>string representing the fileSize</returns>
			get
			{
				return  this.fileSize;

			}
			/// <summary>The method to set the value to fileSize</summary>
			/// <param name="fileSize">string</param>
			set
			{
				 this.fileSize=value;

				 this.keyModified["file_size"] = 1;

			}
		}

		public string Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>string representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">string</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

			}
		}

		public string FileName
		{
			/// <summary>The method to get the fileName</summary>
			/// <returns>string representing the fileName</returns>
			get
			{
				return  this.fileName;

			}
			/// <summary>The method to set the value to fileName</summary>
			/// <param name="fileName">string</param>
			set
			{
				 this.fileName=value;

				 this.keyModified["file_name"] = 1;

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