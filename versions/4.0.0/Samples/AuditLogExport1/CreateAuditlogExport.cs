using System;
using System.Collections.Generic;
using System.Reflection;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.AuditLogExport;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.Util;
using Newtonsoft.Json;

namespace Samples.AuditLogExport1
{
    public class CreateAuditlogExport
	{
		public static void CreateAuditlogExport_1()
		{
			AuditLogExportOperations auditLogExportOperations = new AuditLogExportOperations();
			BodyWrapper request = new BodyWrapper();
			List<AuditLogExport> auditLogExport = new List<AuditLogExport>();
			AuditLogExport auditLogExport1 = new AuditLogExport();
			Criteria criteria = new Criteria();
			criteria.Comparator = "between";
			Field field = new Field();
			field.APIName = "audited_time";
			criteria.Field = field;
			List<DateTimeOffset> values = new List<DateTimeOffset>();
			values.Add(new DateTimeOffset(new DateTime(2020, 05, 15, 12, 0, 0, DateTimeKind.Local)));
			values.Add(new DateTimeOffset(new DateTime(2020, 05, 15, 12, 0, 0, DateTimeKind.Local)));
			criteria.Value = values;
			auditLogExport1.Criteria = criteria;
			auditLogExport.Add(auditLogExport1);
			request.AuditLogExport = auditLogExport;
			APIResponse<ActionHandler> response = auditLogExportOperations.CreateAuditlogExport(request);
			if (response != null)
			{
				Console.WriteLine("Status Code: " + response.StatusCode);
				if (response.IsExpected)
				{
					ActionHandler actionHandler = response.Object;
					if (actionHandler is ActionWrapper)
					{
						ActionWrapper actionWrapper = (ActionWrapper)actionHandler;
						List<ActionResponse> actionresponses = actionWrapper.AuditLogExport;
						foreach (ActionResponse actionresponse in actionresponses)
						{
							if (actionresponse is SuccessResponse)
							{
								SuccessResponse successresponse = (SuccessResponse)actionresponse;
								Console.WriteLine("Status: " + successresponse.Status.Value);
								Console.WriteLine("Code: " + successresponse.Code.Value);
								Console.WriteLine("Details: ");
								foreach (KeyValuePair<string, object> entry in successresponse.Details)
								{
									Console.WriteLine(entry.Key + ": " + entry.Value);
								}
								Console.WriteLine("Message: " + successresponse.Message);
							}
							else if (actionresponse is APIException)
							{
								APIException exception = (APIException)actionresponse;
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
			IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").RedirectURL("Redirect_URL").Build();
			new Initializer.Builder().Environment(environment).Token(token).Initialize();
			CreateAuditlogExport_1();
		}
		catch (Exception e)
		{
			Console.WriteLine(JsonConvert.SerializeObject(e));
		}
	}
}
}

