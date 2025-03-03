using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.Crm.API.MassDeleteTags;
using Com.Zoho.Crm.API;
using static Com.Zoho.Crm.API.MassDeleteTags.MassDeleteTagsOperations;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;
using System.Reflection;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.API.Authenticator;
using Newtonsoft.Json;

namespace Samples.MassDeleteTags1
{
	public class GetStatus
	{
		public static void GetStatus_1()
		{
			MassDeleteTagsOperations massDeleteTagsOperations = new MassDeleteTagsOperations();
			ParameterMap paramInstance = new ParameterMap();
			paramInstance.Add(GetStatusParam.JOB_ID, "3477022003");
			APIResponse<StatusResponseHandler> response = massDeleteTagsOperations.GetStatus(paramInstance);
			if (response != null)
			{
				Console.WriteLine("Status Code: " + response.StatusCode);
				if (response.IsExpected)
				{
					StatusResponseHandler responseHandler = response.Object;
					if (responseHandler is StatusResponseWrapper)
					{
						StatusResponseWrapper statusResponseWrapper = (StatusResponseWrapper) responseHandler;
						List<StatusActionResponse> statusActionResponse = statusResponseWrapper.MassDelete;
						foreach (StatusActionResponse statusActionResponse1 in statusActionResponse)
						{
							if (statusActionResponse1 is MassDeleteDetails)
							{
								MassDeleteDetails massDeleteDetail = (MassDeleteDetails) statusActionResponse1;
								Console.WriteLine("Status JobId: " + massDeleteDetail.JobId);
								Console.WriteLine("Status TotalCount: " + massDeleteDetail.TotalCount);
								Console.WriteLine("Status FailedCount: " + massDeleteDetail.FailedCount);
								Console.WriteLine("Status DeletedCount: " + massDeleteDetail.DeletedCount);
								Console.WriteLine("Job Status: " + massDeleteDetail.Status.Value);
							}
							else if (statusActionResponse1 is APIException)
							{
								APIException exception = (APIException)statusActionResponse1;
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
                IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").RedirectURL("Redirect_URL").Build();
                new Initializer.Builder().Environment(environment).Token(token).Initialize();
                GetStatus_1();
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
	}
}

