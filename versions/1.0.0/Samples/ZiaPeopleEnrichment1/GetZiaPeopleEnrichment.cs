using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.ZiaPeopleEnrichment;
using System.Collections.Generic;
using System.Reflection;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.API.Authenticator;
using Newtonsoft.Json;

namespace Samples.ZiaPeopleEnrichment1
{
	public class GetZiaPeopleEnrichment
	{
		public static void GetZiaPeopleEnrichment_1(long ziaPeopleEnrichmentId)
		{
			ZiaPeopleEnrichmentOperations ziaPeopleEnrichmentOperations = new ZiaPeopleEnrichmentOperations();
			APIResponse<ResponseHandler> response = ziaPeopleEnrichmentOperations.GetZiaPeopleEnrichment(ziaPeopleEnrichmentId);
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
						List<ZiaPeopleEnrichment> ziapeopleenrichment = responseWrapper.Ziapeopleenrichment;
						if(ziapeopleenrichment != null)
						{
							foreach(ZiaPeopleEnrichment ziapeopleenrichment1 in ziapeopleenrichment)
							{
								EnrichedData enrichedData = ziapeopleenrichment1.EnrichedData;
								if(enrichedData != null)
								{
									Console.WriteLine("ZiaPeopleEnrichment EnrichedData Website : " + enrichedData.Website);
									List<EmailInfo> emailInfos = enrichedData.EmailInfos;
									if(emailInfos != null)
									{
										foreach(EmailInfo emailInfo in emailInfos)
										{
											Console.WriteLine("ZiaPeopleEnrichment EnrichedData EmailInfo Type : " + emailInfo.Type);
											Console.WriteLine("ZiaPeopleEnrichment EnrichedData EmailInfo Email : " + emailInfo.Email);	
										}
									}
									Console.WriteLine("ZiaPeopleEnrichment EnrichedData Gender : " + enrichedData.Gender);
									CompanyInfo companyInfo = enrichedData.CompanyInfo;
									if(companyInfo != null)
									{
										Console.WriteLine("ZiaPeopleEnrichment EnrichedData CompanyInfo Name : " + companyInfo.Name);
										List<Industry> industries = companyInfo.Industries;
										if(industries != null)
										{
											foreach(Industry industry in industries)
											{
												Console.WriteLine("ZiaPeopleEnrichment EnrichedData CompanyInfo Industries Name : " + industry.Name);
												Console.WriteLine("ZiaPeopleEnrichment EnrichedData CompanyInfo Industries Description : " + industry.Description);
											}
										}
										
										List<Experience> experiences = companyInfo.Experiences;
										if(experiences != null)
										{
											foreach(Experience experience in experiences)
											{
												Console.WriteLine("ZiaPeopleEnrichment EnrichedData CompanyInfo Experience EndDate : " + experience.EndDate);
												Console.WriteLine("ZiaPeopleEnrichment EnrichedData CompanyInfo Experience CompanyName : " + experience.CompanyName);
												Console.WriteLine("ZiaPeopleEnrichment EnrichedData CompanyInfo Experience Title : " + experience.Title);
												Console.WriteLine("ZiaPeopleEnrichment EnrichedData CompanyInfo Experience StartDate : " + experience.StartDate);
												Console.WriteLine("ZiaPeopleEnrichment EnrichedData CompanyInfo Experience Primary : " + experience.Primary);
											}
										}
									}
									Console.WriteLine("ZiaPeopleEnrichment EnrichedData LastName : " + enrichedData.LastName);
									List<Object> educations = enrichedData.Educations;
									if(educations != null)
									{
										Console.WriteLine("ZiaPeopleEnrichment EnrichedData Educations : ");
										Console.WriteLine(educations);
									}
									Console.WriteLine("ZiaPeopleEnrichment EnrichedData MiddleName : " + enrichedData.MiddleName);
									List<Object> skills = enrichedData.Skills;
									if(skills != null)
									{
										Console.WriteLine("ZiaPeopleEnrichment EnrichedData Skills : ");
										Console.WriteLine(skills);
									}
									List<string> otherContacts = enrichedData.OtherContacts;
									if(otherContacts != null)
									{
										foreach(string otherContact in otherContacts)
										{
											Console.WriteLine("ZiaPeopleEnrichment EnrichedData OtherContacts : " + otherContact);
										}
									}
									List<Address> addressListInfo = enrichedData.AddressListInfo;
									if(addressListInfo != null)
									{
										foreach(Address addressListInfo1 in addressListInfo)
										{
											Console.WriteLine("ZiaPeopleEnrichment EnrichedData AddressListInfo Continent : " + addressListInfo1.Continent);
											Console.WriteLine("ZiaPeopleEnrichment EnrichedData AddressListInfo Country : " + addressListInfo1.Country);
											Console.WriteLine("ZiaPeopleEnrichment EnrichedData AddressListInfo Name : " + addressListInfo1.Name);
											Console.WriteLine("ZiaPeopleEnrichment EnrichedData AddressListInfo Region : " + addressListInfo1.Region);
											Console.WriteLine("ZiaPeopleEnrichment EnrichedData AddressListInfo Primary : " + addressListInfo1.Primary);
										}
									}
									Address primaryAddressInfo = enrichedData.PrimaryAddressInfo;
									if(primaryAddressInfo != null)
									{
										Console.WriteLine("ZiaPeopleEnrichment EnrichedData PrimaryAddressInfo Continent : " + primaryAddressInfo.Continent);
										Console.WriteLine("ZiaPeopleEnrichment EnrichedData PrimaryAddressInfo Country : " + primaryAddressInfo.Country);
										Console.WriteLine("ZiaPeopleEnrichment EnrichedData PrimaryAddressInfo Name : " + primaryAddressInfo.Name);
										Console.WriteLine("ZiaPeopleEnrichment EnrichedData PrimaryAddressInfo Region : " + primaryAddressInfo.Region);
										Console.WriteLine("ZiaPeopleEnrichment EnrichedData PrimaryAddressInfo Primary : " + primaryAddressInfo.Primary);
									}
									Console.WriteLine("ZiaPeopleEnrichment EnrichedData Name : " + enrichedData.Name);
									Console.WriteLine("ZiaPeopleEnrichment EnrichedData SecondaryContact : " + enrichedData.SecondaryContact);
									Console.WriteLine("ZiaPeopleEnrichment EnrichedData PrimaryEmail : " + enrichedData.PrimaryEmail);
									Console.WriteLine("ZiaPeopleEnrichment EnrichedData Designation : " + enrichedData.Designation);
									Console.WriteLine("ZiaPeopleEnrichment EnrichedData Id : " + enrichedData.Id);
									List<Object> interests = enrichedData.Interests;
									if(interests != null)
									{
										Console.WriteLine("ZiaPeopleEnrichment EnrichedData Interests : ");
										Console.WriteLine(interests);
									}
									Console.WriteLine("ZiaPeopleEnrichment EnrichedData FirstName : " + enrichedData.FirstName);
									Console.WriteLine("ZiaPeopleEnrichment EnrichedData PrimaryContact : " + enrichedData.PrimaryContact);
									List<SocialMedia> socialMedia = enrichedData.SocialMedia;
									if(socialMedia != null)
									{
										foreach(SocialMedia socialMedia1 in socialMedia)
										{
											Console.WriteLine("ZiaPeopleEnrichment EnrichedData SocialMedia MediaType : " + socialMedia1.MediaType);
											List<String> mediaUrl = socialMedia1.MediaUrl;
											if(mediaUrl != null)
											{
												foreach(String mediaUrl1 in mediaUrl)
												{
													Console.WriteLine("ZiaPeopleEnrichment EnrichedData SocialMedia MediaUrl: " + mediaUrl1);
												}
											}
										}
									}
								}
								EnrichBasedOn enrichBasedOn = ziapeopleenrichment1.EnrichBasedOn;
								if(enrichBasedOn != null)
								{
									Social social = enrichBasedOn.Social;
									if(social != null)
									{
										Console.WriteLine("ZiaPeopleEnrichment EnrichBasedOn Social Facebook : " + social.Facebook);
										Console.WriteLine("ZiaPeopleEnrichment EnrichBasedOn Social Linkedin : " + social.Linkedin);
										Console.WriteLine("ZiaPeopleEnrichment EnrichBasedOn Social Twitter : " + social.Twitter);
									}
									Console.WriteLine("ZiaPeopleEnrichment EnrichBasedOn Name : " + enrichBasedOn.Name);
									Company company = enrichBasedOn.Company;
									if(company != null)
									{
										Console.WriteLine("ZiaPeopleEnrichment EnrichBasedOn Company Website : " + company.Website);
										Console.WriteLine("ZiaPeopleEnrichment EnrichBasedOn Company Name : " + company.Name);
									}
									Console.WriteLine("ZiaPeopleEnrichment EnrichBasedOn Email : " + enrichBasedOn.Email);
								}
								
								Console.WriteLine("ZiaPeopleEnrichment Id : " + ziapeopleenrichment1.Id);
								Console.WriteLine("ZiaPeopleEnrichment Status : " + ziapeopleenrichment1.Status);
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
				long ziaPeopleEnrichmentId = 34794003l;
                GetZiaPeopleEnrichment_1(ziaPeopleEnrichmentId);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
	}
}

