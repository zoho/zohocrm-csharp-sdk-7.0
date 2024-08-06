using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.GlobalPicklists
{

	public class ReplacedResponseWrapper : Model, ReplacedResponseHandler
	{
		private List<ReplacedValue> replacedValues;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<ReplacedValue> ReplacedValues
		{
			/// <summary>The method to get the replacedValues</summary>
			/// <returns>Instance of List<ReplacedValue></returns>
			get
			{
				return  this.replacedValues;

			}
			/// <summary>The method to set the value to replacedValues</summary>
			/// <param name="replacedValues">Instance of List<ReplacedValue></param>
			set
			{
				 this.replacedValues=value;

				 this.keyModified["replaced_values"] = 1;

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