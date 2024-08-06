using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.PortalInvite
{

	public class PortalInviteOperations
	{
		private string module;

		/// <summary>		/// Creates an instance of PortalInviteOperations with the given parameters
		/// <param name="module">string</param>
		
		public PortalInviteOperations(string module)
		{
			 this.module=module;


		}

		/// <summary>The method to invite users</summary>
		/// <param name="record">long?</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> InviteUsers(long? record, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.module.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath, record.ToString());

			apiPath=string.Concat(apiPath, "/actions/portal_invite");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


		public static class InviteUsersParam
		{
			public static readonly Param<long?> USER_TYPE_ID=new Param<long?>("user_type_id", "com.zoho.crm.api.PortalInvite.InviteUsersParam");
			public static readonly Param<Choice<string>> TYPE=new Param<Choice<string>>("type", "com.zoho.crm.api.PortalInvite.InviteUsersParam");
			public static readonly Param<Choice<string>> LANGUAGE=new Param<Choice<string>>("language", "com.zoho.crm.api.PortalInvite.InviteUsersParam");
		}

	}
}