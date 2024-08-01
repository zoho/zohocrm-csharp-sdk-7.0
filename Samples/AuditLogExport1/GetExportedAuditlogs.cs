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
	public class GetExportedAuditlogs
	{
		public static void GetExportedAuditlogs_1()
		{
			AuditLogExportOperations auditLogExportOperations = new AuditLogExportOperations();
			APIResponse<ResponseHandler> response = auditLogExportOperations.GetExportedAuditlogs();
			if (response != null)
			{
				Console.WriteLine("Status Code: " + response.StatusCode);
				if (response.IsExpected)
				{
					ResponseHandler actionHandler = response.Object;
					if (actionHandler is ResponseWrapper)
					{
						ResponseWrapper responseWrapper = (ResponseWrapper)actionHandler;
						List<AuditLogExport> auditLogExport = responseWrapper.AuditLogExport;
						if (auditLogExport != null)
						{
							foreach (AuditLogExport auditLogExport1 in auditLogExport)
							{
								Criteria criteria = auditLogExport1.Criteria;
								if (criteria != null)
								{
									PrintCriteria(criteria);
								}
								Console.WriteLine("AuditLogExport Id : " + auditLogExport1.Id);
								Console.WriteLine("AuditLogExport Status : " + auditLogExport1.Status);
								User createdBy = auditLogExport1.CreatedBy;
								if(createdBy != null)
								{
								   Console.WriteLine("AuditLogExport User Id : " + createdBy.Id);
								   Console.WriteLine("AuditLogExport User Id : " + createdBy.Name);
								}
								List<String> downloadLinks = auditLogExport1.DownloadLinks;
								if(downloadLinks != null)
								{
									foreach (String link in downloadLinks)
									{
										Console.WriteLine("AuditLogExport DownloadLink : " + link);
									}
								}
								Console.WriteLine("AuditLogExport JobStartTime : " + auditLogExport1.JobStartTime);
								Console.WriteLine("AuditLogExport JobEndTime : " + auditLogExport1.JobEndTime);
								Console.WriteLine("AuditLogExport ExpiryDate : " + auditLogExport1.ExpiryDate);
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

		private static void PrintCriteria(Criteria criteria)
		{
			if (criteria.Comparator != null)
			{
			   Console.WriteLine("ExportedAuditlogs Criteria Comparator: " + criteria.Comparator);
			}
			if (criteria.Value != null)
			{
			   Console.WriteLine("ExportedAuditlogs Criteria Value: " + criteria.Value);
			}
			if (criteria.Field != null)
			{
			   Console.WriteLine("ExportedAuditlogs Criteria field name: " + criteria.Field.APIName);
			}
			List<Criteria> criteriaGroup = criteria.Group;
			if (criteriaGroup != null)
			{
				foreach (Criteria criteria1 in criteriaGroup)
				{
					PrintCriteria(criteria1);
				}
			}
			if (criteria.GroupOperator != null)
			{
			   Console.WriteLine("ExportedAuditlogs Criteria Group Operator: " + criteria.GroupOperator);
			}
		}

		public static void Call()
		{
			try
			{
				Environment environment = USDataCenter.PRODUCTION;
				IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").RedirectURL("Redirect_URL").Build();
				new Initializer.Builder().Environment(environment).Token(token).Initialize();
				GetExportedAuditlogs_1();
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}

