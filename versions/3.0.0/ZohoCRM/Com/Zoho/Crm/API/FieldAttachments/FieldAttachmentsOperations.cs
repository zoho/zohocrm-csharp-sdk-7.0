using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.FieldAttachments
{

	public class FieldAttachmentsOperations
	{
		private long? fieldsAttachmentId;
		private long? recordId;
		private string moduleAPIName;

		/// <summary>		/// Creates an instance of FieldAttachmentsOperations with the given parameters
		/// <param name="moduleAPIName">string</param>
		/// <param name="recordId">long?</param>
		/// <param name="fieldsAttachmentId">long?</param>
		
		public FieldAttachmentsOperations(string moduleAPIName, long? recordId, long? fieldsAttachmentId)
		{
			 this.moduleAPIName=moduleAPIName;

			 this.recordId=recordId;

			 this.fieldsAttachmentId=fieldsAttachmentId;


		}

		/// <summary>The method to get field attachments</summary>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetFieldAttachments()
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.moduleAPIName.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.recordId.ToString());

			apiPath=string.Concat(apiPath, "/actions/download_fields_attachment");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<long?>("fields_attachment_id", "com.zoho.crm.api.FieldAttachments.GetFieldAttachmentsParam"),  this.fieldsAttachmentId);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/x-download");


		}


		public static class GetFieldAttachmentsParam
		{
		}

	}
}