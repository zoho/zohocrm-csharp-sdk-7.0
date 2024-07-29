using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Coql
{

	public class ParseErrorDetails : Model, DetailsWrapper
	{
		private int? line;
		private int? column;
		private string near;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? Line
		{
			/// <summary>The method to get the line</summary>
			/// <returns>int? representing the line</returns>
			get
			{
				return  this.line;

			}
			/// <summary>The method to set the value to line</summary>
			/// <param name="line">int?</param>
			set
			{
				 this.line=value;

				 this.keyModified["line"] = 1;

			}
		}

		public int? Column
		{
			/// <summary>The method to get the column</summary>
			/// <returns>int? representing the column</returns>
			get
			{
				return  this.column;

			}
			/// <summary>The method to set the value to column</summary>
			/// <param name="column">int?</param>
			set
			{
				 this.column=value;

				 this.keyModified["column"] = 1;

			}
		}

		public string Near
		{
			/// <summary>The method to get the near</summary>
			/// <returns>string representing the near</returns>
			get
			{
				return  this.near;

			}
			/// <summary>The method to set the value to near</summary>
			/// <param name="near">string</param>
			set
			{
				 this.near=value;

				 this.keyModified["near"] = 1;

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