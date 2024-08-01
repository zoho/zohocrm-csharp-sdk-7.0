using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using APIException = Com.Zoho.Crm.API.UserGroups.APIException;
using Owner = Com.Zoho.Crm.API.UserGroups.Owner;
using ResponseHandler = Com.Zoho.Crm.API.UserGroups.ResponseHandler;
using ResponseWrapper = Com.Zoho.Crm.API.UserGroups.ResponseWrapper;
using Source = Com.Zoho.Crm.API.UserGroups.Source;
using Sources = Com.Zoho.Crm.API.UserGroups.Sources;
using UserGroupsOperations = Com.Zoho.Crm.API.UserGroups.UserGroupsOperations;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.UserGroups
{
	public class GetGroup
	{
		public static void GetGroup_1(long groupId)
		{
			UserGroupsOperations userGroupsOperations = new UserGroupsOperations();
			APIResponse<ResponseHandler> response = userGroupsOperations.GetGroup(groupId);
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
					if (responseHandler is ResponseWrapper)
					{
						ResponseWrapper responseWrapper = (ResponseWrapper) responseHandler;
						List<Com.Zoho.Crm.API.UserGroups.Groups> users = responseWrapper.UserGroups;
						foreach (Com.Zoho.Crm.API.UserGroups.Groups user in users)
						{
							Owner createdBy = user.CreatedBy;
							if (createdBy != null)
							{
								Console.WriteLine ("UserGroups Created By User-Name: " + createdBy.Name);
								Console.WriteLine ("UserGroups Created By User-ID: " + createdBy.Id);
							}
							Owner modifiedBy = user.ModifiedBy;
							if (modifiedBy != null)
							{
								Console.WriteLine ("UserGroups Modified By User-Name: " + modifiedBy.Name);
								Console.WriteLine ("UserGroups Modified By User-ID: " + modifiedBy.Id);
							}
							Console.WriteLine ("User ModifiedTime: " + user.ModifiedTime);
							Console.WriteLine ("User CreatedTime: " + user.CreatedTime);
							Console.WriteLine ("UserGroups Description: " + user.Description);
							Console.WriteLine ("UserGroups Id: " + user.Id);
							Console.WriteLine ("UserGroups Name: " + user.Name);
							List<Sources> sources = user.Sources;
							if (sources != null)
							{
								sources.ForEach(source =>
								{
									Console.WriteLine ("UserGroups Sources Type: " + source.Type.Value);
									Source source1 = source.Source;
									if (source1 != null)
									{
										Console.WriteLine ("UserGroups Sources Id: " + source1.Id);
									}
									Console.WriteLine ("UserGroups Sources Subordinates: " + source.Subordinates);
									Console.WriteLine ("UserGroups Sources SubTerritories: " + source.SubTerritories);
								});
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
				long groupId = 440248001307102;
                GetGroup_1(groupId);
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}