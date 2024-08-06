using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.Timelines
{

	public class TimelinesOperations
	{
		/// <summary>The method to get timelines</summary>
		/// <param name="module">string</param>
		/// <param name="recordId">string</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetTimelines(string module, string recordId, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath, module.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath, recordId.ToString());

			apiPath=string.Concat(apiPath, "/__timeline");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetTimelinesParam
		{
			public static readonly Param<Choice<string>> INCLUDE_INNER_DETAILS=new Param<Choice<string>>("include_inner_details", "com.zoho.crm.api.Timelines.GetTimelinesParam");
			public static readonly Param<string> SORT_BY=new Param<string>("sort_by", "com.zoho.crm.api.Timelines.GetTimelinesParam");
			public static readonly Param<Choice<string>> SORT_ORDER=new Param<Choice<string>>("sort_order", "com.zoho.crm.api.Timelines.GetTimelinesParam");
			public static readonly Param<string> INCLUDE_TIMELINE_TYPE=new Param<string>("include_timeline_type", "com.zoho.crm.api.Timelines.GetTimelinesParam");
			public static readonly Param<Choice<string>> INCLUDE=new Param<Choice<string>>("include", "com.zoho.crm.api.Timelines.GetTimelinesParam");
			public static readonly Param<string> FILTERS=new Param<string>("filters", "com.zoho.crm.api.Timelines.GetTimelinesParam");
			public static readonly Param<string> PER_PAGE=new Param<string>("per_page", "com.zoho.crm.api.Timelines.GetTimelinesParam");
			public static readonly Param<string> PAGE=new Param<string>("page", "com.zoho.crm.api.Timelines.GetTimelinesParam");
			public static readonly Param<string> PAGE_TOKEN=new Param<string>("page_token", "com.zoho.crm.api.Timelines.GetTimelinesParam");
		}

	}
}