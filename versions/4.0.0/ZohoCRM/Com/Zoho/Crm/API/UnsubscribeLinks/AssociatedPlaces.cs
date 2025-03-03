using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UnsubscribeLinks
{

	public class AssociatedPlaces : Model
	{
		private string type;
		private Resource resource;
		private Detail details;
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

		public Resource Resource
		{
			/// <summary>The method to get the resource</summary>
			/// <returns>Instance of Resource</returns>
			get
			{
				return  this.resource;

			}
			/// <summary>The method to set the value to resource</summary>
			/// <param name="resource">Instance of Resource</param>
			set
			{
				 this.resource=value;

				 this.keyModified["resource"] = 1;

			}
		}

		public Detail Details
		{
			/// <summary>The method to get the details</summary>
			/// <returns>Instance of Detail</returns>
			get
			{
				return  this.details;

			}
			/// <summary>The method to set the value to details</summary>
			/// <param name="details">Instance of Detail</param>
			set
			{
				 this.details=value;

				 this.keyModified["details"] = 1;

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