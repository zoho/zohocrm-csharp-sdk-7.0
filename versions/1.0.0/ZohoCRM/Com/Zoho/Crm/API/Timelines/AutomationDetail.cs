using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Timelines
{

	public class AutomationDetail : Model
	{
		private string type;
		private NameIdStructure rule;
		private PathFinder pathfinder;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public NameIdStructure Rule
		{
			/// <summary>The method to get the rule</summary>
			/// <returns>Instance of NameIdStructure</returns>
			get
			{
				return  this.rule;

			}
			/// <summary>The method to set the value to rule</summary>
			/// <param name="rule">Instance of NameIdStructure</param>
			set
			{
				 this.rule=value;

				 this.keyModified["rule"] = 1;

			}
		}

		public PathFinder Pathfinder
		{
			/// <summary>The method to get the pathfinder</summary>
			/// <returns>Instance of PathFinder</returns>
			get
			{
				return  this.pathfinder;

			}
			/// <summary>The method to set the value to pathfinder</summary>
			/// <param name="pathfinder">Instance of PathFinder</param>
			set
			{
				 this.pathfinder=value;

				 this.keyModified["pathfinder"] = 1;

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