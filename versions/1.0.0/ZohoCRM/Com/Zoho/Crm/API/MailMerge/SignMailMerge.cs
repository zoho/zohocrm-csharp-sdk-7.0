using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.MailMerge
{

	public class SignMailMerge : Model
	{
		private MailMergeTemplate mailMergeTemplate;
		private bool? signInOrder;
		private string fileName;
		private List<Signers> signers;
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

		public bool? SignInOrder
		{
			/// <summary>The method to get the signInOrder</summary>
			/// <returns>bool? representing the signInOrder</returns>
			get
			{
				return  this.signInOrder;

			}
			/// <summary>The method to set the value to signInOrder</summary>
			/// <param name="signInOrder">bool?</param>
			set
			{
				 this.signInOrder=value;

				 this.keyModified["sign_in_order"] = 1;

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

		public List<Signers> Signers
		{
			/// <summary>The method to get the signers</summary>
			/// <returns>Instance of List<Signers></returns>
			get
			{
				return  this.signers;

			}
			/// <summary>The method to set the value to signers</summary>
			/// <param name="signers">Instance of List<Signers></param>
			set
			{
				 this.signers=value;

				 this.keyModified["signers"] = 1;

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