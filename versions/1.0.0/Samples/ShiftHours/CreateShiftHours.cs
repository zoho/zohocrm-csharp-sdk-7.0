using System;
using System.Reflection;
using System.Collections.Generic;
using ActionHandler = Com.Zoho.Crm.API.BusinessHours.ActionHandler;
using BodyWrapper = Com.Zoho.Crm.API.BusinessHours.BodyWrapper;
using BreakHoursCustomTiming = Com.Zoho.Crm.API.BusinessHours.BreakHoursCustomTiming;
using BusinessHours = Com.Zoho.Crm.API.BusinessHours.BusinessHours;
using BusinessHoursOperations = Com.Zoho.Crm.API.BusinessHours.BusinessHoursOperations;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using APIException = Com.Zoho.Crm.API.BusinessHours.APIException;
using ActionResponse = Com.Zoho.Crm.API.BusinessHours.ActionResponse;
using ActionWrapper = Com.Zoho.Crm.API.BusinessHours.ActionWrapper;
using SuccessResponse = Com.Zoho.Crm.API.BusinessHours.SuccessResponse;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.Shifthours
{
    public class CreateBusinessHours
    {
        public static void CreateBusinessHours_1()
        {
            BusinessHoursOperations businessHoursOperations = new BusinessHoursOperations("X-CRM-ORG");
            BodyWrapper request = new BodyWrapper();
            BusinessHours businessHours = new BusinessHours();
            List<Choice<string>> businessdays = new List<Choice<string>>();
            businessdays.Add(new Choice<string>("Monday"));
            businessHours.BusinessDays = businessdays;
            businessHours.WeekStartsOn = new Choice<string>("Monday");
            BreakHoursCustomTiming bhct = new BreakHoursCustomTiming();
            bhct.Days = new Choice<string>("Monday");
            List<string> businessTiming = new List<string>();
            businessTiming.Add("10:00");
            businessTiming.Add("11:00");
            bhct.BusinessTiming = businessTiming;
            List<BreakHoursCustomTiming> customTiming = new List<BreakHoursCustomTiming>();
            customTiming.Add(bhct);
            businessHours.CustomTiming = customTiming;
            businessHours.SameAsEveryday = false;
            // when sameasEveryDay is true
            List<Choice<string>> dailyTiming = new List<Choice<string>>();
            dailyTiming.Add(new Choice<string>("10:00"));
            dailyTiming.Add(new Choice<string>("11:00"));
            businessHours.Type = new Choice<string>("custom");
            request.BusinessHours = businessHours;
            APIResponse<ActionHandler> response = businessHoursOperations.CreateBusinessHours(request);
            if (response != null)
            {
                Console.WriteLine("Status Code: " + response.StatusCode);
                if (response.IsExpected)
                {
                    ActionHandler actionHandler = response.Object;
                    if (actionHandler is ActionWrapper)
                    {
                        ActionWrapper actionWrapper = (ActionWrapper)actionHandler;
                        ActionResponse actionResponse = actionWrapper.BusinessHours;
                        if (actionResponse is SuccessResponse)
                        {
                            SuccessResponse businesshourscreated = (SuccessResponse)actionResponse;
                            Console.WriteLine("Status: " + businesshourscreated.Status.Value);
                            Console.WriteLine("Code: " + businesshourscreated.Code.Value);
                            Console.WriteLine("Details: ");
                            foreach (KeyValuePair<string, object> entry in businesshourscreated.Details)
                            {
                                Console.WriteLine(entry.Key + ": " + entry.Value);
                            }
                            Console.WriteLine("Message: " + businesshourscreated.Message.Value);
                        }
                        else if (actionResponse is APIException)
                        {
                            APIException exception = (APIException)actionResponse;
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
                CreateBusinessHours_1();
            }
            catch (Exception e)
            {
                Console.WriteLine(JsonConvert.SerializeObject(e));
            }
        }
    }
}