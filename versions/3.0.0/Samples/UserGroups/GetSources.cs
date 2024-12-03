using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Com.Zoho.Crm.API;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using APIException = Com.Zoho.Crm.API.UserGroups.APIException;
using Info = Com.Zoho.Crm.API.UserGroups.Info;
using ResponseHandler = Com.Zoho.Crm.API.UserGroups.ResponseHandler;
using Source = Com.Zoho.Crm.API.UserGroups.Source;
using Sources = Com.Zoho.Crm.API.UserGroups.Sources;
using SourcesWrapper = Com.Zoho.Crm.API.UserGroups.SourcesWrapper;
using UserGroupsOperations = Com.Zoho.Crm.API.UserGroups.UserGroupsOperations;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.UserGroups
{
	public class GetSources
	{
		public static void GetSources_1(long groupId)
		{
			UserGroupsOperations userGroupsOperations = new UserGroupsOperations();
			ParameterMap paramInstance = new ParameterMap();
			APIResponse<ResponseHandler> response = userGroupsOperations.GetSources(groupId, paramInstance);
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
					if (responseHandler is SourcesWrapper)
					{
						SourcesWrapper responseWrapper = (SourcesWrapper) responseHandler;
						List<Sources> sources = responseWrapper.Sources;
						foreach (Sources source in sources)
						{
							Source source1 = source.Source;
							if (source1 != null)
							{
								Console.WriteLine ("Sources  User-Name: " + source1.Name);
								Console.WriteLine ("Sources User-ID: " + source1.Id);
							}
							Console.WriteLine ("Sources Type: " + source.Type.Value);
							Console.WriteLine ("Sources Subordinates: " + source.Subordinates);
						}
						Info info = responseWrapper.Info;
						if (info != null)
						{
							if (info.PerPage != null)
							{
								Console.WriteLine ("Sources Info PerPage: " + info.PerPage);
							}
							if (info.Count != null)
							{
								Console.WriteLine ("Sources Info Count: " + info.Count);
							}
							if (info.Page != null)
							{
								Console.WriteLine ("Sources Info Page: " + info.Page);
							}
							if (info.MoreRecords != null)
							{
								Console.WriteLine ("Sources Info MoreRecords: " + info.MoreRecords);
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
				long groupId = 440248001219057;
                GetSources_1(groupId);
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}