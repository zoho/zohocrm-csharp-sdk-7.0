using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.Tags
{

	public class TagsOperations
	{
		/// <summary>The method to get tags</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetTags(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/tags");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to create tags</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> CreateTags(BodyWrapper request, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/tags");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to update tags</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateTags(BodyWrapper request, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/tags");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to update tag</summary>
		/// <param name="id">long?</param>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateTag(long? id, BodyWrapper request, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/tags/");

			apiPath=string.Concat(apiPath, id.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to delete tag</summary>
		/// <param name="id">long?</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteTag(long? id)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/tags/");

			apiPath=string.Concat(apiPath, id.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to merge tags</summary>
		/// <param name="id">long?</param>
		/// <param name="request">Instance of MergeWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> MergeTags(long? id, MergeWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/tags/");

			apiPath=string.Concat(apiPath, id.ToString());

			apiPath=string.Concat(apiPath, "/actions/merge");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to add tags</summary>
		/// <param name="recordId">long?</param>
		/// <param name="moduleAPIName">string</param>
		/// <param name="request">Instance of NewTagRequestWrapper</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<RecordActionHandler></returns>
		public APIResponse<RecordActionHandler> AddTags(long? recordId, string moduleAPIName, NewTagRequestWrapper request, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath, moduleAPIName.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath, recordId.ToString());

			apiPath=string.Concat(apiPath, "/actions/add_tags");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<RecordActionHandler>(typeof(RecordActionHandler), "application/json");


		}

		/// <summary>The method to remove tags</summary>
		/// <param name="recordId">long?</param>
		/// <param name="moduleAPIName">string</param>
		/// <param name="request">Instance of ExistingTagRequestWrapper</param>
		/// <returns>Instance of APIResponse<RecordActionHandler></returns>
		public APIResponse<RecordActionHandler> RemoveTags(long? recordId, string moduleAPIName, ExistingTagRequestWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath, moduleAPIName.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath, recordId.ToString());

			apiPath=string.Concat(apiPath, "/actions/remove_tags");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<RecordActionHandler>(typeof(RecordActionHandler), "application/json");


		}

		/// <summary>The method to add tags to multiple records</summary>
		/// <param name="moduleAPIName">string</param>
		/// <param name="request">Instance of NewTagRequestWrapper</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<RecordActionHandler></returns>
		public APIResponse<RecordActionHandler> AddTagsToMultipleRecords(string moduleAPIName, NewTagRequestWrapper request, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath, moduleAPIName.ToString());

			apiPath=string.Concat(apiPath, "/actions/add_tags");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<RecordActionHandler>(typeof(RecordActionHandler), "application/json");


		}

		/// <summary>The method to remove tags from multiple records</summary>
		/// <param name="moduleAPIName">string</param>
		/// <param name="request">Instance of ExistingTagRequestWrapper</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<RecordActionHandler></returns>
		public APIResponse<RecordActionHandler> RemoveTagsFromMultipleRecords(string moduleAPIName, ExistingTagRequestWrapper request, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath, moduleAPIName.ToString());

			apiPath=string.Concat(apiPath, "/actions/remove_tags");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<RecordActionHandler>(typeof(RecordActionHandler), "application/json");


		}

		/// <summary>The method to get record count for tag</summary>
		/// <param name="id">long?</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetRecordCountForTag(long? id, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/tags/");

			apiPath=string.Concat(apiPath, id.ToString());

			apiPath=string.Concat(apiPath, "/actions/records_count");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetTagsParam
		{
			public static readonly Param<string> MODULE=new Param<string>("module", "com.zoho.crm.api.Tags.GetTagsParam");
			public static readonly Param<string> MY_TAGS=new Param<string>("my_tags", "com.zoho.crm.api.Tags.GetTagsParam");
			public static readonly Param<string> INCLUDE=new Param<string>("include", "com.zoho.crm.api.Tags.GetTagsParam");
		}


		public static class CreateTagsParam
		{
			public static readonly Param<string> MODULE=new Param<string>("module", "com.zoho.crm.api.Tags.CreateTagsParam");
		}


		public static class UpdateTagsParam
		{
			public static readonly Param<string> MODULE=new Param<string>("module", "com.zoho.crm.api.Tags.UpdateTagsParam");
		}


		public static class UpdateTagParam
		{
			public static readonly Param<string> MODULE=new Param<string>("module", "com.zoho.crm.api.Tags.UpdateTagParam");
		}


		public static class AddTagsParam
		{
			public static readonly Param<string> OVER_WRITE=new Param<string>("over_write", "com.zoho.crm.api.Tags.AddTagsParam");
		}


		public static class AddTagsToMultipleRecordsParam
		{
			public static readonly Param<string> OVER_WRITE=new Param<string>("over_write", "com.zoho.crm.api.Tags.AddTagsToMultipleRecordsParam");
		}


		public static class RemoveTagsFromMultipleRecordsParam
		{
			public static readonly Param<long?> IDS=new Param<long?>("ids", "com.zoho.crm.api.Tags.RemoveTagsFromMultipleRecordsParam");
		}


		public static class GetRecordCountForTagParam
		{
			public static readonly Param<string> MODULE=new Param<string>("module", "com.zoho.crm.api.Tags.GetRecordCountForTagParam");
		}

	}
}