using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.RelatedLists
{

	public class RelatedListsOperations
	{
		private long? layoutId;

		/// <summary>		/// Creates an instance of RelatedListsOperations with the given parameters
		/// <param name="layoutId">long?</param>
		
		public RelatedListsOperations(long? layoutId)
		{
			 this.layoutId=layoutId;


		}

		/// <summary>The method to get related lists</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetRelatedLists(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/related_lists");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<long?>("layout_id", "com.zoho.crm.api.RelatedLists.GetRelatedListsParam"),  this.layoutId);

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to get related list</summary>
		/// <param name="id">long?</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetRelatedList(long? id, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/related_lists/");

			apiPath=string.Concat(apiPath, id.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<long?>("layout_id", "com.zoho.crm.api.RelatedLists.GetRelatedListParam"),  this.layoutId);

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetRelatedListsParam
		{
			public static readonly Param<string> MODULE=new Param<string>("module", "com.zoho.crm.api.RelatedLists.GetRelatedListsParam");
		}


		public static class GetRelatedListParam
		{
			public static readonly Param<string> MODULE=new Param<string>("module", "com.zoho.crm.api.RelatedLists.GetRelatedListParam");
		}

	}
}