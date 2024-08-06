using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.Crm.API.ZiaPeopleEnrichment;
using System.Collections.Generic;
using Com.Zoho.Crm.API;
using static Com.Zoho.Crm.API.ZiaPeopleEnrichment.ZiaPeopleEnrichmentOperations;
using Com.Zoho.Crm.API.Util;
using System.Reflection;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.API.Authenticator;
using Newtonsoft.Json;

namespace Samples.ZiaPeopleEnrichment1
{
	public class CreateZiaPeopleEnrichment
	{
		public static void CreateZiaPeopleEnrichment_1()
		{
			ZiaPeopleEnrichmentOperations ziaPeopleEnrichmentOperations = new ZiaPeopleEnrichmentOperations();
			BodyWrapper request = new BodyWrapper();
			List<ZiaPeopleEnrichment> ziapeopleenrichment = new List<ZiaPeopleEnrichment>();
			ZiaPeopleEnrichment ziapeopleenrichment1 = new ZiaPeopleEnrichment();
			EnrichBasedOn enrichBasedOn = new EnrichBasedOn();
			enrichBasedOn.Name = "zoho";
			enrichBasedOn.Email = "sales@zohocorp.com";
			Company company = new Company();
			company.Name = "zoho";
			company.Website = "www.zoho.com";
			enrichBasedOn.Company = company;
			Social social = new Social();
			social.Facebook = "facebook.com/zoho";
			social.Linkedin = "linkedin.com/zoho";
			social.Twitter = "twitter.com/zoho";
			enrichBasedOn.Social = social;
			ziapeopleenrichment1.EnrichBasedOn = enrichBasedOn;
			ziapeopleenrichment.Add(ziapeopleenrichment1);
			request.Ziapeopleenrichment = ziapeopleenrichment;
			ParameterMap paramInstance = new ParameterMap();
			paramInstance.Add(CreateZiaPeopleEnrichmentParam.MODULE, "Leads");
			APIResponse<ActionHandler> response = ziaPeopleEnrichmentOperations.CreateZiaPeopleEnrichment(request, paramInstance);
			if (response != null)
			{
				Console.WriteLine("Status Code: " + response.StatusCode);
				if (response.IsExpected)
				{
                    ActionHandler actionHandler = response.Object;
					if (actionHandler is ActionWrapper)
					{
						ActionWrapper actionWrapper = (ActionWrapper) actionHandler;
						List<ActionResponse> actionresponses = actionWrapper.Ziapeopleenrichment;
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
								APIException exception = (APIException) actionresponse;
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
						APIException exception = (APIException) actionHandler;
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
				CreateZiaPeopleEnrichment_1();
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
	}
}

