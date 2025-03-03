using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using APIException = Com.Zoho.Crm.API.Notes.APIException;
using ActionHandler = Com.Zoho.Crm.API.Notes.ActionHandler;
using ActionResponse = Com.Zoho.Crm.API.Notes.ActionResponse;
using ActionWrapper = Com.Zoho.Crm.API.Notes.ActionWrapper;
using BodyWrapper = Com.Zoho.Crm.API.Notes.BodyWrapper;
using NotesOperations = Com.Zoho.Crm.API.Notes.NotesOperations;
using SuccessResponse = Com.Zoho.Crm.API.Notes.SuccessResponse;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;
using Com.Zoho.Crm.API.Modules;

namespace Samples.Notes
{
	public class CreateNotes
	{
		public static void CreateNotes_1()
		{
			NotesOperations notesOperations = new NotesOperations();
			BodyWrapper bodyWrapper = new BodyWrapper();
			List<Com.Zoho.Crm.API.Notes.Note> notes = new List<Com.Zoho.Crm.API.Notes.Note>();
			for (int i = 1; i <= 5; i++)
			{
				Com.Zoho.Crm.API.Notes.Note note =  new Com.Zoho.Crm.API.Notes.Note();
				note.NoteTitle = "Contacted";
				note.NoteContent = "Need to do further tracking";
                Com.Zoho.Crm.API.Notes.ParentId parentRecord = new Com.Zoho.Crm.API.Notes.ParentId();
				parentRecord.Id = 347703778003;
				MinifiedModule module = new MinifiedModule();
				module.APIName = "Leads";
				module.Id = 347706002175;
				parentRecord.Module = module;
                note.ParentId = parentRecord;
				notes.Add (note);
			}
			bodyWrapper.Data = notes;
			APIResponse<ActionHandler> response = notesOperations.CreateNotes(bodyWrapper);
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
                CreateNotes_1();
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}