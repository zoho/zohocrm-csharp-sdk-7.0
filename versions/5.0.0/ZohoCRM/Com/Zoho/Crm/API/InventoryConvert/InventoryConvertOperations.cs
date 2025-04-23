using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.InventoryConvert
{

	public class InventoryConvertOperations
	{
		private string moduleAPIName;
		private long? id;

		/// <summary>		/// Creates an instance of InventoryConvertOperations with the given parameters
		/// <param name="id">long?</param>
		/// <param name="moduleAPIName">string</param>
		
		public InventoryConvertOperations(long? id, string moduleAPIName)
		{
			 this.id=id;

			 this.moduleAPIName=moduleAPIName;


		}

		/// <summary>The method to convert inventory</summary>
		/// <param name="request">Instance of BodyWrapper</param>
		/// <returns>Instance of APIResponse<ActionHandler></returns>
		public APIResponse<ActionHandler> ConvertInventory(BodyWrapper request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v7/");

			apiPath=string.Concat(apiPath,  this.moduleAPIName.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.id.ToString());

			apiPath=string.Concat(apiPath, "/actions/convert");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_CREATE;

			handlerInstance.ContentType="application/json";

			handlerInstance.Request=request;

			handlerInstance.MandatoryChecker=true;

			return handlerInstance.APICall<ActionHandler>(typeof(ActionHandler), "application/json");


		}


	}
}