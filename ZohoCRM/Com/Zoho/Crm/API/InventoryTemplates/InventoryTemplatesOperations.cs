using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.InventoryTemplates
{

	public class InventoryTemplatesOperations
	{
		/// <summary>The method to get inventory templates</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetInventoryTemplates(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/inventory_templates");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to get inventory template</summary>
		/// <param name="template">long?</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetInventoryTemplate(long? template)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/inventory_templates/");

			apiPath=string.Concat(apiPath, template.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetInventoryTemplatesParam
		{
			public static readonly Param<string> MODULE=new Param<string>("module", "com.zoho.crm.api.InventoryTemplates.GetInventoryTemplatesParam");
			public static readonly Param<string> CATEGORY=new Param<string>("category", "com.zoho.crm.api.InventoryTemplates.GetInventoryTemplatesParam");
			public static readonly Param<string> SORT_BY=new Param<string>("sort_by", "com.zoho.crm.api.InventoryTemplates.GetInventoryTemplatesParam");
			public static readonly Param<string> SORT_ORDER=new Param<string>("sort_order", "com.zoho.crm.api.InventoryTemplates.GetInventoryTemplatesParam");
			public static readonly Param<string> FILTERS=new Param<string>("filters", "com.zoho.crm.api.InventoryTemplates.GetInventoryTemplatesParam");
		}

	}
}