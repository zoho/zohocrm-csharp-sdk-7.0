using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.DownloadInlineImages
{

	public class DownloadInlineImagesOperations
	{
		/// <summary>The method to get download inline images</summary>
		/// <param name="recordId">long?</param>
		/// <param name="module">string</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetDownloadInlineImages(long? recordId, string module, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath, module.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath, recordId.ToString());

			apiPath=string.Concat(apiPath, "/Emails/actions/download_inline_images");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "multipart/form-data");


		}


		public static class GetDownloadInlineImagesParam
		{
			public static readonly Param<long?> USER_ID=new Param<long?>("user_id", "com.zoho.crm.api.DownloadInlineImages.GetDownloadInlineImagesParam");
			public static readonly Param<string> MESSAGE_ID=new Param<string>("message_id", "com.zoho.crm.api.DownloadInlineImages.GetDownloadInlineImagesParam");
			public static readonly Param<string> ID=new Param<string>("id", "com.zoho.crm.api.DownloadInlineImages.GetDownloadInlineImagesParam");
		}

	}
}