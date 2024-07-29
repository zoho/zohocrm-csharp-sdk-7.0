using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Features
{

	public class Component : Model
	{
		private string apiName;
		private bool? moduleSupported;
		private Detail details;
		private string featureLabel;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public bool? ModuleSupported
		{
			/// <summary>The method to get the moduleSupported</summary>
			/// <returns>bool? representing the moduleSupported</returns>
			get
			{
				return  this.moduleSupported;

			}
			/// <summary>The method to set the value to moduleSupported</summary>
			/// <param name="moduleSupported">bool?</param>
			set
			{
				 this.moduleSupported=value;

				 this.keyModified["module_supported"] = 1;

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

		public string FeatureLabel
		{
			/// <summary>The method to get the featureLabel</summary>
			/// <returns>string representing the featureLabel</returns>
			get
			{
				return  this.featureLabel;

			}
			/// <summary>The method to set the value to featureLabel</summary>
			/// <param name="featureLabel">string</param>
			set
			{
				 this.featureLabel=value;

				 this.keyModified["feature_label"] = 1;

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