using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserGroups
{

	public class Sources : Model
	{
		private Choice<string> type;
		private Source source;
		private bool? subordinates;
		private bool? subTerritories;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Choice<string> Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">Instance of Choice<string></param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

		public Source Source
		{
			/// <summary>The method to get the source</summary>
			/// <returns>Instance of Source</returns>
			get
			{
				return  this.source;

			}
			/// <summary>The method to set the value to source</summary>
			/// <param name="source">Instance of Source</param>
			set
			{
				 this.source=value;

				 this.keyModified["source"] = 1;

			}
		}

		public bool? Subordinates
		{
			/// <summary>The method to get the subordinates</summary>
			/// <returns>bool? representing the subordinates</returns>
			get
			{
				return  this.subordinates;

			}
			/// <summary>The method to set the value to subordinates</summary>
			/// <param name="subordinates">bool?</param>
			set
			{
				 this.subordinates=value;

				 this.keyModified["subordinates"] = 1;

			}
		}

		public bool? SubTerritories
		{
			/// <summary>The method to get the subTerritories</summary>
			/// <returns>bool? representing the subTerritories</returns>
			get
			{
				return  this.subTerritories;

			}
			/// <summary>The method to set the value to subTerritories</summary>
			/// <param name="subTerritories">bool?</param>
			set
			{
				 this.subTerritories=value;

				 this.keyModified["sub_territories"] = 1;

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