using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.FieldMapDependency
{

	public class FieldMapDependencyOperations
	{
		private string module;
		private long? layoutId;

		/// <summary>		/// Creates an instance of FieldMapDependencyOperations with the given parameters
		/// <param name="layoutId">long?</param>
		/// <param name="module">string</param>
		
		public FieldMapDependencyOperations(long? layoutId, string module)
		{
			 this.layoutId=layoutId;

			 this.module=module;


		}

		/// <summary>The method to create map dependency</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> CreateMapDependency(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/layouts/");

			apiPath=string.Concat(apiPath,  this.layoutId.ToString());

			apiPath=string.Concat(apiPath, "/map_dependency");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.FieldMapDependency.CreateMapDependencyParam"),  this.module);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to get map dependencies</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetMapDependencies(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/layouts/");

			apiPath=string.Concat(apiPath,  this.layoutId.ToString());

			apiPath=string.Concat(apiPath, "/map_dependency");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.FieldMapDependency.GetMapDependenciesParam"),  this.module);

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to update map dependency</summary>
		/// <param name="dependencyId">long?</param>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateMapDependency(long? dependencyId, BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/layouts/");

			apiPath=string.Concat(apiPath,  this.layoutId.ToString());

			apiPath=string.Concat(apiPath, "/map_dependency/");

			apiPath=string.Concat(apiPath, dependencyId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.FieldMapDependency.UpdateMapDependencyParam"),  this.module);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to get map dependency</summary>
		/// <param name="dependencyId">long?</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetMapDependency(long? dependencyId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/layouts/");

			apiPath=string.Concat(apiPath,  this.layoutId.ToString());

			apiPath=string.Concat(apiPath, "/map_dependency/");

			apiPath=string.Concat(apiPath, dependencyId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.FieldMapDependency.GetMapDependencyParam"),  this.module);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to delete map dependency</summary>
		/// <param name="dependencyId">long?</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteMapDependency(long? dependencyId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/layouts/");

			apiPath=string.Concat(apiPath,  this.layoutId.ToString());

			apiPath=string.Concat(apiPath, "/map_dependency/");

			apiPath=string.Concat(apiPath, dependencyId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.AddParam(new Param<string>("module", "com.zoho.crm.api.FieldMapDependency.DeleteMapDependencyParam"),  this.module);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


		public static class CreateMapDependencyParam
		{
		}


		public static class CreateMapDependencyHeader
		{
		}


		public static class GetMapDependenciesParam
		{
			public static readonly Param<int?> PAGE=new Param<int?>("page", "com.zoho.crm.api.FieldMapDependency.GetMapDependenciesParam");
			public static readonly Param<int?> PER_PAGE=new Param<int?>("per_page", "com.zoho.crm.api.FieldMapDependency.GetMapDependenciesParam");
			public static readonly Param<string> FILTERS=new Param<string>("filters", "com.zoho.crm.api.FieldMapDependency.GetMapDependenciesParam");
			public static readonly Param<long?> LAYOUT_ID=new Param<long?>("layout_id", "com.zoho.crm.api.FieldMapDependency.GetMapDependenciesParam");
		}


		public static class UpdateMapDependencyParam
		{
		}


		public static class GetMapDependencyParam
		{
		}


		public static class DeleteMapDependencyParam
		{
		}

	}
}