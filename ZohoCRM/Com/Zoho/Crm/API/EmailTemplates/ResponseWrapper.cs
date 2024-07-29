using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailTemplates
{

	public class ResponseWrapper : Model, ResponseHandler
	{
		private List<EmailTemplate> emailTemplates;
		private Info info;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<EmailTemplate> EmailTemplates
		{
			/// <summary>The method to get the emailTemplates</summary>
			/// <returns>Instance of List<EmailTemplate></returns>
			get
			{
				return  this.emailTemplates;

			}
			/// <summary>The method to set the value to emailTemplates</summary>
			/// <param name="emailTemplates">Instance of List<EmailTemplate></param>
			set
			{
				 this.emailTemplates=value;

				 this.keyModified["email_templates"] = 1;

			}
		}

		public Info Info
		{
			/// <summary>The method to get the info</summary>
			/// <returns>Instance of Info</returns>
			get
			{
				return  this.info;

			}
			/// <summary>The method to set the value to info</summary>
			/// <param name="info">Instance of Info</param>
			set
			{
				 this.info=value;

				 this.keyModified["info"] = 1;

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