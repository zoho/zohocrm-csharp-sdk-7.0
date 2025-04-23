using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.ConvertLead
{

	public class ConvertLeadOperations
	{
		private long? leadId;

		/// <summary>		/// Creates an instance of ConvertLeadOperations with the given parameters
		/// <param name="leadId">long?</param>
		
		public ConvertLeadOperations(long? leadId)
		{
			 this.leadId=leadId;


		}

		/// <summary>The method to convert lead</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> ConvertLead(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Leads/");

			apiPath=string.Concat(apiPath,  this.leadId.ToString());

			apiPath=string.Concat(apiPath, "/actions/convert");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.ModuleAPIName="Deals";

			Utility.GetFields("Deals", handlerInstance);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


	}
}