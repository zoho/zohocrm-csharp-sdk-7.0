using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.InventoryConvert;
using System.Collections.Generic;
using Com.Zoho.Crm.API.Util;
using Newtonsoft.Json;
using System.Reflection;
using Module = Com.Zoho.Crm.API.InventoryConvert.Module;

namespace Samples.InventoryConvert
{
    public class ConvertInventory
	{
		public static void ConvertInventory_1(long id, String moduleAPIName)
		{
			InventoryConvertOperations inventoryConvertOperations = new InventoryConvertOperations(id, moduleAPIName);
			BodyWrapper request = new BodyWrapper();
			List<InventoryConverter> data = new List<InventoryConverter>();
			InventoryConverter record1 = new InventoryConverter();
			List<ConvertTo> convertToList = new List<ConvertTo>();
			ConvertTo convertTo = new ConvertTo();
			Module module = new Module();
			module.APIName = "Sales_Orders";
			module.Id = 347702221;
			convertTo.Module = module;
			convertToList.Add(convertTo);
			record1.ConvertTo = convertToList;
			data.Add(record1);
			request.Data = data;
			APIResponse<ActionHandler> response = inventoryConvertOperations.ConvertInventory(request);
			if (response != null)
			{
				Console.WriteLine("Status Code: " + response.StatusCode);
				if (response.IsExpected)
				{
					ActionHandler actionHandler = response.Object;
					if (actionHandler is ActionWrapper)
					{
						ActionWrapper actionWrapper = (ActionWrapper)actionHandler;
						List<ActionResponse> actionResponses = actionWrapper.Data;
						foreach (ActionResponse actionResponse in actionResponses)
						{
							if (actionResponse is SuccessResponse)
							{
								SuccessResponse successResponse = (SuccessResponse)actionResponse;
								Console.WriteLine("Status: " + successResponse.Status.Value);
								Console.WriteLine("Code: " + successResponse.Code.Value);
								Console.WriteLine("Details: ");
								foreach (KeyValuePair<string, object> entry in successResponse.Details)
								{
									Console.WriteLine(entry.Key + ": " + entry.Value);
								}
								Console.WriteLine("Message: " + successResponse.Message.Value);
							}
							else if (actionResponse is APIException)
							{
								APIException exception = (APIException)actionResponse;
								Console.WriteLine("Status: " + exception.Status.Value);
								Console.WriteLine("Code: " + exception.Code.Value);
								Console.WriteLine("Details: ");
								foreach (KeyValuePair<string, object> entry in exception.Details)
								{
									Console.WriteLine(entry.Key + ": " + entry.Value);
								}
								Console.WriteLine("Message: " + exception.Message.Value);
							}
						}
					}
					else if (actionHandler is APIException)
					{
						APIException exception = (APIException)actionHandler;
						Console.WriteLine("Status: " + exception.Status.Value);
						Console.WriteLine("Code: " + exception.Code.Value);
						Console.WriteLine("Details: ");
						foreach (KeyValuePair<string, object> entry in exception.Details)
						{
							Console.WriteLine(entry.Key + ": " + entry.Value);
						}
						Console.WriteLine("Message: " + exception.Message.Value);
					}
				}
				else
				{
					Model responseObject = response.Model;
					Type type = responseObject.GetType();
					Console.WriteLine("Type is : {0}", type.Name);
					PropertyInfo[] props = type.GetProperties();
					Console.WriteLine("Properties (N = {0}) :", props.Length);
					foreach (var prop in props)
					{
						if (prop.GetIndexParameters().Length == 0)
						{
							Console.WriteLine("{0} ({1}) in {2}", prop.Name, prop.PropertyType.Name, prop.GetValue(responseObject));
						}
						else
						{
							Console.WriteLine("{0} ({1}) in <Indexed>", prop.Name, prop.PropertyType.Name);
						}
					}
				}
			}
		}

		public static void Call()
		{
			try
			{
				Environment environment = USDataCenter.PRODUCTION;
				IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").Build();
				new Initializer.Builder().Environment(environment).Token(token).Initialize();
				long id = 347706121168;
				String moduleAPIName = "Quotes";
				ConvertInventory_1(id, moduleAPIName);
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}