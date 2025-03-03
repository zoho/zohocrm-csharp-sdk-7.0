using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.ConversionOption
{

	public class ConversionOptionOperations
	{
		private long? leadId;

		/// <summary>		/// Creates an instance of ConversionOptionOperations with the given parameters
		/// <param name="leadId">long?</param>
		
		public ConversionOptionOperations(long? leadId)
		{
			 this.leadId=leadId;


		}

		/// <summary>The method to lead conversion options</summary>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> LeadConversionOptions()
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Leads/");

			apiPath=string.Concat(apiPath,  this.leadId.ToString());

			apiPath=string.Concat(apiPath, "/__conversion_options");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ModuleAPIName="Leads";

			Utility.GetFields("Leads,Contacts,Deals,Accounts", handlerInstance);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


	}
}