using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Pipeline
{

	public class TransferPipeline : Model
	{
		private TPipeline pipeline;
		private List<Stages> stages;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public TPipeline Pipeline
		{
			/// <summary>The method to get the pipeline</summary>
			/// <returns>Instance of TPipeline</returns>
			get
			{
				return  this.pipeline;

			}
			/// <summary>The method to set the value to pipeline</summary>
			/// <param name="pipeline">Instance of TPipeline</param>
			set
			{
				 this.pipeline=value;

				 this.keyModified["pipeline"] = 1;

			}
		}

		public List<Stages> Stages
		{
			/// <summary>The method to get the stages</summary>
			/// <returns>Instance of List<Stages></returns>
			get
			{
				return  this.stages;

			}
			/// <summary>The method to set the value to stages</summary>
			/// <param name="stages">Instance of List<Stages></param>
			set
			{
				 this.stages=value;

				 this.keyModified["stages"] = 1;

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