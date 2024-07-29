using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Pipeline
{

	public class Pipeline : Model
	{
		private string displayValue;
		private bool? default1;
		private List<Maps> maps;
		private string actualValue;
		private long? id;
		private bool? childAvailable;
		private Pipeline parent;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string DisplayValue
		{
			/// <summary>The method to get the displayValue</summary>
			/// <returns>string representing the displayValue</returns>
			get
			{
				return  this.displayValue;

			}
			/// <summary>The method to set the value to displayValue</summary>
			/// <param name="displayValue">string</param>
			set
			{
				 this.displayValue=value;

				 this.keyModified["display_value"] = 1;

			}
		}

		public bool? Default
		{
			/// <summary>The method to get the default</summary>
			/// <returns>bool? representing the default1</returns>
			get
			{
				return  this.default1;

			}
			/// <summary>The method to set the value to default</summary>
			/// <param name="default1">bool?</param>
			set
			{
				 this.default1=value;

				 this.keyModified["default"] = 1;

			}
		}

		public List<Maps> Maps
		{
			/// <summary>The method to get the maps</summary>
			/// <returns>Instance of List<Maps></returns>
			get
			{
				return  this.maps;

			}
			/// <summary>The method to set the value to maps</summary>
			/// <param name="maps">Instance of List<Maps></param>
			set
			{
				 this.maps=value;

				 this.keyModified["maps"] = 1;

			}
		}

		public string ActualValue
		{
			/// <summary>The method to get the actualValue</summary>
			/// <returns>string representing the actualValue</returns>
			get
			{
				return  this.actualValue;

			}
			/// <summary>The method to set the value to actualValue</summary>
			/// <param name="actualValue">string</param>
			set
			{
				 this.actualValue=value;

				 this.keyModified["actual_value"] = 1;

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

		public bool? ChildAvailable
		{
			/// <summary>The method to get the childAvailable</summary>
			/// <returns>bool? representing the childAvailable</returns>
			get
			{
				return  this.childAvailable;

			}
			/// <summary>The method to set the value to childAvailable</summary>
			/// <param name="childAvailable">bool?</param>
			set
			{
				 this.childAvailable=value;

				 this.keyModified["child_available"] = 1;

			}
		}

		public Pipeline Parent
		{
			/// <summary>The method to get the parent</summary>
			/// <returns>Instance of Pipeline</returns>
			get
			{
				return  this.parent;

			}
			/// <summary>The method to set the value to parent</summary>
			/// <param name="parent">Instance of Pipeline</param>
			set
			{
				 this.parent=value;

				 this.keyModified["parent"] = 1;

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