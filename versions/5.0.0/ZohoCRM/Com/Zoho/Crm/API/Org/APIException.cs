using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Org
{

	public class APIException : Model, ResponseHandler, ActionHandler
	{
		private Choice<string> status;
		private Choice<string> code;
		private Choice<string> message;
		private Dictionary<string, object> details;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();
		private string apiName;
		private string jsonPath;
		private List<Feature> features;

		public Choice<string> Status
		{
			/// <summary>The method to get the status</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.status;

			}
			/// <summary>The method to set the value to status</summary>
			/// <param name="status">Instance of Choice<string></param>
			set
			{
				 this.status=value;

				 this.keyModified["status"] = 1;

			}
		}

		public Choice<string> Code
		{
			/// <summary>The method to get the code</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.code;

			}
			/// <summary>The method to set the value to code</summary>
			/// <param name="code">Instance of Choice<string></param>
			set
			{
				 this.code=value;

				 this.keyModified["code"] = 1;

			}
		}

		public Choice<string> Message
		{
			/// <summary>The method to get the message</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.message;

			}
			/// <summary>The method to set the value to message</summary>
			/// <param name="message">Instance of Choice<string></param>
			set
			{
				 this.message=value;

				 this.keyModified["message"] = 1;

			}
		}

		public Dictionary<string, object> Details
		{
			/// <summary>The method to get the details</summary>
			/// <returns>Dictionary representing the details<String,Object></returns>
			get
			{
				return  this.details;

			}
			/// <summary>The method to set the value to details</summary>
			/// <param name="details">Dictionary<string,object></param>
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

		public string JsonPath
		{
			/// <summary>The method to get the jsonPath</summary>
			/// <returns>string representing the jsonPath</returns>
			get
			{
				return  this.jsonPath;

			}
			/// <summary>The method to set the value to jsonPath</summary>
			/// <param name="jsonPath">string</param>
			set
			{
				 this.jsonPath=value;

				 this.keyModified["json_path"] = 1;

			}
		}

		public List<Feature> Features
		{
			/// <summary>The method to get the features</summary>
			/// <returns>Instance of List<Feature></returns>
			get
			{
				return  this.features;

			}
			/// <summary>The method to set the value to features</summary>
			/// <param name="features">Instance of List<Feature></param>
			set
			{
				 this.features=value;

				 this.keyModified["features"] = 1;

			}
		}


	}
}