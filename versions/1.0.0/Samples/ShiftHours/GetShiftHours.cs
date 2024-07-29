using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Initializer = Com.Zoho.Crm.API.Initializer;
using APIException = Com.Zoho.Crm.API.ShiftHours.APIException;
using BreakCustomTiming = Com.Zoho.Crm.API.ShiftHours.BreakCustomTiming;
using BreakHours = Com.Zoho.Crm.API.ShiftHours.BreakHours;
using ResponseHandler = Com.Zoho.Crm.API.ShiftHours.ResponseHandler;
using ResponseWrapper = Com.Zoho.Crm.API.ShiftHours.ResponseWrapper;
using ShiftCount = Com.Zoho.Crm.API.ShiftHours.ShiftCount;
using ShiftCustomTiming = Com.Zoho.Crm.API.ShiftHours.ShiftCustomTiming;
using ShiftHours = Com.Zoho.Crm.API.ShiftHours.ShiftHours;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using ShiftHoursOperations = Com.Zoho.Crm.API.ShiftHours.ShiftHoursOperations;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.Shifthours
{
    public class GetShiftHours
	{
		public static void GetShiftHours_1()
		{
			ShiftHoursOperations shiftHoursOperations = new ShiftHoursOperations("440248020813");
			APIResponse<ResponseHandler> response = shiftHoursOperations.GetShiftHours();
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
					ResponseHandler responseObject = (ResponseHandler) response.Object;
					if (responseObject is ResponseWrapper)
					{
						ResponseWrapper responseWrapper = (ResponseWrapper) responseObject;
						ShiftCount shiftcount = responseWrapper.ShiftCount;
						Console.WriteLine ("Shift_count :");
						Console.WriteLine ("total_shift_with_user :" + shiftcount.TotalShiftWithUser);
						Console.WriteLine ("total_shift :" + shiftcount.TotalShift);
						List<ShiftHours> shifthours = responseWrapper.ShiftHours;
						foreach (ShiftHours shifthour in shifthours)
						{
							Console.WriteLine ("name : " + shifthour.Name);
							Console.WriteLine ("same_as_everyday : " + shifthour.SameAsEveryday);
							Console.WriteLine ("shifthour id : " + shifthour.Id);
							Console.WriteLine ("users_count : " + shifthour.UsersCount);
							Console.WriteLine ("timezone : " + shifthour.Timezone);
							List<string> shiftDays = shifthour.ShiftDays;
							if (shiftDays != null)
							{
								Console.WriteLine ("ShiftDays : ");
								foreach (string shiftDay in shiftDays)
								{
									Console.WriteLine (shiftDay);
								}
							}
							List<TimeSpan> dailyTiming = shifthour.DailyTiming;
							if (dailyTiming != null)
							{
								Console.WriteLine ("Daily_timing : ");
								foreach (TimeSpan dailytiming in dailyTiming)
								{
									Console.WriteLine (dailytiming);
								}
							}
							List<ShiftCustomTiming> customTiming = shifthour.CustomTiming;
							if(customTiming != null) {
								Console.WriteLine ("custom_timing : ");
								foreach (ShiftCustomTiming customtiming in customTiming) {
									List<TimeSpan> shiftTiming = customtiming.ShiftTiming;
									Console.WriteLine ("shift_timing :");
									foreach (TimeSpan shifttiming in shiftTiming) {
										Console.WriteLine (shifttiming);
									}
									Console.WriteLine ("days : "+ customtiming.Days);
								}
							}
							List<Com.Zoho.Crm.API.ShiftHours.Holidays> holidays = shifthour.Holidays;
							if (holidays != null)
							{
								Console.WriteLine ("holidays : ");
								foreach (Com.Zoho.Crm.API.ShiftHours.Holidays holiday in holidays)
								{
									Console.WriteLine ("date : " + holiday.Date);
									Console.WriteLine ("year : " + holiday.Year);
									Console.WriteLine ("name : " + holiday.Name);
									Console.WriteLine ("id : " + holiday.Id);
								}
							}
							List<Com.Zoho.Crm.API.ShiftHours.Users> users = shifthour.Users;
							if (users != null)
							{
								Console.WriteLine ("Users : ");
								foreach (Com.Zoho.Crm.API.ShiftHours.Users user in users)
								{
									Console.WriteLine ("User_Id : " + user.Id);
									Console.WriteLine ("User_name : " + user.Name);
									Console.WriteLine ("User_email : " + user.Email);
									Console.WriteLine ("User_role : " + user.Role);
									Console.WriteLine ("User_ZUID : " + user.Zuid);
									Console.WriteLine ("effective_from : " + user.EffectiveFrom);
								}
							}
							List<BreakHours> breakHours = shifthour.BreakHours;
							if (breakHours != null)
							{
								foreach (BreakHours breakhour in breakHours)
								{
									Console.WriteLine ("breakHour_ID : " + breakhour.Id);
									Console.WriteLine ("same_as_everyday : " + breakhour.SameAsEveryday);
									List<string> breakdays = breakhour.BreakDays;
									if (breakdays != null)
									{
										foreach (string breakday in breakdays)
										{
											Console.WriteLine ("breakdays : " + breakday);
										}
									}
									List<TimeSpan> dailyTimings = breakhour.DailyTiming;
									if (dailyTimings != null)
									{
										foreach (TimeSpan dailytiming in dailyTimings)
										{
											Console.WriteLine ("dailyTiming : " + dailytiming);
										}
									}
									List<BreakCustomTiming> breakHoursCustomTimings = breakhour.CustomTiming;
									if (breakHoursCustomTimings != null)
									{
										foreach (BreakCustomTiming breakHourCustomTiming in breakHoursCustomTimings)
										{
											Console.WriteLine ("CustomTiming : ");
											List<TimeSpan> breakTimings = breakHourCustomTiming.BreakTiming;
											if (breakTimings != null)
											{
												foreach (TimeSpan breakTiming in breakTimings)
												{
													Console.WriteLine ("breakTiming : " + breakTiming);
												}
												Console.WriteLine ("days : " + breakHourCustomTiming.Days);
											}
										}
									}
								}
							}
						}
					}
					else if (responseObject is APIException)
					{
						APIException exception = (APIException) responseObject;
						Console.WriteLine ("Status: " + exception.Status.Value);
						Console.WriteLine ("Code: " + exception.Code.Value);
						Console.WriteLine ("Details: ");
						foreach (KeyValuePair<string, object> entry in exception.Details)
						{
							Console.WriteLine (entry.Key + ": " + entry.Value);
						}
						Console.WriteLine ("Message: " + exception.Message);
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
                GetShiftHours_1();
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}