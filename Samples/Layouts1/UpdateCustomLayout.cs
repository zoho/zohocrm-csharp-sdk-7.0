using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.Layouts;
using System.Collections.Generic;
using Com.Zoho.Crm.API;
using static Com.Zoho.Crm.API.Layouts.LayoutsOperations;
using Com.Zoho.Crm.API.Util;
using System.Reflection;
using Newtonsoft.Json;

namespace Samples.Layouts1
{
    public class UpdateCustomLayout
    {
        public static void UpdateCustomLayout_1(long id, String moduleAPIName)
        {
            LayoutsOperations layoutsOperations = new LayoutsOperations();
            BodyWrapper request = new BodyWrapper();
            List<Layouts> layouts = new List<Layouts>();
            Layouts layout = new Layouts();

            List<Sections> sections = new List<Sections>();
            Sections section = new Sections();
            section.Id = 34770447317;
            List<SectionField> sectionFields = new List<SectionField>();

            SectionField sectionField = new SectionField();
            sectionField.FieldLabel = "JAVASDK";
            sectionField.DataType = "boolean";
            sectionFields.Add(sectionField);

            sectionField = new SectionField();
            sectionField.Id = 34778447113;
            sectionField.FieldLabel = "Subform123";
            sectionFields.Add(sectionField);

            sectionField = new SectionField();
            sectionField.Id = 34770447113;
            Delete1 delete = new Delete1();
            delete.Permanent = false;
            sectionField.Delete = delete;
            sectionFields.Add(sectionField);

            section.Fields = sectionFields;
            sections.Add(section);

            layout.Sections = sections;
            layouts.Add(layout);

            request.Layouts = layouts;

            ParameterMap paramInstance = new ParameterMap();
            paramInstance.Add(ActivateCustomLayoutParam.MODULE, moduleAPIName);
            APIResponse<ActionHandler> response = layoutsOperations.UpdateCustomLayout(id, request, paramInstance);
            if (response != null)
            {
                Console.WriteLine("Status Code: " + response.StatusCode);
                if (response.IsExpected)
                {
                    ActionHandler actionHandler = response.Object;
                    if (actionHandler is ActionWrapper)
                    {
                        ActionWrapper actionWrapper = (ActionWrapper)actionHandler;
                        List<ActionResponse> actionresponses = actionWrapper.Layouts;
                        foreach (ActionResponse actionresponse in actionresponses)
                        {
                            if (actionresponse is SuccessResponse)
                            {
                                SuccessResponse successresponse = (SuccessResponse)actionresponse;
                                Console.WriteLine("Status: " + successresponse.Status.Value);
                                Console.WriteLine("Code: " + successresponse.Code.Value);
                                Console.WriteLine("Details: ");
                                foreach (KeyValuePair<string, object> entry in successresponse.Details)
                                {
                                    Console.WriteLine(entry.Key + ": " + entry.Value);
                                }
                                Console.WriteLine("Message: " + successresponse.Message.Value);
                            }
                            else if (actionresponse is APIException)
                            {
                                APIException exception = (APIException)actionresponse;
                                Console.WriteLine("Status: " + exception.Status.Value);
                                Console.WriteLine("Code: " + exception.Code.Value);
                                Console.WriteLine("Details: ");
                                foreach (KeyValuePair<string, object> entry in exception.Details)
                                {
                                    Console.WriteLine(entry.Key + ": " + entry.Value);
                                }
                                Console.WriteLine("Message: " + exception.Message.Value);
                            }
                        }

                    }
                    else if (actionHandler is APIException)
                    {
                        APIException exception = (APIException)actionHandler;
                        Console.WriteLine("Status: " + exception.Status.Value);
                        Console.WriteLine("Code: " + exception.Code.Value);
                        Console.WriteLine("Details: ");
                        foreach (KeyValuePair<string, object> entry in exception.Details)
                        {
                            Console.WriteLine(entry.Key + ": " + entry.Value);
                        }
                        Console.WriteLine("Message: " + exception.Message.Value);
                    }
                }
                else
                {
                    Model responseObject = response.Model;
                    System.Type type = responseObject.GetType();
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
                IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").Build();
                new Initializer.Builder().Environment(environment).Token(token).Initialize();
                long id = 34770626323001;
                String moduleAPIName = "Leads";
                UpdateCustomLayout_1(id, moduleAPIName);
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}