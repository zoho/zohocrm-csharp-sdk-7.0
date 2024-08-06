using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Webforms
{

	public class AcknowledgeVisitor : Model
	{
		private AutoResponseRule autoResponseRule;
		private long? templateId;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public AutoResponseRule AutoResponseRule
		{
			/// <summary>The method to get the autoResponseRule</summary>
			/// <returns>Instance of AutoResponseRule</returns>
			get
			{
				return  this.autoResponseRule;

			}
			/// <summary>The method to set the value to autoResponseRule</summary>
			/// <param name="autoResponseRule">Instance of AutoResponseRule</param>
			set
			{
				 this.autoResponseRule=value;

				 this.keyModified["auto_response_rule"] = 1;

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