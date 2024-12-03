using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.CadencesExecution
{

	public class AnalyticsAlert : Model
	{
		private int? emailCount;
		private int? clikedEmailCount;
		private int? bouncedEmailCount;
		private int? repliedEmailCount;
		private int? emailSpamCount;
		private int? sentEmailCount;
		private int? unsentEmailCount;
		private int? openedEmailCount;
		private int? unsubscribedEmailCount;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? EmailCount
		{
			/// <summary>The method to get the emailCount</summary>
			/// <returns>int? representing the emailCount</returns>
			get
			{
				return  this.emailCount;

			}
			/// <summary>The method to set the value to emailCount</summary>
			/// <param name="emailCount">int?</param>
			set
			{
				 this.emailCount=value;

				 this.keyModified["email_count"] = 1;

			}
		}

		public int? ClikedEmailCount
		{
			/// <summary>The method to get the clikedEmailCount</summary>
			/// <returns>int? representing the clikedEmailCount</returns>
			get
			{
				return  this.clikedEmailCount;

			}
			/// <summary>The method to set the value to clikedEmailCount</summary>
			/// <param name="clikedEmailCount">int?</param>
			set
			{
				 this.clikedEmailCount=value;

				 this.keyModified["cliked_email_count"] = 1;

			}
		}

		public int? BouncedEmailCount
		{
			/// <summary>The method to get the bouncedEmailCount</summary>
			/// <returns>int? representing the bouncedEmailCount</returns>
			get
			{
				return  this.bouncedEmailCount;

			}
			/// <summary>The method to set the value to bouncedEmailCount</summary>
			/// <param name="bouncedEmailCount">int?</param>
			set
			{
				 this.bouncedEmailCount=value;

				 this.keyModified["bounced_email_count"] = 1;

			}
		}

		public int? RepliedEmailCount
		{
			/// <summary>The method to get the repliedEmailCount</summary>
			/// <returns>int? representing the repliedEmailCount</returns>
			get
			{
				return  this.repliedEmailCount;

			}
			/// <summary>The method to set the value to repliedEmailCount</summary>
			/// <param name="repliedEmailCount">int?</param>
			set
			{
				 this.repliedEmailCount=value;

				 this.keyModified["replied_email_count"] = 1;

			}
		}

		public int? EmailSpamCount
		{
			/// <summary>The method to get the emailSpamCount</summary>
			/// <returns>int? representing the emailSpamCount</returns>
			get
			{
				return  this.emailSpamCount;

			}
			/// <summary>The method to set the value to emailSpamCount</summary>
			/// <param name="emailSpamCount">int?</param>
			set
			{
				 this.emailSpamCount=value;

				 this.keyModified["email_spam_count"] = 1;

			}
		}

		public int? SentEmailCount
		{
			/// <summary>The method to get the sentEmailCount</summary>
			/// <returns>int? representing the sentEmailCount</returns>
			get
			{
				return  this.sentEmailCount;

			}
			/// <summary>The method to set the value to sentEmailCount</summary>
			/// <param name="sentEmailCount">int?</param>
			set
			{
				 this.sentEmailCount=value;

				 this.keyModified["sent_email_count"] = 1;

			}
		}

		public int? UnsentEmailCount
		{
			/// <summary>The method to get the unsentEmailCount</summary>
			/// <returns>int? representing the unsentEmailCount</returns>
			get
			{
				return  this.unsentEmailCount;

			}
			/// <summary>The method to set the value to unsentEmailCount</summary>
			/// <param name="unsentEmailCount">int?</param>
			set
			{
				 this.unsentEmailCount=value;

				 this.keyModified["unsent_email_count"] = 1;

			}
		}

		public int? OpenedEmailCount
		{
			/// <summary>The method to get the openedEmailCount</summary>
			/// <returns>int? representing the openedEmailCount</returns>
			get
			{
				return  this.openedEmailCount;

			}
			/// <summary>The method to set the value to openedEmailCount</summary>
			/// <param name="openedEmailCount">int?</param>
			set
			{
				 this.openedEmailCount=value;

				 this.keyModified["opened_email_count"] = 1;

			}
		}

		public int? UnsubscribedEmailCount
		{
			/// <summary>The method to get the unsubscribedEmailCount</summary>
			/// <returns>int? representing the unsubscribedEmailCount</returns>
			get
			{
				return  this.unsubscribedEmailCount;

			}
			/// <summary>The method to set the value to unsubscribedEmailCount</summary>
			/// <param name="unsubscribedEmailCount">int?</param>
			set
			{
				 this.unsubscribedEmailCount=value;

				 this.keyModified["unsubscribed_email_count"] = 1;

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