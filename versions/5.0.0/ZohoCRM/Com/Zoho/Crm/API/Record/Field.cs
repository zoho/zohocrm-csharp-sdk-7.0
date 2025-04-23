using Com.Zoho.Crm.API.Layouts;
using Com.Zoho.Crm.API.Modules;
using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Record
{

	public class Field<T>
	{
		private string apiName;

		/// <summary>		/// Creates an instance of Field with the given parameters
		/// <param name="apiName">string</param>
		
		public Field(string apiName)
		{
			 this.apiName=apiName;


		}

		public string APIName
		{
			/// <summary>The method to get the aPIName</summary>
			/// <returns>string representing the apiName</returns>
			get
			{
				return  this.apiName;

			}

		}


	}
	public static class Products
	{
		public static readonly Field<Choice<string>> PRODUCT_CATEGORY=new Field<Choice<string>>("Product_Category");
		public static readonly Field<double?> QTY_IN_DEMAND=new Field<double?>("Qty_in_Demand");
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<Record> VENDOR_NAME=new Field<Record>("Vendor_Name");
		public static readonly Field<DateTime?> SALES_START_DATE=new Field<DateTime?>("Sales_Start_Date");
		public static readonly Field<List<Tax>> TAX=new Field<List<Tax>>("Tax");
		public static readonly Field<bool?> PRODUCT_ACTIVE=new Field<bool?>("Product_Active");
		public static readonly Field<string> RECORD_IMAGE=new Field<string>("Record_Image");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<string> PRODUCT_CODE=new Field<string>("Product_Code");
		public static readonly Field<Choice<string>> MANUFACTURER=new Field<Choice<string>>("Manufacturer");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<DateTime?> SUPPORT_EXPIRY_DATE=new Field<DateTime?>("Support_Expiry_Date");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<double?> COMMISSION_RATE=new Field<double?>("Commission_Rate");
		public static readonly Field<string> PRODUCT_NAME=new Field<string>("Product_Name");
		public static readonly Field<MinifiedUser> HANDLER=new Field<MinifiedUser>("Handler");
		public static readonly Field<DateTime?> SUPPORT_START_DATE=new Field<DateTime?>("Support_Start_Date");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<Choice<string>> USAGE_UNIT=new Field<Choice<string>>("Usage_Unit");
		public static readonly Field<double?> QTY_ORDERED=new Field<double?>("Qty_Ordered");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<double?> QTY_IN_STOCK=new Field<double?>("Qty_in_Stock");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<DateTime?> SALES_END_DATE=new Field<DateTime?>("Sales_End_Date");
		public static readonly Field<double?> UNIT_PRICE=new Field<double?>("Unit_Price");
		public static readonly Field<bool?> TAXABLE=new Field<bool?>("Taxable");
		public static readonly Field<double?> REORDER_LEVEL=new Field<double?>("Reorder_Level");
	}


	public static class Consents
	{
		public static readonly Field<bool?> CONTACT_THROUGH_EMAIL=new Field<bool?>("Contact_Through_Email");
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<string> EMAIL=new Field<string>("Email");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<Choice<string>> CONSENT_THROUGH=new Field<Choice<string>>("Consent_Through");
		public static readonly Field<bool?> CONTACT_THROUGH_SURVEY=new Field<bool?>("Contact_Through_Survey");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<Choice<string>> DATA_PROCESSING_BASIS=new Field<Choice<string>>("Data_Processing_Basis");
		public static readonly Field<bool?> CONTACT_THROUGH_PHONE=new Field<bool?>("Contact_Through_Phone");
		public static readonly Field<string> LAWFUL_REASON=new Field<string>("Lawful_Reason");
		public static readonly Field<DateTimeOffset?> MAIL_SENT_TIME=new Field<DateTimeOffset?>("Mail_Sent_Time");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<DateTime?> CONSENT_DATE=new Field<DateTime?>("Consent_Date");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> CONSENT_REMARKS=new Field<string>("Consent_Remarks");
	}


	public static class Tasks
	{
		public static readonly Field<Choice<string>> STATUS=new Field<Choice<string>>("Status");
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<DateTime?> DUE_DATE=new Field<DateTime?>("Due_Date");
		public static readonly Field<Choice<string>> PRIORITY=new Field<Choice<string>>("Priority");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<DateTimeOffset?> CLOSED_TIME=new Field<DateTimeOffset?>("Closed_Time");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<string> SUBJECT=new Field<string>("Subject");
		public static readonly Field<bool?> SEND_NOTIFICATION_EMAIL=new Field<bool?>("Send_Notification_Email");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<RecurringActivity> RECURRING_ACTIVITY=new Field<RecurringActivity>("Recurring_Activity");
		public static readonly Field<Record> WHAT_ID=new Field<Record>("What_Id");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<RemindAt> REMIND_AT=new Field<RemindAt>("Remind_At");
		public static readonly Field<Record> WHO_ID=new Field<Record>("Who_Id");
	}


	public static class Data_Subject_Requests
	{
		public static readonly Field<Choice<string>> REQUEST_TYPE=new Field<Choice<string>>("Request_Type");
		public static readonly Field<string> IS_CLOSED=new Field<string>("Is_Closed");
		public static readonly Field<Record> PARENT_ID=new Field<Record>("Parent_Id");
		public static readonly Field<Choice<string>> REQUEST_SOURCE=new Field<Choice<string>>("Request_Source");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<MinifiedUser> CLOSED_BY=new Field<MinifiedUser>("Closed_By");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<MinifiedUser> REQUESTED_BY=new Field<MinifiedUser>("Requested_By");
		public static readonly Field<DateTimeOffset?> REQUESTED_DATE=new Field<DateTimeOffset?>("Requested_Date");
		public static readonly Field<DateTimeOffset?> CLOSED_DATE=new Field<DateTimeOffset?>("Closed_Date");
	}


	public static class Vendors
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> EMAIL=new Field<string>("Email");
		public static readonly Field<string> CATEGORY=new Field<string>("Category");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<string> VENDOR_NAME=new Field<string>("Vendor_Name");
		public static readonly Field<string> WEBSITE=new Field<string>("Website");
		public static readonly Field<string> RECORD_IMAGE=new Field<string>("Record_Image");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<Choice<string>> UNSUBSCRIBED_MODE=new Field<Choice<string>>("Unsubscribed_Mode");
		public static readonly Field<string> PHONE=new Field<string>("Phone");
		public static readonly Field<string> STREET=new Field<string>("Street");
		public static readonly Field<string> ZIP_CODE=new Field<string>("Zip_Code");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<bool?> EMAIL_OPT_OUT=new Field<bool?>("Email_Opt_Out");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<DateTimeOffset?> UNSUBSCRIBED_TIME=new Field<DateTimeOffset?>("Unsubscribed_Time");
		public static readonly Field<string> CITY=new Field<string>("City");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<string> STATE=new Field<string>("State");
		public static readonly Field<Choice<string>> GL_ACCOUNT=new Field<Choice<string>>("GL_Account");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<string> COUNTRY=new Field<string>("Country");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
	}


	public static class Data_Enrichment_Stats__s
	{
		public static readonly Field<long?> USAGE_BULK_COUNT__S=new Field<long?>("Usage_Bulk_Count__s");
		public static readonly Field<DateTimeOffset?> USAGE_DATE__S=new Field<DateTimeOffset?>("Usage_Date__s");
		public static readonly Field<string> FEATURE_NAME__S=new Field<string>("Feature_Name__s");
		public static readonly Field<Modules.Modules> MODULE__S=new Field<Modules.Modules>("Module__s");
		public static readonly Field<long?> ADD_ON_LIMIT__S=new Field<long?>("Add_On_Limit__s");
		public static readonly Field<long?> MONTHLY_LIMIT__S=new Field<long?>("Monthly_Limit__s");
		public static readonly Field<long?> USAGE_COUNT__S=new Field<long?>("Usage_Count__s");
	}


	public static class Appointments__s
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> ADDRESS=new Field<string>("Address");
		public static readonly Field<DateTimeOffset?> APPOINTMENT_START_TIME=new Field<DateTimeOffset?>("Appointment_Start_Time");
		public static readonly Field<Choice<string>> CANCELLATION_REASON=new Field<Choice<string>>("Cancellation_Reason");
		public static readonly Field<Record> APPOINTMENT_FOR=new Field<Record>("Appointment_For");
		public static readonly Field<DateTimeOffset?> RESCHEDULED_TO=new Field<DateTimeOffset?>("Rescheduled_To");
		public static readonly Field<Choice<string>> RESCHEDULE_REASON=new Field<Choice<string>>("Reschedule_Reason");
		public static readonly Field<string> JOB_SHEET_NAME__S=new Field<string>("Job_Sheet_Name__s");
		public static readonly Field<string> ADDITIONAL_INFORMATION=new Field<string>("Additional_Information");
		public static readonly Field<bool?> JOB_SHEET_CREATED__S=new Field<bool?>("Job_Sheet_Created__s");
		public static readonly Field<DateTimeOffset?> CANCELLED_TIME=new Field<DateTimeOffset?>("Cancelled_Time");
		public static readonly Field<string> CANCELLATION_NOTE=new Field<string>("Cancellation_Note");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<int?> RESCHEDULE_COUNT=new Field<int?>("Reschedule_Count");
		public static readonly Field<MinifiedUser> RESCHEDULED_BY=new Field<MinifiedUser>("Rescheduled_By");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<DateTimeOffset?> RESCHEDULED_TIME=new Field<DateTimeOffset?>("Rescheduled_Time");
		public static readonly Field<List<Reminder>> REMIND_AT=new Field<List<Reminder>>("Remind_At");
		public static readonly Field<DateTimeOffset?> APPOINTMENT_END_TIME=new Field<DateTimeOffset?>("Appointment_End_Time");
		public static readonly Field<Choice<string>> STATUS=new Field<Choice<string>>("Status");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<Record> SERVICE_NAME=new Field<Record>("Service_Name");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<DateTimeOffset?> RESCHEDULED_FROM=new Field<DateTimeOffset?>("Rescheduled_From");
		public static readonly Field<MinifiedUser> CANCELLED_BY=new Field<MinifiedUser>("Cancelled_By");
		public static readonly Field<int?> DURATION=new Field<int?>("Duration");
		public static readonly Field<string> APPOINTMENT_NAME=new Field<string>("Appointment_Name");
		public static readonly Field<Choice<string>> JOB_SHEET_SECTION__S=new Field<Choice<string>>("Job_Sheet_Section__s");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<string> JOB_SHEET_DESCRIPTION__S=new Field<string>("Job_Sheet_Description__s");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<Choice<string>> LOCATION=new Field<Choice<string>>("Location");
		public static readonly Field<string> RESCHEDULE_NOTE=new Field<string>("Reschedule_Note");
	}


	public static class Calls
	{
		public static readonly Field<string> CALL_DURATION=new Field<string>("Call_Duration");
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<string> CALLER_ID=new Field<string>("Caller_ID");
		public static readonly Field<bool?> CTI_ENTRY=new Field<bool?>("CTI_Entry");
		public static readonly Field<string> CALL_AGENDA=new Field<string>("Call_Agenda");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<Choice<string>> CALL_PURPOSE=new Field<Choice<string>>("Call_Purpose");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<Record> WHO_ID=new Field<Record>("Who_Id");
		public static readonly Field<Choice<string>> OUTGOING_CALL_STATUS=new Field<Choice<string>>("Outgoing_Call_Status");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<Choice<string>> REMINDER=new Field<Choice<string>>("Reminder");
		public static readonly Field<string> VOICE_RECORDING__S=new Field<string>("Voice_Recording__s");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<DateTimeOffset?> CALL_START_TIME=new Field<DateTimeOffset?>("Call_Start_Time");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<string> SUBJECT=new Field<string>("Subject");
		public static readonly Field<Choice<string>> CALL_TYPE=new Field<Choice<string>>("Call_Type");
		public static readonly Field<Choice<string>> SCHEDULED_IN_CRM=new Field<Choice<string>>("Scheduled_In_CRM");
		public static readonly Field<string> CALL_RESULT=new Field<string>("Call_Result");
		public static readonly Field<Record> WHAT_ID=new Field<Record>("What_Id");
		public static readonly Field<int?> CALL_DURATION_IN_SECONDS=new Field<int?>("Call_Duration_in_seconds");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<string> DIALLED_NUMBER=new Field<string>("Dialled_Number");
	}


	public static class Leads
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> COMPANY=new Field<string>("Company");
		public static readonly Field<string> EMAIL=new Field<string>("Email");
		public static readonly Field<long?> VISITOR_SCORE=new Field<long?>("Visitor_Score");
		public static readonly Field<DateTimeOffset?> LAST_ACTIVITY_TIME=new Field<DateTimeOffset?>("Last_Activity_Time");
		public static readonly Field<Choice<string>> INDUSTRY=new Field<Choice<string>>("Industry");
		public static readonly Field<Choice<string>> UNSUBSCRIBED_MODE=new Field<Choice<string>>("Unsubscribed_Mode");
		public static readonly Field<double?> EXCHANGE_RATE=new Field<double?>("Exchange_Rate");
		public static readonly Field<Choice<string>> CURRENCY=new Field<Choice<string>>("Currency");
		public static readonly Field<string> STREET=new Field<string>("Street");
		public static readonly Field<Consent> DATA_PROCESSING_BASIS_DETAILS=new Field<Consent>("Data_Processing_Basis_Details");
		public static readonly Field<string> ZIP_CODE=new Field<string>("Zip_Code");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<Choice<string>> DATA_SOURCE=new Field<Choice<string>>("Data_Source");
		public static readonly Field<Choice<string>> ENRICH_STATUS__S=new Field<Choice<string>>("Enrich_Status__s");
		public static readonly Field<string> FIRST_VISITED_URL=new Field<string>("First_Visited_URL");
		public static readonly Field<int?> DAYS_VISITED=new Field<int?>("Days_Visited");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<DateTimeOffset?> CHANGE_LOG_TIME__S=new Field<DateTimeOffset?>("Change_Log_Time__s");
		public static readonly Field<string> CITY=new Field<string>("City");
		public static readonly Field<int?> NO_OF_EMPLOYEES=new Field<int?>("No_of_Employees");
		public static readonly Field<Choice<string>> DATA_PROCESSING_BASIS=new Field<Choice<string>>("Data_Processing_Basis");
		public static readonly Field<bool?> CONVERTED__S=new Field<bool?>("Converted__s");
		public static readonly Field<DateTimeOffset?> CONVERTED_DATE_TIME=new Field<DateTimeOffset?>("Converted_Date_Time");
		public static readonly Field<Record> CONVERTED_ACCOUNT=new Field<Record>("Converted_Account");
		public static readonly Field<string> STATE=new Field<string>("State");
		public static readonly Field<string> COUNTRY=new Field<string>("Country");
		public static readonly Field<DateTimeOffset?> LAST_VISITED_TIME=new Field<DateTimeOffset?>("Last_Visited_Time");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<double?> ANNUAL_REVENUE=new Field<double?>("Annual_Revenue");
		public static readonly Field<string> SECONDARY_EMAIL=new Field<string>("Secondary_Email");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<int?> NUMBER_OF_CHATS=new Field<int?>("Number_Of_Chats");
		public static readonly Field<Choice<string>> RATING=new Field<Choice<string>>("Rating");
		public static readonly Field<string> WEBSITE=new Field<string>("Website");
		public static readonly Field<string> TWITTER=new Field<string>("Twitter");
		public static readonly Field<double?> AVERAGE_TIME_SPENT_MINUTES=new Field<double?>("Average_Time_Spent_Minutes");
		public static readonly Field<Choice<string>> SALUTATION=new Field<Choice<string>>("Salutation");
		public static readonly Field<string> FIRST_NAME=new Field<string>("First_Name");
		public static readonly Field<string> FULL_NAME=new Field<string>("Full_Name");
		public static readonly Field<Choice<string>> LEAD_STATUS=new Field<Choice<string>>("Lead_Status");
		public static readonly Field<string> RECORD_IMAGE=new Field<string>("Record_Image");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<Record> CONVERTED_DEAL=new Field<Record>("Converted_Deal");
		public static readonly Field<int?> LEAD_CONVERSION_TIME=new Field<int?>("Lead_Conversion_Time");
		public static readonly Field<string> SKYPE_ID=new Field<string>("Skype_ID");
		public static readonly Field<string> PHONE=new Field<string>("Phone");
		public static readonly Field<bool?> EMAIL_OPT_OUT=new Field<bool?>("Email_Opt_Out");
		public static readonly Field<string> DESIGNATION=new Field<string>("Designation");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<DateTimeOffset?> UNSUBSCRIBED_TIME=new Field<DateTimeOffset?>("Unsubscribed_Time");
		public static readonly Field<Record> CONVERTED_CONTACT=new Field<Record>("Converted_Contact");
		public static readonly Field<string> MOBILE=new Field<string>("Mobile");
		public static readonly Field<List<Territory>> TERRITORIES=new Field<List<Territory>>("Territories");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<DateTimeOffset?> FIRST_VISITED_TIME=new Field<DateTimeOffset?>("First_Visited_Time");
		public static readonly Field<string> LAST_NAME=new Field<string>("Last_Name");
		public static readonly Field<Layouts.Layouts> LAYOUT=new Field<Layouts.Layouts>("Layout");
		public static readonly Field<string> REFERRER=new Field<string>("Referrer");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<Choice<string>> LEAD_SOURCE=new Field<Choice<string>>("Lead_Source");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<string> FAX=new Field<string>("Fax");
		public static readonly Field<DateTimeOffset?> LAST_ENRICHED_TIME__S=new Field<DateTimeOffset?>("Last_Enriched_Time__s");
	}


	public static class Deals
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<Record> CAMPAIGN_SOURCE=new Field<Record>("Campaign_Source");
		public static readonly Field<DateTime?> CLOSING_DATE=new Field<DateTime?>("Closing_Date");
		public static readonly Field<Choice<string>> REASON_FOR_LOSS__S=new Field<Choice<string>>("Reason_For_Loss__s");
		public static readonly Field<DateTimeOffset?> LAST_ACTIVITY_TIME=new Field<DateTimeOffset?>("Last_Activity_Time");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<int?> LEAD_CONVERSION_TIME=new Field<int?>("Lead_Conversion_Time");
		public static readonly Field<string> DEAL_NAME=new Field<string>("Deal_Name");
		public static readonly Field<double?> EXCHANGE_RATE=new Field<double?>("Exchange_Rate");
		public static readonly Field<double?> EXPECTED_REVENUE=new Field<double?>("Expected_Revenue");
		public static readonly Field<Choice<string>> CURRENCY=new Field<Choice<string>>("Currency");
		public static readonly Field<int?> OVERALL_SALES_DURATION=new Field<int?>("Overall_Sales_Duration");
		public static readonly Field<Choice<string>> STAGE=new Field<Choice<string>>("Stage");
		public static readonly Field<Record> ACCOUNT_NAME=new Field<Record>("Account_Name");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<List<Territory>> TERRITORY=new Field<List<Territory>>("Territory");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<double?> AMOUNT=new Field<double?>("Amount");
		public static readonly Field<int?> PROBABILITY=new Field<int?>("Probability");
		public static readonly Field<string> NEXT_STEP=new Field<string>("Next_Step");
		public static readonly Field<DateTimeOffset?> CHANGE_LOG_TIME__S=new Field<DateTimeOffset?>("Change_Log_Time__s");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<Choice<string>> PIPELINE=new Field<Choice<string>>("Pipeline");
		public static readonly Field<Record> CONTACT_NAME=new Field<Record>("Contact_Name");
		public static readonly Field<int?> SALES_CYCLE_DURATION=new Field<int?>("Sales_Cycle_Duration");
		public static readonly Field<Choice<string>> TYPE=new Field<Choice<string>>("Type");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<Choice<string>> LEAD_SOURCE=new Field<Choice<string>>("Lead_Source");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
	}


	public static class Quotes
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<double?> DISCOUNT=new Field<double?>("Discount");
		public static readonly Field<string> SHIPPING_STATE=new Field<string>("Shipping_State");
		public static readonly Field<double?> TAX=new Field<double?>("Tax");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<Record> DEAL_NAME=new Field<Record>("Deal_Name");
		public static readonly Field<double?> EXCHANGE_RATE=new Field<double?>("Exchange_Rate");
		public static readonly Field<DateTime?> VALID_TILL=new Field<DateTime?>("Valid_Till");
		public static readonly Field<Choice<string>> CURRENCY=new Field<Choice<string>>("Currency");
		public static readonly Field<string> BILLING_COUNTRY=new Field<string>("Billing_Country");
		public static readonly Field<string> TEAM=new Field<string>("Team");
		public static readonly Field<Record> ACCOUNT_NAME=new Field<Record>("Account_Name");
		public static readonly Field<Choice<string>> CARRIER=new Field<Choice<string>>("Carrier");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<List<Record>> QUOTED_ITEMS=new Field<List<Record>>("Quoted_Items");
		public static readonly Field<Choice<string>> QUOTE_STAGE=new Field<Choice<string>>("Quote_Stage");
		public static readonly Field<double?> GRAND_TOTAL=new Field<double?>("Grand_Total");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<string> BILLING_STREET=new Field<string>("Billing_Street");
		public static readonly Field<double?> ADJUSTMENT=new Field<double?>("Adjustment");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<string> TERMS_AND_CONDITIONS=new Field<string>("Terms_and_Conditions");
		public static readonly Field<double?> SUB_TOTAL=new Field<double?>("Sub_Total");
		public static readonly Field<string> BILLING_CODE=new Field<string>("Billing_Code");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<string> SUBJECT=new Field<string>("Subject");
		public static readonly Field<Record> CONTACT_NAME=new Field<Record>("Contact_Name");
		public static readonly Field<string> SHIPPING_CITY=new Field<string>("Shipping_City");
		public static readonly Field<string> SHIPPING_COUNTRY=new Field<string>("Shipping_Country");
		public static readonly Field<string> SHIPPING_CODE=new Field<string>("Shipping_Code");
		public static readonly Field<string> BILLING_CITY=new Field<string>("Billing_City");
		public static readonly Field<string> QUOTE_NUMBER=new Field<string>("Quote_Number");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<string> BILLING_STATE=new Field<string>("Billing_State");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<string> SHIPPING_STREET=new Field<string>("Shipping_Street");
	}


	public static class Invoices
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<double?> DISCOUNT=new Field<double?>("Discount");
		public static readonly Field<string> SHIPPING_STATE=new Field<string>("Shipping_State");
		public static readonly Field<double?> TAX=new Field<double?>("Tax");
		public static readonly Field<DateTime?> INVOICE_DATE=new Field<DateTime?>("Invoice_Date");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<List<Record>> INVOICED_ITEMS=new Field<List<Record>>("Invoiced_Items");
		public static readonly Field<double?> EXCHANGE_RATE=new Field<double?>("Exchange_Rate");
		public static readonly Field<Choice<string>> CURRENCY=new Field<Choice<string>>("Currency");
		public static readonly Field<string> BILLING_COUNTRY=new Field<string>("Billing_Country");
		public static readonly Field<Record> ACCOUNT_NAME=new Field<Record>("Account_Name");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<Record> SALES_ORDER=new Field<Record>("Sales_Order");
		public static readonly Field<Choice<string>> STATUS=new Field<Choice<string>>("Status");
		public static readonly Field<double?> SALES_COMMISSION=new Field<double?>("Sales_Commission");
		public static readonly Field<double?> GRAND_TOTAL=new Field<double?>("Grand_Total");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<DateTime?> DUE_DATE=new Field<DateTime?>("Due_Date");
		public static readonly Field<string> BILLING_STREET=new Field<string>("Billing_Street");
		public static readonly Field<double?> ADJUSTMENT=new Field<double?>("Adjustment");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<string> TERMS_AND_CONDITIONS=new Field<string>("Terms_and_Conditions");
		public static readonly Field<double?> SUB_TOTAL=new Field<double?>("Sub_Total");
		public static readonly Field<string> INVOICE_NUMBER=new Field<string>("Invoice_Number");
		public static readonly Field<string> BILLING_CODE=new Field<string>("Billing_Code");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<string> SUBJECT=new Field<string>("Subject");
		public static readonly Field<double?> EXCISE_DUTY=new Field<double?>("Excise_Duty");
		public static readonly Field<Record> CONTACT_NAME=new Field<Record>("Contact_Name");
		public static readonly Field<string> SHIPPING_CITY=new Field<string>("Shipping_City");
		public static readonly Field<string> SHIPPING_COUNTRY=new Field<string>("Shipping_Country");
		public static readonly Field<string> SHIPPING_CODE=new Field<string>("Shipping_Code");
		public static readonly Field<string> BILLING_CITY=new Field<string>("Billing_City");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<string> PURCHASE_ORDER=new Field<string>("Purchase_Order");
		public static readonly Field<string> BILLING_STATE=new Field<string>("Billing_State");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<string> SHIPPING_STREET=new Field<string>("Shipping_Street");
	}


	public static class Campaigns
	{
		public static readonly Field<Choice<string>> STATUS=new Field<Choice<string>>("Status");
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<string> CAMPAIGN_NAME=new Field<string>("Campaign_Name");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<DateTime?> END_DATE=new Field<DateTime?>("End_Date");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<Choice<string>> TYPE=new Field<Choice<string>>("Type");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<long?> NUM_SENT=new Field<long?>("Num_sent");
		public static readonly Field<double?> EXCHANGE_RATE=new Field<double?>("Exchange_Rate");
		public static readonly Field<double?> EXPECTED_REVENUE=new Field<double?>("Expected_Revenue");
		public static readonly Field<Choice<string>> CURRENCY=new Field<Choice<string>>("Currency");
		public static readonly Field<double?> ACTUAL_COST=new Field<double?>("Actual_Cost");
		public static readonly Field<long?> EXPECTED_RESPONSE=new Field<long?>("Expected_Response");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<Record> PARENT_CAMPAIGN=new Field<Record>("Parent_Campaign");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<DateTime?> START_DATE=new Field<DateTime?>("Start_Date");
		public static readonly Field<double?> BUDGETED_COST=new Field<double?>("Budgeted_Cost");
	}


	public static class Attachments
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<string> FILE_NAME=new Field<string>("File_Name");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<long?> SIZE=new Field<long?>("Size");
		public static readonly Field<Record> PARENT_ID=new Field<Record>("Parent_Id");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
	}


	public static class Price_Books
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<List<PricingDetails>> PRICING_DETAILS=new Field<List<PricingDetails>>("Pricing_Details");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<bool?> ACTIVE=new Field<bool?>("Active");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<Choice<string>> PRICING_MODEL=new Field<Choice<string>>("Pricing_Model");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<string> PRICE_BOOK_NAME=new Field<string>("Price_Book_Name");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<long?> ID=new Field<long?>("id");
	}


	public static class Sales_Orders
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<double?> DISCOUNT=new Field<double?>("Discount");
		public static readonly Field<string> CUSTOMER_NO=new Field<string>("Customer_No");
		public static readonly Field<string> SHIPPING_STATE=new Field<string>("Shipping_State");
		public static readonly Field<double?> TAX=new Field<double?>("Tax");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<Record> DEAL_NAME=new Field<Record>("Deal_Name");
		public static readonly Field<double?> EXCHANGE_RATE=new Field<double?>("Exchange_Rate");
		public static readonly Field<Choice<string>> CURRENCY=new Field<Choice<string>>("Currency");
		public static readonly Field<string> BILLING_COUNTRY=new Field<string>("Billing_Country");
		public static readonly Field<Record> ACCOUNT_NAME=new Field<Record>("Account_Name");
		public static readonly Field<Choice<string>> CARRIER=new Field<Choice<string>>("Carrier");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<List<Record>> ORDERED_ITEMS=new Field<List<Record>>("Ordered_Items");
		public static readonly Field<Record> QUOTE_NAME=new Field<Record>("Quote_Name");
		public static readonly Field<Choice<string>> STATUS=new Field<Choice<string>>("Status");
		public static readonly Field<double?> SALES_COMMISSION=new Field<double?>("Sales_Commission");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<DateTime?> DUE_DATE=new Field<DateTime?>("Due_Date");
		public static readonly Field<string> BILLING_STREET=new Field<string>("Billing_Street");
		public static readonly Field<double?> ADJUSTMENT=new Field<double?>("Adjustment");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<string> TERMS_AND_CONDITIONS=new Field<string>("Terms_and_Conditions");
		public static readonly Field<double?> SUB_TOTAL=new Field<double?>("Sub_Total");
		public static readonly Field<string> BILLING_CODE=new Field<string>("Billing_Code");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<string> SUBJECT=new Field<string>("Subject");
		public static readonly Field<Record> CONTACT_NAME=new Field<Record>("Contact_Name");
		public static readonly Field<double?> EXCISE_DUTY=new Field<double?>("Excise_Duty");
		public static readonly Field<string> SHIPPING_CITY=new Field<string>("Shipping_City");
		public static readonly Field<string> SHIPPING_COUNTRY=new Field<string>("Shipping_Country");
		public static readonly Field<string> SHIPPING_CODE=new Field<string>("Shipping_Code");
		public static readonly Field<string> BILLING_CITY=new Field<string>("Billing_City");
		public static readonly Field<string> SO_NUMBER=new Field<string>("SO_Number");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<string> PURCHASE_ORDER=new Field<string>("Purchase_Order");
		public static readonly Field<string> BILLING_STATE=new Field<string>("Billing_State");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<string> PENDING=new Field<string>("Pending");
		public static readonly Field<string> SHIPPING_STREET=new Field<string>("Shipping_Street");
	}


	public static class Services__s
	{
		public static readonly Field<Choice<string>> JOB_SHEET_REQUIRED=new Field<Choice<string>>("Job_Sheet_Required");
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<List<Choice<string>>> AVAILABLE_DAYS=new Field<List<Choice<string>>>("Available_Days");
		public static readonly Field<List<Choice<string>>> TAX=new Field<List<Choice<string>>>("Tax");
		public static readonly Field<DateTimeOffset?> UNAVAILABLE_FROM=new Field<DateTimeOffset?>("Unavailable_From");
		public static readonly Field<string> RECORD_IMAGE=new Field<string>("Record_Image");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<DateTime?> AVAILABLE_DATES=new Field<DateTime?>("Available_Dates");
		public static readonly Field<Choice<string>> STATUS=new Field<Choice<string>>("Status");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<List<TimeRange>> AVAILABLE_TIMINGS=new Field<List<TimeRange>>("Available_Timings");
		public static readonly Field<string> SERVICE_NAME=new Field<string>("Service_Name");
		public static readonly Field<DateTime?> AVAILABLE_FROM=new Field<DateTime?>("Available_From");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<DateTime?> AVAILABLE_TILL=new Field<DateTime?>("Available_Till");
		public static readonly Field<int?> DURATION=new Field<int?>("Duration");
		public static readonly Field<Choice<string>> JOB_SHEET_SECTION__S=new Field<Choice<string>>("Job_Sheet_Section__s");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<double?> PRICE=new Field<double?>("Price");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<Choice<string>> AVAILABILITY_TYPE=new Field<Choice<string>>("Availability_Type");
		public static readonly Field<List<Record>> MEMBERS=new Field<List<Record>>("Members");
		public static readonly Field<Choice<string>> LOCATION=new Field<Choice<string>>("Location");
		public static readonly Field<DateTimeOffset?> UNAVAILABLE_TILL=new Field<DateTimeOffset?>("Unavailable_Till");
	}


	public static class Contacts
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> EMAIL=new Field<string>("Email");
		public static readonly Field<long?> VISITOR_SCORE=new Field<long?>("Visitor_Score");
		public static readonly Field<string> OTHER_PHONE=new Field<string>("Other_Phone");
		public static readonly Field<string> MAILING_STATE=new Field<string>("Mailing_State");
		public static readonly Field<string> OTHER_STATE=new Field<string>("Other_State");
		public static readonly Field<string> OTHER_COUNTRY=new Field<string>("Other_Country");
		public static readonly Field<DateTimeOffset?> LAST_ACTIVITY_TIME=new Field<DateTimeOffset?>("Last_Activity_Time");
		public static readonly Field<string> DEPARTMENT=new Field<string>("Department");
		public static readonly Field<Choice<string>> UNSUBSCRIBED_MODE=new Field<Choice<string>>("Unsubscribed_Mode");
		public static readonly Field<string> ASSISTANT=new Field<string>("Assistant");
		public static readonly Field<string> MAILING_COUNTRY=new Field<string>("Mailing_Country");
		public static readonly Field<Consent> DATA_PROCESSING_BASIS_DETAILS=new Field<Consent>("Data_Processing_Basis_Details");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<Choice<string>> DATA_SOURCE=new Field<Choice<string>>("Data_Source");
		public static readonly Field<Record> REPORTING_TO=new Field<Record>("Reporting_To");
		public static readonly Field<Choice<string>> ENRICH_STATUS__S=new Field<Choice<string>>("Enrich_Status__s");
		public static readonly Field<string> FIRST_VISITED_URL=new Field<string>("First_Visited_URL");
		public static readonly Field<int?> DAYS_VISITED=new Field<int?>("Days_Visited");
		public static readonly Field<string> OTHER_CITY=new Field<string>("Other_City");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<DateTimeOffset?> CHANGE_LOG_TIME__S=new Field<DateTimeOffset?>("Change_Log_Time__s");
		public static readonly Field<Choice<string>> DATA_PROCESSING_BASIS=new Field<Choice<string>>("Data_Processing_Basis");
		public static readonly Field<string> HOME_PHONE=new Field<string>("Home_Phone");
		public static readonly Field<DateTimeOffset?> LAST_VISITED_TIME=new Field<DateTimeOffset?>("Last_Visited_Time");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> SECONDARY_EMAIL=new Field<string>("Secondary_Email");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<Record> VENDOR_NAME=new Field<Record>("Vendor_Name");
		public static readonly Field<string> MAILING_ZIP=new Field<string>("Mailing_Zip");
		public static readonly Field<string> REPORTS_TO=new Field<string>("Reports_To");
		public static readonly Field<int?> NUMBER_OF_CHATS=new Field<int?>("Number_Of_Chats");
		public static readonly Field<string> TWITTER=new Field<string>("Twitter");
		public static readonly Field<string> OTHER_ZIP=new Field<string>("Other_Zip");
		public static readonly Field<string> MAILING_STREET=new Field<string>("Mailing_Street");
		public static readonly Field<double?> AVERAGE_TIME_SPENT_MINUTES=new Field<double?>("Average_Time_Spent_Minutes");
		public static readonly Field<Choice<string>> SALUTATION=new Field<Choice<string>>("Salutation");
		public static readonly Field<string> FIRST_NAME=new Field<string>("First_Name");
		public static readonly Field<string> FULL_NAME=new Field<string>("Full_Name");
		public static readonly Field<string> ASST_PHONE=new Field<string>("Asst_Phone");
		public static readonly Field<string> RECORD_IMAGE=new Field<string>("Record_Image");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<string> SKYPE_ID=new Field<string>("Skype_ID");
		public static readonly Field<string> PHONE=new Field<string>("Phone");
		public static readonly Field<Record> ACCOUNT_NAME=new Field<Record>("Account_Name");
		public static readonly Field<bool?> EMAIL_OPT_OUT=new Field<bool?>("Email_Opt_Out");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<DateTime?> DATE_OF_BIRTH=new Field<DateTime?>("Date_of_Birth");
		public static readonly Field<string> MAILING_CITY=new Field<string>("Mailing_City");
		public static readonly Field<DateTimeOffset?> UNSUBSCRIBED_TIME=new Field<DateTimeOffset?>("Unsubscribed_Time");
		public static readonly Field<string> TITLE=new Field<string>("Title");
		public static readonly Field<string> OTHER_STREET=new Field<string>("Other_Street");
		public static readonly Field<string> MOBILE=new Field<string>("Mobile");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<List<Territory>> TERRITORIES=new Field<List<Territory>>("Territories");
		public static readonly Field<DateTimeOffset?> FIRST_VISITED_TIME=new Field<DateTimeOffset?>("First_Visited_Time");
		public static readonly Field<string> LAST_NAME=new Field<string>("Last_Name");
		public static readonly Field<string> REFERRER=new Field<string>("Referrer");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<Choice<string>> LEAD_SOURCE=new Field<Choice<string>>("Lead_Source");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<string> FAX=new Field<string>("Fax");
		public static readonly Field<DateTimeOffset?> LAST_ENRICHED_TIME__S=new Field<DateTimeOffset?>("Last_Enriched_Time__s");
	}


	public static class Solutions
	{
		public static readonly Field<Choice<string>> STATUS=new Field<Choice<string>>("Status");
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<List<Comment>> COMMENTS=new Field<List<Comment>>("Comments");
		public static readonly Field<int?> NO_OF_COMMENTS=new Field<int?>("No_of_comments");
		public static readonly Field<Record> PRODUCT_NAME=new Field<Record>("Product_Name");
		public static readonly Field<string> ADD_COMMENT=new Field<string>("Add_Comment");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<string> SOLUTION_NUMBER=new Field<string>("Solution_Number");
		public static readonly Field<string> ANSWER=new Field<string>("Answer");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<string> SOLUTION_TITLE=new Field<string>("Solution_Title");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<bool?> PUBLISHED=new Field<bool?>("Published");
		public static readonly Field<string> QUESTION=new Field<string>("Question");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<long?> ID=new Field<long?>("id");
	}


	public static class Events
	{
		public static readonly Field<bool?> ALL_DAY=new Field<bool?>("All_day");
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> CHECK_IN_STATE=new Field<string>("Check_In_State");
		public static readonly Field<string> CHECK_IN_ADDRESS=new Field<string>("Check_In_Address");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<List<Reminder>> REMIND_PARTICIPANTS=new Field<List<Reminder>>("Remind_Participants");
		public static readonly Field<DateTimeOffset?> START_DATETIME=new Field<DateTimeOffset?>("Start_DateTime");
		public static readonly Field<double?> LATITUDE=new Field<double?>("Latitude");
		public static readonly Field<List<Participants>> PARTICIPANTS=new Field<List<Participants>>("Participants");
		public static readonly Field<string> EVENT_TITLE=new Field<string>("Event_Title");
		public static readonly Field<DateTimeOffset?> END_DATETIME=new Field<DateTimeOffset?>("End_DateTime");
		public static readonly Field<MinifiedUser> CHECK_IN_BY=new Field<MinifiedUser>("Check_In_By");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<string> CHECK_IN_CITY=new Field<string>("Check_In_City");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<string> CHECK_IN_COMMENT=new Field<string>("Check_In_Comment");
		public static readonly Field<List<Reminder>> REMIND_AT=new Field<List<Reminder>>("Remind_At");
		public static readonly Field<Record> WHO_ID=new Field<Record>("Who_Id");
		public static readonly Field<string> CHECK_IN_STATUS=new Field<string>("Check_In_Status");
		public static readonly Field<string> CHECK_IN_COUNTRY=new Field<string>("Check_In_Country");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<string> VENUE=new Field<string>("Venue");
		public static readonly Field<string> ZIP_CODE=new Field<string>("ZIP_Code");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<double?> LONGITUDE=new Field<double?>("Longitude");
		public static readonly Field<DateTimeOffset?> CHECK_IN_TIME=new Field<DateTimeOffset?>("Check_In_Time");
		public static readonly Field<RecurringActivity> RECURRING_ACTIVITY=new Field<RecurringActivity>("Recurring_Activity");
		public static readonly Field<Record> WHAT_ID=new Field<Record>("What_Id");
		public static readonly Field<string> CHECK_IN_SUB_LOCALITY=new Field<string>("Check_In_Sub_Locality");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
	}


	public static class Purchase_Orders
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<double?> DISCOUNT=new Field<double?>("Discount");
		public static readonly Field<Record> VENDOR_NAME=new Field<Record>("Vendor_Name");
		public static readonly Field<string> SHIPPING_STATE=new Field<string>("Shipping_State");
		public static readonly Field<double?> TAX=new Field<double?>("Tax");
		public static readonly Field<DateTime?> PO_DATE=new Field<DateTime?>("PO_Date");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<double?> EXCHANGE_RATE=new Field<double?>("Exchange_Rate");
		public static readonly Field<Choice<string>> CURRENCY=new Field<Choice<string>>("Currency");
		public static readonly Field<string> BILLING_COUNTRY=new Field<string>("Billing_Country");
		public static readonly Field<List<Record>> PURCHASE_ITEMS=new Field<List<Record>>("Purchase_Items");
		public static readonly Field<Choice<string>> CARRIER=new Field<Choice<string>>("Carrier");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<Choice<string>> STATUS=new Field<Choice<string>>("Status");
		public static readonly Field<double?> SALES_COMMISSION=new Field<double?>("Sales_Commission");
		public static readonly Field<double?> GRAND_TOTAL=new Field<double?>("Grand_Total");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<string> PO_NUMBER=new Field<string>("PO_Number");
		public static readonly Field<DateTime?> DUE_DATE=new Field<DateTime?>("Due_Date");
		public static readonly Field<string> BILLING_STREET=new Field<string>("Billing_Street");
		public static readonly Field<double?> ADJUSTMENT=new Field<double?>("Adjustment");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<string> TERMS_AND_CONDITIONS=new Field<string>("Terms_and_Conditions");
		public static readonly Field<double?> SUB_TOTAL=new Field<double?>("Sub_Total");
		public static readonly Field<string> BILLING_CODE=new Field<string>("Billing_Code");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<string> SUBJECT=new Field<string>("Subject");
		public static readonly Field<string> TRACKING_NUMBER=new Field<string>("Tracking_Number");
		public static readonly Field<Record> CONTACT_NAME=new Field<Record>("Contact_Name");
		public static readonly Field<double?> EXCISE_DUTY=new Field<double?>("Excise_Duty");
		public static readonly Field<string> SHIPPING_CITY=new Field<string>("Shipping_City");
		public static readonly Field<string> SHIPPING_COUNTRY=new Field<string>("Shipping_Country");
		public static readonly Field<string> SHIPPING_CODE=new Field<string>("Shipping_Code");
		public static readonly Field<string> BILLING_CITY=new Field<string>("Billing_City");
		public static readonly Field<string> REQUISITION_NO=new Field<string>("Requisition_No");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<string> BILLING_STATE=new Field<string>("Billing_State");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<string> SHIPPING_STREET=new Field<string>("Shipping_Street");
	}


	public static class Accounts
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<Choice<string>> OWNERSHIP=new Field<Choice<string>>("Ownership");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<Choice<string>> ACCOUNT_TYPE=new Field<Choice<string>>("Account_Type");
		public static readonly Field<Choice<string>> RATING=new Field<Choice<string>>("Rating");
		public static readonly Field<int?> SIC_CODE=new Field<int?>("SIC_Code");
		public static readonly Field<string> SHIPPING_STATE=new Field<string>("Shipping_State");
		public static readonly Field<string> WEBSITE=new Field<string>("Website");
		public static readonly Field<int?> EMPLOYEES=new Field<int?>("Employees");
		public static readonly Field<DateTimeOffset?> LAST_ACTIVITY_TIME=new Field<DateTimeOffset?>("Last_Activity_Time");
		public static readonly Field<Choice<string>> INDUSTRY=new Field<Choice<string>>("Industry");
		public static readonly Field<string> RECORD_IMAGE=new Field<string>("Record_Image");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<string> ACCOUNT_SITE=new Field<string>("Account_Site");
		public static readonly Field<double?> EXCHANGE_RATE=new Field<double?>("Exchange_Rate");
		public static readonly Field<string> PHONE=new Field<string>("Phone");
		public static readonly Field<Choice<string>> CURRENCY=new Field<Choice<string>>("Currency");
		public static readonly Field<string> BILLING_COUNTRY=new Field<string>("Billing_Country");
		public static readonly Field<string> ACCOUNT_NAME=new Field<string>("Account_Name");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<long?> ACCOUNT_NUMBER=new Field<long?>("Account_Number");
		public static readonly Field<string> TICKER_SYMBOL=new Field<string>("Ticker_Symbol");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<Choice<string>> ENRICH_STATUS__S=new Field<Choice<string>>("Enrich_Status__s");
		public static readonly Field<string> BILLING_STREET=new Field<string>("Billing_Street");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<DateTimeOffset?> CHANGE_LOG_TIME__S=new Field<DateTimeOffset?>("Change_Log_Time__s");
		public static readonly Field<string> BILLING_CODE=new Field<string>("Billing_Code");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<List<Territory>> TERRITORIES=new Field<List<Territory>>("Territories");
		public static readonly Field<Record> PARENT_ACCOUNT=new Field<Record>("Parent_Account");
		public static readonly Field<string> SHIPPING_CITY=new Field<string>("Shipping_City");
		public static readonly Field<string> SHIPPING_COUNTRY=new Field<string>("Shipping_Country");
		public static readonly Field<string> SHIPPING_CODE=new Field<string>("Shipping_Code");
		public static readonly Field<string> BILLING_CITY=new Field<string>("Billing_City");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<string> BILLING_STATE=new Field<string>("Billing_State");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<string> FAX=new Field<string>("Fax");
		public static readonly Field<double?> ANNUAL_REVENUE=new Field<double?>("Annual_Revenue");
		public static readonly Field<DateTimeOffset?> LAST_ENRICHED_TIME__S=new Field<DateTimeOffset?>("Last_Enriched_Time__s");
		public static readonly Field<string> SHIPPING_STREET=new Field<string>("Shipping_Street");
	}


	public static class Cases
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<string> EMAIL=new Field<string>("Email");
		public static readonly Field<string> DESCRIPTION=new Field<string>("Description");
		public static readonly Field<string> INTERNAL_COMMENTS=new Field<string>("Internal_Comments");
		public static readonly Field<int?> NO_OF_COMMENTS=new Field<int?>("No_of_comments");
		public static readonly Field<string> REPORTED_BY=new Field<string>("Reported_By");
		public static readonly Field<string> CASE_NUMBER=new Field<string>("Case_Number");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<Record> DEAL_NAME=new Field<Record>("Deal_Name");
		public static readonly Field<string> PHONE=new Field<string>("Phone");
		public static readonly Field<Record> ACCOUNT_NAME=new Field<Record>("Account_Name");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<string> SOLUTION=new Field<string>("Solution");
		public static readonly Field<Choice<string>> STATUS=new Field<Choice<string>>("Status");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<Choice<string>> PRIORITY=new Field<Choice<string>>("Priority");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<List<Comment>> COMMENTS=new Field<List<Comment>>("Comments");
		public static readonly Field<Record> PRODUCT_NAME=new Field<Record>("Product_Name");
		public static readonly Field<string> ADD_COMMENT=new Field<string>("Add_Comment");
		public static readonly Field<Choice<string>> CASE_ORIGIN=new Field<Choice<string>>("Case_Origin");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
		public static readonly Field<Choice<string>> CASE_REASON=new Field<Choice<string>>("Case_Reason");
		public static readonly Field<string> SUBJECT=new Field<string>("Subject");
		public static readonly Field<Choice<string>> TYPE=new Field<Choice<string>>("Type");
		public static readonly Field<bool?> LOCKED__S=new Field<bool?>("Locked__s");
		public static readonly Field<string> TAG=new Field<string>("Tag");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<Record> RELATED_TO=new Field<Record>("Related_To");
	}


	public static class Notes
	{
		public static readonly Field<MinifiedUser> OWNER=new Field<MinifiedUser>("Owner");
		public static readonly Field<MinifiedUser> MODIFIED_BY=new Field<MinifiedUser>("Modified_By");
		public static readonly Field<DateTimeOffset?> MODIFIED_TIME=new Field<DateTimeOffset?>("Modified_Time");
		public static readonly Field<DateTimeOffset?> CREATED_TIME=new Field<DateTimeOffset?>("Created_Time");
		public static readonly Field<Record> PARENT_ID=new Field<Record>("Parent_Id");
		public static readonly Field<long?> ASSOCIATED_ID__S=new Field<long?>("Associated_Id__s");
		public static readonly Field<MinifiedUser> CREATED_BY=new Field<MinifiedUser>("Created_By");
		public static readonly Field<long?> ID=new Field<long?>("id");
		public static readonly Field<string> NOTE_TITLE=new Field<string>("Note_Title");
		public static readonly Field<string> NOTE_CONTENT=new Field<string>("Note_Content");
		public static readonly Field<Choice<string>> RECORD_STATUS__S=new Field<Choice<string>>("Record_Status__s");
	}

}
