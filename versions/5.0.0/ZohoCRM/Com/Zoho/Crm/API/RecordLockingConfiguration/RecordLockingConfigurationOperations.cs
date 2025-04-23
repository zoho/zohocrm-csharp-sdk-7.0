using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.RecordLockingConfiguration
{

	public class RecordLockingConfigurationOperations
	{
		private string module;

		/// <summary>		/// Creates an instance of RecordLockingConfigurationOperations with the given parameters
		/// <param name="module">string</param>
		
		public RecordLockingConfigurationOperations(string module)
		{
			 this.module=module;


		}

		/// <summary>The method to get record locking configurations</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetRecordLockingConfigurations(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/record_locking_configurations");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.RecordLockingConfiguration.GetRecordLockingConfigurationsParam"),  this.module);

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to add record locking configuration</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> AddRecordLockingConfiguration(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/record_locking_configurations");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.RecordLockingConfiguration.AddRecordLockingConfigurationParam"),  this.module);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to update record locking configurations</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateRecordLockingConfigurations(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/record_locking_configurations");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.RecordLockingConfiguration.UpdateRecordLockingConfigurationsParam"),  this.module);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to update record locking configuration</summary>
		/// <param name="recordLockingConfigId">long?</param>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateRecordLockingConfiguration(long? recordLockingConfigId, BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/record_locking_configurations/");

			apiPath=string.Concat(apiPath, recordLockingConfigId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.RecordLockingConfiguration.UpdateRecordLockingConfigurationParam"),  this.module);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to delete record locking configuration</summary>
		/// <param name="recordLockingConfigId">long?</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteRecordLockingConfiguration(long? recordLockingConfigId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/record_locking_configurations/");

			apiPath=string.Concat(apiPath, recordLockingConfigId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.RecordLockingConfiguration.DeleteRecordLockingConfigurationParam"),  this.module);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


		public static class GetRecordLockingConfigurationsParam
		{
			public static readonly Param<string> FEATURE_TYPE=new Param<string>("feature_type", "com.zoho.crm.api.RecordLockingConfiguration.GetRecordLockingConfigurationsParam");
		}


		public static class AddRecordLockingConfigurationParam
		{
		}


		public static class UpdateRecordLockingConfigurationsParam
		{
		}


		public static class UpdateRecordLockingConfigurationParam
		{
		}


		public static class DeleteRecordLockingConfigurationParam
		{
		}

	}
}