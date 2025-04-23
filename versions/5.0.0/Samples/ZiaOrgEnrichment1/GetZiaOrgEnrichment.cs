using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.ZiaOrgEnrichment;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.API.Authenticator;

namespace Samples.ZiaOrgEnrichment1
{
	public class GetZiaOrgEnrichment
	{
		public static void GetZiaOrgEnrichment_1(long ziaOrgEnrichmentId)
		{
			ZiaOrgEnrichmentOperations ziaOrgEnrichmentOperations = new ZiaOrgEnrichmentOperations();
			APIResponse<ResponseHandler> response = ziaOrgEnrichmentOperations.GetZiaOrgEnrichment(ziaOrgEnrichmentId);
			if (response != null)
			{
				Console.WriteLine("Status Code: " + response.StatusCode);
				if (response.StatusCode == 204)
				{
					Console.WriteLine("No Content");
					return;
				}
				if (response.IsExpected)
				{
					ResponseHandler responseHandler = response.Object;
					if (responseHandler is ResponseWrapper)
					{
						ResponseWrapper responseWrapper = (ResponseWrapper) responseHandler;
						List<ZiaOrgEnrichment> ziaorgenrichment = responseWrapper.Ziaorgenrichment;
						if(ziaorgenrichment != null)
						{
							foreach(ZiaOrgEnrichment ziaorgenrichment1 in ziaorgenrichment)
							{
								EnrichedData enrichedData = ziaorgenrichment1.EnrichedData;
								if(enrichedData != null)
								{
									Console.WriteLine("ZiaOrgEnrichment EnrichedData OrgStatus : " + enrichedData.OrgStatus);
									List<Description> description = enrichedData.Description;
									if(description != null)
									{
                                        foreach (Description description1 in description)
										{
											Console.WriteLine("ZiaOrgEnrichment EnrichedData Title : " + description1.Title);
											Console.WriteLine("ZiaOrgEnrichment EnrichedData Description : " + description1.Description_1);	
										}
									}
									Console.WriteLine("ZiaOrgEnrichment EnrichedData CEO : " + enrichedData.Ceo);
									Console.WriteLine("ZiaOrgEnrichment EnrichedData SecondaryEmail : " + enrichedData.SecondaryEmail);
									Console.WriteLine("ZiaOrgEnrichment EnrichedData Revenue : " + enrichedData.Revenue);
									Console.WriteLine("ZiaOrgEnrichment EnrichedData YearsInIndustry : " + enrichedData.YearsInIndustry);
									List<String> otherContacts = enrichedData.OtherContacts;
									if(otherContacts != null)
									{
                                        foreach (string otherContact in otherContacts)
										{
											Console.WriteLine("ZiaOrgEnrichment EnrichedData OtherContacts : " + otherContact);
										}
									}
									Console.WriteLine("ZiaOrgEnrichment EnrichedData TechnoGraphicData : " + enrichedData.TechnoGraphicData);
									Console.WriteLine("ZiaOrgEnrichment EnrichedData Logo : " + enrichedData.Logo);
									Console.WriteLine("ZiaOrgEnrichment EnrichedData SecondaryContact : " + enrichedData.SecondaryContact);
									Console.WriteLine("ZiaOrgEnrichment EnrichedData Id: " + enrichedData.Id);
									List<String> otherEmails = enrichedData.OtherEmails;
									if(otherEmails != null)
									{
                                        foreach (string otherEmail in otherEmails)
										{
											Console.WriteLine("ZiaOrgEnrichment EnrichedData OtherEmails : " + otherEmail);
										}
									}
									
									Console.WriteLine("ZiaOrgEnrichment EnrichedData SignIn : " + enrichedData.SignIn);
									Console.WriteLine("ZiaOrgEnrichment EnrichedData Website : " + enrichedData.Website);
									
									List<Address> address = enrichedData.Address;
									if(address != null)
									{
                                        foreach (Address address1 in address)
										{
											Console.WriteLine("ZiaOrgEnrichment EnrichedData Address Country : " + address1.Country);
											Console.WriteLine("ZiaOrgEnrichment EnrichedData Address City : " + address1.City);
											Console.WriteLine("ZiaOrgEnrichment EnrichedData Address PinCode : " + address1.PinCode);
											Console.WriteLine("ZiaOrgEnrichment EnrichedData Address State : " + address1.State);
											Console.WriteLine("ZiaOrgEnrichment EnrichedData Address FillAddress : " + address1.FillAddress);
										}
									}
									Console.WriteLine("ZiaOrgEnrichment EnrichedData SignUp : " + enrichedData.SignUp);
									Console.WriteLine("ZiaOrgEnrichment EnrichedData OrgType : " + enrichedData.OrgType);
									List<Address> headQuarters = enrichedData.HeadQuarters;
									if(headQuarters != null)
									{
                                        foreach (Address headQuarters1 in headQuarters)
										{
											Console.WriteLine("ZiaOrgEnrichment EnrichedData HeadQuarters Country : " + headQuarters1.Country);
											Console.WriteLine("ZiaOrgEnrichment EnrichedData HeadQuarters City : " + headQuarters1.City);
											Console.WriteLine("ZiaOrgEnrichment EnrichedData HeadQuarters PinCode : " + headQuarters1.PinCode);
											Console.WriteLine("ZiaOrgEnrichment EnrichedData HeadQuarters State : " + headQuarters1.State);
											Console.WriteLine("ZiaOrgEnrichment EnrichedData HeadQuarters FillAddress : " + headQuarters1.FillAddress);
										}
									}
									Console.WriteLine("ZiaOrgEnrichment EnrichedData NoOfEmployees : " + enrichedData.NoOfEmployees);
									List<String> territoryList = enrichedData.TerritoryList;
									if(territoryList != null)
									{
                                        foreach (string territory in territoryList)
										{
											Console.WriteLine("ZiaOrgEnrichment EnrichedData TerritoryList : " + territory);
										}
									}
									Console.WriteLine("ZiaOrgEnrichment EnrichedData FoundingYear : " + enrichedData.FoundingYear);
									List<Industry> industries = enrichedData.Industries;
									if(industries != null)
									{
                                        foreach (Industry industry in industries)
										{
											Console.WriteLine("ZiaOrgEnrichment EnrichedData Industries Name : " + industry.Name);
											Console.WriteLine("ZiaOrgEnrichment EnrichedData Industries Description : " + industry.Description);
										}
									}
									Console.WriteLine("ZiaOrgEnrichment EnrichedData Name : " + enrichedData.Name);
									Console.WriteLine("ZiaOrgEnrichment EnrichedData PrimaryEmail : " + enrichedData.PrimaryEmail);
									List<String> businessModel = enrichedData.BusinessModel;
									if(businessModel != null)
									{
                                        foreach (string businessModel1 in businessModel)
										{
											Console.WriteLine("ZiaOrgEnrichment EnrichedData BusinessModel : " + businessModel1);
										}
									}
									Console.WriteLine("ZiaOrgEnrichment EnrichedData PrimaryContact : " + enrichedData.PrimaryContact);
									List<SocialMedia> socialMedia = enrichedData.SocialMedia;
									if(socialMedia != null)
									{
                                        foreach (SocialMedia socialMedia1 in socialMedia)
										{
											Console.WriteLine("ZiaOrgEnrichment EnrichedData SocialMedia MediaType : " + socialMedia1.MediaType);
											List<String> mediaUrl = socialMedia1.MediaUrl;
											if(mediaUrl != null)
											{
                                                foreach (String mediaUrl1 in mediaUrl)
												{
													Console.WriteLine("ZiaOrgEnrichment EnrichedData SocialMedia MediaUrl: " + mediaUrl1);
												}
											}
										}
									}
								}
								
								EnrichBasedOn enrichBasedOn = ziaorgenrichment1.EnrichBasedOn;
								if(enrichBasedOn != null)
								{
									Console.WriteLine("ZiaOrgEnrichment EnrichBasedOn Name : " + enrichBasedOn.Name);
									Console.WriteLine("ZiaOrgEnrichment EnrichBasedOn Email : " + enrichBasedOn.Email);
									Console.WriteLine("ZiaOrgEnrichment EnrichBasedOn Website : " + enrichBasedOn.Website);
								}
								
								Console.WriteLine("ZiaOrgEnrichment Id : " + ziaorgenrichment1.Id);
								Console.WriteLine("ZiaOrgEnrichment Status : " + ziaorgenrichment1.Status);
							}
						}
					}
					else if (responseHandler is APIException)
					{
						APIException exception = (APIException) responseHandler;
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
				else if (response.StatusCode != 204)
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
                long ziaOrgEnrichmentId = 34794003;
				GetZiaOrgEnrichment_1(ziaOrgEnrichmentId);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
	}
}

