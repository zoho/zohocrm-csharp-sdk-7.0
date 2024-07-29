using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.MailMerge
{

	public class MailMergeOperations
	{
		private string id;
		private string module;

		/// <summary>		/// Creates an instance of MailMergeOperations with the given parameters
		/// <param name="module">string</param>
		/// <param name="id">string</param>
		
		public MailMergeOperations(string module, string id)
		{
			 this.module=module;

			 this.id=id;


		}

		/// <summary>The method to send mail merge</summary>
		/// <param name="request">Instance of MailMergeWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> SendMailMerge(MailMergeWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.module.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.id.ToString());

			apiPath=string.Concat(apiPath, "/actions/send_mail_merge");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to download mail merge</summary>
		/// <param name="request">Instance of DownloadMailMergeWrapper</param>
		/// <returns>Instance of APIResponse<DownloadResponseHandler></returns>
		public APIResponse<DownloadResponseHandler> DownloadMailMerge(DownloadMailMergeWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.module.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.id.ToString());

			apiPath=string.Concat(apiPath, "/actions/download_mail_merge");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<DownloadResponseHandler>(typeof(DownloadResponseHandler), "application/json");


		}

		/// <summary>The method to sign mail merge</summary>
		/// <param name="request">Instance of SignMailMergeWrapper</param>
		/// <returns>Instance of APIResponse<SignActionHandler></returns>
		public APIResponse<SignActionHandler> SignMailMerge(SignMailMergeWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.module.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.id.ToString());

			apiPath=string.Concat(apiPath, "/actions/sign_mail_merge");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<SignActionHandler>(typeof(SignActionHandler), "application/json");


		}


	}
}