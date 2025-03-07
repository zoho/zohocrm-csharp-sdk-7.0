using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.RecycleBin;
using static Com.Zoho.Crm.API.RecycleBin.RecycleBinOperations;
using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;
using Com.Zoho.Crm.API.Users;
using ResponseWrapper = Com.Zoho.Crm.API.RecycleBin.ResponseWrapper;
using APIException = Com.Zoho.Crm.API.RecycleBin.APIException;
using Com.Zoho.Crm.API.Modules;
using ResponseHandler = Com.Zoho.Crm.API.RecycleBin.ResponseHandler;
using Info = Com.Zoho.Crm.API.RecycleBin.Info;
using System.Reflection;
using Newtonsoft.Json;

namespace Samples.RecycleBin1
{
	public class GetRecyclebinRecords
	{
		public static void GetRecyclebinRecords_1()
		{
			RecycleBinOperations recycleBinOperations = new RecycleBinOperations();
			ParameterMap paramInstance = new ParameterMap();
			paramInstance.Add(GetRecycleBinRecordsParam.IDS, "347704108020");
			paramInstance.Add(GetRecycleBinRecordsParam.SORT_BY, "");
			paramInstance.Add(GetRecycleBinRecordsParam.SORT_ORDER, "");
			paramInstance.Add(GetRecycleBinRecordsParam.PAGE, 1);
			paramInstance.Add(GetRecycleBinRecordsParam.PER_PAGE, 10);
			paramInstance.Add(GetRecycleBinRecordsParam.FILTERS, "{\"group_operator\": \"AND\",\"group\": [{\"field\": {\"api_name\": \"module\"},\"comparator\": \"equal\",\"value\": \"Leads\"}]}}");
			APIResponse<ResponseHandler> response = recycleBinOperations.GetRecyclebinRecords(paramInstance);
			if (response != null)
			{
				Console.WriteLine("Status Code: " + response.StatusCode);
				if (new List<int>() { 204, 304 }.Contains(response.StatusCode))
				{
					Console.WriteLine(response.StatusCode == 204 ? "No Content" : "Not Modified");
					return;
				}
				if (response.IsExpected)
				{
					ResponseHandler responseHandler = response.Object;
					if (responseHandler is ResponseWrapper)
					{
						ResponseWrapper responseWrapper = (ResponseWrapper)responseHandler;
						List<RecycleBin> recycleBin = responseWrapper.RecycleBin;
						foreach (RecycleBin recycleBin1 in recycleBin)
						{
							MinifiedUser owner = recycleBin1.Owner;
							if (owner != null)
							{
								Console.WriteLine("RecycleBin Owner Name: " + owner.Name);
								Console.WriteLine("RecycleBin Owner Id: " + owner.Id);
							}
							MinifiedModule module = recycleBin1.Module;
							if (module != null)
							{
								Console.WriteLine("RecycleBin Module APIName: " + module.APIName);
								Console.WriteLine("RecycleBin Module Id: " + module.Id);
							}
							MinifiedUser deletedBy = recycleBin1.DeletedBy;
							if (deletedBy != null)
							{
								Console.WriteLine("RecycleBin DeletedBy User Name: " + deletedBy.Name);
								Console.WriteLine("RecycleBin DeletedBy User Id: " + deletedBy.Id);
							}
							Console.WriteLine("RecycleBin ID: " + recycleBin1.Id);
							Console.WriteLine("RecycleBin DisplayName: " + recycleBin1.DisplayName);
							Console.WriteLine("RecycleBin DeletedTime: " + recycleBin1.DeletedTime);
						}

						Info info = responseWrapper.Info;
						Console.WriteLine("RecycleBin Info Count: " + info.Count);
						Console.WriteLine("RecycleBin Info Page: " + info.Page);
						Console.WriteLine("RecycleBin Info PerPage: " + info.PerPage);
						Console.WriteLine("RecycleBin Info MoreRecords: " + info.MoreRecords);
					}
					else if (responseHandler is APIException)
					{
						APIException exception = (APIException)responseHandler;
						Console.WriteLine("Status: " + exception.Status.Value);
						Console.WriteLine("Code: " + exception.Code.Value);
						Console.WriteLine("Details: ");
						foreach (KeyValuePair<string, object> entry in exception.Details)
						{
							Console.WriteLine(entry.Key + ": " + entry.Value);
						}
						Console.WriteLine("Message: " + exception.Message);
					}
				}
				else
				{
					Model responseObject = response.Model;
					System.Type type = responseObject.GetType();
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
				GetRecyclebinRecords_1();
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}