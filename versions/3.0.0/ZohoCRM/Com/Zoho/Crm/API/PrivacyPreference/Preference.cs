using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PrivacyPreference
{

	public class Preference : Model
	{
		private string consentModules;
		private string restrictTptFields;
		private string excludeAPIZoho;
		private string awaitingPeriod;
		private string consentMailSend;
		private string excludeExportFields;
		private string limitActions;
		private string excludeExport;
		private string restrictZohoInteg;
		private string excludeAPIZohoFields;
		private string durationTiming;
		private string dataProcessingDuration;
		private string restrictTptServices;
		private string excludeAPITptFields;
		private string restrictZohoIntegServices;
		private string privacySettingStatus;
		private string doubleOptIn;
		private string restrictZohoIntegFields;
		private string excludeAPITpt;
		private string blockList;
		private string restrictTpt;
		private string actionsWhileAwaiting;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string ConsentModules
		{
			/// <summary>The method to get the consentModules</summary>
			/// <returns>string representing the consentModules</returns>
			get
			{
				return  this.consentModules;

			}
			/// <summary>The method to set the value to consentModules</summary>
			/// <param name="consentModules">string</param>
			set
			{
				 this.consentModules=value;

				 this.keyModified["consent_modules"] = 1;

			}
		}

		public string RestrictTptFields
		{
			/// <summary>The method to get the restrictTptFields</summary>
			/// <returns>string representing the restrictTptFields</returns>
			get
			{
				return  this.restrictTptFields;

			}
			/// <summary>The method to set the value to restrictTptFields</summary>
			/// <param name="restrictTptFields">string</param>
			set
			{
				 this.restrictTptFields=value;

				 this.keyModified["restrict_tpt_fields"] = 1;

			}
		}

		public string ExcludeAPIZoho
		{
			/// <summary>The method to get the excludeAPIZoho</summary>
			/// <returns>string representing the excludeAPIZoho</returns>
			get
			{
				return  this.excludeAPIZoho;

			}
			/// <summary>The method to set the value to excludeAPIZoho</summary>
			/// <param name="excludeAPIZoho">string</param>
			set
			{
				 this.excludeAPIZoho=value;

				 this.keyModified["exclude_api_zoho"] = 1;

			}
		}

		public string AwaitingPeriod
		{
			/// <summary>The method to get the awaitingPeriod</summary>
			/// <returns>string representing the awaitingPeriod</returns>
			get
			{
				return  this.awaitingPeriod;

			}
			/// <summary>The method to set the value to awaitingPeriod</summary>
			/// <param name="awaitingPeriod">string</param>
			set
			{
				 this.awaitingPeriod=value;

				 this.keyModified["awaiting_period"] = 1;

			}
		}

		public string ConsentMailSend
		{
			/// <summary>The method to get the consentMailSend</summary>
			/// <returns>string representing the consentMailSend</returns>
			get
			{
				return  this.consentMailSend;

			}
			/// <summary>The method to set the value to consentMailSend</summary>
			/// <param name="consentMailSend">string</param>
			set
			{
				 this.consentMailSend=value;

				 this.keyModified["consent_mail_send"] = 1;

			}
		}

		public string ExcludeExportFields
		{
			/// <summary>The method to get the excludeExportFields</summary>
			/// <returns>string representing the excludeExportFields</returns>
			get
			{
				return  this.excludeExportFields;

			}
			/// <summary>The method to set the value to excludeExportFields</summary>
			/// <param name="excludeExportFields">string</param>
			set
			{
				 this.excludeExportFields=value;

				 this.keyModified["exclude_export_fields"] = 1;

			}
		}

		public string LimitActions
		{
			/// <summary>The method to get the limitActions</summary>
			/// <returns>string representing the limitActions</returns>
			get
			{
				return  this.limitActions;

			}
			/// <summary>The method to set the value to limitActions</summary>
			/// <param name="limitActions">string</param>
			set
			{
				 this.limitActions=value;

				 this.keyModified["limit_actions"] = 1;

			}
		}

		public string ExcludeExport
		{
			/// <summary>The method to get the excludeExport</summary>
			/// <returns>string representing the excludeExport</returns>
			get
			{
				return  this.excludeExport;

			}
			/// <summary>The method to set the value to excludeExport</summary>
			/// <param name="excludeExport">string</param>
			set
			{
				 this.excludeExport=value;

				 this.keyModified["exclude_export"] = 1;

			}
		}

		public string RestrictZohoInteg
		{
			/// <summary>The method to get the restrictZohoInteg</summary>
			/// <returns>string representing the restrictZohoInteg</returns>
			get
			{
				return  this.restrictZohoInteg;

			}
			/// <summary>The method to set the value to restrictZohoInteg</summary>
			/// <param name="restrictZohoInteg">string</param>
			set
			{
				 this.restrictZohoInteg=value;

				 this.keyModified["restrict_zoho_integ"] = 1;

			}
		}

		public string ExcludeAPIZohoFields
		{
			/// <summary>The method to get the excludeAPIZohoFields</summary>
			/// <returns>string representing the excludeAPIZohoFields</returns>
			get
			{
				return  this.excludeAPIZohoFields;

			}
			/// <summary>The method to set the value to excludeAPIZohoFields</summary>
			/// <param name="excludeAPIZohoFields">string</param>
			set
			{
				 this.excludeAPIZohoFields=value;

				 this.keyModified["exclude_api_zoho_fields"] = 1;

			}
		}

		public string DurationTiming
		{
			/// <summary>The method to get the durationTiming</summary>
			/// <returns>string representing the durationTiming</returns>
			get
			{
				return  this.durationTiming;

			}
			/// <summary>The method to set the value to durationTiming</summary>
			/// <param name="durationTiming">string</param>
			set
			{
				 this.durationTiming=value;

				 this.keyModified["duration_timing"] = 1;

			}
		}

		public string DataProcessingDuration
		{
			/// <summary>The method to get the dataProcessingDuration</summary>
			/// <returns>string representing the dataProcessingDuration</returns>
			get
			{
				return  this.dataProcessingDuration;

			}
			/// <summary>The method to set the value to dataProcessingDuration</summary>
			/// <param name="dataProcessingDuration">string</param>
			set
			{
				 this.dataProcessingDuration=value;

				 this.keyModified["data_processing_duration"] = 1;

			}
		}

		public string RestrictTptServices
		{
			/// <summary>The method to get the restrictTptServices</summary>
			/// <returns>string representing the restrictTptServices</returns>
			get
			{
				return  this.restrictTptServices;

			}
			/// <summary>The method to set the value to restrictTptServices</summary>
			/// <param name="restrictTptServices">string</param>
			set
			{
				 this.restrictTptServices=value;

				 this.keyModified["restrict_tpt_services"] = 1;

			}
		}

		public string ExcludeAPITptFields
		{
			/// <summary>The method to get the excludeAPITptFields</summary>
			/// <returns>string representing the excludeAPITptFields</returns>
			get
			{
				return  this.excludeAPITptFields;

			}
			/// <summary>The method to set the value to excludeAPITptFields</summary>
			/// <param name="excludeAPITptFields">string</param>
			set
			{
				 this.excludeAPITptFields=value;

				 this.keyModified["exclude_api_tpt_fields"] = 1;

			}
		}

		public string RestrictZohoIntegServices
		{
			/// <summary>The method to get the restrictZohoIntegServices</summary>
			/// <returns>string representing the restrictZohoIntegServices</returns>
			get
			{
				return  this.restrictZohoIntegServices;

			}
			/// <summary>The method to set the value to restrictZohoIntegServices</summary>
			/// <param name="restrictZohoIntegServices">string</param>
			set
			{
				 this.restrictZohoIntegServices=value;

				 this.keyModified["restrict_zoho_integ_services"] = 1;

			}
		}

		public string PrivacySettingStatus
		{
			/// <summary>The method to get the privacySettingStatus</summary>
			/// <returns>string representing the privacySettingStatus</returns>
			get
			{
				return  this.privacySettingStatus;

			}
			/// <summary>The method to set the value to privacySettingStatus</summary>
			/// <param name="privacySettingStatus">string</param>
			set
			{
				 this.privacySettingStatus=value;

				 this.keyModified["privacy_setting_status"] = 1;

			}
		}

		public string DoubleOptIn
		{
			/// <summary>The method to get the doubleOptIn</summary>
			/// <returns>string representing the doubleOptIn</returns>
			get
			{
				return  this.doubleOptIn;

			}
			/// <summary>The method to set the value to doubleOptIn</summary>
			/// <param name="doubleOptIn">string</param>
			set
			{
				 this.doubleOptIn=value;

				 this.keyModified["double_opt_in"] = 1;

			}
		}

		public string RestrictZohoIntegFields
		{
			/// <summary>The method to get the restrictZohoIntegFields</summary>
			/// <returns>string representing the restrictZohoIntegFields</returns>
			get
			{
				return  this.restrictZohoIntegFields;

			}
			/// <summary>The method to set the value to restrictZohoIntegFields</summary>
			/// <param name="restrictZohoIntegFields">string</param>
			set
			{
				 this.restrictZohoIntegFields=value;

				 this.keyModified["restrict_zoho_integ_fields"] = 1;

			}
		}

		public string ExcludeAPITpt
		{
			/// <summary>The method to get the excludeAPITpt</summary>
			/// <returns>string representing the excludeAPITpt</returns>
			get
			{
				return  this.excludeAPITpt;

			}
			/// <summary>The method to set the value to excludeAPITpt</summary>
			/// <param name="excludeAPITpt">string</param>
			set
			{
				 this.excludeAPITpt=value;

				 this.keyModified["exclude_api_tpt"] = 1;

			}
		}

		public string BlockList
		{
			/// <summary>The method to get the blockList</summary>
			/// <returns>string representing the blockList</returns>
			get
			{
				return  this.blockList;

			}
			/// <summary>The method to set the value to blockList</summary>
			/// <param name="blockList">string</param>
			set
			{
				 this.blockList=value;

				 this.keyModified["block_list"] = 1;

			}
		}

		public string RestrictTpt
		{
			/// <summary>The method to get the restrictTpt</summary>
			/// <returns>string representing the restrictTpt</returns>
			get
			{
				return  this.restrictTpt;

			}
			/// <summary>The method to set the value to restrictTpt</summary>
			/// <param name="restrictTpt">string</param>
			set
			{
				 this.restrictTpt=value;

				 this.keyModified["restrict_tpt"] = 1;

			}
		}

		public string ActionsWhileAwaiting
		{
			/// <summary>The method to get the actionsWhileAwaiting</summary>
			/// <returns>string representing the actionsWhileAwaiting</returns>
			get
			{
				return  this.actionsWhileAwaiting;

			}
			/// <summary>The method to set the value to actionsWhileAwaiting</summary>
			/// <param name="actionsWhileAwaiting">string</param>
			set
			{
				 this.actionsWhileAwaiting=value;

				 this.keyModified["actions_while_awaiting"] = 1;

			}
		}

		/// <summary>The method to check if the user has modified the given key</summary>
		/// <param name="key">string</param>
		/// <returns>int? representing the modification</returns>
		public int? IsKeyModified(string key)
		{
			if((( this.keyModified.ContainsKey(key))))
			{
				return  this.keyModified[key];

			}
			return null;


		}

		/// <summary>The method to mark the given key as modified</summary>
		/// <param name="key">string</param>
		/// <param name="modification">int?</param>
		public void SetKeyModified(string key, int? modification)
		{
			 this.keyModified[key] = modification;


		}


	}
}