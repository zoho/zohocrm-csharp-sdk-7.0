using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.DealContactRoles
{

	public class DealContactRolesOperations
	{
		/// <summary>The method to get associated contact roles</summary>
		/// <param name="deal">long?</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetAssociatedContactRoles(long? deal, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Deals/");

			apiPath=string.Concat(apiPath, deal.ToString());

			apiPath=string.Concat(apiPath, "/Contact_Roles");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			handlerInstance.ModuleAPIName="Contacts";

			Utility.GetFields("Contacts", handlerInstance);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to delete associated contact roles</summary>
		/// <param name="deal">long?</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteAssociatedContactRoles(long? deal, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Deals/");

			apiPath=string.Concat(apiPath, deal.ToString());

			apiPath=string.Concat(apiPath, "/Contact_Roles");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to get associated contact roles specific to contact</summary>
		/// <param name="contact">long?</param>
		/// <param name="deal">long?</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetAssociatedContactRolesSpecificToContact(long? contact, long? deal)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Deals/");

			apiPath=string.Concat(apiPath, deal.ToString());

			apiPath=string.Concat(apiPath, "/Contact_Roles/");

			apiPath=string.Concat(apiPath, contact.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ModuleAPIName="Contacts";

			Utility.GetFields("Contacts", handlerInstance);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to associate contact role to deal</summary>
		/// <param name="contact">long?</param>
		/// <param name="deal">long?</param>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> AssociateContactRoleToDeal(long? contact, long? deal, BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Deals/");

			apiPath=string.Concat(apiPath, deal.ToString());

			apiPath=string.Concat(apiPath, "/Contact_Roles/");

			apiPath=string.Concat(apiPath, contact.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to delete contact role relation</summary>
		/// <param name="contact">long?</param>
		/// <param name="deal">long?</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteContactRoleRelation(long? contact, long? deal)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Deals/");

			apiPath=string.Concat(apiPath, deal.ToString());

			apiPath=string.Concat(apiPath, "/Contact_Roles/");

			apiPath=string.Concat(apiPath, contact.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


		public static class GetAssociatedContactRolesParam
		{
			public static readonly Param<string> IDS=new Param<string>("ids", "com.zoho.crm.api.DealContactRoles.GetAssociatedContactRolesParam");
			public static readonly Param<string> FIELDS=new Param<string>("fields", "com.zoho.crm.api.DealContactRoles.GetAssociatedContactRolesParam");
		}


		public static class DeleteAssociatedContactRolesParam
		{
			public static readonly Param<string> IDS=new Param<string>("ids", "com.zoho.crm.api.DealContactRoles.DeleteAssociatedContactRolesParam");
		}

	}
}