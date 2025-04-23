using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.GlobalPicklists
{

	public class GlobalPicklistsOperations
	{
		/// <summary>The method to get global picklists</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetGlobalPicklists(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/global_picklists");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to create global picklist</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> CreateGlobalPicklist(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/global_picklists");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to update global picklists</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateGlobalPicklists(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/global_picklists");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PATCH;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to delete global picklists</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteGlobalPicklists(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/global_picklists");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to get global picklist</summary>
		/// <param name="id">long?</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetGlobalPicklist(long? id, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/global_picklists/");

			apiPath=string.Concat(apiPath, id.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to update global picklist</summary>
		/// <param name="id">long?</param>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateGlobalPicklist(long? id, BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/global_picklists/");

			apiPath=string.Concat(apiPath, id.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PATCH;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to delete global picklist</summary>
		/// <param name="id">long?</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteGlobalPicklist(long? id)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/global_picklists/");

			apiPath=string.Concat(apiPath, id.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to replace picklist values</summary>
		/// <param name="id">long?</param>
		/// <param name="request">Instance of ReplaceBodyWrapper</param>
		/// <returns>Instance of APIResponse<ReplaceActionHandler></returns>
		public APIResponse<ReplaceActionHandler> ReplacePicklistValues(long? id, ReplaceBodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/global_picklists/");

			apiPath=string.Concat(apiPath, id.ToString());

			apiPath=string.Concat(apiPath, "/actions/replace_picklist_values");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			return handlerInstance.APICall<ReplaceActionHandler>(typeof(ReplaceActionHandler), "application/json");


		}

		/// <summary>The method to get replace values</summary>
		/// <param name="id">long?</param>
		/// <returns>Instance of APIResponse<ReplacedResponseHandler></returns>
		public APIResponse<ReplacedResponseHandler> GetReplaceValues(long? id)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/global_picklists/");

			apiPath=string.Concat(apiPath, id.ToString());

			apiPath=string.Concat(apiPath, "/actions/replaced_values");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			return handlerInstance.APICall<ReplacedResponseHandler>(typeof(ReplacedResponseHandler), "application/json");


		}

		/// <summary>The method to get associations</summary>
		/// <param name="id">long?</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<AssociationsResponseHandler></returns>
		public APIResponse<AssociationsResponseHandler> GetAssociations(long? id, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/global_picklists/");

			apiPath=string.Concat(apiPath, id.ToString());

			apiPath=string.Concat(apiPath, "/actions/associations");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<AssociationsResponseHandler>(typeof(AssociationsResponseHandler), "application/json");


		}

		/// <summary>The method to get pick list value associations</summary>
		/// <param name="id">long?</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<PickListValuesAssociationsResponseHandler></returns>
		public APIResponse<PickListValuesAssociationsResponseHandler> GetPickListValueAssociations(long? id, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/global_picklists/");

			apiPath=string.Concat(apiPath, id.ToString());

			apiPath=string.Concat(apiPath, "/actions/pick_list_values_associations");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<PickListValuesAssociationsResponseHandler>(typeof(PickListValuesAssociationsResponseHandler), "application/json");


		}


		public static class GetGlobalPicklistsParam
		{
			public static readonly Param<string> INCLUDE=new Param<string>("include", "com.zoho.crm.api.GlobalPicklists.GetGlobalPicklistsParam");
			public static readonly Param<string> INCLUDE_INNER_DETAILS=new Param<string>("include_inner_details", "com.zoho.crm.api.GlobalPicklists.GetGlobalPicklistsParam");
		}


		public static class DeleteGlobalPicklistsParam
		{
			public static readonly Param<string> IDS=new Param<string>("ids", "com.zoho.crm.api.GlobalPicklists.DeleteGlobalPicklistsParam");
		}


		public static class GetGlobalPicklistParam
		{
			public static readonly Param<string> INCLUDE=new Param<string>("include", "com.zoho.crm.api.GlobalPicklists.GetGlobalPicklistParam");
			public static readonly Param<string> INCLUDE_INNER_DETAILS=new Param<string>("include_inner_details", "com.zoho.crm.api.GlobalPicklists.GetGlobalPicklistParam");
		}


		public static class GetAssociationsParam
		{
			public static readonly Param<string> INCLUDE_INNER_DETAILS=new Param<string>("include_inner_details", "com.zoho.crm.api.GlobalPicklists.GetAssociationsParam");
			public static readonly Param<int?> PAGE=new Param<int?>("page", "com.zoho.crm.api.GlobalPicklists.GetAssociationsParam");
			public static readonly Param<int?> PER_PAGE=new Param<int?>("per_page", "com.zoho.crm.api.GlobalPicklists.GetAssociationsParam");
		}


		public static class GetPickListValueAssociationsParam
		{
			public static readonly Param<long?> PICKLIST_VALUE_ID=new Param<long?>("picklist_value_id", "com.zoho.crm.api.GlobalPicklists.GetPickListValueAssociationsParam");
		}

	}
}