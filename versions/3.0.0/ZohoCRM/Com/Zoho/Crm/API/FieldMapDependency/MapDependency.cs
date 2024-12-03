using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.FieldMapDependency
{

	public class MapDependency : Model
	{
		private Parent parent;
		private Child child;
		private List<PickListMapping> pickListValues;
		private bool? internal1;
		private bool? active;
		private long? id;
		private int? source;
		private int? category;
		private SubModule subModule;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Parent Parent
		{
			/// <summary>The method to get the parent</summary>
			/// <returns>Instance of Parent</returns>
			get
			{
				return  this.parent;

			}
			/// <summary>The method to set the value to parent</summary>
			/// <param name="parent">Instance of Parent</param>
			set
			{
				 this.parent=value;

				 this.keyModified["parent"] = 1;

			}
		}

		public Child Child
		{
			/// <summary>The method to get the child</summary>
			/// <returns>Instance of Child</returns>
			get
			{
				return  this.child;

			}
			/// <summary>The method to set the value to child</summary>
			/// <param name="child">Instance of Child</param>
			set
			{
				 this.child=value;

				 this.keyModified["child"] = 1;

			}
		}

		public List<PickListMapping> PickListValues
		{
			/// <summary>The method to get the pickListValues</summary>
			/// <returns>Instance of List<PickListMapping></returns>
			get
			{
				return  this.pickListValues;

			}
			/// <summary>The method to set the value to pickListValues</summary>
			/// <param name="pickListValues">Instance of List<PickListMapping></param>
			set
			{
				 this.pickListValues=value;

				 this.keyModified["pick_list_values"] = 1;

			}
		}

		public bool? Internal
		{
			/// <summary>The method to get the internal</summary>
			/// <returns>bool? representing the internal1</returns>
			get
			{
				return  this.internal1;

			}
			/// <summary>The method to set the value to internal</summary>
			/// <param name="internal1">bool?</param>
			set
			{
				 this.internal1=value;

				 this.keyModified["internal"] = 1;

			}
		}

		public bool? Active
		{
			/// <summary>The method to get the active</summary>
			/// <returns>bool? representing the active</returns>
			get
			{
				return  this.active;

			}
			/// <summary>The method to set the value to active</summary>
			/// <param name="active">bool?</param>
			set
			{
				 this.active=value;

				 this.keyModified["active"] = 1;

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

		public int? Source
		{
			/// <summary>The method to get the source</summary>
			/// <returns>int? representing the source</returns>
			get
			{
				return  this.source;

			}
			/// <summary>The method to set the value to source</summary>
			/// <param name="source">int?</param>
			set
			{
				 this.source=value;

				 this.keyModified["source"] = 1;

			}
		}

		public int? Category
		{
			/// <summary>The method to get the category</summary>
			/// <returns>int? representing the category</returns>
			get
			{
				return  this.category;

			}
			/// <summary>The method to set the value to category</summary>
			/// <param name="category">int?</param>
			set
			{
				 this.category=value;

				 this.keyModified["category"] = 1;

			}
		}

		public SubModule SubModule
		{
			/// <summary>The method to get the subModule</summary>
			/// <returns>Instance of SubModule</returns>
			get
			{
				return  this.subModule;

			}
			/// <summary>The method to set the value to subModule</summary>
			/// <param name="subModule">Instance of SubModule</param>
			set
			{
				 this.subModule=value;

				 this.keyModified["sub_module"] = 1;

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