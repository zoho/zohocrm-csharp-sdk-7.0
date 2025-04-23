using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Webforms
{

	public class AcknowledgeVisitors : Model
	{
		private string templateName;
		private long? templateId;
		private FromAddress fromAddress;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string TemplateName
		{
			/// <summary>The method to get the templateName</summary>
			/// <returns>string representing the templateName</returns>
			get
			{
				return  this.templateName;

			}
			/// <summary>The method to set the value to templateName</summary>
			/// <param name="templateName">string</param>
			set
			{
				 this.templateName=value;

				 this.keyModified["template_name"] = 1;

			}
		}

		public long? TemplateId
		{
			/// <summary>The method to get the templateId</summary>
			/// <returns>long? representing the templateId</returns>
			get
			{
				return  this.templateId;

			}
			/// <summary>The method to set the value to templateId</summary>
			/// <param name="templateId">long?</param>
			set
			{
				 this.templateId=value;

				 this.keyModified["template_id"] = 1;

			}
		}

		public FromAddress FromAddress
		{
			/// <summary>The method to get the fromAddress</summary>
			/// <returns>Instance of FromAddress</returns>
			get
			{
				return  this.fromAddress;

			}
			/// <summary>The method to set the value to fromAddress</summary>
			/// <param name="fromAddress">Instance of FromAddress</param>
			set
			{
				 this.fromAddress=value;

				 this.keyModified["from_address"] = 1;

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