using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.APIs
{

	public class APIsOperations
	{
		private string filters;

		/// <summary>		/// Creates an instance of ApisOperations with the given parameters
		/// <param name="filters">string</param>
		
		public APIsOperations(string filters)
		{
			 this.filters=filters;


		}

		/// <summary>The method to get supported api</summary>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetSupportedAPI()
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/__apis");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("filters", "com.zoho.crm.api.Apis.GetSupportedAPIParam"),  this.filters);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetSupportedAPIParam
		{
		}

	}
}