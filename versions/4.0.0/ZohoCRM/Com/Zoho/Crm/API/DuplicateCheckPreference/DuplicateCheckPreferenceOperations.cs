using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.DuplicateCheckPreference
{

	public class DuplicateCheckPreferenceOperations
	{
		private string module;

		/// <summary>		/// Creates an instance of DuplicateCheckPreferenceOperations with the given parameters
		/// <param name="module">string</param>
		
		public DuplicateCheckPreferenceOperations(string module)
		{
			 this.module=module;


		}

		/// <summary>The method to get duplicate check preference</summary>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetDuplicateCheckPreference()
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/duplicate_check_preference");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.DuplicateCheckPreference.GetDuplicateCheckPreferenceParam"),  this.module);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to create duplicate check preference</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> CreateDuplicateCheckPreference(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/duplicate_check_preference");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.DuplicateCheckPreference.CreateDuplicateCheckPreferenceParam"),  this.module);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to update duplicate check preference</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateDuplicateCheckPreference(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/duplicate_check_preference");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.DuplicateCheckPreference.UpdateDuplicateCheckPreferenceParam"),  this.module);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to delete duplicate check preference</summary>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteDuplicateCheckPreference()
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/duplicate_check_preference");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.DuplicateCheckPreference.DeleteDuplicateCheckPreferenceParam"),  this.module);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


		public static class GetDuplicateCheckPreferenceParam
		{
		}


		public static class CreateDuplicateCheckPreferenceParam
		{
		}


		public static class UpdateDuplicateCheckPreferenceParam
		{
		}


		public static class DeleteDuplicateCheckPreferenceParam
		{
		}

	}
}