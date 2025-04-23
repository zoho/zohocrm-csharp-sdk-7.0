using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using MinifiedModule = Com.Zoho.Crm.API.Modules.MinifiedModule;
using APIException = Com.Zoho.Crm.API.UserGroups.APIException;
using AssociationModule = Com.Zoho.Crm.API.UserGroups.AssociationModule;
using AssociationResponse = Com.Zoho.Crm.API.UserGroups.AssociationResponse;
using AssociationWrapper = Com.Zoho.Crm.API.UserGroups.AssociationWrapper;
using Resource = Com.Zoho.Crm.API.UserGroups.Resource;
using ResponseHandler = Com.Zoho.Crm.API.UserGroups.ResponseHandler;
using UserGroupsOperations = Com.Zoho.Crm.API.UserGroups.UserGroupsOperations;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.UserGroups
{
	public class GetAssociations
	{
		public static void GetAssociations_1(long groupId)
		{
			UserGroupsOperations userGroupsOperations = new UserGroupsOperations();
			APIResponse<ResponseHandler> response = userGroupsOperations.GetAssociations(groupId);
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
					if (responseHandler is AssociationWrapper)
					{
						AssociationWrapper assoicationWrapper = (AssociationWrapper) responseHandler;
						List<AssociationResponse> associations = assoicationWrapper.Associations;
						if (associations != null)
						{
							foreach (AssociationResponse associationResponse in associations)
							{
								Console.WriteLine ("Associations Type : " + associationResponse.Type);
								Resource resource = associationResponse.Resource;
								if (resource != null)
								{
									Console.WriteLine ("Associations Resource Id : " + resource.Id);
									Console.WriteLine ("Associations Resource Name : " + resource.Name);
								}
								AssociationModule detail = associationResponse.Detail;
								if (detail != null)
								{
									MinifiedModule module = detail.Module;
									if (module != null)
									{
										Console.WriteLine ("Associations Module Id : " + module.Id);
										Console.WriteLine ("Associations Module Id : " + module.APIName);
										Console.WriteLine ("Associations Module Id : " + module.Module);
									}
								}
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
				long groupId = 44024801326019;
                GetAssociations_1(groupId);
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}