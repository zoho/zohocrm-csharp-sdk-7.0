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


namespace Samples.Record.Updaterecords
{
	public class Cases
	{
		public static void UpdateCases_1(string module)
		{
			RecordOperations recordOperations = new RecordOperations(module);
			BodyWrapper bodyWrapper = new BodyWrapper();
			List<Com.Zoho.Crm.API.Record.Record> records = new List<Com.Zoho.Crm.API.Record.Record>();
			Com.Zoho.Crm.API.Record.Record record1 =  new Com.Zoho.Crm.API.Record.Record();
			record1.Id = 3434432L;
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.SUBJECT, "new Case");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.TYPE, new Choice<string>("Question"));
			Com.Zoho.Crm.API.Record.Record product_name =  new Com.Zoho.Crm.API.Record.Record();
			product_name.AddKeyValue("id", 321334231321L);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.PRODUCT_NAME, product_name);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.CASE_ORIGIN, new Choice<string>("Email"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.STATUS, new Choice<string>("On Hold"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.REPORTED_BY, "none");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.PHONE, "31231242131");
			Com.Zoho.Crm.API.Record.Record contactName =  new Com.Zoho.Crm.API.Record.Record();
			contactName.AddKeyValue("id", 31212323012312232L);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.RELATED_TO, contactName);
			Com.Zoho.Crm.API.Record.Record accountName =  new Com.Zoho.Crm.API.Record.Record();
			accountName.AddKeyValue("id", 3245633789213L);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.ACCOUNT_NAME, accountName);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.EMAIL, "abc@zoho.com");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.PRIORITY, new Choice<string>("Low"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.CASE_REASON, new Choice<string>("New Problem"));
			Com.Zoho.Crm.API.Record.Record dealName =  new Com.Zoho.Crm.API.Record.Record();
			dealName.AddKeyValue("id", 392223423412L);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.DEAL_NAME, dealName);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.DESCRIPTION, "description of case");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.INTERNAL_COMMENTS, "comments");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Cases.SOLUTION, "Solution for problem");
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
			fileDetail1.FileIdS = "ae9c7cefa418aa5cc2d9ab35c32a6ae23d729ad87c6d90b0bd44183d280";
			fileDetail1.Delete = null;
			fileDetails.Add (fileDetail1);
			FileDetails fileDetail2 = new FileDetails();
			fileDetail2.FileIdS = "ae9c7cefa418aec1d6a5cc2d9ab35c32e0063e7321b5b4ca34519e6cdb2";
			fileDetail2.Delete = null;
			fileDetails.Add (fileDetail2);
			record1.AddKeyValue("File_Upload", fileDetails);
			// for Custom User LookUp
			Com.Zoho.Crm.API.Users.MinifiedUser user =  new Com.Zoho.Crm.API.Users.MinifiedUser();
			user.Id = 440248254001L;
			record1.AddKeyValue("User_1", user);
			// for Custom LookUp
			Com.Zoho.Crm.API.Record.Record data =  new Com.Zoho.Crm.API.Record.Record();
			data.Id = 440248774074L;
			record1.AddKeyValue("Lookup_2", data);
			// for Custom pickList
			record1.AddKeyValue("pick", new Choice<string>("true"));
			// for Custom MultiSelect
			record1.AddKeyValue("Multiselect", new List<Choice<string>>() {new Choice<string>("Option 1"), new Choice<string>("Option 2") });
			// Subform sample code
			List<Com.Zoho.Crm.API.Record.Record> subformList = new List<Com.Zoho.Crm.API.Record.Record>();
			Com.Zoho.Crm.API.Record.Record subform =  new Com.Zoho.Crm.API.Record.Record();
			subform.AddKeyValue("customfield", "customvalue");
			Com.Zoho.Crm.API.Users.MinifiedUser user1 =  new Com.Zoho.Crm.API.Users.MinifiedUser();
			user1.Id = 440248254001L;
			subform.AddKeyValue("Userfield", user1);
			subformList.Add (subform);
			record1.AddKeyValue("Subform_2", subformList);
			// can update another record with same above mention fields
			Com.Zoho.Crm.API.Record.Record record2 =  new Com.Zoho.Crm.API.Record.Record();
			record2.Id = 35002303403L;
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
	//				headerInstance.Add (CreateRecordsHeader.X_EXTERNAL, "Quotes.Quoted_Items.Product_Name.Products_External");
			APIResponse<ActionHandler> response = recordOperations.UpdateRecords(bodyWrapper, headerInstance);
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
				string moduleAPIName = "cases";
                UpdateCases_1(moduleAPIName);
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}