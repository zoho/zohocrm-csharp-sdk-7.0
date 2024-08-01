using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Fields
{

	public class RollupSummary : Model
	{
		private string returnType;
		private Expression expression;
		private MinifiedField basedOnModule;
		private MinifiedField relatedList;
		private string rollupBasedOn;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string ReturnType
		{
			/// <summary>The method to get the returnType</summary>
			/// <returns>string representing the returnType</returns>
			get
			{
				return  this.returnType;

			}
			/// <summary>The method to set the value to returnType</summary>
			/// <param name="returnType">string</param>
			set
			{
				 this.returnType=value;

				 this.keyModified["return_type"] = 1;

			}
		}

		public Expression Expression
		{
			/// <summary>The method to get the expression</summary>
			/// <returns>Instance of Expression</returns>
			get
			{
				return  this.expression;

			}
			/// <summary>The method to set the value to expression</summary>
			/// <param name="expression">Instance of Expression</param>
			set
			{
				 this.expression=value;

				 this.keyModified["expression"] = 1;

			}
		}

		public MinifiedField BasedOnModule
		{
			/// <summary>The method to get the basedOnModule</summary>
			/// <returns>Instance of MinifiedField</returns>
			get
			{
				return  this.basedOnModule;

			}
			/// <summary>The method to set the value to basedOnModule</summary>
			/// <param name="basedOnModule">Instance of MinifiedField</param>
			set
			{
				 this.basedOnModule=value;

				 this.keyModified["based_on_module"] = 1;

			}
		}

		public MinifiedField RelatedList
		{
			/// <summary>The method to get the relatedList</summary>
			/// <returns>Instance of MinifiedField</returns>
			get
			{
				return  this.relatedList;

			}
			/// <summary>The method to set the value to relatedList</summary>
			/// <param name="relatedList">Instance of MinifiedField</param>
			set
			{
				 this.relatedList=value;

				 this.keyModified["related_list"] = 1;

			}
		}

		public string RollupBasedOn
		{
			/// <summary>The method to get the rollupBasedOn</summary>
			/// <returns>string representing the rollupBasedOn</returns>
			get
			{
				return  this.rollupBasedOn;

			}
			/// <summary>The method to set the value to rollupBasedOn</summary>
			/// <param name="rollupBasedOn">string</param>
			set
			{
				 this.rollupBasedOn=value;

				 this.keyModified["rollup_based_on"] = 1;

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