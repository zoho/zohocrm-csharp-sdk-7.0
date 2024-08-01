using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.Holidays
{

	public class HolidaysOperations
	{
		private string xCrmOrg;

		/// <summary>		/// Creates an instance of HolidaysOperations with the given parameters
		/// <param name="xCrmOrg">string</param>
		
		public HolidaysOperations(string xCrmOrg)
		{
			 this.xCrmOrg=xCrmOrg;


		}

		/// <summary>The method to get holidays</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetHolidays(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/holidays");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddHeader(new Header<string>("X-CRM-ORG", "com.zoho.crm.api.Holidays.GetHolidaysHeader"),  this.xCrmOrg);

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to create holidays</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> CreateHolidays(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/holidays");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddHeader(new Header<string>("X-CRM-ORG", "com.zoho.crm.api.Holidays.CreateHolidaysHeader"),  this.xCrmOrg);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to update holidays</summary>
		/// <param name="request">Instance of Holidays</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateHolidays(Holidays request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/holidays");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddHeader(new Header<string>("X-CRM-ORG", "com.zoho.crm.api.Holidays.UpdateHolidaysHeader"),  this.xCrmOrg);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to update holiday</summary>
		/// <param name="holidayId">long?</param>
		/// <param name="request">Instance of Holidays</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateHoliday(long? holidayId, Holidays request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/holidays/");

			apiPath=string.Concat(apiPath, holidayId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddHeader(new Header<string>("X-CRM-ORG", "com.zoho.crm.api.Holidays.UpdateHolidayHeader"),  this.xCrmOrg);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to get holiday</summary>
		/// <param name="holidayId">long?</param>
		/// <returns>Instance of APIResponse<ResonseHandler></returns>
		public APIResponse<ResonseHandler> GetHoliday(long? holidayId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/holidays/");

			apiPath=string.Concat(apiPath, holidayId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddHeader(new Header<string>("X-CRM-ORG", "com.zoho.crm.api.Holidays.GetHolidayHeader"),  this.xCrmOrg);

			return handlerInstance.APICall<ResonseHandler>(typeof(ResonseHandler), "application/json");


		}

		/// <summary>The method to delete holiday</summary>
		/// <param name="holidayId">long?</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteHoliday(long? holidayId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/holidays/");

			apiPath=string.Concat(apiPath, holidayId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.AddHeader(new Header<string>("X-CRM-ORG", "com.zoho.crm.api.Holidays.DeleteHolidayHeader"),  this.xCrmOrg);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


		public static class GetHolidaysHeader
		{
		}


		public static class GetHolidaysParam
		{
			public static readonly Param<int?> YEAR=new Param<int?>("year", "com.zoho.crm.api.Holidays.GetHolidaysParam");
			public static readonly Param<Choice<string>> TYPE=new Param<Choice<string>>("type", "com.zoho.crm.api.Holidays.GetHolidaysParam");
			public static readonly Param<long?> SHIFT_ID=new Param<long?>("shift_id", "com.zoho.crm.api.Holidays.GetHolidaysParam");
		}


		public static class CreateHolidaysHeader
		{
		}


		public static class UpdateHolidaysHeader
		{
		}


		public static class UpdateHolidayHeader
		{
		}


		public static class GetHolidayHeader
		{
		}


		public static class DeleteHolidayHeader
		{
		}

	}
}