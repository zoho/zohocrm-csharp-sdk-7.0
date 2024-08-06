using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.BulkWrite
{

	public class RequestWrapper : Model
	{
		private string characterEncoding;
		private Choice<string> operation;
		private CallBack callback;
		private List<Resource> resource;
		private bool? ignoreEmpty;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string CharacterEncoding
		{
			/// <summary>The method to get the characterEncoding</summary>
			/// <returns>string representing the characterEncoding</returns>
			get
			{
				return  this.characterEncoding;

			}
			/// <summary>The method to set the value to characterEncoding</summary>
			/// <param name="characterEncoding">string</param>
			set
			{
				 this.characterEncoding=value;

				 this.keyModified["character_encoding"] = 1;

			}
		}

		public Choice<string> Operation
		{
			/// <summary>The method to get the operation</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.operation;

			}
			/// <summary>The method to set the value to operation</summary>
			/// <param name="operation">Instance of Choice<string></param>
			set
			{
				 this.operation=value;

				 this.keyModified["operation"] = 1;

			}
		}

		public CallBack Callback
		{
			/// <summary>The method to get the callback</summary>
			/// <returns>Instance of CallBack</returns>
			get
			{
				return  this.callback;

			}
			/// <summary>The method to set the value to callback</summary>
			/// <param name="callback">Instance of CallBack</param>
			set
			{
				 this.callback=value;

				 this.keyModified["callback"] = 1;

			}
		}

		public List<Resource> Resource
		{
			/// <summary>The method to get the resource</summary>
			/// <returns>Instance of List<Resource></returns>
			get
			{
				return  this.resource;

			}
			/// <summary>The method to set the value to resource</summary>
			/// <param name="resource">Instance of List<Resource></param>
			set
			{
				 this.resource=value;

				 this.keyModified["resource"] = 1;

			}
		}

		public bool? IgnoreEmpty
		{
			/// <summary>The method to get the ignoreEmpty</summary>
			/// <returns>bool? representing the ignoreEmpty</returns>
			get
			{
				return  this.ignoreEmpty;

			}
			/// <summary>The method to set the value to ignoreEmpty</summary>
			/// <param name="ignoreEmpty">bool?</param>
			set
			{
				 this.ignoreEmpty=value;

				 this.keyModified["ignore_empty"] = 1;

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