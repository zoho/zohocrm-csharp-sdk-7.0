using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.RescheduleHistory
{

	public class RescheduleHistoryOperations
	{
		/// <summary>The method to add appointments rescheduled history</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> AddAppointmentsRescheduledHistory(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Appointments_Rescheduled_History__s");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to update appointments rescheduled history</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateAppointmentsRescheduledHistory(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Appointments_Rescheduled_History__s");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to get appointments rescheduled history</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetAppointmentsRescheduledHistory(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Appointments_Rescheduled_History__s");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to update appointment rescheduled history</summary>
		/// <param name="id">long?</param>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> UpdateAppointmentRescheduledHistory(long? id, BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Appointments_Rescheduled_History__s/");

			apiPath=string.Concat(apiPath, id.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_PUT;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_UPDATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}

		/// <summary>The method to get appointment rescheduled history</summary>
		/// <param name="id">long?</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetAppointmentRescheduledHistory(long? id, ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Appointments_Rescheduled_History__s/");

			apiPath=string.Concat(apiPath, id.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to delete appointments rescheduled history</summary>
		/// <param name="id">long?</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> DeleteAppointmentsRescheduledHistory(long? id)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Appointments_Rescheduled_History__s/");

			apiPath=string.Concat(apiPath, id.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_METHOD_DELETE;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


		public static class GetAppointmentsRescheduledHistoryParam
		{
			public static readonly Param<string> FIELDS=new Param<string>("fields", "com.zoho.crm.api.RescheduleHistory.GetAppointmentsRescheduledHistoryParam");
			public static readonly Param<int?> PAGE=new Param<int?>("page", "com.zoho.crm.api.RescheduleHistory.GetAppointmentsRescheduledHistoryParam");
			public static readonly Param<int?> PER_PAGE=new Param<int?>("per_page", "com.zoho.crm.api.RescheduleHistory.GetAppointmentsRescheduledHistoryParam");
			public static readonly Param<string> SORT_ORDER=new Param<string>("sort_order", "com.zoho.crm.api.RescheduleHistory.GetAppointmentsRescheduledHistoryParam");
			public static readonly Param<string> SORT_BY=new Param<string>("sort_by", "com.zoho.crm.api.RescheduleHistory.GetAppointmentsRescheduledHistoryParam");
			public static readonly Param<string> IDS=new Param<string>("ids", "com.zoho.crm.api.RescheduleHistory.GetAppointmentsRescheduledHistoryParam");
		}


		public static class GetAppointmentRescheduledHistoryParam
		{
			public static readonly Param<string> FIELDS=new Param<string>("fields", "com.zoho.crm.api.RescheduleHistory.GetAppointmentRescheduledHistoryParam");
		}

	}
}