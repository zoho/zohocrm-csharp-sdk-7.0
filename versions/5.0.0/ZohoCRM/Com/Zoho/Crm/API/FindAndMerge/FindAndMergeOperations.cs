using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.FindAndMerge
{

	public class FindAndMergeOperations
	{
		private long? masterrecordid;
		private string module;

		/// <summary>		/// Creates an instance of FindAndMergeOperations with the given parameters
		/// <param name="module">string</param>
		/// <param name="masterrecordid">long?</param>
		
		public FindAndMergeOperations(string module, long? masterrecordid)
		{
			 this.module=module;

			 this.masterrecordid=masterrecordid;


		}

		/// <summary>The method to get record merge</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetRecordMerge(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.module.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.masterrecordid.ToString());

			apiPath=string.Concat(apiPath, "/actions/merge");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to merge records</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> MergeRecords(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.module.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.masterrecordid.ToString());

			apiPath=string.Concat(apiPath, "/actions/merge");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


		public static class GetRecordMergeParam
		{
			public static readonly Param<long?> JOB_ID=new Param<long?>("job_id", "com.zoho.crm.api.FindAndMerge.GetRecordMergeParam");
		}

	}
}