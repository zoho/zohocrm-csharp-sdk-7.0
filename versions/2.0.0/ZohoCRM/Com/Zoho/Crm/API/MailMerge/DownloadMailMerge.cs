using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.MailMerge
{

	public class DownloadMailMerge : Model
	{
		private MailMergeTemplate mailMergeTemplate;
		private Choice<string> outputFormat;
		private string fileName;
		private string password;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public MailMergeTemplate MailMergeTemplate
		{
			/// <summary>The method to get the mailMergeTemplate</summary>
			/// <returns>Instance of MailMergeTemplate</returns>
			get
			{
				return  this.mailMergeTemplate;

			}
			/// <summary>The method to set the value to mailMergeTemplate</summary>
			/// <param name="mailMergeTemplate">Instance of MailMergeTemplate</param>
			set
			{
				 this.mailMergeTemplate=value;

				 this.keyModified["mail_merge_template"] = 1;

			}
		}

		public Choice<string> OutputFormat
		{
			/// <summary>The method to get the outputFormat</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.outputFormat;

			}
			/// <summary>The method to set the value to outputFormat</summary>
			/// <param name="outputFormat">Instance of Choice<string></param>
			set
			{
				 this.outputFormat=value;

				 this.keyModified["output_format"] = 1;

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

		public string Password
		{
			/// <summary>The method to get the password</summary>
			/// <returns>string representing the password</returns>
			get
			{
				return  this.password;

			}
			/// <summary>The method to set the value to password</summary>
			/// <param name="password">string</param>
			set
			{
				 this.password=value;

				 this.keyModified["password"] = 1;

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