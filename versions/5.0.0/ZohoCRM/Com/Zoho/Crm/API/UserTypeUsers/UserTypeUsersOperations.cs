using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.UserTypeUsers
{

	public class UserTypeUsersOperations
	{
		private string portalName;
		private long? userTypeId;

		/// <summary>		/// Creates an instance of UserTypeUsersOperations with the given parameters
		/// <param name="userTypeId">long?</param>
		/// <param name="portalName">string</param>
		
		public UserTypeUsersOperations(long? userTypeId, string portalName)
		{
			 this.userTypeId=userTypeId;

			 this.portalName=portalName;


		}

		/// <summary>The method to get users of user type</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetUsersOfUserType(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/portals/");

			apiPath=string.Concat(apiPath,  this.portalName.ToString());

			apiPath=string.Concat(apiPath, "/user_type/");

			apiPath=string.Concat(apiPath,  this.userTypeId.ToString());

			apiPath=string.Concat(apiPath, "/users");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to delete user from the portal</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteUserFromThePortal(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/portals/");

			apiPath=string.Concat(apiPath,  this.portalName.ToString());

			apiPath=string.Concat(apiPath, "/user_type/");

			apiPath=string.Concat(apiPath,  this.userTypeId.ToString());

			apiPath=string.Concat(apiPath, "/users");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to transfer users of a user type</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> TransferUsersOfAUserType(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/portals/");

			apiPath=string.Concat(apiPath,  this.portalName.ToString());

			apiPath=string.Concat(apiPath, "/user_type/");

			apiPath=string.Concat(apiPath,  this.userTypeId.ToString());

			apiPath=string.Concat(apiPath, "/users/action/transfer");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to change users status</summary>
		/// <param name="userId">long?</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<StatusActionHandler></returns>
		public APIResponse<StatusActionHandler> ChangeUsersStatus(long? userId, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/portals/");

			apiPath=string.Concat(apiPath,  this.portalName.ToString());

			apiPath=string.Concat(apiPath, "/user_type/");

			apiPath=string.Concat(apiPath,  this.userTypeId.ToString());

			apiPath=string.Concat(apiPath, "/users/");

			apiPath=string.Concat(apiPath, userId.ToString());

			apiPath=string.Concat(apiPath, "/actions/change_status");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<StatusActionHandler>(typeof(StatusActionHandler), "application/json");


		}


		public static class GetUsersOfUserTypeParam
		{
			public static readonly Param<string> FILTERS=new Param<string>("filters", "com.zoho.crm.api.UserTypeUsers.GetUsersOfUserTypeParam");
			public static readonly Param<string> TYPE=new Param<string>("type", "com.zoho.crm.api.UserTypeUsers.GetUsersOfUserTypeParam");
		}


		public static class DeleteUserFromThePortalParam
		{
			public static readonly Param<string> PERSONALITY_IDS=new Param<string>("personality_ids", "com.zoho.crm.api.UserTypeUsers.DeleteUserFromThePortalParam");
		}


		public static class TransferUsersOfAUserTypeParam
		{
			public static readonly Param<string> PERSONALITY_IDS=new Param<string>("personality_ids", "com.zoho.crm.api.UserTypeUsers.TransferUsersOfAUserTypeParam");
			public static readonly Param<string> TRANSFER_TO=new Param<string>("transfer_To", "com.zoho.crm.api.UserTypeUsers.TransferUsersOfAUserTypeParam");
		}


		public static class ChangeUsersStatusParam
		{
			public static readonly Param<bool?> ACTIVE=new Param<bool?>("active", "com.zoho.crm.api.UserTypeUsers.ChangeUsersStatusParam");
		}

	}
}