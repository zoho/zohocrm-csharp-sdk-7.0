using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.DownloadAttachments
{

	public class DownloadAttachmentsOperations
	{
		/// <summary>The method to get download attachments details</summary>
		/// <param name="recordId">long?</param>
		/// <param name="module">string</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetDownloadAttachmentsDetails(long? recordId, string module, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath, module.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath, recordId.ToString());

			apiPath=string.Concat(apiPath, "/Emails/actions/download_attachments");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "multipart/form-data");


		}


		public static class GetDownloadAttachmentsDetailsParam
		{
			public static readonly Param<long?> USER_ID=new Param<long?>("user_id", "com.zoho.crm.api.DownloadAttachments.GetDownloadAttachmentsDetailsParam");
			public static readonly Param<string> MESSAGE_ID=new Param<string>("message_id", "com.zoho.crm.api.DownloadAttachments.GetDownloadAttachmentsDetailsParam");
			public static readonly Param<string> ID=new Param<string>("id", "com.zoho.crm.api.DownloadAttachments.GetDownloadAttachmentsDetailsParam");
			public static readonly Param<string> NAME=new Param<string>("name", "com.zoho.crm.api.DownloadAttachments.GetDownloadAttachmentsDetailsParam");
		}

	}
}