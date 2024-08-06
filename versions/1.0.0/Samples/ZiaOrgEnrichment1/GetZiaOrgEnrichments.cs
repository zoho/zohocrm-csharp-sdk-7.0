using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.ZiaOrgEnrichment;
using Com.Zoho.Crm.API;
using System.Collections.Generic;
using System.Reflection;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.API.Authenticator;
using Newtonsoft.Json;

namespace Samples.ZiaOrgEnrichment1
{
	public class GetZiaOrgEnrichments
	{
		public static void GetZiaOrgEnrichments_1()
		{
			ZiaOrgEnrichmentOperations ziaOrgEnrichmentOperations = new ZiaOrgEnrichmentOperations();
			ParameterMap paramInstance = new ParameterMap();
			APIResponse<ResponseHandler> response = ziaOrgEnrichmentOperations.GetZiaOrgEnrichments(paramInstance);
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
						ResponseWrapper responseWrapper = (ResponseWrapper) responseHandler;
						List<ZiaOrgEnrichment> ziaorgenrichment = responseWrapper.Ziaorgenrichment;
						if(ziaorgenrichment != null)
						{
							foreach(ZiaOrgEnrichment ziaorgenrichment1 in ziaorgenrichment)
							{
								Console.WriteLine("ZiaOrgEnrichment CreatedTime : " + ziaorgenrichment1.CreatedTime);
								Console.WriteLine("ZiaOrgEnrichment Id : " + ziaorgenrichment1.Id);
								User user = ziaorgenrichment1.CreatedBy;
								if(user != null)
								{
									Console.WriteLine("ZiaOrgEnrichment User Id : " + user.Id);
									Console.WriteLine("ZiaOrgEnrichment User Name : " + user.Name);
								}
								Console.WriteLine("ZiaOrgEnrichment Status : " + ziaorgenrichment1.Status);
							}
						}
						
						Info info = responseWrapper.Info;
						if (info != null)
						{
							if (info.PerPage != null)
							{
								Console.WriteLine("ZiaOrgEnrichment Info PerPage: " + info.PerPage);
							}
							if (info.Count != null)
							{
								Console.WriteLine("ZiaOrgEnrichment Info Count: " + info.Count);
							}
							if (info.Page != null)
							{
								Console.WriteLine("ZiaOrgEnrichment Info Page: " + info.Page);
							}
							if (info.MoreRecords != null)
							{
								Console.WriteLine("ZiaOrgEnrichment Info MoreRecords: " + info.MoreRecords);
							}
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
                IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").RedirectURL("Redirect_URL").Build();
                new Initializer.Builder().Environment(environment).Token(token).Initialize();
                GetZiaOrgEnrichments_1();
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
	}
}

