using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.Crm.API.MassDeleteTags;
using System.Collections.Generic;
using Com.Zoho.Crm.API.Util;
using System.Reflection;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.API.Authenticator;
using Newtonsoft.Json;
using Module = Com.Zoho.Crm.API.MassDeleteTags.Module;

namespace Samples.MassDeleteTags1
{
	public class MassDeleteTags
	{
		public static void MassDeleteTags_1()
		{
			MassDeleteTagsOperations massDeleteTagsOperations = new MassDeleteTagsOperations();
			BodyWrapper request = new BodyWrapper();
			List<MassDelete> massDelete = new List<MassDelete>();
			MassDelete massDelete1 = new MassDelete();
			Module module = new Module();
			module.APIName = "Leads";
			module.Id = 347706002175l;
			massDelete1.Module = module;
			List<Tag> tags = new List<Tag>();
			Tag tag = new Tag();
			tag.Id = 34770689001l;
			tags.Add(tag);
			tag = new Tag();
			tag.Id = 34770628007l;
			tags.Add(tag);
			massDelete1.Tags = tags;
			massDelete.Add(massDelete1);
			request.MassDelete = massDelete;
			APIResponse<ActionResponse> response = massDeleteTagsOperations.MassDeleteTags(request);
			if (response != null)
			{
				Console.WriteLine("Status Code: " + response.StatusCode);
				if (response.IsExpected)
				{
					ActionResponse actionResponse = response.Object;
					if (actionResponse is SuccessResponse)
					{
						SuccessResponse successresponse = (SuccessResponse)actionResponse;
						Console.WriteLine("Status: " + successresponse.Status.Value);
						Console.WriteLine("Code: " + successresponse.Code.Value);
						Console.WriteLine("Details: ");
						foreach (KeyValuePair<string, object> entry in successresponse.Details)
						{
							Console.WriteLine(entry.Key + ": " + entry.Value);
						}
						Console.WriteLine("Message: " + successresponse.Message);
					}
					else if (actionResponse is APIException)
					{
						APIException exception = (APIException)actionResponse;
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
                MassDeleteTags_1();
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
	}
}

