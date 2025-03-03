using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.MassDeleteTags
{

	public class MassDeleteTagsOperations
	{
		/// <summary>The method to mass delete tags</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionResponse></returns>
		public APIResponse<ActionResponse> MassDeleteTags(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/tags/actions/mass_delete");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			return handlerInstance.APICall<ActionResponse>(typeof(ActionResponse), "application/json");


		}

		/// <summary>The method to get status</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<StatusResponseHandler></returns>
		public APIResponse<StatusResponseHandler> GetStatus(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/tags/actions/mass_delete");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<StatusResponseHandler>(typeof(StatusResponseHandler), "application/json");


		}


		public static class GetStatusParam
		{
			public static readonly Param<string> JOB_ID=new Param<string>("job_id", "com.zoho.crm.api.MassDeleteTags.GetStatusParam");
		}

	}
}