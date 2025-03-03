using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Fields
{

	public class Expression : Model
	{
		private List<FunctionParameter> functionParameters;
		private RollupCriteria criteria;
		private string function;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<FunctionParameter> FunctionParameters
		{
			/// <summary>The method to get the functionParameters</summary>
			/// <returns>Instance of List<FunctionParameter></returns>
			get
			{
				return  this.functionParameters;

			}
			/// <summary>The method to set the value to functionParameters</summary>
			/// <param name="functionParameters">Instance of List<FunctionParameter></param>
			set
			{
				 this.functionParameters=value;

				 this.keyModified["function_parameters"] = 1;

			}
		}

		public RollupCriteria Criteria
		{
			/// <summary>The method to get the criteria</summary>
			/// <returns>Instance of RollupCriteria</returns>
			get
			{
				return  this.criteria;

			}
			/// <summary>The method to set the value to criteria</summary>
			/// <param name="criteria">Instance of RollupCriteria</param>
			set
			{
				 this.criteria=value;

				 this.keyModified["criteria"] = 1;

			}
		}

		public string Function
		{
			/// <summary>The method to get the function</summary>
			/// <returns>string representing the function</returns>
			get
			{
				return  this.function;

			}
			/// <summary>The method to set the value to function</summary>
			/// <param name="function">string</param>
			set
			{
				 this.function=value;

				 this.keyModified["function"] = 1;

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