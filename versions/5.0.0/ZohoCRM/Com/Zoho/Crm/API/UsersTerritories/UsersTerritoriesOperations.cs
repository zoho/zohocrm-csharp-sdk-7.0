using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.UsersTerritories
{

	public class UsersTerritoriesOperations
	{
		private long? user;

		/// <summary>		/// Creates an instance of UsersTerritoriesOperations with the given parameters
		/// <param name="user">long?</param>
		
		public UsersTerritoriesOperations(long? user)
		{
			 this.user=user;


		}

		/// <summary>The method to get territories of user</summary>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetTerritoriesOfUser()
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/users/");

			apiPath=string.Concat(apiPath,  this.user.ToString());

			apiPath=string.Concat(apiPath, "/territories");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to associate territories to user</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> AssociateTerritoriesToUser(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/users/");

			apiPath=string.Concat(apiPath,  this.user.ToString());

			apiPath=string.Concat(apiPath, "/territories");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to remove territories from user</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> RemoveTerritoriesFromUser(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/users/");

			apiPath=string.Concat(apiPath,  this.user.ToString());

			apiPath=string.Concat(apiPath, "/territories");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to get territory of user</summary>
		/// <param name="territory">long?</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetTerritoryOfUser(long? territory)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/users/");

			apiPath=string.Concat(apiPath,  this.user.ToString());

			apiPath=string.Concat(apiPath, "/territories/");

			apiPath=string.Concat(apiPath, territory.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to remove territory from user</summary>
		/// <param name="territory">long?</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> RemoveTerritoryFromUser(long? territory)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/users/");

			apiPath=string.Concat(apiPath,  this.user.ToString());

			apiPath=string.Concat(apiPath, "/territories/");

			apiPath=string.Concat(apiPath, territory.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


		public static class RemoveTerritoriesFromUserParam
		{
			public static readonly Param<string> IDS=new Param<string>("ids", "com.zoho.crm.api.UsersTerritories.RemoveTerritoriesFromUserParam");
		}

	}
}