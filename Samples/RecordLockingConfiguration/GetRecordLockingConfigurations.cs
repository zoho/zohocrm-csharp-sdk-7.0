using System;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.Dc;
using System.Collections.Generic;
using System.Reflection;
using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Fields;
using Com.Zoho.Crm.API.RecordLockingConfiguration;
using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using Newtonsoft.Json;
using static Com.Zoho.Crm.API.RecordLockingConfiguration.RecordLockingConfigurationOperations;
using APIException = Com.Zoho.Crm.API.RecordLockingConfiguration.APIException;
using Criteria = Com.Zoho.Crm.API.RecordLockingConfiguration.Criteria;
using ResponseHandler = Com.Zoho.Crm.API.RecordLockingConfiguration.ResponseHandler;
using ResponseWrapper = Com.Zoho.Crm.API.RecordLockingConfiguration.ResponseWrapper;

namespace Samples.RecordLockingConfiguration
{
	public class GetRecordLockingConfigurations
	{
		public static void GetRecordLockingConfigurations_1(String moduleAPIName)
		{
			RecordLockingConfigurationOperations recordLockingConfigurationOperations = new RecordLockingConfigurationOperations(moduleAPIName);
			ParameterMap paramInstance = new ParameterMap();
			paramInstance.Add(GetRecordLockingConfigurationsParam.FEATURE_TYPE, "record_locking");
			APIResponse<ResponseHandler> response = recordLockingConfigurationOperations.GetRecordLockingConfigurations(paramInstance);
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
						List<RecordLock> recordLocks = responseWrapper.RecordLockingConfigurations;
						foreach (RecordLock recordLock in recordLocks)
						{
							Console.WriteLine("RecordLockingConfigurationOperations LockedFor: " + recordLock.CreatedTime);
							Console.WriteLine("RecordLockingConfigurationOperations LockedFor: " + recordLock.LockedFor);

							List<MinifiedField> excludedFields = recordLock.ExcludedFields;
							if (excludedFields != null)
							{
								foreach (MinifiedField excludedField in excludedFields)
								{
									Console.WriteLine("RecordLockingConfigurationOperations ExcludedFields APIName: " + excludedField.APIName);
									Console.WriteLine("RecordLockingConfigurationOperations ExcludedFields Id: " + excludedField.Id);
								}
							}
							MinifiedUser createdBy = recordLock.CreatedBy;
							if (createdBy != null)
							{
								Console.WriteLine("RecordLockingConfigurationOperations CreatedBy User Name: " + createdBy.Name);
								Console.WriteLine("RecordLockingConfigurationOperations CreatedBy User Id: " + createdBy.Id);
							}
							Console.WriteLine("RecordLockingConfigurationOperations FeatureType: " + recordLock.FeatureType);
							List<LockingRules> lockingRules = recordLock.LockingRules;
							if (lockingRules != null)
							{
								foreach (LockingRules lockingRule in lockingRules)
								{
									Console.WriteLine("RecordLockingConfigurationOperations LockingRules Name: " + lockingRule.Name);
									Console.WriteLine("RecordLockingConfigurationOperations LockingRules Id: " + lockingRule.Id);
									Console.WriteLine("RecordLockingConfigurationOperations LockingRules LockExistingRecords: " + lockingRule.LockExistingRecords);
									Criteria criteria = lockingRule.Criteria;
									if (criteria != null)
									{
										PrintCriteria(criteria);
									}
								}
							}
							List<String> restrictedActions = recordLock.RestrictedActions;
							if (restrictedActions != null)
							{
								foreach (String restrictedAction in restrictedActions)
								{
									Console.WriteLine("RecordLockingConfigurationOperations RestrictedActions : " + restrictedAction);
								}
							}
							Console.WriteLine("RecordLockingConfigurationOperations LockForPortalUsers: " + recordLock.LockForPortalUsers);
							Console.WriteLine("RecordLockingConfigurationOperations ModifiedTime: " + recordLock.ModifiedTime);
							List<String> restrictedCommunications = recordLock.RestrictedCommunications;
							if (restrictedCommunications != null)
							{
								foreach (String restrictedCommunication in restrictedCommunications)
								{
									Console.WriteLine("RecordLockingConfigurationOperations RestrictedCommunications : " + restrictedCommunication);
								}
							}
							Console.WriteLine("RecordLockingConfigurationOperations SystemDefined: " + recordLock.SystemDefined);
							MinifiedUser modifiedBy = recordLock.ModifiedBy;
							if (modifiedBy != null)
							{
								Console.WriteLine("RecordLockingConfigurationOperations ModifiedBy User Name: " + modifiedBy.Name);
								Console.WriteLine("RecordLockingConfigurationOperations ModifiedBy User Id: " + modifiedBy.Id);
							}
							Console.WriteLine("RecordLockingConfigurationOperations Id: " + recordLock.Id);
							Console.WriteLine("RecordLockingConfigurationOperations LockType: " + recordLock.LockType.Value);

							List<RestrictedCustomButton> restrictedCustomButtons = recordLock.RestrictedCustomButtons;
							if (restrictedCustomButtons != null)
							{
								foreach (RestrictedCustomButton restrictedCustomButton in restrictedCustomButtons)
								{
									Console.WriteLine("RecordLockingConfigurationOperations RestrictedCustomButton Name: " + restrictedCustomButton.Name);
									Console.WriteLine("RecordLockingConfigurationOperations RestrictedCustomButton Id: " + restrictedCustomButton.Id);
								}
							}

							List<LockExcludedProfile> lockExcludedProfiles = recordLock.LockExcludedProfiles;
							if (lockExcludedProfiles != null)
							{
								foreach (LockExcludedProfile lockExcludedProfile in lockExcludedProfiles)
								{
									Console.WriteLine("RecordLockingConfigurationOperations LockExcludedProfile Name: " + lockExcludedProfile.Name);
									Console.WriteLine("RecordLockingConfigurationOperations LockExcludedProfile Id: " + lockExcludedProfile.Id);
								}
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

		private static void PrintCriteria(Criteria criteria)
		{
			if (criteria.Comparator != null)
			{
				Console.WriteLine("Criteria Comparator: " + criteria.Comparator);
			}
			if (criteria.Value != null)
			{
				Console.WriteLine("Criteria Value: " + criteria.Value);
			}
			if (criteria.Field != null)
			{
				Console.WriteLine("Criteria field name: " + criteria.Field.APIName);
			}
			List<Criteria> criteriaGroup = criteria.Group;
			if (criteriaGroup != null)
			{
				foreach (Criteria criteria1 in criteriaGroup)
				{
					PrintCriteria(criteria1);
				}
			}
			if (criteria.GroupOperator != null)
			{
				Console.WriteLine("Criteria Group Operator: " + criteria.GroupOperator);
			}
		}
		public static void Call()
		{
			try
			{
				Environment environment = USDataCenter.PRODUCTION;
				IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").Build();
				new Initializer.Builder().Environment(environment).Token(token).Initialize();
				String moduleAPIName = "Leads";
				GetRecordLockingConfigurations_1(moduleAPIName);
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}