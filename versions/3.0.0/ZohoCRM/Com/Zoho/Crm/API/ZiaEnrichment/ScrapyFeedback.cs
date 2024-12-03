using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaEnrichment
{

	public class ScrapyFeedback : Model
	{
		private Choice<string> enrichId;
		private Choice<string> type;
		private Choice<string> feedback;
		private string comment;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Choice<string> EnrichId
		{
			/// <summary>The method to get the enrichId</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.enrichId;

			}
			/// <summary>The method to set the value to enrichId</summary>
			/// <param name="enrichId">Instance of Choice<string></param>
			set
			{
				 this.enrichId=value;

				 this.keyModified["enrich_id"] = 1;

			}
		}

		public Choice<string> Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">Instance of Choice<string></param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

		public Choice<string> Feedback
		{
			/// <summary>The method to get the feedback</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.feedback;

			}
			/// <summary>The method to set the value to feedback</summary>
			/// <param name="feedback">Instance of Choice<string></param>
			set
			{
				 this.feedback=value;

				 this.keyModified["feedback"] = 1;

			}
		}

		public string Comment
		{
			/// <summary>The method to get the comment</summary>
			/// <returns>string representing the comment</returns>
			get
			{
				return  this.comment;

			}
			/// <summary>The method to set the value to comment</summary>
			/// <param name="comment">string</param>
			set
			{
				 this.comment=value;

				 this.keyModified["comment"] = 1;

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