using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.Crm.API.ZiaPeopleEnrichment;
using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;
using System.Reflection;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.API.Authenticator;
using Newtonsoft.Json;

namespace Samples.ZiaPeopleEnrichment1
{
	public class GetZiaPeopleEnrichments
	{
		public static void GetZiaPeopleEnrichments_1()
		{
			ZiaPeopleEnrichmentOperations ziaPeopleEnrichmentOperations = new ZiaPeopleEnrichmentOperations();
			ParameterMap paramInstance = new ParameterMap();
			APIResponse<ResponseHandler> response = ziaPeopleEnrichmentOperations.GetZiaPeopleEnrichments(paramInstance);
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
						List<ZiaPeopleEnrichment> ziapeopleenrichment = responseWrapper.Ziapeopleenrichment;
						if(ziapeopleenrichment != null)
						{
							foreach(ZiaPeopleEnrichment ziapeopleenrichment1 in ziapeopleenrichment)
							{
								Console.WriteLine("ZiaPeopleEnrichment CreatedTime : " + ziapeopleenrichment1.CreatedTime);
								Console.WriteLine("ZiaPeopleEnrichment Id : " + ziapeopleenrichment1.Id);
								User user = ziapeopleenrichment1.CreatedBy;
								if(user != null)
								{
									Console.WriteLine("ZiaPeopleEnrichment User Id : " + user.Id);
									Console.WriteLine("ZiaPeopleEnrichment User Name : " + user.Name);
								}
								Console.WriteLine("ZiaPeopleEnrichment Status : " + ziapeopleenrichment1.Status);
							}
						}
						Info info = responseWrapper.Info;
						if (info != null)
						{
							if (info.PerPage != null)
							{
								Console.WriteLine("ZiaPeopleEnrichment Info PerPage: " + info.PerPage);
							}
							if (info.Count != null)
							{
								Console.WriteLine("ZiaPeopleEnrichment Info Count: " + info.Count);
							}
							if (info.Page != null)
							{
								Console.WriteLine("ZiaPeopleEnrichment Info Page: " + info.Page);
							}
							if (info.MoreRecords != null)
							{
								Console.WriteLine("ZiaPeopleEnrichment Info MoreRecords: " + info.MoreRecords);
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
                GetZiaPeopleEnrichments_1();
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
	}
}

