using Com.Zoho.Crm.API.Modules;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.BulkRead
{

	public class Query : Model
	{
		private Modules.MinifiedModule module;
		private long? cvid;
		private List<string> fields;
		private int? page;
		private Criteria criteria;
		private Choice<string> fileType;
		private string pageToken;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Modules.MinifiedModule Module
		{
			/// <summary>The method to get the module</summary>
			/// <returns>Instance of MinifiedModule</returns>
			get
			{
				return  this.module;

			}
			/// <summary>The method to set the value to module</summary>
			/// <param name="module">Instance of MinifiedModule</param>
			set
			{
				 this.module=value;

				 this.keyModified["module"] = 1;

			}
		}

		public long? Cvid
		{
			/// <summary>The method to get the cvid</summary>
			/// <returns>long? representing the cvid</returns>
			get
			{
				return  this.cvid;

			}
			/// <summary>The method to set the value to cvid</summary>
			/// <param name="cvid">long?</param>
			set
			{
				 this.cvid=value;

				 this.keyModified["cvid"] = 1;

			}
		}

		public List<string> Fields
		{
			/// <summary>The method to get the fields</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.fields;

			}
			/// <summary>The method to set the value to fields</summary>
			/// <param name="fields">Instance of List<string></param>
			set
			{
				 this.fields=value;

				 this.keyModified["fields"] = 1;

			}
		}

		public int? Page
		{
			/// <summary>The method to get the page</summary>
			/// <returns>int? representing the page</returns>
			get
			{
				return  this.page;

			}
			/// <summary>The method to set the value to page</summary>
			/// <param name="page">int?</param>
			set
			{
				 this.page=value;

				 this.keyModified["page"] = 1;

			}
		}

		public Criteria Criteria
		{
			/// <summary>The method to get the criteria</summary>
			/// <returns>Instance of Criteria</returns>
			get
			{
				return  this.criteria;

			}
			/// <summary>The method to set the value to criteria</summary>
			/// <param name="criteria">Instance of Criteria</param>
			set
			{
				 this.criteria=value;

				 this.keyModified["criteria"] = 1;

			}
		}

		public Choice<string> FileType
		{
			/// <summary>The method to get the fileType</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.fileType;

			}
			/// <summary>The method to set the value to fileType</summary>
			/// <param name="fileType">Instance of Choice<string></param>
			set
			{
				 this.fileType=value;

				 this.keyModified["file_type"] = 1;

			}
		}

		public string PageToken
		{
			/// <summary>The method to get the pageToken</summary>
			/// <returns>string representing the pageToken</returns>
			get
			{
				return  this.pageToken;

			}
			/// <summary>The method to set the value to pageToken</summary>
			/// <param name="pageToken">string</param>
			set
			{
				 this.pageToken=value;

				 this.keyModified["page_token"] = 1;

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