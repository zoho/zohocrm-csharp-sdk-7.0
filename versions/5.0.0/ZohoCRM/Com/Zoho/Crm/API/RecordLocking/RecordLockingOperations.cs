using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.RecordLocking
{

	public class RecordLockingOperations
	{
		private string moduleName;
		private long? recordId;

		/// <summary>		/// Creates an instance of RecordLockingOperations with the given parameters
		/// <param name="recordId">long?</param>
		/// <param name="moduleName">string</param>
		
		public RecordLockingOperations(long? recordId, string moduleName)
		{
			 this.recordId=recordId;

			 this.moduleName=moduleName;


		}

		/// <summary>The method to get record locking informations</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetRecordLockingInformations(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.moduleName.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.recordId.ToString());

			apiPath=string.Concat(apiPath, "/Locking_Information__s");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			handlerInstance.ModuleAPIName="Locking_Information__s";

			Utility.GetFields("Locking_Information__s", handlerInstance);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to lock records</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> LockRecords(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.moduleName.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.recordId.ToString());

			apiPath=string.Concat(apiPath, "/Locking_Information__s");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.ModuleAPIName="Locking_Information__s";

			Utility.GetFields("Locking_Information__s", handlerInstance);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to get record locking information</summary>
		/// <param name="lockId">long?</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetRecordLockingInformation(long? lockId, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.moduleName.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.recordId.ToString());

			apiPath=string.Concat(apiPath, "/Locking_Information__s/");

			apiPath=string.Concat(apiPath, lockId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			handlerInstance.ModuleAPIName="Locking_Information__s";

			Utility.GetFields("Locking_Information__s", handlerInstance);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to update record locking information</summary>
		/// <param name="lockId">long?</param>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateRecordLockingInformation(long? lockId, BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.moduleName.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.recordId.ToString());

			apiPath=string.Concat(apiPath, "/Locking_Information__s/");

			apiPath=string.Concat(apiPath, lockId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.ModuleAPIName="Locking_Information__s";

			Utility.GetFields("Locking_Information__s", handlerInstance);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to unlock record</summary>
		/// <param name="lockId">long?</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UnlockRecord(long? lockId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.moduleName.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.recordId.ToString());

			apiPath=string.Concat(apiPath, "/Locking_Information__s/");

			apiPath=string.Concat(apiPath, lockId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.ModuleAPIName="Locking_Information__s";

			Utility.GetFields("Locking_Information__s", handlerInstance);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


		public static class GetRecordLockingInformationsParam
		{
			public static readonly Param<string> FIELDS=new Param<string>("fields", "com.zoho.crm.api.RecordLocking.GetRecordLockingInformationsParam");
			public static readonly Param<string> PAGE_TOKEN=new Param<string>("page_token", "com.zoho.crm.api.RecordLocking.GetRecordLockingInformationsParam");
			public static readonly Param<int?> PAGE=new Param<int?>("page", "com.zoho.crm.api.RecordLocking.GetRecordLockingInformationsParam");
			public static readonly Param<int?> PER_PAGE=new Param<int?>("per_page", "com.zoho.crm.api.RecordLocking.GetRecordLockingInformationsParam");
			public static readonly Param<string> IDS=new Param<string>("ids", "com.zoho.crm.api.RecordLocking.GetRecordLockingInformationsParam");
		}


		public static class GetRecordLockingInformationParam
		{
			public static readonly Param<string> FIELDS=new Param<string>("fields", "com.zoho.crm.api.RecordLocking.GetRecordLockingInformationParam");
		}

	}
}