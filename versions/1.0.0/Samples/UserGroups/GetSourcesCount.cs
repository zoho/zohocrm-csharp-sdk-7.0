using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using APIException = Com.Zoho.Crm.API.UserGroups.APIException;
using ResponseHandler = Com.Zoho.Crm.API.UserGroups.ResponseHandler;
using SourcesCount = Com.Zoho.Crm.API.UserGroups.SourcesCount;
using SourcesCountWrapper = Com.Zoho.Crm.API.UserGroups.SourcesCountWrapper;
using UserGroupsOperations = Com.Zoho.Crm.API.UserGroups.UserGroupsOperations;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.UserGroups
{
	public class GetSourcesCount
	{
		public static void GetSourcesCount_1(long groupId)
		{
			UserGroupsOperations userGroupsOperations = new UserGroupsOperations();
			APIResponse<ResponseHandler> response = userGroupsOperations.GetSourcesCount(groupId);
			if (response != null)
			{
				Console.WriteLine ("Status Code: " + response.StatusCode);
				if (new List<int>(){ 204, 304}.Contains(response.StatusCode))
				{
					Console.WriteLine (response.StatusCode == 204 ? "No Content" : "Not Modified");
					return;
				}
				if (response.IsExpected)
				{
					ResponseHandler responseHandler = response.Object;
					if (responseHandler is SourcesCountWrapper)
					{
						SourcesCountWrapper responseWrapper = (SourcesCountWrapper) responseHandler;
						List<SourcesCount> sourcesCount = responseWrapper.SourcesCount;
						foreach (SourcesCount count in sourcesCount)
						{
							Console.WriteLine ("Sources Count Territories: " + count.Territories);
							Console.WriteLine ("Sources Count Roles: " + count.Roles);
							Console.WriteLine ("Sources Count Groups: " + count.Groups);
                            Com.Zoho.Crm.API.UserGroups.Users users = count.Users;
							if (users != null)
							{
								Console.WriteLine ("Sources Users Inactive: " + users.Inactive);
								Console.WriteLine ("Sources Users Deleted: " + users.Deleted);
								Console.WriteLine ("Sources Users Groups: " + users.Active);
							}
						}
					}
					else if (responseHandler is APIException)
					{
						APIException exception = (APIException) responseHandler;
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
				long groupId = 347706117236002;
                GetSourcesCount_1(groupId);
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}