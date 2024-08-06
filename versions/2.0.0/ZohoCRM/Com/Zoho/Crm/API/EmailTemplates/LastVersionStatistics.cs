using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailTemplates
{

	public class LastVersionStatistics : Model
	{
		private int? tracked;
		private int? delivered;
		private int? opened;
		private int? bounced;
		private int? sent;
		private int? clicked;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? Tracked
		{
			/// <summary>The method to get the tracked</summary>
			/// <returns>int? representing the tracked</returns>
			get
			{
				return  this.tracked;

			}
			/// <summary>The method to set the value to tracked</summary>
			/// <param name="tracked">int?</param>
			set
			{
				 this.tracked=value;

				 this.keyModified["tracked"] = 1;

			}
		}

		public int? Delivered
		{
			/// <summary>The method to get the delivered</summary>
			/// <returns>int? representing the delivered</returns>
			get
			{
				return  this.delivered;

			}
			/// <summary>The method to set the value to delivered</summary>
			/// <param name="delivered">int?</param>
			set
			{
				 this.delivered=value;

				 this.keyModified["delivered"] = 1;

			}
		}

		public int? Opened
		{
			/// <summary>The method to get the opened</summary>
			/// <returns>int? representing the opened</returns>
			get
			{
				return  this.opened;

			}
			/// <summary>The method to set the value to opened</summary>
			/// <param name="opened">int?</param>
			set
			{
				 this.opened=value;

				 this.keyModified["opened"] = 1;

			}
		}

		public int? Bounced
		{
			/// <summary>The method to get the bounced</summary>
			/// <returns>int? representing the bounced</returns>
			get
			{
				return  this.bounced;

			}
			/// <summary>The method to set the value to bounced</summary>
			/// <param name="bounced">int?</param>
			set
			{
				 this.bounced=value;

				 this.keyModified["bounced"] = 1;

			}
		}

		public int? Sent
		{
			/// <summary>The method to get the sent</summary>
			/// <returns>int? representing the sent</returns>
			get
			{
				return  this.sent;

			}
			/// <summary>The method to set the value to sent</summary>
			/// <param name="sent">int?</param>
			set
			{
				 this.sent=value;

				 this.keyModified["sent"] = 1;

			}
		}

		public int? Clicked
		{
			/// <summary>The method to get the clicked</summary>
			/// <returns>int? representing the clicked</returns>
			get
			{
				return  this.clicked;

			}
			/// <summary>The method to set the value to clicked</summary>
			/// <param name="clicked">int?</param>
			set
			{
				 this.clicked=value;

				 this.keyModified["clicked"] = 1;

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