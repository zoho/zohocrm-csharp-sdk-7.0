using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PrivacyPreference
{

	public class Section : Model
	{
		private string name;
		private string tooltip;
		private string showType;
		private string title;
		private List<Option> options;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public string Tooltip
		{
			/// <summary>The method to get the tooltip</summary>
			/// <returns>string representing the tooltip</returns>
			get
			{
				return  this.tooltip;

			}
			/// <summary>The method to set the value to tooltip</summary>
			/// <param name="tooltip">string</param>
			set
			{
				 this.tooltip=value;

				 this.keyModified["tooltip"] = 1;

			}
		}

		public string ShowType
		{
			/// <summary>The method to get the showType</summary>
			/// <returns>string representing the showType</returns>
			get
			{
				return  this.showType;

			}
			/// <summary>The method to set the value to showType</summary>
			/// <param name="showType">string</param>
			set
			{
				 this.showType=value;

				 this.keyModified["show_type"] = 1;

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

		public List<Option> Options
		{
			/// <summary>The method to get the options</summary>
			/// <returns>Instance of List<Option></returns>
			get
			{
				return  this.options;

			}
			/// <summary>The method to set the value to options</summary>
			/// <param name="options">Instance of List<Option></param>
			set
			{
				 this.options=value;

				 this.keyModified["options"] = 1;

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