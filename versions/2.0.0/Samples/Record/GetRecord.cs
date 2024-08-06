using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using HeaderMap = Com.Zoho.Crm.API.HeaderMap;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Com.Zoho.Crm.API;
using Attachment = Com.Zoho.Crm.API.Attachments.Attachment;
using ParentId = Com.Zoho.Crm.API.Attachments.ParentId;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using APIException = Com.Zoho.Crm.API.Record.APIException;
using Comment = Com.Zoho.Crm.API.Record.Comment;
using Consent = Com.Zoho.Crm.API.Record.Consent;
using FileBodyWrapper = Com.Zoho.Crm.API.Record.FileBodyWrapper;
using FileDetails = Com.Zoho.Crm.API.Record.FileDetails;
using ImageUpload = Com.Zoho.Crm.API.Record.ImageUpload;
using LineTax = Com.Zoho.Crm.API.Record.LineTax;
using PricingDetails = Com.Zoho.Crm.API.Record.PricingDetails;
using RecordOperations = Com.Zoho.Crm.API.Record.RecordOperations;
using RecurringActivity = Com.Zoho.Crm.API.Record.RecurringActivity;
using RemindAt = Com.Zoho.Crm.API.Record.RemindAt;
using ResponseHandler = Com.Zoho.Crm.API.Record.ResponseHandler;
using ResponseWrapper = Com.Zoho.Crm.API.Record.ResponseWrapper;
using Tax = Com.Zoho.Crm.API.Record.Tax;
using GetRecordHeader = Com.Zoho.Crm.API.Record.RecordOperations.GetRecordHeader;
using GetRecordParam = Com.Zoho.Crm.API.Record.RecordOperations.GetRecordParam;
using Tag = Com.Zoho.Crm.API.Tags.Tag;
using MinifiedUser = Com.Zoho.Crm.API.Users.MinifiedUser;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;
using System.Collections;

