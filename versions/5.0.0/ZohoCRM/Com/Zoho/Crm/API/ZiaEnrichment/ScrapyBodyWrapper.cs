using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaEnrichment
{

	public class ScrapyBodyWrapper : Model
	{
		private ScrapyFeedback scrapyFeedback;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public ScrapyFeedback ScrapyFeedback
		{
			/// <summary>The method to get the scrapyFeedback</summary>
			/// <returns>Instance of ScrapyFeedback</returns>
			get
			{
				return  this.scrapyFeedback;

			}
			/// <summary>The method to set the value to scrapyFeedback</summary>
			/// <param name="scrapyFeedback">Instance of ScrapyFeedback</param>
			set
			{
				 this.scrapyFeedback=value;

				 this.keyModified["scrapy_feedback"] = 1;

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