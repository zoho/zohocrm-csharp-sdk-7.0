using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.Crm.API.ZiaOrgEnrichment;
using System.Collections.Generic;
using Com.Zoho.Crm.API;
using static Com.Zoho.Crm.API.ZiaOrgEnrichment.ZiaOrgEnrichmentOperations;
using Com.Zoho.Crm.API.Util;
using System.Reflection;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.API.Authenticator;
using Newtonsoft.Json;

namespace Samples.ZiaOrgEnrichment1
{
	public class CreateZiaOrgEnrichment
	{
		public static void CreateZiaOrgEnrichment_1()
		{
			ZiaOrgEnrichmentOperations ziaOrgEnrichmentOperations = new ZiaOrgEnrichmentOperations();
			BodyWrapper request = new BodyWrapper();
			List<ZiaOrgEnrichment> ziaorgenrichment = new List<ZiaOrgEnrichment>();
			ZiaOrgEnrichment ziaorgenrichment1 = new ZiaOrgEnrichment();
			EnrichBasedOn enrichBasedOn = new EnrichBasedOn();
			enrichBasedOn.Name = "zoho";
			enrichBasedOn.Email = "sales@zohocorp.com";
			enrichBasedOn.Website = "www.zoho.com";
			ziaorgenrichment1.EnrichBasedOn = enrichBasedOn;
			ziaorgenrichment.Add(ziaorgenrichment1);
			request.Ziaorgenrichment = ziaorgenrichment;
			ParameterMap paramInstance = new ParameterMap();
			paramInstance.Add(CreateZiaOrgEnrichmentParam.MODULE, "Vendors");
			APIResponse<ActionHandler> response = ziaOrgEnrichmentOperations.CreateZiaOrgEnrichment(request, paramInstance);
			if (response != null)
			{
				Console.WriteLine("Status Code: " + response.StatusCode);
				if (response.IsExpected)
				{
					ActionHandler actionHandler = response.Object;
					if (actionHandler is ActionWrapper)
					{
						ActionWrapper actionWrapper = (ActionWrapper) actionHandler;
						List<ActionResponse> actionresponses = actionWrapper.Ziaorgenrichment;
						foreach (ActionResponse actionresponse in actionresponses)
						{
							if (actionresponse is SuccessResponse)
							{
								SuccessResponse successresponse = (SuccessResponse) actionresponse;
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
                CreateZiaOrgEnrichment_1();
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
	}
}

