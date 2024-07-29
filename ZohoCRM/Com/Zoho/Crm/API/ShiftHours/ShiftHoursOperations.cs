using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.ShiftHours
{

	public class ShiftHoursOperations
	{
		private string xCrmOrg;

		/// <summary>		/// Creates an instance of ShiftHoursOperations with the given parameters
		/// <param name="xCrmOrg">string</param>
		
		public ShiftHoursOperations(string xCrmOrg)
		{
			 this.xCrmOrg=xCrmOrg;


		}

		/// <summary>The method to get shift hours</summary>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetShiftHours()
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/business_hours/shift_hours");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddHeader(new Header<string>("X-CRM-ORG", "com.zoho.crm.api.ShiftHours.GetShiftHoursHeader"),  this.xCrmOrg);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to create shifts hours</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> CreateShiftsHours(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/business_hours/shift_hours");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddHeader(new Header<string>("X-CRM-ORG", "com.zoho.crm.api.ShiftHours.CreateShiftsHoursHeader"),  this.xCrmOrg);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to update shift hours</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateShiftHours(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/business_hours/shift_hours");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddHeader(new Header<string>("X-CRM-ORG", "com.zoho.crm.api.ShiftHours.UpdateShiftHoursHeader"),  this.xCrmOrg);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to get shift hour</summary>
		/// <param name="shiftId">long?</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetShiftHour(long? shiftId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/business_hours/shift_hours/");

			apiPath=string.Concat(apiPath, shiftId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddHeader(new Header<string>("X-CRM-ORG", "com.zoho.crm.api.ShiftHours.GetShiftHourHeader"),  this.xCrmOrg);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to update shift hour</summary>
		/// <param name="shiftId">long?</param>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateShiftHour(long? shiftId, BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/business_hours/shift_hours/");

			apiPath=string.Concat(apiPath, shiftId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddHeader(new Header<string>("X-CRM-ORG", "com.zoho.crm.api.ShiftHours.UpdateShiftHourHeader"),  this.xCrmOrg);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to delete shift hour</summary>
		/// <param name="shiftId">long?</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteShiftHour(long? shiftId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/settings/business_hours/shift_hours/");

			apiPath=string.Concat(apiPath, shiftId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.AddHeader(new Header<string>("X-CRM-ORG", "com.zoho.crm.api.ShiftHours.DeleteShiftHourHeader"),  this.xCrmOrg);

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


		public static class GetShiftHoursHeader
		{
		}


		public static class CreateShiftsHoursHeader
		{
		}


		public static class UpdateShiftHoursHeader
		{
		}


		public static class GetShiftHourHeader
		{
		}


		public static class UpdateShiftHourHeader
		{
		}


		public static class DeleteShiftHourHeader
		{
		}

	}
}