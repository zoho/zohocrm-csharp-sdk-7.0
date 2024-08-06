using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.PickListValues
{

	public class PickListValuesOperations
	{
		private long? fieldId;
		private string module;

		/// <summary>		/// Creates an instance of PickListValuesOperations with the given parameters
		/// <param name="fieldId">long?</param>
		/// <param name="module">string</param>
		
		public PickListValuesOperations(long? fieldId, string module)
		{
			 this.fieldId=fieldId;

			 this.module=module;


		}

		/// <summary>The method to get pick list values</summary>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetPickListValues()
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/fields/");

			apiPath=string.Concat(apiPath,  this.fieldId.ToString());

			apiPath=string.Concat(apiPath, "/pick_list_values");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.PickListValues.GetPickListValuesParam"),  this.module);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetPickListValuesParam
		{
		}

	}
}