namespace Samples.Record
{
	public class GetRecord
	{
		public static void GetRecord_1(string moduleAPIName, long recordId, string destinationFolder)
		{
			RecordOperations recordOperations = new RecordOperations(moduleAPIName);
			ParameterMap paramInstance = new ParameterMap();
			//paramInstance.Add(GetRecordParam.APPROVED, "both");
			//paramInstance.Add(GetRecordParam.CONVERTED, "false");
			//List<string> fieldNames = new List<string>() { "Company", "Email" };
			//paramInstance.Add(GetRecordParam.FIELDS, string.Join(",", fieldNames));
			//DateTimeOffset startdatetime = new DateTimeOffset(new DateTime(2020, 05, 15, 12, 0, 0, DateTimeKind.Local));
			//paramInstance.Add(GetRecordParam.STARTDATETIME, startdatetime);
			//DateTimeOffset enddatetime = new DateTimeOffset(new DateTime(2020, 05, 15, 12, 0, 0, DateTimeKind.Local));
			//paramInstance.Add(GetRecordParam.ENDDATETIME, enddatetime);
			//paramInstance.Add(GetRecordParam.TERRITORY_ID, "34770613051357");
			//paramInstance.Add(GetRecordParam.INCLUDE_CHILD, "true");
			HeaderMap headerInstance = new HeaderMap();
			//DateTimeOffset ifmodifiedsince = new DateTimeOffset(new DateTime(2020, 05, 15, 12, 0, 0, DateTimeKind.Local));
			//headerInstance.Add(GetRecordHeader.IF_MODIFIED_SINCE, ifmodifiedsince);
			//headerInstance.Add(GetRecordHeader.X_EXTERNAL, "Leads.External");
			APIResponse<ResponseHandler> response = recordOperations.GetRecord(recordId, paramInstance, headerInstance);
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
						List<Com.Zoho.Crm.API.Record.Record> records = responseWrapper.Data;
						foreach (Com.Zoho.Crm.API.Record.Record record in records)
						{
							Console.WriteLine ("Record ID: " + record.Id);
							Com.Zoho.Crm.API.Users.MinifiedUser createdBy =  record.CreatedBy;
							if (createdBy != null)
							{
								Console.WriteLine ("Record Created By User-ID: " + createdBy.Id);
								Console.WriteLine ("Record Created By User-Name: " + createdBy.Name);
								Console.WriteLine ("Record Created By User-Email: " + createdBy.Email);
							}
							Console.WriteLine ("Record CreatedTime: " + record.CreatedTime);
							Com.Zoho.Crm.API.Users.MinifiedUser modifiedBy =  record.ModifiedBy;
							if (modifiedBy != null)
							{
								Console.WriteLine ("Record Modified By User-ID: " + modifiedBy.Id);
								Console.WriteLine ("Record Modified By User-Name: " + modifiedBy.Name);
								Console.WriteLine ("Record Modified By User-Email: " + modifiedBy.Email);
							}
							Console.WriteLine ("Record ModifiedTime: " + record.ModifiedTime);
							List<Tag> tags = record.Tag;
							if (tags != null)
							{
								foreach (Tag tag in tags)
								{
									Console.WriteLine ("Record Tag Name: " + tag.Name);
									Console.WriteLine ("Record Tag ID: " + tag.Id);
								}
							}
							// To get particular field value
							Console.WriteLine ("Record Field Value: " + record.GetKeyValue("Last_Name"));
							Console.WriteLine ("Record KeyValues: ");
							foreach (KeyValuePair<string, object> entry in record.GetKeyValues())
							{
								string keyName = entry.Key;
								object value = entry.Value;
								if(value == null)
								{
									continue;
								}
								if (value is IList)
								{
                                    IList dataList = (IList) value;
									if (dataList.Count > 0)
									{
										if (dataList[0] is FileDetails)
										{
											List<FileDetails> fileDetails = (List<FileDetails>) value;
											foreach (FileDetails fileDetail in fileDetails)
											{
												Console.WriteLine ("Record FileDetails FileIds: " + fileDetail.FileIdS);
												Console.WriteLine ("Record FileDetails FileNameS: " + fileDetail.FileNameS);
												Console.WriteLine ("Record FileDetails SizeS: " + fileDetail.SizeS);
												Console.WriteLine ("Record FileDetails Id: " + fileDetail.Id);
											}
										}
                                        else if (dataList[0].GetType().FullName.Contains("Choice"))
                                        {
                                            Console.WriteLine(keyName);
                                            Console.WriteLine("values");
                                            foreach (object choice in dataList)
                                            {
                                                Type type = choice.GetType();
                                                PropertyInfo prop = type.GetProperty("Value");
                                                Console.WriteLine(prop.GetValue(choice));
                                            }
                                        }
                                        else if (dataList[0] is ImageUpload)
										{
											List<ImageUpload> imageUploads = (List<ImageUpload>) dataList;
											foreach (ImageUpload imageUpload in imageUploads)
											{
												Console.WriteLine ("Record  Description: " + imageUpload.DescriptionS);
												Console.WriteLine ("Record  FileIds: " + imageUpload.FileIdS);
												Console.WriteLine ("Record  FileNameS: " + imageUpload.FileNameS);
												Console.WriteLine ("Record PreviewIdS: " + imageUpload.PreviewIdS);
												Console.WriteLine ("Record  SizeS: " + imageUpload.SizeS);
												Console.WriteLine ("Record  States: " + imageUpload.StateS);
												Console.WriteLine ("Record  ID: " + imageUpload.Id);
												Console.WriteLine ("Record  SequenceNumber: " + imageUpload.SequenceNumberS);
											}
										}
										else if (dataList[0] is Tax)
										{
											Tax tax = (Tax) dataList[0];
											Console.WriteLine ("Record Tax id: " + tax.Id);
											Console.WriteLine ("Record Tax value: " + tax.Value);
										}
										else if (dataList[0] is Tag)
										{
											List<Tag> tagList = (List<Tag>) value;
											foreach (Tag tag in tagList)
											{
												Console.WriteLine ("Record Tag Name: " + tag.Name);
												Console.WriteLine ("Record Tag ID: " + tag.Id);
											}
										}
										else if (dataList[0] is PricingDetails)
										{
											List<PricingDetails> pricingDetails = (List<PricingDetails>) value;
											foreach (PricingDetails pricingDetail in pricingDetails)
											{
												Console.WriteLine ("Record PricingDetails ToRange: " + pricingDetail.ToRange);
												Console.WriteLine ("Record PricingDetails Discount: " + pricingDetail.Discount);
												Console.WriteLine ("Record PricingDetails ID: " + pricingDetail.Id);
												Console.WriteLine ("Record PricingDetails FromRange: " + pricingDetail.FromRange);
											}
										}
										else if (dataList[0] is Com.Zoho.Crm.API.Record.Record)
										{
											List<Com.Zoho.Crm.API.Record.Record> recordList = (List<Com.Zoho.Crm.API.Record.Record>) dataList;
											foreach (Com.Zoho.Crm.API.Record.Record record1 in recordList)
											{
												foreach (KeyValuePair<string, object> entry1 in record1.GetKeyValues())
												{
													Console.WriteLine (entry1.Key + ": " + entry1.Value);
												}
											}
										}
										else if (dataList[0] is LineTax)
										{
											List<LineTax> lineTaxes = (List<LineTax>) dataList;
											foreach (LineTax lineTax in lineTaxes)
											{
												Console.WriteLine ("Record ProductDetails LineTax Percentage: " + lineTax.Percentage);
												Console.WriteLine ("Record ProductDetails LineTax Name: " + lineTax.Name);
												Console.WriteLine ("Record ProductDetails LineTax Id: " + lineTax.Id);
												Console.WriteLine ("Record ProductDetails LineTax Value: " + lineTax.Value);
											}
										}
										else if (dataList[0] is Comment)
										{
											List<Comment> comments = (List<Comment>) dataList;
											foreach (Comment comment in comments)
											{
												Console.WriteLine ("Record Comment CommentedBy: " + comment.CommentedBy);
												Console.WriteLine ("Record Comment CommentedTime: " + comment.CommentedTime);
												Console.WriteLine ("Record Comment CommentContent: " + comment.CommentContent);
												Console.WriteLine ("Record Comment Id: " + comment.Id);
											}
										}
										else if (dataList[0] is Attachment)
										{
											List<Com.Zoho.Crm.API.Attachments.Attachment> attachments = (List<Attachment>) dataList;
											foreach (Com.Zoho.Crm.API.Attachments.Attachment attachment in attachments)
											{
												Com.Zoho.Crm.API.Users.MinifiedUser owner =  attachment.Owner;
												if (owner != null)
												{
													Console.WriteLine ("Record Attachment Owner User-Name: " + owner.Name);
													Console.WriteLine ("Record Attachment Owner User-ID: " + owner.Id);
													Console.WriteLine ("Record Attachment Owner User-Email: " + owner.Email);
												}
												Console.WriteLine ("Record Attachment Modified Time: " + attachment.ModifiedTime);
												Console.WriteLine ("Record Attachment File Name: " + attachment.FileName);
												Console.WriteLine ("Record Attachment Created Time: " + attachment.CreatedTime);
												Console.WriteLine ("Record Attachment File Size: " + attachment.Size);
												ParentId parentId = attachment.ParentId;
												if (parentId != null)
												{
													Console.WriteLine ("Record Attachment parent record Name: " + parentId.Name);
													Console.WriteLine ("Record Attachment parent record ID: " + parentId.Id);
												}
												Console.WriteLine ("Record Attachment is Editable: " + attachment.Editable);
												Console.WriteLine ("Record Attachment File ID: " + attachment.FileId);
												Console.WriteLine ("Record Attachment File Type: " + attachment.Type);
												Console.WriteLine ("Record Attachment seModule: " + attachment.SeModule);
												modifiedBy = attachment.ModifiedBy;
												if (modifiedBy != null)
												{
													Console.WriteLine ("Record Attachment Modified By User-Name: " + modifiedBy.Name);
													Console.WriteLine ("Record Attachment Modified By User-ID: " + modifiedBy.Id);
													Console.WriteLine ("Record Attachment Modified By User-Email: " + modifiedBy.Email);
												}
												Console.WriteLine ("Record Attachment State: " + attachment.State);
												Console.WriteLine ("Record Attachment ID: " + attachment.Id);
												createdBy = attachment.CreatedBy;
												if (createdBy != null)
												{
													Console.WriteLine ("Record Attachment Created By User-Name: " + createdBy.Name);
													Console.WriteLine ("Record Attachment Created By User-ID: " + createdBy.Id);
													Console.WriteLine ("Record Attachment Created By User-Email: " + createdBy.Email);
												}
												Console.WriteLine ("Record Attachment LinkUrl: " + attachment.LinkUrl);
											}
										}
										else
										{
											Console.WriteLine (keyName + ": " + value);
										}
									}
								}
								else if (value is Com.Zoho.Crm.API.Record.Record)
								{
									Com.Zoho.Crm.API.Record.Record recordValue =  (Com.Zoho.Crm.API.Record.Record) value;
									Console.WriteLine ("Record " + keyName + " ID: " + recordValue.Id);
									Console.WriteLine ("Record " + keyName + " Name: " + recordValue.GetKeyValue("name"));
								}
								else if (value is Com.Zoho.Crm.API.Layouts.Layouts)
								{
									Com.Zoho.Crm.API.Layouts.Layouts layout =  (Com.Zoho.Crm.API.Layouts.Layouts) value;
									if (layout != null)
									{
										Console.WriteLine ("Record " + keyName + " ID: " + layout.Id);
										Console.WriteLine ("Record " + keyName + " Name: " + layout.Name);
									}
								}
								else if (value is MinifiedUser)
								{
									Com.Zoho.Crm.API.Users.MinifiedUser user =  (MinifiedUser) value;
									if (user != null)
									{
										Console.WriteLine ("Record " + keyName + " User-ID: " + user.Id);
										Console.WriteLine ("Record " + keyName + " User-Name: " + user.Name);
										Console.WriteLine ("Record " + keyName + " User-Email: " + user.Email);
									}
								}
                                else if (value.GetType().FullName.Contains("Choice"))
                                {
                                    Type type = value.GetType();
                                    PropertyInfo prop = type.GetProperty("Value");
                                    Console.WriteLine(keyName + ": " + prop.GetValue(value));
                                }
                                else if (value is RemindAt)
								{
									Console.WriteLine (keyName + ": " + ((RemindAt) value).Alarm);
								}
								else if (value is RecurringActivity)
								{
									Console.WriteLine (keyName);
									Console.WriteLine ("RRULE" + ": " + ((RecurringActivity) value).Rrule);
								}
								else if (value is Consent)
								{
									Consent consent = (Consent) value;
									Console.WriteLine ("Record Consent ID: " + consent.Id);
									MinifiedUser owner = consent.Owner;
									if (owner != null)
									{
										Console.WriteLine ("Record Consent Owner Name: " + owner.Name);
										Console.WriteLine ("Record Consent Owner ID: " + owner.Id);
										Console.WriteLine ("Record Consent Owner Email: " + owner.Email);
									}
									MinifiedUser consentCreatedBy = consent.CreatedBy;
									if (consentCreatedBy != null)
									{
										Console.WriteLine ("Record Consent CreatedBy Name: " + consentCreatedBy.Name);
										Console.WriteLine ("Record Consent CreatedBy ID: " + consentCreatedBy.Id);
										Console.WriteLine ("Record Consent CreatedBy Email: " + consentCreatedBy.Email);
									}
									MinifiedUser consentModifiedBy = consent.ModifiedBy;
									if (consentModifiedBy != null)
									{
										Console.WriteLine ("Record Consent ModifiedBy Name: " + consentModifiedBy.Name);
										Console.WriteLine ("Record Consent ModifiedBy ID: " + consentModifiedBy.Id);
										Console.WriteLine ("Record Consent ModifiedBy Email: " + consentModifiedBy.Email);
									}
									Console.WriteLine ("Record Consent CreatedTime: " + consent.CreatedTime);
									Console.WriteLine ("Record Consent ModifiedTime: " + consent.ModifiedTime);
									Console.WriteLine ("Record Consent ContactThroughEmail: " + consent.ContactThroughEmail);
									Console.WriteLine ("Record Consent ContactThroughSocial: " + consent.ContactThroughSocial);
									Console.WriteLine ("Record Consent ContactThroughSurvey: " + consent.ContactThroughSurvey);
									Console.WriteLine ("Record Consent ContactThroughPhone: " + consent.ContactThroughPhone);
									Console.WriteLine ("Record Consent MailSentTime: " + consent.MailSentTime);
									Console.WriteLine ("Record Consent ConsentDate: " + consent.ConsentDate);
									Console.WriteLine ("Record Consent ConsentRemarks: " + consent.ConsentRemarks);
									Console.WriteLine ("Record Consent ConsentThrough: " + consent.ConsentThrough);
									Console.WriteLine ("Record Consent DataProcessingBasis: " + consent.DataProcessingBasis);
									// To get custom values
									Console.WriteLine ("Record Consent Lawful Reason: " + consent.GetKeyValue("Lawful_Reason"));
								}
								else
								{
									Console.WriteLine (keyName + ": " + value);
								}
							}
						}
					}
					else if (responseHandler is FileBodyWrapper)
					{
                        FileBodyWrapper fileBodyWrapper = (FileBodyWrapper)responseHandler;
                        StreamWrapper streamWrapper = fileBodyWrapper.File;
                        Stream file = streamWrapper.Stream;
                        string fullFilePath = Path.Combine(destinationFolder, streamWrapper.Name);
                        using (FileStream outputFileStream = new FileStream(fullFilePath, FileMode.Create))
                        {
                            file.CopyTo(outputFileStream);
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
				long recordId = 44024000774074l;
				string destinationFolder = "/Users/zohocrm-csharp-sdk-sample/file";
                GetRecord_1(moduleAPIName, recordId, destinationFolder);
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}