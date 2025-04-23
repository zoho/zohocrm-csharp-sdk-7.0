using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.UserGroups;
using Com.Zoho.Crm.API;
using static Com.Zoho.Crm.API.UserGroups.UserGroupsOperations;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;

namespace Samples.UserGroups
{
	public class GetAssociateGroupsOfUser
	{
		public static void GetAssociateGroupsOfUser_1(long id)
		{
			UserGroupsOperations userGroupsOperations = new UserGroupsOperations();
			ParameterMap paramInstance = new ParameterMap();
			paramInstance.Add(GetAssociateGroupsOfUserParam.PAGE, "1");
			paramInstance.Add(GetAssociateGroupsOfUserParam.PER_PAGE, "10");
			//		paramInstance.Add(GetAssociateGroupsOfUserParam.INCLUDE, "");
			APIResponse<ResponseHandler> response = userGroupsOperations.GetAssociateGroupsOfUser(id, paramInstance);
			if (response != null)
			{
				Console.WriteLine("Status Code: " + response.StatusCode);
				if (new List<int>() { 204, 304 }.Contains(response.StatusCode))
				{
					Console.WriteLine(response.StatusCode == 204 ? "No Content" : "Not Modified");
					return;
				}
				if (response.IsExpected)
				{
					ResponseHandler responseHandler = response.Object;
					if (responseHandler is ResponseWrapper)
					{
						ResponseWrapper responseWrapper = (ResponseWrapper)responseHandler;
						List<Groups> users = responseWrapper.UserGroups;
						foreach (Groups user in users)
						{
							Owner createdBy = user.CreatedBy;
							if (createdBy != null)
							{
								Console.WriteLine("UserGroups Created By User-Name: " + createdBy.Name);
								Console.WriteLine("UserGroups Created By User-ID: " + createdBy.Id);
							}
							Owner modifiedBy = user.ModifiedBy;
							if (modifiedBy != null)
							{
								Console.WriteLine("UserGroups Modified By User-Name: " + modifiedBy.Name);
								Console.WriteLine("UserGroups Modified By User-ID: " + modifiedBy.Id);
							}
							Console.WriteLine("User ModifiedTime: " + user.ModifiedTime);
							Console.WriteLine("User CreatedTime: " + user.CreatedTime);
							Console.WriteLine("UserGroups Description: " + user.Description);
							Console.WriteLine("UserGroups Id: " + user.Id);
							Console.WriteLine("UserGroups Name: " + user.Name);
							List<Sources> sources = user.Sources;
							if (sources != null)
							{
								foreach (Sources source in sources)
								{
									Console.WriteLine("UserGroups Sources Type: " + source.Type.Value);
									Source source1 = source.Source;
									if (source1 != null)
									{
										Console.WriteLine("UserGroups Sources Id: " + source1.Id);
									}
									Console.WriteLine("UserGroups Sources Subordinates: " + source.Subordinates);
									Console.WriteLine("UserGroups Sources SubTerritories: " + source.SubTerritories);
								}
							}
						}
						Info info = responseWrapper.Info;
						if (info != null)
						{
							if (info.PerPage != null)
							{
								Console.WriteLine("User Info PerPage: " + info.PerPage);
							}
							if (info.Count != null)
							{
								Console.WriteLine("User Info Count: " + info.Count);
							}
							if (info.Page != null)
							{
								Console.WriteLine("User Info Page: " + info.Page);
							}
							if (info.MoreRecords != null)
							{
								Console.WriteLine("User Info MoreRecords: " + info.MoreRecords);
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
					System.Type type = responseObject.GetType();
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
				IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").Build();
				new Initializer.Builder().Environment(environment).Token(token).Initialize();
				long id = 34776002;
				GetAssociateGroupsOfUser_1(id);
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}