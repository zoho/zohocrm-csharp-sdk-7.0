using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Pipeline
{

	public class TransferPipelineActionWrapper : Model, TransferPipelineActionHandler
	{
		private List<TransferPipelineActionResponse> transferPipeline;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<TransferPipelineActionResponse> TransferPipeline
		{
			/// <summary>The method to get the transferPipeline</summary>
			/// <returns>Instance of List<TransferPipelineActionResponse></returns>
			get
			{
				return  this.transferPipeline;

			}
			/// <summary>The method to set the value to transferPipeline</summary>
			/// <param name="transferPipeline">Instance of List<TransferPipelineActionResponse></param>
			set
			{
				 this.transferPipeline=value;

				 this.keyModified["transfer_pipeline"] = 1;

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