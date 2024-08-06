using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.CancelMeetings
{

	public class CancelMeetingsOperations
	{
		private long? event1;

		/// <summary>		/// Creates an instance of CancelMeetingsOperations with the given parameters
		/// <param name="event1">long?</param>
		
		public CancelMeetingsOperations(long? event1)
		{
			 this.event1=event1;


		}

		/// <summary>The method to cancel meetings</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> CancelMeetings(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Events/");

			apiPath=string.Concat(apiPath,  this.event1.ToString());

			apiPath=string.Concat(apiPath, "/actions/cancel");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_ACTION;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


	}
}