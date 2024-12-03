using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.APIs
{

	public class SupportedAPI : Model
	{
		private string path;
		private List<OperationTypes> operationTypes;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Path
		{
			/// <summary>The method to get the path</summary>
			/// <returns>string representing the path</returns>
			get
			{
				return  this.path;

			}
			/// <summary>The method to set the value to path</summary>
			/// <param name="path">string</param>
			set
			{
				 this.path=value;

				 this.keyModified["path"] = 1;

			}
		}

		public List<OperationTypes> OperationTypes
		{
			/// <summary>The method to get the operationTypes</summary>
			/// <returns>Instance of List<OperationTypes></returns>
			get
			{
				return  this.operationTypes;

			}
			/// <summary>The method to set the value to operationTypes</summary>
			/// <param name="operationTypes">Instance of List<OperationTypes></param>
			set
			{
				 this.operationTypes=value;

				 this.keyModified["operation_types"] = 1;

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