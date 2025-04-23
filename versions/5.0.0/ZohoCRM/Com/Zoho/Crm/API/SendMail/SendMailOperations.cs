using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.SendMail
{

	public class SendMailOperations
	{
		private string modulename;
		private long? id;

		/// <summary>		/// Creates an instance of SendMailOperations with the given parameters
		/// <param name="id">long?</param>
		/// <param name="modulename">string</param>
		
		public SendMailOperations(long? id, string modulename)
		{
			 this.id=id;

			 this.modulename=modulename;


		}

		/// <summary>The method to send mail</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> SendMail(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.modulename.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.id.ToString());

			apiPath=string.Concat(apiPath, "/actions/send_mail");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


	}
}