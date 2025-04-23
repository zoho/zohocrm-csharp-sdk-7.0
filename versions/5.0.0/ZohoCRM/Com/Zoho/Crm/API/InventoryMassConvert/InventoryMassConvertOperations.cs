using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.InventoryMassConvert
{

	public class InventoryMassConvertOperations
	{
		private string moduleAPIName;

		/// <summary>		/// Creates an instance of InventoryMassConvertOperations with the given parameters
		/// <param name="moduleAPIName">string</param>
		
		public InventoryMassConvertOperations(string moduleAPIName)
		{
			 this.moduleAPIName=moduleAPIName;


		}

		/// <summary>The method to mass inventory convert</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionResponse></returns>
		public APIResponse<ActionResponse> MassInventoryConvert(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.moduleAPIName.ToString());

			apiPath=string.Concat(apiPath, "/actions/mass_convert");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<ActionResponse>(typeof(ActionResponse), "application/json");


		}

		/// <summary>The method to get scheduled jobs details</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetScheduledJobsDetails(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.moduleAPIName.ToString());

			apiPath=string.Concat(apiPath, "/actions/mass_convert");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetScheduledJobsDetailsParam
		{
			public static readonly Param<long?> JOB_ID=new Param<long?>("job_id", "com.zoho.crm.api.InventoryMassConvert.GetScheduledJobsDetailsParam");
		}

	}
}