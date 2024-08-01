using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using APIException = Com.Zoho.Crm.API.UserGroups.APIException;
using AssociatedUser = Com.Zoho.Crm.API.UserGroups.AssociatedUser;
using AssociatedUserCount = Com.Zoho.Crm.API.UserGroups.AssociatedUserCount;
using Info = Com.Zoho.Crm.API.UserGroups.Info;
using ResponseHandler = Com.Zoho.Crm.API.UserGroups.ResponseHandler;
using UserGroup = Com.Zoho.Crm.API.UserGroups.UserGroup;
using UserGroupsOperations = Com.Zoho.Crm.API.UserGroups.UserGroupsOperations;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;

namespace Samples.UserGroups
{
	public class GetAssociatedUsersCount
	{
		public static void GetAssociatedUsersCount_1()
		{
			UserGroupsOperations userGroupsOperations = new UserGroupsOperations();
			APIResponse<ResponseHandler> response = userGroupsOperations.GetAssociatedUsersCount();
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
					if (responseHandler is AssociatedUserCount)
					{
						List<AssociatedUser> associatedUsersCount = ((AssociatedUserCount) responseHandler).AssociatedUsersCount;
						if (associatedUsersCount != null)
						{
							foreach (AssociatedUser associatedUser in associatedUsersCount)
							{
								Console.WriteLine ("AssociatedUser count: " + associatedUser.Count);
								UserGroup userGroup = associatedUser.UserGroup;
								if (userGroup != null)
								{
									Console.WriteLine ("AssociatedUser Name: " + userGroup.Name);
									Console.WriteLine ("AssociatedUser ID: " + userGroup.Id);
								}
							}
						}
						Info info = ((AssociatedUserCount) responseHandler).Info;
						if (info != null)
						{
							if (info.PerPage != null)
							{
								Console.WriteLine ("User Info PerPage: " + info.PerPage);
							}
							if (info.Count != null)
							{
								Console.WriteLine ("User Info Count: " + info.Count);
							}
							if (info.Page != null)
							{
								Console.WriteLine ("User Info Page: " + info.Page);
							}
							if (info.MoreRecords != null)
							{
								Console.WriteLine ("User Info MoreRecords: " + info.MoreRecords);
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
                GetAssociatedUsersCount_1();
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}