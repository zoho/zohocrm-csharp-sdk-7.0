using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.ZiaOrgEnrichment
{

	public class ZiaOrgEnrichmentOperations
	{
		/// <summary>The method to get zia org enrichments</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetZiaOrgEnrichments(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/__zia_org_enrichment");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to create zia org enrichment</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> CreateZiaOrgEnrichment(BodyWrapper request, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/__zia_org_enrichment");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to get zia org enrichment</summary>
		/// <param name="ziaOrgEnrichmentId">long?</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetZiaOrgEnrichment(long? ziaOrgEnrichmentId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/__zia_org_enrichment/");

			apiPath=string.Concat(apiPath, ziaOrgEnrichmentId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetZiaOrgEnrichmentsParam
		{
			public static readonly Param<Choice<string>> STATUS=new Param<Choice<string>>("status", "com.zoho.crm.api.ZiaOrgEnrichment.GetZiaOrgEnrichmentsParam");
			public static readonly Param<string> SORT_ORDER=new Param<string>("sort_order", "com.zoho.crm.api.ZiaOrgEnrichment.GetZiaOrgEnrichmentsParam");
			public static readonly Param<string> SORT_BY=new Param<string>("sort_by", "com.zoho.crm.api.ZiaOrgEnrichment.GetZiaOrgEnrichmentsParam");
			public static readonly Param<int?> PAGE=new Param<int?>("page", "com.zoho.crm.api.ZiaOrgEnrichment.GetZiaOrgEnrichmentsParam");
			public static readonly Param<int?> PER_PAGE=new Param<int?>("per_page", "com.zoho.crm.api.ZiaOrgEnrichment.GetZiaOrgEnrichmentsParam");
		}


		public static class CreateZiaOrgEnrichmentParam
		{
			public static readonly Param<string> MODULE=new Param<string>("module", "com.zoho.crm.api.ZiaOrgEnrichment.CreateZiaOrgEnrichmentParam");
			public static readonly Param<long?> RECORD_ID=new Param<long?>("record_id", "com.zoho.crm.api.ZiaOrgEnrichment.CreateZiaOrgEnrichmentParam");
		}

	}
}