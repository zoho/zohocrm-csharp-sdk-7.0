using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Com.Zoho.Crm.API;
using APIException = Com.Zoho.Crm.API.Attachments.APIException;
using AttachmentsOperations = Com.Zoho.Crm.API.Attachments.AttachmentsOperations;
using ParentId = Com.Zoho.Crm.API.Attachments.ParentId;
using ResponseHandler = Com.Zoho.Crm.API.Attachments.ResponseHandler;
using ResponseWrapper = Com.Zoho.Crm.API.Attachments.ResponseWrapper;
using GetAttachmentsParam = Com.Zoho.Crm.API.Attachments.AttachmentsOperations.GetAttachmentsParam;
using Info = Com.Zoho.Crm.API.Attachments.Info;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.Attachments
{
    public class GetAttachments
    {
        public static void GetAttachments_1(string moduleAPIName, long recordId)
        {
            AttachmentsOperations attachmentsOperations = new AttachmentsOperations();
            ParameterMap paramInstance = new ParameterMap();
            paramInstance.Add(GetAttachmentsParam.PAGE, 1);
            paramInstance.Add(GetAttachmentsParam.PER_PAGE, 10);
            paramInstance.Add(GetAttachmentsParam.FIELDS, "id");
            paramInstance.Add(GetAttachmentsParam.IDS, "347706117069001");
            APIResponse<ResponseHandler> response = attachmentsOperations.GetAttachments(recordId, moduleAPIName, paramInstance);
            if (response != null)
            {
                Console.WriteLine("Status Code: " + response.StatusCode);
                if (new List<int>() { 204, 304 }.Contains(response.StatusCode))
                {
                    Console.WriteLine(response.StatusCode == 204 ? "No Content" : "Not Modified");
                    return;
                }
                if (response.IsExpected)
                {
                    ResponseHandler responseHandler = response.Object;
                    if (responseHandler is ResponseWrapper)
                    {
                        ResponseWrapper responseWrapper = (ResponseWrapper)responseHandler;
                        List<Com.Zoho.Crm.API.Attachments.Attachment> attachments = responseWrapper.Data;
                        foreach (Com.Zoho.Crm.API.Attachments.Attachment attachment in attachments)
                        {
                            Com.Zoho.Crm.API.Users.MinifiedUser owner = attachment.Owner;
                            if (owner != null)
                            {
                                Console.WriteLine("Attachment Owner User-Name: " + owner.Name);
                                Console.WriteLine("Attachment Owner User-ID: " + owner.Id);
                                Console.WriteLine("Attachment Owner User-Email: " + owner.Email);
                            }
                            Console.WriteLine("Attachment Modified Time: " + attachment.ModifiedTime);
                            Console.WriteLine("Attachment File Name: " + attachment.FileName);
                            Console.WriteLine("Attachment Created Time: " + attachment.CreatedTime);
                            Console.WriteLine("Attachment File Size: " + attachment.Size);
                            ParentId parentId = attachment.ParentId;
                            if (parentId != null)
                            {
                                Console.WriteLine("Attachment parent record Name: " + parentId.Name);
                                Console.WriteLine("Attachment parent record ID: " + parentId.Id);
                            }
                            Console.WriteLine("Attachment is Editable: " + attachment.Editable);
                            Console.WriteLine("Attachment SharingPermission: " + attachment.SharingPermission);
                            Console.WriteLine("Attachment File ID: " + attachment.FileId);
                            Console.WriteLine("Attachment File Type: " + attachment.Type);
                            Console.WriteLine("Attachment seModule: " + attachment.SeModule);
                            Com.Zoho.Crm.API.Users.MinifiedUser modifiedBy = attachment.ModifiedBy;
                            if (modifiedBy != null)
                            {
                                Console.WriteLine("Attachment Modified By User-Name: " + modifiedBy.Name);
                                Console.WriteLine("Attachment Modified By User-ID: " + modifiedBy.Id);
                                Console.WriteLine("Attachment Modified By User-Email: " + modifiedBy.Email);
                            }
                            Console.WriteLine("Attachment Type: " + attachment.AttachmentType);
                            Console.WriteLine("Attachment State: " + attachment.State);
                            Console.WriteLine("Attachment ID: " + attachment.Id);
                            Com.Zoho.Crm.API.Users.MinifiedUser createdBy = attachment.CreatedBy;
                            if (createdBy != null)
                            {
                                Console.WriteLine("Attachment Created By User-Name: " + createdBy.Name);
                                Console.WriteLine("Attachment Created By User-ID: " + createdBy.Id);
                                Console.WriteLine("Attachment Created By User-Email: " + createdBy.Email);
                            }
                            Console.WriteLine("Attachment LinkUrl: " + attachment.LinkUrl);
                        }
                        Info info = responseWrapper.Info;
                        if (info != null)
                        {
                            if (info.PerPage != null)
                            {
                                Console.WriteLine("Attachment Info PerPage: " + info.PerPage);
                            }
                            if (info.Count != null)
                            {
                                Console.WriteLine("Attachment Info Count: " + info.Count);
                            }
                            if (info.Page != null)
                            {
                                Console.WriteLine("Attachment Info Page: " + info.Page);
                            }
                            if (info.MoreRecords != null)
                            {
                                Console.WriteLine("Record Info MoreRecords: " + info.MoreRecords);
                            }
                        }
                    }
                    else if (responseHandler is APIException)
                    {
                        APIException exception = (APIException)responseHandler;
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
                IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").RedirectURL("Redirect_URL").Build();
                new Initializer.Builder().Environment(environment).Token(token).Initialize();
                string moduleAPIName = "Leads";
                long recordId = 4402480774074l;
                GetAttachments_1(moduleAPIName, recordId);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}