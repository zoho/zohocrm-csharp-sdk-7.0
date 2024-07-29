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
	public class Calls
	{
		public static void CreateCall_1(string moduleAPIName)
		{
			RecordOperations recordOperations = new RecordOperations(moduleAPIName);
			BodyWrapper bodyWrapper = new BodyWrapper();
			List<Com.Zoho.Crm.API.Record.Record> records = new List<Com.Zoho.Crm.API.Record.Record>();
			Com.Zoho.Crm.API.Record.Record record1 =  new Com.Zoho.Crm.API.Record.Record();
			// Schedule a Call
			Com.Zoho.Crm.API.Record.Record whoId =  new Com.Zoho.Crm.API.Record.Record();
			whoId.Id = 4402481030088L;
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.WHO_ID, whoId);
			Com.Zoho.Crm.API.Record.Record whatId =  new Com.Zoho.Crm.API.Record.Record();
			whatId.Id = 440248884001L;
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.WHAT_ID, whatId);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.CALL_TYPE, new Choice<string>("Outbound"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.OUTGOING_CALL_STATUS, new Choice<string>("Scheduled"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.CALL_START_TIME, new DateTimeOffset(new DateTime(2020, 05, 15, 12, 0, 0, DateTimeKind.Local)));
			Com.Zoho.Crm.API.Record.Record user =  new Com.Zoho.Crm.API.Record.Record();
			user.Id = 440248254001L;
			record1.AddKeyValue("Call_Owner", user);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.SUBJECT, "call scheduled");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.REMINDER, new Choice<string>("5 mins"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.CALL_PURPOSE, new Choice<string>("Demo"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.CALL_AGENDA, "agenda to make call");
			record1.AddKeyValue("$se_module", "Accounts");
			// log a Call
			Com.Zoho.Crm.API.Record.Record whoId1 =  new Com.Zoho.Crm.API.Record.Record();
			whoId1.Id = 4402481030088L;
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.WHO_ID, whoId1);
			Com.Zoho.Crm.API.Record.Record whatId1 =  new Com.Zoho.Crm.API.Record.Record();
			whatId1.Id = 440248884001L;
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.WHAT_ID, whatId1);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.CALL_TYPE, new Choice<string>("Outbound"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.SUBJECT, "call");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.CALL_DURATION, "10:00");
	//		record1.AddKeyValue("Voice_Recording__s", "recordingofcall.com");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.OUTGOING_CALL_STATUS, new Choice<string>("Completed"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.CALL_START_TIME, new DateTimeOffset(new DateTime(2020, 05, 15, 12, 0, 0, DateTimeKind.Local)));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.CALL_PURPOSE, new Choice<string>("Demo"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.CALL_AGENDA, "agenda to make call");
			record1.AddKeyValue("Call_Result", new Choice<string>("Not interested"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Calls.DESCRIPTION, "desc");
			record1.AddKeyValue("$se_module", "Accounts");
			//
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
			record.AddKeyValue("id", 440248884001L);
			linkingRecord.AddKeyValue("Msl", record);
			Multirecords.Add (linkingRecord);
			record1.AddKeyValue("Msl", Multirecords);
			// for Custom Fields
			record1.AddKeyValue("External", "Value12345");
			record1.AddKeyValue("Custom_field", "Value");
			record1.AddKeyValue("Date_Time_2", new DateTimeOffset(new DateTime(2020, 05, 15, 12, 0, 0, DateTimeKind.Local)));
			record1.AddKeyValue("Date_1", new DateTime(2021, 1, 13).Date);
			record1.AddKeyValue("Subject", "AutomatedSDK");
			record1.AddKeyValue("Product_Name", "AutomatedSDK");
			List<FileDetails> fileDetails = new List<FileDetails>();
			FileDetails fileDetail1 = new FileDetails();
			fileDetail1.FileIdS = "ae9c7cefa418aec1d6a5cc2d9ab35c32a6ae23d729add280";
			fileDetails.Add (fileDetail1);
			FileDetails fileDetail2 = new FileDetails();
			fileDetail2.FileIdS = "ae9c7cefa418aec1d6a5cc2d9ab35cca878a934519e6cdb2";
			fileDetails.Add (fileDetail2);
			record1.AddKeyValue("File_Upload", fileDetails);
			// for Custom User LookUp
			Com.Zoho.Crm.API.Users.MinifiedUser user_1 =  new Com.Zoho.Crm.API.Users.MinifiedUser();
			user_1.Id = 440248254001L;
			record1.AddKeyValue("User_1", user_1);
			// for Custom LookUp
			Com.Zoho.Crm.API.Record.Record data =  new Com.Zoho.Crm.API.Record.Record();
			data.Id = 440248774074L;
			record1.AddKeyValue("Lookup_2", data);
			// for Custom pickList
			record1.AddKeyValue("pick", new Choice<string>("true"));
			// for Custom MultiSelect
			record1.AddKeyValue("Multiselect", new List<Choice<string>> () {new Choice<string>("Option 1"), new Choice<string>("Option 2") }) ;
			// Subform sample code
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
				string moduleAPIName = "Calls";
                CreateCall_1(moduleAPIName);
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}