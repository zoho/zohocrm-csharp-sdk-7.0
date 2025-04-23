using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Fields
{

	public class OperationType : Model
	{
		private bool? webUpdate;
		private bool? apiCreate;
		private bool? webCreate;
		private bool? apiUpdate;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? WebUpdate
		{
			/// <summary>The method to get the webUpdate</summary>
			/// <returns>bool? representing the webUpdate</returns>
			get
			{
				return  this.webUpdate;

			}
			/// <summary>The method to set the value to webUpdate</summary>
			/// <param name="webUpdate">bool?</param>
			set
			{
				 this.webUpdate=value;

				 this.keyModified["web_update"] = 1;

			}
		}

		public bool? APICreate
		{
			/// <summary>The method to get the aPICreate</summary>
			/// <returns>bool? representing the apiCreate</returns>
			get
			{
				return  this.apiCreate;

			}
			/// <summary>The method to set the value to aPICreate</summary>
			/// <param name="apiCreate">bool?</param>
			set
			{
				 this.apiCreate=value;

				 this.keyModified["api_create"] = 1;

			}
		}

		public bool? WebCreate
		{
			/// <summary>The method to get the webCreate</summary>
			/// <returns>bool? representing the webCreate</returns>
			get
			{
				return  this.webCreate;

			}
			/// <summary>The method to set the value to webCreate</summary>
			/// <param name="webCreate">bool?</param>
			set
			{
				 this.webCreate=value;

				 this.keyModified["web_create"] = 1;

			}
		}

		public bool? APIUpdate
		{
			/// <summary>The method to get the aPIUpdate</summary>
			/// <returns>bool? representing the apiUpdate</returns>
			get
			{
				return  this.apiUpdate;

			}
			/// <summary>The method to set the value to aPIUpdate</summary>
			/// <param name="apiUpdate">bool?</param>
			set
			{
				 this.apiUpdate=value;

				 this.keyModified["api_update"] = 1;

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