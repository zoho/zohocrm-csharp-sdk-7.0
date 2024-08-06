using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Webforms
{

	public class Fields : Model
	{
		private Layout layout;
		private string help;
		private Fields field;
		private Module module;
		private string secretKey;
		private string recaptchaLabel;
		private bool? hidden;
		private string siteKey;
		private bool? advanced;
		private string apiName;
		private string fieldLabel;
		private string theme;
		private long? id;
		private bool? required;
		private string fieldName;
		private string dateFormat;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Layout Layout
		{
			/// <summary>The method to get the layout</summary>
			/// <returns>Instance of Layout</returns>
			get
			{
				return  this.layout;

			}
			/// <summary>The method to set the value to layout</summary>
			/// <param name="layout">Instance of Layout</param>
			set
			{
				 this.layout=value;

				 this.keyModified["layout"] = 1;

			}
		}

		public string Help
		{
			/// <summary>The method to get the help</summary>
			/// <returns>string representing the help</returns>
			get
			{
				return  this.help;

			}
			/// <summary>The method to set the value to help</summary>
			/// <param name="help">string</param>
			set
			{
				 this.help=value;

				 this.keyModified["help"] = 1;

			}
		}

		public Fields Field
		{
			/// <summary>The method to get the field</summary>
			/// <returns>Instance of Fields</returns>
			get
			{
				return  this.field;

			}
			/// <summary>The method to set the value to field</summary>
			/// <param name="field">Instance of Fields</param>
			set
			{
				 this.field=value;

				 this.keyModified["field"] = 1;

			}
		}

		public Module Module
		{
			/// <summary>The method to get the module</summary>
			/// <returns>Instance of Module</returns>
			get
			{
				return  this.module;

			}
			/// <summary>The method to set the value to module</summary>
			/// <param name="module">Instance of Module</param>
			set
			{
				 this.module=value;

				 this.keyModified["module"] = 1;

			}
		}

		public string SecretKey
		{
			/// <summary>The method to get the secretKey</summary>
			/// <returns>string representing the secretKey</returns>
			get
			{
				return  this.secretKey;

			}
			/// <summary>The method to set the value to secretKey</summary>
			/// <param name="secretKey">string</param>
			set
			{
				 this.secretKey=value;

				 this.keyModified["secret_key"] = 1;

			}
		}

		public string RecaptchaLabel
		{
			/// <summary>The method to get the recaptchaLabel</summary>
			/// <returns>string representing the recaptchaLabel</returns>
			get
			{
				return  this.recaptchaLabel;

			}
			/// <summary>The method to set the value to recaptchaLabel</summary>
			/// <param name="recaptchaLabel">string</param>
			set
			{
				 this.recaptchaLabel=value;

				 this.keyModified["recaptcha_label"] = 1;

			}
		}

		public bool? Hidden
		{
			/// <summary>The method to get the hidden</summary>
			/// <returns>bool? representing the hidden</returns>
			get
			{
				return  this.hidden;

			}
			/// <summary>The method to set the value to hidden</summary>
			/// <param name="hidden">bool?</param>
			set
			{
				 this.hidden=value;

				 this.keyModified["hidden"] = 1;

			}
		}

		public string SiteKey
		{
			/// <summary>The method to get the siteKey</summary>
			/// <returns>string representing the siteKey</returns>
			get
			{
				return  this.siteKey;

			}
			/// <summary>The method to set the value to siteKey</summary>
			/// <param name="siteKey">string</param>
			set
			{
				 this.siteKey=value;

				 this.keyModified["site_key"] = 1;

			}
		}

		public bool? Advanced
		{
			/// <summary>The method to get the advanced</summary>
			/// <returns>bool? representing the advanced</returns>
			get
			{
				return  this.advanced;

			}
			/// <summary>The method to set the value to advanced</summary>
			/// <param name="advanced">bool?</param>
			set
			{
				 this.advanced=value;

				 this.keyModified["advanced"] = 1;

			}
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

		public string FieldLabel
		{
			/// <summary>The method to get the fieldLabel</summary>
			/// <returns>string representing the fieldLabel</returns>
			get
			{
				return  this.fieldLabel;

			}
			/// <summary>The method to set the value to fieldLabel</summary>
			/// <param name="fieldLabel">string</param>
			set
			{
				 this.fieldLabel=value;

				 this.keyModified["field_label"] = 1;

			}
		}

		public string Theme
		{
			/// <summary>The method to get the theme</summary>
			/// <returns>string representing the theme</returns>
			get
			{
				return  this.theme;

			}
			/// <summary>The method to set the value to theme</summary>
			/// <param name="theme">string</param>
			set
			{
				 this.theme=value;

				 this.keyModified["theme"] = 1;

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

		public bool? Required
		{
			/// <summary>The method to get the required</summary>
			/// <returns>bool? representing the required</returns>
			get
			{
				return  this.required;

			}
			/// <summary>The method to set the value to required</summary>
			/// <param name="required">bool?</param>
			set
			{
				 this.required=value;

				 this.keyModified["required"] = 1;

			}
		}

		public string FieldName
		{
			/// <summary>The method to get the fieldName</summary>
			/// <returns>string representing the fieldName</returns>
			get
			{
				return  this.fieldName;

			}
			/// <summary>The method to set the value to fieldName</summary>
			/// <param name="fieldName">string</param>
			set
			{
				 this.fieldName=value;

				 this.keyModified["field_name"] = 1;

			}
		}

		public string DateFormat
		{
			/// <summary>The method to get the dateFormat</summary>
			/// <returns>string representing the dateFormat</returns>
			get
			{
				return  this.dateFormat;

			}
			/// <summary>The method to set the value to dateFormat</summary>
			/// <param name="dateFormat">string</param>
			set
			{
				 this.dateFormat=value;

				 this.keyModified["date_format"] = 1;

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