using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using APIException = Com.Zoho.Crm.API.UserGroups.APIException;
using ActionHandler = Com.Zoho.Crm.API.UserGroups.ActionHandler;
using ActionResponse = Com.Zoho.Crm.API.UserGroups.ActionResponse;
using ActionWrapper = Com.Zoho.Crm.API.UserGroups.ActionWrapper;
using SuccessResponse = Com.Zoho.Crm.API.UserGroups.SuccessResponse;
using UserGroupsOperations = Com.Zoho.Crm.API.UserGroups.UserGroupsOperations;
using BodyWrapper = Com.Zoho.Crm.API.UserGroups.BodyWrapper;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;

namespace Samples.UserGroups
{
	public class CreateGroup
	{
		public static void CreateGroup_1()
		{
			UserGroupsOperations userGroupsOperations = new UserGroupsOperations();
			BodyWrapper request = new BodyWrapper();
			List<Com.Zoho.Crm.API.UserGroups.Groups> userList = new List<Com.Zoho.Crm.API.UserGroups.Groups>();
            Com.Zoho.Crm.API.UserGroups.Groups user1 = new Com.Zoho.Crm.API.UserGroups.Groups();
			user1.Name = "test group";
			user1.Description = "my group";
			List<Com.Zoho.Crm.API.UserGroups.Sources> sources = new List<Com.Zoho.Crm.API.UserGroups.Sources>();
            Com.Zoho.Crm.API.UserGroups.Sources source = new Com.Zoho.Crm.API.UserGroups.Sources();
			source.Type = new Choice<String>("users");
            Com.Zoho.Crm.API.UserGroups.Source source1 = new Com.Zoho.Crm.API.UserGroups.Source();
			source1.Id = 4402480254001;
			source.Source = source1;
			sources.Add(source);
			user1.Sources = sources;
			userList.Add(user1);
			request.UserGroups = userList;
			APIResponse<ActionHandler> response = userGroupsOperations.CreateGroups(request);
			if (response != null)
			{
                Console.WriteLine("Status Code: " + response.StatusCode);
				if (response.IsExpected)
				{
					ActionHandler actionHandler = response.Object;
					if (actionHandler is ActionWrapper)
					{
						ActionWrapper responseWrapper = (ActionWrapper) actionHandler;
						List<ActionResponse> actionResponses = responseWrapper.UserGroups;
						foreach (ActionResponse actionResponse in actionResponses)
						{
							if (actionResponse is SuccessResponse)
							{
								SuccessResponse successResponse = (SuccessResponse) actionResponse;
								Console.WriteLine ("Status: " + successResponse.Status.Value);
								Console.WriteLine ("Code: " + successResponse.Code.Value);
								Console.WriteLine ("Details: ");
								foreach (KeyValuePair<string, object> entry in successResponse.Details)
								{
									Console.WriteLine (entry.Key + ": " + entry.Value);
								}
								Console.WriteLine ("Message: " + successResponse.Message);
							}
							else if (actionResponse is APIException)
							{
								APIException exception = (APIException) actionResponse;
								Console.WriteLine ("Status: " + exception.Status.Value);
								Console.WriteLine ("Code: " + exception.Code.Value);
								Console.WriteLine ("Details: ");
								foreach (KeyValuePair<string, object> entry in exception.Details)
								{
									Console.WriteLine (entry.Key + ": " + entry.Value);
								}
								Console.WriteLine ("Message: " + exception.Message);
							}
						}
					}
					else if (actionHandler is APIException)
					{
						APIException exception = (APIException) actionHandler;
						Console.WriteLine ("Status: " + exception.Status.Value);
						Console.WriteLine ("Code: " + exception.Code.Value);
						Console.WriteLine ("Details: ");
						foreach (KeyValuePair<string, object> entry in exception.Details)
						{
							Console.WriteLine (entry.Key + ": " + entry.Value);
						}
						Console.WriteLine ("Message: " + exception.Message);
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
				IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").RedirectURL("Redirect_URL" ).Build();
				new Initializer.Builder().Environment(environment).Token(token).Initialize();
				CreateGroup_1();
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}
