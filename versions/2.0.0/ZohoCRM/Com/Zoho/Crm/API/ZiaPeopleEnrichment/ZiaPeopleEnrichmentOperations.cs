using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.ZiaPeopleEnrichment
{

	public class ZiaPeopleEnrichmentOperations
	{
		/// <summary>The method to get zia people enrichments</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetZiaPeopleEnrichments(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/__zia_people_enrichment");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to get zia people enrichment</summary>
		/// <param name="ziaPeopleEnrichmentId">long?</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetZiaPeopleEnrichment(long? ziaPeopleEnrichmentId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/__zia_people_enrichment/");

			apiPath=string.Concat(apiPath, ziaPeopleEnrichmentId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to create zia people enrichment</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> CreateZiaPeopleEnrichment(BodyWrapper request, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/__zia_people_enrichment");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


		public static class GetZiaPeopleEnrichmentsParam
		{
			public static readonly Param<Choice<string>> STATUS=new Param<Choice<string>>("status", "com.zoho.crm.api.ZiaPeopleEnrichment.GetZiaPeopleEnrichmentsParam");
			public static readonly Param<string> SORT_ORDER=new Param<string>("sort_order", "com.zoho.crm.api.ZiaPeopleEnrichment.GetZiaPeopleEnrichmentsParam");
			public static readonly Param<string> SORT_BY=new Param<string>("sort_by", "com.zoho.crm.api.ZiaPeopleEnrichment.GetZiaPeopleEnrichmentsParam");
			public static readonly Param<int?> PAGE=new Param<int?>("page", "com.zoho.crm.api.ZiaPeopleEnrichment.GetZiaPeopleEnrichmentsParam");
			public static readonly Param<int?> PER_PAGE=new Param<int?>("per_page", "com.zoho.crm.api.ZiaPeopleEnrichment.GetZiaPeopleEnrichmentsParam");
			public static readonly Param<int?> COUNT=new Param<int?>("count", "com.zoho.crm.api.ZiaPeopleEnrichment.GetZiaPeopleEnrichmentsParam");
		}


		public static class CreateZiaPeopleEnrichmentParam
		{
			public static readonly Param<string> MODULE=new Param<string>("module", "com.zoho.crm.api.ZiaPeopleEnrichment.CreateZiaPeopleEnrichmentParam");
			public static readonly Param<long?> RECORD_ID=new Param<long?>("record_id", "com.zoho.crm.api.ZiaPeopleEnrichment.CreateZiaPeopleEnrichmentParam");
		}

	}
}