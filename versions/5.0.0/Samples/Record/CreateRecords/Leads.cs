using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using HeaderMap = Com.Zoho.Crm.API.HeaderMap;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using APIException = Com.Zoho.Crm.API.Record.APIException;
using ActionHandler = Com.Zoho.Crm.API.Record.ActionHandler;
using ActionResponse = Com.Zoho.Crm.API.Record.ActionResponse;
using ActionWrapper = Com.Zoho.Crm.API.Record.ActionWrapper;
using BodyWrapper = Com.Zoho.Crm.API.Record.BodyWrapper;
using Consent = Com.Zoho.Crm.API.Record.Consent;
using FileDetails = Com.Zoho.Crm.API.Record.FileDetails;
using RecordOperations = Com.Zoho.Crm.API.Record.RecordOperations;
using SuccessResponse = Com.Zoho.Crm.API.Record.SuccessResponse;
using Tag = Com.Zoho.Crm.API.Tags.Tag;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.Record.CreateRecords
{
	public class Leads
	{
		public static void CreateLeads_1(string module)
		{
			RecordOperations recordOperations = new RecordOperations(module);
			BodyWrapper bodyWrapper = new BodyWrapper();
			List<Com.Zoho.Crm.API.Record.Record> records = new List<Com.Zoho.Crm.API.Record.Record>();
			Com.Zoho.Crm.API.Record.Record record1 =  new Com.Zoho.Crm.API.Record.Record();
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.LAST_NAME, "Last Name");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.FIRST_NAME, "First Name");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.COMPANY, "KKRNP");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.ANNUAL_REVENUE, 1221.2);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.LEAD_STATUS, new Choice<string>("Not Contacted"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.LEAD_SOURCE, new Choice<string>("Advertisement"));
			record1.AddKeyValue("Title", "titleName");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.PHONE, "11123");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.MOBILE, "200221");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.INDUSTRY, new Choice<string>("ERP"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.EMAIL_OPT_OUT, true);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.EMAIL, "abc@zoho.com");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.FAX, "fax");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.WEBSITE, "website.com");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.NO_OF_EMPLOYEES, 10);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.RATING, new Choice<string>("Active"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.SKYPE_ID, "Skype123");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.SECONDARY_EMAIL, "abc1@zoho.com");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.TWITTER, "twitter55");
			// Address info of Lead
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.CITY, "City");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.COUNTRY, "country");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.STREET, "street");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.STATE, "state");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.ZIP_CODE, "501210");
			//
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Leads.DESCRIPTION, "description");
			// Used when GDPR is enabled
			Consent dataConsent = new Consent();
			dataConsent.ConsentRemarks = "Approved.";
			dataConsent.ConsentThrough = "Email";
			dataConsent.ContactThroughEmail = true;
			dataConsent.ContactThroughSocial = false;
			dataConsent.ContactThroughPhone = true;
			dataConsent.ContactThroughSurvey = true;
			dataConsent.ConsentDate = new DateTime(2023, 10, 11).Date;
			dataConsent.DataProcessingBasis = "Obtained";
			record1.AddKeyValue("Data_Processing_Basis_Details", dataConsent);
			// for MultiSelectLookUp/custom MultiSelectLookUp
			List<Com.Zoho.Crm.API.Record.Record> Multirecords = new List<Com.Zoho.Crm.API.Record.Record>();
			Com.Zoho.Crm.API.Record.Record record =  new Com.Zoho.Crm.API.Record.Record();
			Com.Zoho.Crm.API.Record.Record linkingRecord =  new Com.Zoho.Crm.API.Record.Record();
			record.AddKeyValue("id", 4402481103145L);
			linkingRecord.AddKeyValue("MultiSelectLookup", record);
			Multirecords.Add (linkingRecord);
			record1.AddKeyValue("MultiSelectLookup", Multirecords);
			// for Custom Fields
			record1.AddKeyValue("External", "Value12345");
			record1.AddKeyValue("CustomField", "Value");
			record1.AddKeyValue("Datetime", new DateTimeOffset(new DateTime(2020, 05, 15, 12, 0, 0, DateTimeKind.Local)));
			record1.AddKeyValue("Date_1", new DateTime(2021, 1, 13).Date);
			record1.AddKeyValue("Subject", "AutomatedSDK");
			record1.AddKeyValue("Product_Name", "AutomatedSDK");
			List<FileDetails> fileDetails = new List<FileDetails>();
			FileDetails fileDetail1 = new FileDetails();
			fileDetail1.FileIdS = "ae9c7cefa418aec1d6a5cc2d9ab35c32a6ae23d70b0bd44183d280";
			fileDetails.Add (fileDetail1);
			FileDetails fileDetail2 = new FileDetails();
			fileDetail2.FileIdS = "ae9c7cefa418aec1d6a5cc2d9ab35c21b5b4ca878a934519e6cdb2";
			fileDetails.Add (fileDetail2);
			record1.AddKeyValue("File_Upload", fileDetails);
			// for Custom User LookUp
			Com.Zoho.Crm.API.Users.MinifiedUser user =  new Com.Zoho.Crm.API.Users.MinifiedUser();
			user.Id = 440248254001L;
			record1.AddKeyValue("User_1", user);
	//		// for Custom LookUp
			Com.Zoho.Crm.API.Record.Record data =  new Com.Zoho.Crm.API.Record.Record();
			data.Id = 440248774074L;
			record1.AddKeyValue("Lookup_1", data);
	//		// for Custom pickList
			record1.AddKeyValue("Pick", new Choice<string>("true"));
	//		// for Custom MultiSelect 
			record1.AddKeyValue("Multiselect", new List<Choice<string>>() {new Choice<string>("Option 1"), new Choice<string>("Option 2") }) ;
	//		// Subform sample code
			List<Com.Zoho.Crm.API.Record.Record> subformList = new List<Com.Zoho.Crm.API.Record.Record>();
			Com.Zoho.Crm.API.Record.Record subform =  new Com.Zoho.Crm.API.Record.Record();
			subform.AddKeyValue("customfield", "customvalue");
			Com.Zoho.Crm.API.Users.MinifiedUser user1 =  new Com.Zoho.Crm.API.Users.MinifiedUser();
			user1.Id = 440248254001L;
			subform.AddKeyValue("Userfield", user1);
			subformList.Add (subform);
			record1.AddKeyValue("Subform_2", subformList);
			List<Tag> tagList = new List<Tag>();
			Tag tag = new Tag();
			tag.Name = "Testtask";
			tagList.Add (tag);
			record1.Tag = tagList;
			// Add Record instance to the list
			records.Add (record1);
			bodyWrapper.Data = records;
			List<string> trigger = new List<string>();
			trigger.Add ("approval");
			trigger.Add ("workflow");
			trigger.Add ("blueprint");
			bodyWrapper.Trigger = trigger;
	//		bodyWrapper.LarId = "3477061087515";
			HeaderMap headerInstance = new HeaderMap();
	//		headerInstance.Add (CreateRecordsHeader.X_EXTERNAL, "Quotes.Quoted_Items.Product_Name.Products_External");
			APIResponse<ActionHandler> response = recordOperations.CreateRecords(bodyWrapper, headerInstance);
			if (response != null)
			{
				Console.WriteLine ("Status Code: " + response.StatusCode);
				if (response.IsExpected)
				{
					ActionHandler actionHandler = response.Object;
					if (actionHandler is ActionWrapper)
					{
						ActionWrapper actionWrapper = (ActionWrapper) actionHandler;
						List<ActionResponse> actionResponses = actionWrapper.Data;
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
								Console.WriteLine ("Message: " + successResponse.Message.Value);
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
								Console.WriteLine ("Message: " + exception.Message.Value);
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
						Console.WriteLine ("Message: " + exception.Message.Value);
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
				string moduleAPIName = "Leads";
                CreateLeads_1(moduleAPIName);
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}