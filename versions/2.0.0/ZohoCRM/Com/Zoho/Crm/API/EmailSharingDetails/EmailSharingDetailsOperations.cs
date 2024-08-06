using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.EmailSharingDetails
{

	public class EmailSharingDetailsOperations
	{
		private string module;
		private long? recordId;

		/// <summary>		/// Creates an instance of EmailSharingDetailsOperations with the given parameters
		/// <param name="recordId">long?</param>
		/// <param name="module">string</param>
		
		public EmailSharingDetailsOperations(long? recordId, string module)
		{
			 this.recordId=recordId;

			 this.module=module;


		}

		/// <summary>The method to get email sharing details</summary>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetEmailSharingDetails()
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.module.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.recordId.ToString());

			apiPath=string.Concat(apiPath, "/__emails_sharing_details");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


	}
}