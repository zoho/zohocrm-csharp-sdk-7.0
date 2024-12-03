using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.RelatedLists
{

	public class RelatedList : Model
	{
		private long? id;
		private string sequenceNumber;
		private string displayLabel;
		private string apiName;
		private ModuleMap module;
		private string name;
		private string action;
		private string href;
		private string type;
		private string connectedmodule;
		private string linkingmodule;
		private bool? visible;
		private bool? customizeSort;
		private bool? customizeFields;
		private bool? customizeDisplayLabel;
		private Field sortBy;
		private string sortOrder;
		private List<Field> fields;
		private Choice<string> status;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public string SequenceNumber
		{
			/// <summary>The method to get the sequenceNumber</summary>
			/// <returns>string representing the sequenceNumber</returns>
			get
			{
				return  this.sequenceNumber;

			}
			/// <summary>The method to set the value to sequenceNumber</summary>
			/// <param name="sequenceNumber">string</param>
			set
			{
				 this.sequenceNumber=value;

				 this.keyModified["sequence_number"] = 1;

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

		public ModuleMap Module
		{
			/// <summary>The method to get the module</summary>
			/// <returns>Instance of ModuleMap</returns>
			get
			{
				return  this.module;

			}
			/// <summary>The method to set the value to module</summary>
			/// <param name="module">Instance of ModuleMap</param>
			set
			{
				 this.module=value;

				 this.keyModified["module"] = 1;

			}
		}

		public string Name
		{
			/// <summary>The method to get the name</summary>
			/// <returns>string representing the name</returns>
			get
			{
				return  this.name;

			}
			/// <summary>The method to set the value to name</summary>
			/// <param name="name">string</param>
			set
			{
				 this.name=value;

				 this.keyModified["name"] = 1;

			}
		}

		public string Action
		{
			/// <summary>The method to get the action</summary>
			/// <returns>string representing the action</returns>
			get
			{
				return  this.action;

			}
			/// <summary>The method to set the value to action</summary>
			/// <param name="action">string</param>
			set
			{
				 this.action=value;

				 this.keyModified[Constants.REQUEST_CATEGORY_ACTION] = 1;

			}
		}

		public string Href
		{
			/// <summary>The method to get the href</summary>
			/// <returns>string representing the href</returns>
			get
			{
				return  this.href;

			}
			/// <summary>The method to set the value to href</summary>
			/// <param name="href">string</param>
			set
			{
				 this.href=value;

				 this.keyModified["href"] = 1;

			}
		}

		public string Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>string representing the type</returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">string</param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

		public string Connectedmodule
		{
			/// <summary>The method to get the connectedmodule</summary>
			/// <returns>string representing the connectedmodule</returns>
			get
			{
				return  this.connectedmodule;

			}
			/// <summary>The method to set the value to connectedmodule</summary>
			/// <param name="connectedmodule">string</param>
			set
			{
				 this.connectedmodule=value;

				 this.keyModified["connectedmodule"] = 1;

			}
		}

		public string Linkingmodule
		{
			/// <summary>The method to get the linkingmodule</summary>
			/// <returns>string representing the linkingmodule</returns>
			get
			{
				return  this.linkingmodule;

			}
			/// <summary>The method to set the value to linkingmodule</summary>
			/// <param name="linkingmodule">string</param>
			set
			{
				 this.linkingmodule=value;

				 this.keyModified["linkingmodule"] = 1;

			}
		}

		public bool? Visible
		{
			/// <summary>The method to get the visible</summary>
			/// <returns>bool? representing the visible</returns>
			get
			{
				return  this.visible;

			}
			/// <summary>The method to set the value to visible</summary>
			/// <param name="visible">bool?</param>
			set
			{
				 this.visible=value;

				 this.keyModified["visible"] = 1;

			}
		}

		public bool? CustomizeSort
		{
			/// <summary>The method to get the customizeSort</summary>
			/// <returns>bool? representing the customizeSort</returns>
			get
			{
				return  this.customizeSort;

			}
			/// <summary>The method to set the value to customizeSort</summary>
			/// <param name="customizeSort">bool?</param>
			set
			{
				 this.customizeSort=value;

				 this.keyModified["customize_sort"] = 1;

			}
		}

		public bool? CustomizeFields
		{
			/// <summary>The method to get the customizeFields</summary>
			/// <returns>bool? representing the customizeFields</returns>
			get
			{
				return  this.customizeFields;

			}
			/// <summary>The method to set the value to customizeFields</summary>
			/// <param name="customizeFields">bool?</param>
			set
			{
				 this.customizeFields=value;

				 this.keyModified["customize_fields"] = 1;

			}
		}

		public bool? CustomizeDisplayLabel
		{
			/// <summary>The method to get the customizeDisplayLabel</summary>
			/// <returns>bool? representing the customizeDisplayLabel</returns>
			get
			{
				return  this.customizeDisplayLabel;

			}
			/// <summary>The method to set the value to customizeDisplayLabel</summary>
			/// <param name="customizeDisplayLabel">bool?</param>
			set
			{
				 this.customizeDisplayLabel=value;

				 this.keyModified["customize_display_label"] = 1;

			}
		}

		public Field SortBy
		{
			/// <summary>The method to get the sortBy</summary>
			/// <returns>Instance of Field</returns>
			get
			{
				return  this.sortBy;

			}
			/// <summary>The method to set the value to sortBy</summary>
			/// <param name="sortBy">Instance of Field</param>
			set
			{
				 this.sortBy=value;

				 this.keyModified["sort_by"] = 1;

			}
		}

		public string SortOrder
		{
			/// <summary>The method to get the sortOrder</summary>
			/// <returns>string representing the sortOrder</returns>
			get
			{
				return  this.sortOrder;

			}
			/// <summary>The method to set the value to sortOrder</summary>
			/// <param name="sortOrder">string</param>
			set
			{
				 this.sortOrder=value;

				 this.keyModified["sort_order"] = 1;

			}
		}

		public List<Field> Fields
		{
			/// <summary>The method to get the fields</summary>
			/// <returns>Instance of List<Field></returns>
			get
			{
				return  this.fields;

			}
			/// <summary>The method to set the value to fields</summary>
			/// <param name="fields">Instance of List<Field></param>
			set
			{
				 this.fields=value;

				 this.keyModified["fields"] = 1;

			}
		}

		public Choice<string> Status
		{
			/// <summary>The method to get the status</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.status;

			}
			/// <summary>The method to set the value to status</summary>
			/// <param name="status">Instance of Choice<string></param>
			set
			{
				 this.status=value;

				 this.keyModified["status"] = 1;

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