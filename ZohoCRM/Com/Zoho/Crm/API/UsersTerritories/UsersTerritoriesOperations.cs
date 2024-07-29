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

		/// <summary>The method to validate before transfer for all territories</summary>
		/// <returns>Instance of APIResponse<ValidationHandler></returns>
		public APIResponse<ValidationHandler> ValidateBeforeTransferForAllTerritories()
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/users/");

			apiPath=string.Concat(apiPath,  this.user.ToString());

			apiPath=string.Concat(apiPath, "/territories/actions/validate_before_transfer");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			return handlerInstance.APICall<ValidationHandler>(typeof(ValidationHandler), "application/json");


		}

		/// <summary>The method to validate before transfer</summary>
		/// <param name="territory">long?</param>
		/// <returns>Instance of APIResponse<ValidationHandler></returns>
		public APIResponse<ValidationHandler> ValidateBeforeTransfer(long? territory)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/users/");

			apiPath=string.Concat(apiPath,  this.user.ToString());

			apiPath=string.Concat(apiPath, "/territories/");

			apiPath=string.Concat(apiPath, territory.ToString());

			apiPath=string.Concat(apiPath, "/actions/validate_before_transfer");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			return handlerInstance.APICall<ValidationHandler>(typeof(ValidationHandler), "application/json");


		}

		/// <summary>The method to delink and transfer from all territories</summary>
		/// <param name="request">Instance of TransferWrapper</param>
		/// <returns>Instance of APIResponse<TransferActionHandler></returns>
		public APIResponse<TransferActionHandler> DelinkAndTransferFromAllTerritories(TransferWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/users/");

			apiPath=string.Concat(apiPath,  this.user.ToString());

			apiPath=string.Concat(apiPath, "/territories/actions/transfer_and_delink");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			return handlerInstance.APICall<TransferActionHandler>(typeof(TransferActionHandler), "application/json");


		}

		/// <summary>The method to delink and transfer from specific territory</summary>
		/// <param name="territory">long?</param>
		/// <param name="request">Instance of TransferWrapper</param>
		/// <returns>Instance of APIResponse<TransferActionHandler></returns>
		public APIResponse<TransferActionHandler> DelinkAndTransferFromSpecificTerritory(long? territory, TransferWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/users/");

			apiPath=string.Concat(apiPath,  this.user.ToString());

			apiPath=string.Concat(apiPath, "/territories/");

			apiPath=string.Concat(apiPath, territory.ToString());

			apiPath=string.Concat(apiPath, "/actions/transfer_and_delink");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			return handlerInstance.APICall<TransferActionHandler>(typeof(TransferActionHandler), "application/json");


		}


	}
}