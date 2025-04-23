using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Definition
{

	public class Definition : Model
	{
		private string rootElementName;
		private Dictionary<string, object> extradetails;
		private List<Property> properties;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string RootElementName
		{
			/// <summary>The method to get the rootElementName</summary>
			/// <returns>string representing the rootElementName</returns>
			get
			{
				return  this.rootElementName;

			}
			/// <summary>The method to set the value to rootElementName</summary>
			/// <param name="rootElementName">string</param>
			set
			{
				 this.rootElementName=value;

				 this.keyModified["root_element_name"] = 1;

			}
		}

		public Dictionary<string, object> Extradetails
		{
			/// <summary>The method to get the extradetails</summary>
			/// <returns>Dictionary representing the extradetails<String,Object></returns>
			get
			{
				return  this.extradetails;

			}
			/// <summary>The method to set the value to extradetails</summary>
			/// <param name="extradetails">Dictionary<string,object></param>
			set
			{
				 this.extradetails=value;

				 this.keyModified["extraDetails"] = 1;

			}
		}

		public List<Property> Properties
		{
			/// <summary>The method to get the properties</summary>
			/// <returns>Instance of List<Property></returns>
			get
			{
				return  this.properties;

			}
			/// <summary>The method to set the value to properties</summary>
			/// <param name="properties">Instance of List<Property></param>
			set
			{
				 this.properties=value;

				 this.keyModified["properties"] = 1;

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