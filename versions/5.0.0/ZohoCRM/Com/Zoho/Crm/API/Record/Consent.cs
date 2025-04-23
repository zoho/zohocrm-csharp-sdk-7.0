using Com.Zoho.Crm.API.Tags;
using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Record
{

	public class Consent : Record , Model
	{

		public Users.MinifiedUser Owner
		{
			/// <summary>The method to get the owner</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				if((( this.GetKeyValue("Owner")) != (null)))
				{
					return (Users.MinifiedUser) this.GetKeyValue("Owner");

				}
					return null;


			}
			/// <summary>The method to set the value to owner</summary>
			/// <param name="owner">Instance of MinifiedUser</param>
			set
			{
				 this.AddKeyValue("Owner", value);

			}
		}

		public bool? ContactThroughEmail
		{
			/// <summary>The method to get the contactThroughEmail</summary>
			/// <returns>bool? representing the contactThroughEmail</returns>
			get
			{
				if((( this.GetKeyValue("Contact_Through_Email")) != (null)))
				{
					return (bool?) this.GetKeyValue("Contact_Through_Email");

				}
					return null;


			}
			/// <summary>The method to set the value to contactThroughEmail</summary>
			/// <param name="contactThroughEmail">bool?</param>
			set
			{
				 this.AddKeyValue("Contact_Through_Email", value);

			}
		}

		public bool? ContactThroughSocial
		{
			/// <summary>The method to get the contactThroughSocial</summary>
			/// <returns>bool? representing the contactThroughSocial</returns>
			get
			{
				if((( this.GetKeyValue("Contact_Through_Social")) != (null)))
				{
					return (bool?) this.GetKeyValue("Contact_Through_Social");

				}
					return null;


			}
			/// <summary>The method to set the value to contactThroughSocial</summary>
			/// <param name="contactThroughSocial">bool?</param>
			set
			{
				 this.AddKeyValue("Contact_Through_Social", value);

			}
		}

		public bool? ContactThroughSurvey
		{
			/// <summary>The method to get the contactThroughSurvey</summary>
			/// <returns>bool? representing the contactThroughSurvey</returns>
			get
			{
				if((( this.GetKeyValue("Contact_Through_Survey")) != (null)))
				{
					return (bool?) this.GetKeyValue("Contact_Through_Survey");

				}
					return null;


			}
			/// <summary>The method to set the value to contactThroughSurvey</summary>
			/// <param name="contactThroughSurvey">bool?</param>
			set
			{
				 this.AddKeyValue("Contact_Through_Survey", value);

			}
		}

		public bool? ContactThroughPhone
		{
			/// <summary>The method to get the contactThroughPhone</summary>
			/// <returns>bool? representing the contactThroughPhone</returns>
			get
			{
				if((( this.GetKeyValue("Contact_Through_Phone")) != (null)))
				{
					return (bool?) this.GetKeyValue("Contact_Through_Phone");

				}
					return null;


			}
			/// <summary>The method to set the value to contactThroughPhone</summary>
			/// <param name="contactThroughPhone">bool?</param>
			set
			{
				 this.AddKeyValue("Contact_Through_Phone", value);

			}
		}

		public DateTimeOffset? MailSentTime
		{
			/// <summary>The method to get the mailSentTime</summary>
			/// <returns>DateTimeOffset? representing the mailSentTime</returns>
			get
			{
				if((( this.GetKeyValue("Mail_Sent_Time")) != (null)))
				{
					return (DateTimeOffset?) this.GetKeyValue("Mail_Sent_Time");

				}
					return null;


			}
			/// <summary>The method to set the value to mailSentTime</summary>
			/// <param name="mailSentTime">DateTimeOffset?</param>
			set
			{
				 this.AddKeyValue("Mail_Sent_Time", value);

			}
		}

		public DateTime? ConsentDate
		{
			/// <summary>The method to get the consentDate</summary>
			/// <returns>DateTime? representing the consentDate</returns>
			get
			{
				if((( this.GetKeyValue("Consent_Date")) != (null)))
				{
					return (DateTime?) this.GetKeyValue("Consent_Date");

				}
					return null;


			}
			/// <summary>The method to set the value to consentDate</summary>
			/// <param name="consentDate">DateTime?</param>
			set
			{
				 this.AddKeyValue("Consent_Date", value);

			}
		}

		public string ConsentRemarks
		{
			/// <summary>The method to get the consentRemarks</summary>
			/// <returns>string representing the consentRemarks</returns>
			get
			{
				if((( this.GetKeyValue("Consent_Remarks")) != (null)))
				{
					return (string) this.GetKeyValue("Consent_Remarks");

				}
					return null;


			}
			/// <summary>The method to set the value to consentRemarks</summary>
			/// <param name="consentRemarks">string</param>
			set
			{
				 this.AddKeyValue("Consent_Remarks", value);

			}
		}

		public string ConsentThrough
		{
			/// <summary>The method to get the consentThrough</summary>
			/// <returns>string representing the consentThrough</returns>
			get
			{
				if((( this.GetKeyValue("Consent_Through")) != (null)))
				{
					return (string) this.GetKeyValue("Consent_Through");

				}
					return null;


			}
			/// <summary>The method to set the value to consentThrough</summary>
			/// <param name="consentThrough">string</param>
			set
			{
				 this.AddKeyValue("Consent_Through", value);

			}
		}

		public string DataProcessingBasis
		{
			/// <summary>The method to get the dataProcessingBasis</summary>
			/// <returns>string representing the dataProcessingBasis</returns>
			get
			{
				if((( this.GetKeyValue("Data_Processing_Basis")) != (null)))
				{
					return (string) this.GetKeyValue("Data_Processing_Basis");

				}
					return null;


			}
			/// <summary>The method to set the value to dataProcessingBasis</summary>
			/// <param name="dataProcessingBasis">string</param>
			set
			{
				 this.AddKeyValue("Data_Processing_Basis", value);

			}
		}

		public long? Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>long? representing the id</returns>
			get
			{
				if((( this.GetKeyValue("id")) != (null)))
				{
					return (long?) this.GetKeyValue("id");

				}
					return null;


			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">long?</param>
			set
			{
				 this.AddKeyValue("id", value);

			}
		}

		public Users.MinifiedUser CreatedBy
		{
			/// <summary>The method to get the createdBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				if((( this.GetKeyValue("Created_By")) != (null)))
				{
					return (Users.MinifiedUser) this.GetKeyValue("Created_By");

				}
					return null;


			}
			/// <summary>The method to set the value to createdBy</summary>
			/// <param name="createdBy">Instance of MinifiedUser</param>
			set
			{
				 this.AddKeyValue("Created_By", value);

			}
		}

		public DateTimeOffset? CreatedTime
		{
			/// <summary>The method to get the createdTime</summary>
			/// <returns>DateTimeOffset? representing the createdTime</returns>
			get
			{
				if((( this.GetKeyValue("Created_Time")) != (null)))
				{
					return (DateTimeOffset?) this.GetKeyValue("Created_Time");

				}
					return null;


			}
			/// <summary>The method to set the value to createdTime</summary>
			/// <param name="createdTime">DateTimeOffset?</param>
			set
			{
				 this.AddKeyValue("Created_Time", value);

			}
		}

		public Users.MinifiedUser ModifiedBy
		{
			/// <summary>The method to get the modifiedBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				if((( this.GetKeyValue("Modified_By")) != (null)))
				{
					return (Users.MinifiedUser) this.GetKeyValue("Modified_By");

				}
					return null;


			}
			/// <summary>The method to set the value to modifiedBy</summary>
			/// <param name="modifiedBy">Instance of MinifiedUser</param>
			set
			{
				 this.AddKeyValue("Modified_By", value);

			}
		}

		public DateTimeOffset? ModifiedTime
		{
			/// <summary>The method to get the modifiedTime</summary>
			/// <returns>DateTimeOffset? representing the modifiedTime</returns>
			get
			{
				if((( this.GetKeyValue("Modified_Time")) != (null)))
				{
					return (DateTimeOffset?) this.GetKeyValue("Modified_Time");

				}
					return null;


			}
			/// <summary>The method to set the value to modifiedTime</summary>
			/// <param name="modifiedTime">DateTimeOffset?</param>
			set
			{
				 this.AddKeyValue("Modified_Time", value);

			}
		}

		public List<Tags.Tag> Tag
		{
			/// <summary>The method to get the tag</summary>
			/// <returns>Instance of List<Tag></returns>
			get
			{
				if((( this.GetKeyValue("Tag")) != (null)))
				{
					return (List<Tags.Tag>) this.GetKeyValue("Tag");

				}
					return null;


			}
			/// <summary>The method to set the value to tag</summary>
			/// <param name="tag">Instance of List<Tag></param>
			set
			{
				 this.AddKeyValue("Tag", value);

			}
		}

		public string Name
		{
			/// <summary>The method to get the name</summary>
			/// <returns>string representing the name</returns>
			get
			{
				if((( this.GetKeyValue("name")) != (null)))
				{
					return (string) this.GetKeyValue("name");

				}
					return null;


			}
			/// <summary>The method to set the value to name</summary>
			/// <param name="name">string</param>
			set
			{
				 this.AddKeyValue("name", value);

			}
		}


	}
}