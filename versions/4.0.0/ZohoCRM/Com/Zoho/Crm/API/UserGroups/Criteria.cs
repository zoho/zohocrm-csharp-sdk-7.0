using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserGroups
{

	public class Criteria : Model
	{
		private string comparator;
		private Field field;
		private Choice<string> groupOperator;
		private List<Criteria> group;
		private object value;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Comparator
		{
			/// <summary>The method to get the comparator</summary>
			/// <returns>string representing the comparator</returns>
			get
			{
				return  this.comparator;

			}
			/// <summary>The method to set the value to comparator</summary>
			/// <param name="comparator">string</param>
			set
			{
				 this.comparator=value;

				 this.keyModified["comparator"] = 1;

			}
		}

		public Field Field
		{
			/// <summary>The method to get the field</summary>
			/// <returns>Instance of Field</returns>
			get
			{
				return  this.field;

			}
			/// <summary>The method to set the value to field</summary>
			/// <param name="field">Instance of Field</param>
			set
			{
				 this.field=value;

				 this.keyModified["field"] = 1;

			}
		}

		public Choice<string> GroupOperator
		{
			/// <summary>The method to get the groupOperator</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.groupOperator;

			}
			/// <summary>The method to set the value to groupOperator</summary>
			/// <param name="groupOperator">Instance of Choice<string></param>
			set
			{
				 this.groupOperator=value;

				 this.keyModified["group_operator"] = 1;

			}
		}

		public List<Criteria> Group
		{
			/// <summary>The method to get the group</summary>
			/// <returns>Instance of List<Criteria></returns>
			get
			{
				return  this.group;

			}
			/// <summary>The method to set the value to group</summary>
			/// <param name="group">Instance of List<Criteria></param>
			set
			{
				 this.group=value;

				 this.keyModified["group"] = 1;

			}
		}

		public object Value
		{
			/// <summary>The method to get the value</summary>
			/// <returns>object representing the value</returns>
			get
			{
				return  this.value;

			}
			/// <summary>The method to set the value to value</summary>
			/// <param name="value">object</param>
			set
			{
				 this.value=value;

				 this.keyModified["value"] = 1;

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