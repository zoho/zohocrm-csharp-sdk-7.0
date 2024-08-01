using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;
using System;

namespace Com.Zoho.Crm.API.EntityScores
{

	public class EntityScoresOperations
	{
		private string fields;
		private string cvid;

		/// <summary>		/// Creates an instance of EntityScoresOperations with the given parameters
		/// <param name="fields">string</param>
		/// <param name="cvid">string</param>
		
		public EntityScoresOperations(string fields, string cvid)
		{
			 this.fields=fields;

			 this.cvid=cvid;


		}

		/// <summary>The method to get entity score</summary>
		/// <param name="recordId">long?</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetEntityScore(long? recordId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Entity_Scores__s/");

			apiPath=string.Concat(apiPath, recordId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("fields", "com.zoho.crm.api.EntityScores.GetEntityScoreParam"),  this.fields);

			handlerInstance.AddParam(new Param<string>("cvid", "com.zoho.crm.api.EntityScores.GetEntityScoreParam"),  this.cvid);

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to get entity scores</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <param name="headerInstance">Instance of HeaderMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetEntityScores(ParameterMap paramInstance, HeaderMap headerInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/Entity_Scores__s");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("fields", "com.zoho.crm.api.EntityScores.GetEntityScoresParam"),  this.fields);

			handlerInstance.AddParam(new Param<string>("cvid", "com.zoho.crm.api.EntityScores.GetEntityScoresParam"),  this.cvid);

			handlerInstance.Param=paramInstance;

			handlerInstance.Header=headerInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetEntityScoreParam
		{
		}


		public static class GetEntityScoresParam
		{
			public static readonly Param<string> IDS=new Param<string>("ids", "com.zoho.crm.api.EntityScores.GetEntityScoresParam");
			public static readonly Param<string> SORT_BY=new Param<string>("sort_by", "com.zoho.crm.api.EntityScores.GetEntityScoresParam");
			public static readonly Param<string> SORT_ORDER=new Param<string>("sort_order", "com.zoho.crm.api.EntityScores.GetEntityScoresParam");
			public static readonly Param<int?> PAGE=new Param<int?>("page", "com.zoho.crm.api.EntityScores.GetEntityScoresParam");
			public static readonly Param<int?> PER_PAGE=new Param<int?>("per_page", "com.zoho.crm.api.EntityScores.GetEntityScoresParam");
			public static readonly Param<string> PAGE_TOKEN=new Param<string>("page_token", "com.zoho.crm.api.EntityScores.GetEntityScoresParam");
		}


		public static class GetEntityScoresHeader
		{
			public static readonly Header<DateTimeOffset?> IF_MODIFIED_SINCE=new Header<DateTimeOffset?>("If-Modified-Since", "com.zoho.crm.api.EntityScores.GetEntityScoresHeader");
		}

	}
}