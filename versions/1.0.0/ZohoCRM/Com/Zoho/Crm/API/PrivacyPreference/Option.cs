using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PrivacyPreference
{

	public class Option : Model
	{
		private string name;
		private string tooltip;
		private string type;
		private List<string> suboptions;
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

		public List<string> Suboptions
		{
			/// <summary>The method to get the suboptions</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.suboptions;

			}
			/// <summary>The method to set the value to suboptions</summary>
			/// <param name="suboptions">Instance of List<string></param>
			set
			{
				 this.suboptions=value;

				 this.keyModified["suboptions"] = 1;

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