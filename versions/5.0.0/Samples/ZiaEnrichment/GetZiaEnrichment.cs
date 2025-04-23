using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.ZiaEnrichment;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Module = Com.Zoho.Crm.API.ZiaEnrichment.Module;

namespace Samples.ZiaEnrichment
{
	public class GetZiaEnrichment
	{
		public static void GetZiaEnrichment_1()
		{
			ZiaEnrichmentOperations ziaEnrichmentOperations = new ZiaEnrichmentOperations();
			APIResponse<ResponseHandler> response = ziaEnrichmentOperations.GetZiaEnrichment();
			if (response != null)
			{
				Console.WriteLine("Status Code: " + response.StatusCode);
				if (response.StatusCode == 204)
				{
					Console.WriteLine("No Content");
					return;
				}
				if (response.IsExpected)
				{
					ResponseHandler responseHandler = response.Object;
					if (responseHandler is ResponseWrapper)
					{
						ResponseWrapper responseWrapper = (ResponseWrapper)responseHandler;
						List<DataEnrichment> dataEnrichment = responseWrapper.DataEnrichment;
						if (dataEnrichment != null)
						{
							foreach (DataEnrichment dataEnrichment1 in dataEnrichment)
							{
								Module module = dataEnrichment1.Module;
								if (module != null)
								{
									Console.WriteLine("DataEnrichment Module OrgStatus : " + module.APIName);
									Console.WriteLine("DataEnrichment Module Id : " + module.Id);
								}

								Console.WriteLine("DataEnrichment Type : " + dataEnrichment1.Type);
								List<OutputData> outputDataFieldMapping = dataEnrichment1.OutputDataFieldMapping;
								if (outputDataFieldMapping != null)
								{
									foreach (OutputData outputDataFieldMapping1 in outputDataFieldMapping)
									{
										EnrichField enrichField = outputDataFieldMapping1.EnrichField;
										if (enrichField != null)
										{
											Console.WriteLine("DataEnrichment OutputDataFieldMapping EnrichField Name: " + enrichField.Name);
											Console.WriteLine("DataEnrichment OutputDataFieldMapping EnrichField DisplayLabel : " + enrichField.DisplayLabel);
										}
										CrmField crmField = outputDataFieldMapping1.CrmField;
										if (crmField != null)
										{
											Console.WriteLine("DataEnrichment OutputDataFieldMapping CrmField Id: " + crmField.Id);
											Console.WriteLine("DataEnrichment OutputDataFieldMapping CrmField APIName : " + crmField.APIName);
											Console.WriteLine("DataEnrichment OutputDataFieldMapping CrmField Name : " + crmField.Name);
										}
									}
								}
								List<InputData> inputDataFieldMapping = dataEnrichment1.InputDataFieldMapping;
								if (inputDataFieldMapping != null)
								{
									foreach (InputData inputDataFieldMapping1 in inputDataFieldMapping)
									{
										EnrichField enrichField = inputDataFieldMapping1.EnrichField;
										if (enrichField != null)
										{
											Console.WriteLine("DataEnrichment OutputDataFieldMapping EnrichField Name: " + enrichField.Name);
											Console.WriteLine("DataEnrichment OutputDataFieldMapping EnrichField DisplayLabel : " + enrichField.DisplayLabel);
										}
										CrmField crmField = inputDataFieldMapping1.CrmField;
										if (crmField != null)
										{
											Console.WriteLine("DataEnrichment OutputDataFieldMapping CrmField Id: " + crmField.Id);
											Console.WriteLine("DataEnrichment OutputDataFieldMapping CrmField APIName : " + crmField.APIName);
											Console.WriteLine("DataEnrichment OutputDataFieldMapping CrmField Name : " + crmField.Name);
										}
									}
								}
								Console.WriteLine("DataEnrichment Id : " + dataEnrichment1.Id);
								Console.WriteLine("DataEnrichment Status : " + dataEnrichment1.Status);
								Console.WriteLine("DataEnrichment CreatedTime : " + dataEnrichment1.CreatedTime);
								User createdBy = dataEnrichment1.CreatedBy;
								if (createdBy != null)
								{
									Console.WriteLine("DataEnrichment CreatedBy User Id : " + createdBy.Id);
									Console.WriteLine("DataEnrichment CreatedBy User Name: " + createdBy.Name);
								}
								Console.WriteLine("DataEnrichment ModifiedTime : " + dataEnrichment1.ModifiedTime);
								User modifiedBy = dataEnrichment1.ModifiedBy;
								if (modifiedBy != null)
								{
									Console.WriteLine("DataEnrichment ModifiedBy User Id : " + modifiedBy.Id);
									Console.WriteLine("DataEnrichment ModifiedBy User Name: " + modifiedBy.Name);
								}
							}
						}
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
				else if (response.StatusCode != 204)
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
				GetZiaEnrichment_1();
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}
