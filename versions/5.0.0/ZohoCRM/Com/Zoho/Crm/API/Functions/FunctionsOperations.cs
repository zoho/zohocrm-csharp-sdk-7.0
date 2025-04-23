using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Functions
{

	public class FunctionsOperations
	{
		private string authType;
		private string functionName;
		private Dictionary<string, object> arguments;

		/// <summary>		/// Creates an instance of FunctionsOperations with the given parameters
		/// <param name="functionName">string</param>
		/// <param name="authType">string</param>
		/// <param name="arguments">Dictionary<string,object></param>
		
		public FunctionsOperations(string functionName, string authType, Dictionary<string, object> arguments)
		{
			 this.functionName=functionName;

			 this.authType=authType;

			 this.arguments=arguments;


		}

		/// <summary>The method to execute function using request body</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <param name="headerInstance">Instance of HeaderMap</param>
		/// <returns>Instance of APIResponse<ResponseWrapper></returns>
		public APIResponse<ResponseWrapper> ExecuteFunctionUsingRequestBody(BodyWrapper request, ParameterMap paramInstance, HeaderMap headerInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/functions/");

			apiPath=string.Concat(apiPath,  this.functionName.ToString());

			apiPath=string.Concat(apiPath, "/actions/execute");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddParam(new Param<string>("auth_type", "com.zoho.crm.api.Functions.ExecuteFunctionUsingRequestBodyParam"),  this.authType);

			handlerInstance.AddParam(new Param<Dictionary<string, object>>("arguments", "com.zoho.crm.api.Functions.ExecuteFunctionUsingRequestBodyParam"),  this.arguments);

			handlerInstance.Param=paramInstance;

			handlerInstance.Header=headerInstance;

			return handlerInstance.APICall<ResponseWrapper>(typeof(ResponseWrapper), "application/json");


		}

		/// <summary>The method to execute function using parameters</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <param name="headerInstance">Instance of HeaderMap</param>
		/// <returns>Instance of APIResponse<ResponseWrapper></returns>
		public APIResponse<ResponseWrapper> ExecuteFunctionUsingParameters(ParameterMap paramInstance, HeaderMap headerInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/functions/");

			apiPath=string.Concat(apiPath,  this.functionName.ToString());

			apiPath=string.Concat(apiPath, "/actions/execute");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.AddParam(new Param<string>("auth_type", "com.zoho.crm.api.Functions.ExecuteFunctionUsingParametersParam"),  this.authType);

			handlerInstance.AddParam(new Param<Dictionary<string, object>>("arguments", "com.zoho.crm.api.Functions.ExecuteFunctionUsingParametersParam"),  this.arguments);

			handlerInstance.Param=paramInstance;

			handlerInstance.Header=headerInstance;

			return handlerInstance.APICall<ResponseWrapper>(typeof(ResponseWrapper), "application/json");


		}

		/// <summary>The method to execute function using file</summary>
		/// <param name="request">Instance of FileBodyWrapper</param>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <param name="headerInstance">Instance of HeaderMap</param>
		/// <returns>Instance of APIResponse<ResponseWrapper></returns>
		public APIResponse<ResponseWrapper> ExecuteFunctionUsingFile(FileBodyWrapper request, ParameterMap paramInstance, HeaderMap headerInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/functions/");

			apiPath=string.Concat(apiPath,  this.functionName.ToString());

			apiPath=string.Concat(apiPath, "/actions/execute");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			handlerInstance.AddParam(new Param<string>("auth_type", "com.zoho.crm.api.Functions.ExecuteFunctionUsingFileParam"),  this.authType);

			handlerInstance.AddParam(new Param<Dictionary<string, object>>("arguments", "com.zoho.crm.api.Functions.ExecuteFunctionUsingFileParam"),  this.arguments);

			handlerInstance.Param=paramInstance;

			handlerInstance.Header=headerInstance;

			return handlerInstance.APICall<ResponseWrapper>(typeof(ResponseWrapper), "application/json");


		}


		public static class ExecuteFunctionUsingRequestBodyParam
		{
			public static readonly Param<Dictionary<string, object>> CUSTOM_FUNCTIONS_PARAM=new Param<Dictionary<string, object>>("custom_functions_param", "com.zoho.crm.api.Functions.ExecuteFunctionUsingRequestBodyParam");
		}


		public static class ExecuteFunctionUsingRequestBodyHeader
		{
			public static readonly Header<Dictionary<string, object>> CUSTOM_FUNCTIONS_HEADER=new Header<Dictionary<string, object>>("custom_functions_header", "com.zoho.crm.api.Functions.ExecuteFunctionUsingRequestBodyHeader");
		}


		public static class ExecuteFunctionUsingParametersParam
		{
			public static readonly Param<Dictionary<string, object>> GET_CUSTOM_FUNCTIONS_PARAM=new Param<Dictionary<string, object>>("get_custom_functions_param", "com.zoho.crm.api.Functions.ExecuteFunctionUsingParametersParam");
		}


		public static class ExecuteFunctionUsingParametersHeader
		{
			public static readonly Header<Dictionary<string, object>> GET_CUSTOM_FUNCTIONS_HEADER=new Header<Dictionary<string, object>>("get_custom_functions_header", "com.zoho.crm.api.Functions.ExecuteFunctionUsingParametersHeader");
		}


		public static class ExecuteFunctionUsingFileParam
		{
			public static readonly Param<Dictionary<string, object>> UPLOAD_FILE_PARAM=new Param<Dictionary<string, object>>("upload_file_param", "com.zoho.crm.api.Functions.ExecuteFunctionUsingFileParam");
		}


		public static class ExecuteFunctionUsingFileHeader
		{
			public static readonly Header<Dictionary<string, object>> UPLOAD_FILE_HEADER=new Header<Dictionary<string, object>>("upload_file_header", "com.zoho.crm.api.Functions.ExecuteFunctionUsingFileHeader");
		}

	}
}