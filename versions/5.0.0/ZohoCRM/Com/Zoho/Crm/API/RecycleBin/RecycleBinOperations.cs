using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.RecycleBin
{

	public class RecycleBinOperations
	{
		/// <summary>The method to get recyclebin records</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetRecyclebinRecords(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/recycle_bin");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to delete recyclebin records</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteRecyclebinRecords(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/recycle_bin");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to get recyclebin record</summary>
		/// <param name="recordId">long?</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetRecyclebinRecord(long? recordId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/recycle_bin/");

			apiPath=string.Concat(apiPath, recordId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to delete recyclebin record</summary>
		/// <param name="recordId">long?</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteRecyclebinRecord(long? recordId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/recycle_bin/");

			apiPath=string.Concat(apiPath, recordId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


		public static class GetRecycleBinRecordsParam
		{
			public static readonly Param<string> IDS=new Param<string>("ids", "com.zoho.crm.api.RecycleBin.GetRecycleBinRecordsParam");
			public static readonly Param<string> SORT_BY=new Param<string>("sort_by", "com.zoho.crm.api.RecycleBin.GetRecycleBinRecordsParam");
			public static readonly Param<string> SORT_ORDER=new Param<string>("sort_order", "com.zoho.crm.api.RecycleBin.GetRecycleBinRecordsParam");
			public static readonly Param<int?> PAGE=new Param<int?>("page", "com.zoho.crm.api.RecycleBin.GetRecycleBinRecordsParam");
			public static readonly Param<int?> PER_PAGE=new Param<int?>("per_page", "com.zoho.crm.api.RecycleBin.GetRecycleBinRecordsParam");
			public static readonly Param<string> FILTERS=new Param<string>("filters", "com.zoho.crm.api.RecycleBin.GetRecycleBinRecordsParam");
		}


		public static class DeleteRecycleBinRecordsParam
		{
			public static readonly Param<string> FILTERS=new Param<string>("filters", "com.zoho.crm.api.RecycleBin.DeleteRecycleBinRecordsParam");
			public static readonly Param<string> IDS=new Param<string>("ids", "com.zoho.crm.api.RecycleBin.DeleteRecycleBinRecordsParam");
		}

	}
}