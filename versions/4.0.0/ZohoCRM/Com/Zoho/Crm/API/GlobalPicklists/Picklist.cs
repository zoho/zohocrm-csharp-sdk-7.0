using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.GlobalPicklists
{

	public class Picklist : Model
	{
		private string displayLabel;
		private DateTimeOffset? createdTime;
		private DateTimeOffset? modifiedTime;
		private long? id;
		private string apiName;
		private string actualLabel;
		private string description;
		private Users.MinifiedUser modifiedBy;
		private Users.MinifiedUser createdBy;
		private bool? presence;
		private bool? pickListValuesSortedLexically;
		private List<PickListValues> pickListValues;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public DateTimeOffset? CreatedTime
		{
			/// <summary>The method to get the createdTime</summary>
			/// <returns>DateTimeOffset? representing the createdTime</returns>
			get
			{
				return  this.createdTime;

			}
			/// <summary>The method to set the value to createdTime</summary>
			/// <param name="createdTime">DateTimeOffset?</param>
			set
			{
				 this.createdTime=value;

				 this.keyModified["created_time"] = 1;

			}
		}

		public DateTimeOffset? ModifiedTime
		{
			/// <summary>The method to get the modifiedTime</summary>
			/// <returns>DateTimeOffset? representing the modifiedTime</returns>
			get
			{
				return  this.modifiedTime;

			}
			/// <summary>The method to set the value to modifiedTime</summary>
			/// <param name="modifiedTime">DateTimeOffset?</param>
			set
			{
				 this.modifiedTime=value;

				 this.keyModified["modified_time"] = 1;

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

		public string ActualLabel
		{
			/// <summary>The method to get the actualLabel</summary>
			/// <returns>string representing the actualLabel</returns>
			get
			{
				return  this.actualLabel;

			}
			/// <summary>The method to set the value to actualLabel</summary>
			/// <param name="actualLabel">string</param>
			set
			{
				 this.actualLabel=value;

				 this.keyModified["actual_label"] = 1;

			}
		}

		public string Description
		{
			/// <summary>The method to get the description</summary>
			/// <returns>string representing the description</returns>
			get
			{
				return  this.description;

			}
			/// <summary>The method to set the value to description</summary>
			/// <param name="description">string</param>
			set
			{
				 this.description=value;

				 this.keyModified["description"] = 1;

			}
		}

		public Users.MinifiedUser ModifiedBy
		{
			/// <summary>The method to get the modifiedBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.modifiedBy;

			}
			/// <summary>The method to set the value to modifiedBy</summary>
			/// <param name="modifiedBy">Instance of MinifiedUser</param>
			set
			{
				 this.modifiedBy=value;

				 this.keyModified["modified_by"] = 1;

			}
		}

		public Users.MinifiedUser CreatedBy
		{
			/// <summary>The method to get the createdBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.createdBy;

			}
			/// <summary>The method to set the value to createdBy</summary>
			/// <param name="createdBy">Instance of MinifiedUser</param>
			set
			{
				 this.createdBy=value;

				 this.keyModified["created_by"] = 1;

			}
		}

		public bool? Presence
		{
			/// <summary>The method to get the presence</summary>
			/// <returns>bool? representing the presence</returns>
			get
			{
				return  this.presence;

			}
			/// <summary>The method to set the value to presence</summary>
			/// <param name="presence">bool?</param>
			set
			{
				 this.presence=value;

				 this.keyModified["presence"] = 1;

			}
		}

		public bool? PickListValuesSortedLexically
		{
			/// <summary>The method to get the pickListValuesSortedLexically</summary>
			/// <returns>bool? representing the pickListValuesSortedLexically</returns>
			get
			{
				return  this.pickListValuesSortedLexically;

			}
			/// <summary>The method to set the value to pickListValuesSortedLexically</summary>
			/// <param name="pickListValuesSortedLexically">bool?</param>
			set
			{
				 this.pickListValuesSortedLexically=value;

				 this.keyModified["pick_list_values_sorted_lexically"] = 1;

			}
		}

		public List<PickListValues> PickListValues
		{
			/// <summary>The method to get the pickListValues</summary>
			/// <returns>Instance of List<PickListValues></returns>
			get
			{
				return  this.pickListValues;

			}
			/// <summary>The method to set the value to pickListValues</summary>
			/// <param name="pickListValues">Instance of List<PickListValues></param>
			set
			{
				 this.pickListValues=value;

				 this.keyModified["pick_list_values"] = 1;

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