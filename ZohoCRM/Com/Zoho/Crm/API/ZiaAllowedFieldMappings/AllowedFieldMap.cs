using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaAllowedFieldMappings
{

	public class AllowedFieldMap : Model
	{
		private List<AllowedOutputData> outputDataFieldMapping;
		private List<AllowedOutputData> inputDataFieldMapping;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<AllowedOutputData> OutputDataFieldMapping
		{
			/// <summary>The method to get the outputDataFieldMapping</summary>
			/// <returns>Instance of List<AllowedOutputData></returns>
			get
			{
				return  this.outputDataFieldMapping;

			}
			/// <summary>The method to set the value to outputDataFieldMapping</summary>
			/// <param name="outputDataFieldMapping">Instance of List<AllowedOutputData></param>
			set
			{
				 this.outputDataFieldMapping=value;

				 this.keyModified["output_data_field_mapping"] = 1;

			}
		}

		public List<AllowedOutputData> InputDataFieldMapping
		{
			/// <summary>The method to get the inputDataFieldMapping</summary>
			/// <returns>Instance of List<AllowedOutputData></returns>
			get
			{
				return  this.inputDataFieldMapping;

			}
			/// <summary>The method to set the value to inputDataFieldMapping</summary>
			/// <param name="inputDataFieldMapping">Instance of List<AllowedOutputData></param>
			set
			{
				 this.inputDataFieldMapping=value;

				 this.keyModified["input_data_field_mapping"] = 1;

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