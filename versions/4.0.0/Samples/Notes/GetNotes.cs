using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using HeaderMap = Com.Zoho.Crm.API.HeaderMap;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Com.Zoho.Crm.API;
using Attachment = Com.Zoho.Crm.API.Attachments.Attachment;
using ParentId = Com.Zoho.Crm.API.Attachments.ParentId;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using APIException = Com.Zoho.Crm.API.Notes.APIException;
using Info = Com.Zoho.Crm.API.Notes.Info;
using NotesOperations = Com.Zoho.Crm.API.Notes.NotesOperations;
using ResponseHandler = Com.Zoho.Crm.API.Notes.ResponseHandler;
using ResponseWrapper = Com.Zoho.Crm.API.Notes.ResponseWrapper;
using GetNotesHeader = Com.Zoho.Crm.API.Notes.NotesOperations.GetNotesHeader;
using GetNotesParam = Com.Zoho.Crm.API.Notes.NotesOperations.GetNotesParam;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.Notes
{
	public class GetNotes
	{
		public static void GetNotes_1()
		{
			NotesOperations notesOperations = new NotesOperations();
			ParameterMap paramInstance = new ParameterMap();
			paramInstance.Add (GetNotesParam.PAGE, "1");
			paramInstance.Add (GetNotesParam.PER_PAGE, "10");
			paramInstance.Add (GetNotesParam.FIELDS, "id");
			//paramInstance.Add (new Param<string>("ids", null), "3477008207");
			HeaderMap headerInstance = new HeaderMap();
			DateTimeOffset startdatetime = new DateTimeOffset(new DateTime(2020, 05, 15, 12, 0, 0, DateTimeKind.Local));
			headerInstance.Add(GetNotesHeader.IF_MODIFIED_SINCE, startdatetime);
			APIResponse<ResponseHandler> response = notesOperations.GetNotes(paramInstance, headerInstance);
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
						List<Com.Zoho.Crm.API.Notes.Note> notes = responseWrapper.Data;
						foreach (Com.Zoho.Crm.API.Notes.Note note in notes)
						{
							Com.Zoho.Crm.API.Users.MinifiedUser owner =  note.Owner;
							if (owner != null)
							{
								Console.WriteLine ("Note Owner User-Name: " + owner.Name);
								Console.WriteLine ("Note Owner User-ID: " + owner.Id);
								Console.WriteLine ("Note Owner Email: " + owner.Email);
							}
							Console.WriteLine ("Note ModifiedTime: " + note.ModifiedTime);
							List<Attachment> attachments = note.Attachments;
							if (attachments != null)
							{
								foreach (Attachment attachment in attachments)
								{
									printAttachment(attachment);
								}
							}
							Console.WriteLine ("Note CreatedTime: " + note.CreatedTime);
                            Com.Zoho.Crm.API.Notes.ParentId parentId = note.ParentId;
							if (parentId != null)
							{
								Console.WriteLine ("Note parent record Name: " + parentId.Name);
								Console.WriteLine ("Note parent record ID: " + parentId.Id);
							}
							Console.WriteLine ("Note Editable: " + note.Editable);
							Console.WriteLine ("Note SharingPermission: " + note.SharingPermission);
							Console.WriteLine ("Note IsSharedToClient: " + note.IsSharedToClient);
							Com.Zoho.Crm.API.Users.MinifiedUser modifiedBy =  note.ModifiedBy;
							if (modifiedBy != null)
							{
								Console.WriteLine ("Note Modified By User-Name: " + modifiedBy.Name);
								Console.WriteLine ("Note Modified By User-ID: " + modifiedBy.Id);
								Console.WriteLine ("Note Modified By User-Email: " + modifiedBy.Email);
							}
							Console.WriteLine ("Note Size: " + note.Size);
							Console.WriteLine ("Note State: " + note.State);
							Console.WriteLine ("Note VoiceNote: " + note.VoiceNote);
							Console.WriteLine ("Note Id: " + note.Id);
							Com.Zoho.Crm.API.Users.MinifiedUser createdBy =  note.CreatedBy;
							if (createdBy != null)
							{
								Console.WriteLine ("Note Created By User-Name: " + createdBy.Name);
								Console.WriteLine ("Note Created By User-ID: " + createdBy.Id);
								Console.WriteLine ("Note Created By User-Email: " + createdBy.Email);
							}
							Console.WriteLine ("Note NoteTitle: " + note.NoteTitle);
							Console.WriteLine ("Note NoteContent: " + note.NoteContent);
						}
						Info info = responseWrapper.Info;
						if (info != null)
						{
							if (info.PerPage != null)
							{
								Console.WriteLine ("Note Info PerPage: " + info.PerPage);
							}
							if (info.Count != null)
							{
								Console.WriteLine ("Note Info Count: " + info.Count);
							}
							if (info.Page != null)
							{
								Console.WriteLine ("Note Info Page: " + info.Page);
							}
							if (info.MoreRecords != null)
							{
								Console.WriteLine ("Note Info MoreRecords: " + info.MoreRecords);
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
		private static void printAttachment(Attachment attachment)
		{
			Com.Zoho.Crm.API.Users.MinifiedUser owner =  attachment.Owner;
			if (owner != null)
			{
				Console.WriteLine ("Note Attachment Owner User-Name: " + owner.Name);
				Console.WriteLine ("Note Attachment Owner User-ID: " + owner.Id);
				Console.WriteLine ("Note Attachment Owner User-Email: " + owner.Email);
			}
			Console.WriteLine ("Note Attachment Modified Time: " + attachment.ModifiedTime);
			Console.WriteLine ("Note Attachment File Name: " + attachment.FileName);
			Console.WriteLine ("Note Attachment Created Time: " + attachment.CreatedTime);
			Console.WriteLine ("Note Attachment File Size: " + attachment.Size);
			ParentId parentId = attachment.ParentId;
			if (parentId != null)
			{
				Console.WriteLine ("Note Attachment parent record Name: " + parentId.Name);
				Console.WriteLine ("Note Attachment parent record ID: " + parentId.Id);
			}
			Console.WriteLine ("Note Attachment is Editable: " + attachment.Editable);
			Console.WriteLine ("Note Attachment is SharingPermission: " + attachment.SharingPermission);
			Console.WriteLine ("Note Attachment File ID: " + attachment.FileId);
			Console.WriteLine ("Note Attachment File Type: " + attachment.Type);
			Console.WriteLine ("Note Attachment seModule: " + attachment.SeModule);
			Com.Zoho.Crm.API.Users.MinifiedUser modifiedBy =  attachment.ModifiedBy;
			if (modifiedBy != null)
			{
				Console.WriteLine ("Note Attachment Modified By User-Name: " + modifiedBy.Name);
				Console.WriteLine ("Note Attachment Modified By User-ID: " + modifiedBy.Id);
				Console.WriteLine ("Note Attachment Modified By User-Email: " + modifiedBy.Email);
			}
			Console.WriteLine ("Note Attachment State: " + attachment.State);
			Console.WriteLine ("Note Attachment ID: " + attachment.Id);
			Com.Zoho.Crm.API.Users.MinifiedUser createdBy =  attachment.CreatedBy;
			if (createdBy != null)
			{
				Console.WriteLine ("Note Attachment Created By User-Name: " + createdBy.Name);
				Console.WriteLine ("Note Attachment Created By User-ID: " + createdBy.Id);
				Console.WriteLine ("Note Attachment Created By User-Email: " + createdBy.Email);
			}
			Console.WriteLine ("Note Attachment LinkUrl: " + attachment.LinkUrl);
		}
		public static void Call()
		{
			try
			{
				Environment environment = USDataCenter.PRODUCTION;
				IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").RedirectURL("Redirect_URL" ).Build();
				new Initializer.Builder().Environment(environment).Token(token).Initialize();
                GetNotes_1();
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}