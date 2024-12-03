using Com.Zoho.Crm.API.Fields;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Modules
{

	public class ModuleFieldLookup : Fields.Lookup , Model
	{
		private Fields.QueryDetails queryDetails;
		private MinifiedModule module;
		private string displayLabel;
		private string apiName;
		private long? id;
		private bool? revalidateFilterDuringEdit;
		private List<Fields.ShowFields> showFields;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Fields.QueryDetails QueryDetails
		{
			/// <summary>The method to get the queryDetails</summary>
			/// <returns>Instance of QueryDetails</returns>
			get
			{
				return  this.queryDetails;

			}
			/// <summary>The method to set the value to queryDetails</summary>
			/// <param name="queryDetails">Instance of QueryDetails</param>
			set
			{
				 this.queryDetails=value;

				 this.keyModified["query_details"] = 1;

			}
		}

		public MinifiedModule Module
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

		public string DisplayLabel
		{
			/// <summary>The method to get the displayLabel</summary>
			/// <returns>string representing the displayLabel</returns>
			get
			{
				return  this.displayLabel;

			}
			/// <summary>The method to set the value to displayLabel</summary>
			/// <param name="displayLabel">string</param>
			set
			{
				 this.displayLabel=value;

				 this.keyModified["display_label"] = 1;

			}
		}

		public string APIName
		{
			/// <summary>The method to get the aPIName</summary>
			/// <returns>string representing the apiName</returns>
			get
			{
				return  this.apiName;

			}
			/// <summary>The method to set the value to aPIName</summary>
			/// <param name="apiName">string</param>
			set
			{
				 this.apiName=value;

				 this.keyModified["api_name"] = 1;

			}
		}

		public long? Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>long? representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">long?</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

			}
		}

		public bool? RevalidateFilterDuringEdit
		{
			/// <summary>The method to get the revalidateFilterDuringEdit</summary>
			/// <returns>bool? representing the revalidateFilterDuringEdit</returns>
			get
			{
				return  this.revalidateFilterDuringEdit;

			}
			/// <summary>The method to set the value to revalidateFilterDuringEdit</summary>
			/// <param name="revalidateFilterDuringEdit">bool?</param>
			set
			{
				 this.revalidateFilterDuringEdit=value;

				 this.keyModified["revalidate_filter_during_edit"] = 1;

			}
		}

		public List<Fields.ShowFields> ShowFields
		{
			/// <summary>The method to get the showFields</summary>
			/// <returns>Instance of List<ShowFields></returns>
			get
			{
				return  this.showFields;

			}
			/// <summary>The method to set the value to showFields</summary>
			/// <param name="showFields">Instance of List<ShowFields></param>
			set
			{
				 this.showFields=value;

				 this.keyModified["show_fields"] = 1;

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