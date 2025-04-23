using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.EmailRelatedRecords
{

	public class EmailRelatedRecordsOperations
	{
		private string moduleName;
		private long? recordId;
		private string type;
		private long? ownerId;

		/// <summary>		/// Creates an instance of EmailRelatedRecordsOperations with the given parameters
		/// <param name="recordId">long?</param>
		/// <param name="moduleName">string</param>
		/// <param name="type">string</param>
		/// <param name="ownerId">long?</param>
		
		public EmailRelatedRecordsOperations(long? recordId, string moduleName, string type, long? ownerId)
		{
			 this.recordId=recordId;

			 this.moduleName=moduleName;

			 this.type=type;

			 this.ownerId=ownerId;


		}

		/// <summary>The method to get emails related records</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetEmailsRelatedRecords(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.moduleName.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.recordId.ToString());

			apiPath=string.Concat(apiPath, "/Emails");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("type", "com.zoho.crm.api.EmailRelatedRecords.GetEmailsRelatedRecordsParam"),  this.type);

			handlerInstance.AddParam(new Param<long?>("owner_id", "com.zoho.crm.api.EmailRelatedRecords.GetEmailsRelatedRecordsParam"),  this.ownerId);

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to get emails related record</summary>
		/// <param name="messageId">string</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetEmailsRelatedRecord(string messageId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.moduleName.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.recordId.ToString());

			apiPath=string.Concat(apiPath, "/Emails/");

			apiPath=string.Concat(apiPath, messageId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("type", "com.zoho.crm.api.EmailRelatedRecords.GetEmailsRelatedRecordParam"),  this.type);

			handlerInstance.AddParam(new Param<long?>("owner_id", "com.zoho.crm.api.EmailRelatedRecords.GetEmailsRelatedRecordParam"),  this.ownerId);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetEmailsRelatedRecordsParam
		{
			public static readonly Param<Criteria> FILTER=new Param<Criteria>("filter", "com.zoho.crm.api.EmailRelatedRecords.GetEmailsRelatedRecordsParam");
			public static readonly Param<string> INDEX=new Param<string>("index", "com.zoho.crm.api.EmailRelatedRecords.GetEmailsRelatedRecordsParam");
		}


		public static class GetEmailsRelatedRecordParam
		{
		}

	}
}