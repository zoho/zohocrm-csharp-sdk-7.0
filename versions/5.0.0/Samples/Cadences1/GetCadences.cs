using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.Cadences;
using Com.Zoho.Crm.API.Util;
using Newtonsoft.Json;
using System.Reflection;
using System.Collections.Generic;
using Module = Com.Zoho.Crm.API.Cadences.Module;

namespace Samples.Cadences1
{
	public class GetCadences
	{
		public static void GetCadences_1()
		{
			CadencesOperations cadencesOperations = new CadencesOperations();
			APIResponse<ResponseHandler> response = cadencesOperations.GetCadences();
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
						ResponseWrapper responseWrapper = (ResponseWrapper) responseHandler;
						List<Cadences> cadences = responseWrapper.Cadences;
						foreach (Cadences cadence in cadences)
						{
							Summary summary = cadence.Summary;
							if(summary != null)
							{
								Console.WriteLine("Cadences Summary TaskFollowUpCount: " + summary.TaskFollowUpCount);
								Console.WriteLine("Cadences Summary CallFollowUpCount: " + summary.CallFollowUpCount);
								Console.WriteLine("Cadences Summary EmailFollowUpCount: " + summary.EmailFollowUpCount);
							}
							Console.WriteLine("Cadences CreatedTime: " + cadence.CreatedTime);
							Module module = cadence.Module;
							if(module != null)
							{
								Console.WriteLine("Cadences Module APIName: " + module.APIName);
								Console.WriteLine("Cadences Module Id: " + module.Id);
							}
							Console.WriteLine("Cadences Active: " + cadence.Active);
							ExecutionDetail executionDetails = cadence.ExecutionDetails;
							if(executionDetails != null)
							{
								UnenrollProperty unenrollProperties = executionDetails.UnenrollProperties;
								if(unenrollProperties != null)
								{
									Console.WriteLine("Cadences ExecutionDetails UnenrollProperty EndDate: " + unenrollProperties.EndDate);
									Console.WriteLine("Cadences ExecutionDetails UnenrollProperty Type: " + unenrollProperties.Type);
								}
								Console.WriteLine("Cadences ExecutionDetails EndDate: " + executionDetails.EndDate);
								Console.WriteLine("Cadences ExecutionDetails AutomaticUnenroll: " + executionDetails.AutomaticUnenroll);
								Console.WriteLine("Cadences ExecutionDetails Type: " + executionDetails.Type);
								ExecuteEvery executeEvery = executionDetails.ExecuteEvery;
								if(executeEvery != null)
								{
									Console.WriteLine("Cadences ExecutionDetails ExecuteEvery Unit: " + executeEvery.Unit);
									Console.WriteLine("Cadences ExecutionDetails ExecuteEvery Period: " + executeEvery.Period);
								}
							}
							Console.WriteLine("Cadences Published: " + cadence.Published);
							Console.WriteLine("Cadences Type: " + cadence.Type);
							User createdBy = cadence.CreatedBy;
							if(createdBy != null)
							{
								Console.WriteLine("Cadences CreatedBy User Name: " + createdBy.Name);
								Console.WriteLine("Cadences CreatedBy User Id: " + createdBy.Id);
							}
							Console.WriteLine("Cadences ModifiedTime: " + cadence.ModifiedTime);
							Console.WriteLine("Cadences Name: " + cadence.Name);
							User modifiedBy = cadence.ModifiedBy;
							if(modifiedBy != null)
							{
								Console.WriteLine("Cadences ModifiedBy User Name: " + modifiedBy.Name);
								Console.WriteLine("Cadences ModifiedBy User Id: " + modifiedBy.Id);
							}
							Console.WriteLine("Cadences Id: " + cadence.Id);
							CustomView customView = cadence.CustomView;
							if(customView != null)
							{
								Console.WriteLine("Cadences CustomView Id: " + customView.Id);
								Console.WriteLine("Cadences CustomView Name: " + customView.Name);
							}
							Console.WriteLine("Cadences Status: " + cadence.Status);
						}
						Info info = responseWrapper.Info;
						if(info != null)
						{
							Console.WriteLine("Cadences Info PerPage: " + info.PerPage);
							Console.WriteLine("Cadences Info Page: " + info.Page);
							Console.WriteLine("Cadences Info Count: " + info.Count);
							Console.WriteLine("Cadences Info MoreRecords: " + info.MoreRecords);
						}
					}
					else if (responseHandler is APIException)
					{
						APIException exception = (APIException) responseHandler;
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
                GetCadences_1();
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}