using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.UnblockEmail
{

	public class UnblockEmailOperations
	{
		private string module;

		/// <summary>		/// Creates an instance of UnblockEmailOperations with the given parameters
		/// <param name="module">string</param>
		
		public UnblockEmailOperations(string module)
		{
			 this.module=module;


		}

		/// <summary>The method to unblock emails</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UnblockEmails(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.module.ToString());

			apiPath=string.Concat(apiPath, "/actions/unblock_email");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to unblock email</summary>
		/// <param name="id">long?</param>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UnblockEmail(long? id, BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.module.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath, id.ToString());

			apiPath=string.Concat(apiPath, "/actions/unblock_email");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


	}
}