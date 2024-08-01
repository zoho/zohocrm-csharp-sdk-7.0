using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaPeopleEnrichment
{

	public class Experience : Model
	{
		private string endDate;
		private string companyName;
		private string title;
		private string startDate;
		private bool? primary;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string EndDate
		{
			/// <summary>The method to get the endDate</summary>
			/// <returns>string representing the endDate</returns>
			get
			{
				return  this.endDate;

			}
			/// <summary>The method to set the value to endDate</summary>
			/// <param name="endDate">string</param>
			set
			{
				 this.endDate=value;

				 this.keyModified["end_date"] = 1;

			}
		}

		public string CompanyName
		{
			/// <summary>The method to get the companyName</summary>
			/// <returns>string representing the companyName</returns>
			get
			{
				return  this.companyName;

			}
			/// <summary>The method to set the value to companyName</summary>
			/// <param name="companyName">string</param>
			set
			{
				 this.companyName=value;

				 this.keyModified["company_name"] = 1;

			}
		}

		public string Title
		{
			/// <summary>The method to get the title</summary>
			/// <returns>string representing the title</returns>
			get
			{
				return  this.title;

			}
			/// <summary>The method to set the value to title</summary>
			/// <param name="title">string</param>
			set
			{
				 this.title=value;

				 this.keyModified["title"] = 1;

			}
		}

		public string StartDate
		{
			/// <summary>The method to get the startDate</summary>
			/// <returns>string representing the startDate</returns>
			get
			{
				return  this.startDate;

			}
			/// <summary>The method to set the value to startDate</summary>
			/// <param name="startDate">string</param>
			set
			{
				 this.startDate=value;

				 this.keyModified["start_date"] = 1;

			}
		}

		public bool? Primary
		{
			/// <summary>The method to get the primary</summary>
			/// <returns>bool? representing the primary</returns>
			get
			{
				return  this.primary;

			}
			/// <summary>The method to set the value to primary</summary>
			/// <param name="primary">bool?</param>
			set
			{
				 this.primary=value;

				 this.keyModified["primary"] = 1;

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