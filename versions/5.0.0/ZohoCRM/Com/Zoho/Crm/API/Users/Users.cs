using Com.Zoho.Crm.API.Record;
using Com.Zoho.Crm.API.Tags;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Users
{

	public class Users : Record.Record , Model
	{

		public string Country
		{
			/// <summary>The method to get the country</summary>
			/// <returns>string representing the country</returns>
			get
			{
				if((( this.GetKeyValue("country")) != (null)))
				{
					return (string) this.GetKeyValue("country");

				}
					return null;


			}
			/// <summary>The method to set the value to country</summary>
			/// <param name="country">string</param>
			set
			{
				 this.AddKeyValue("country", value);

			}
		}

		public string Language
		{
			/// <summary>The method to get the language</summary>
			/// <returns>string representing the language</returns>
			get
			{
				if((( this.GetKeyValue("language")) != (null)))
				{
					return (string) this.GetKeyValue("language");

				}
					return null;


			}
			/// <summary>The method to set the value to language</summary>
			/// <param name="language">string</param>
			set
			{
				 this.AddKeyValue("language", value);

			}
		}

		public bool? Microsoft
		{
			/// <summary>The method to get the microsoft</summary>
			/// <returns>bool? representing the microsoft</returns>
			get
			{
				if((( this.GetKeyValue("microsoft")) != (null)))
				{
					return (bool?) this.GetKeyValue("microsoft");

				}
					return null;


			}
			/// <summary>The method to set the value to microsoft</summary>
			/// <param name="microsoft">bool?</param>
			set
			{
				 this.AddKeyValue("microsoft", value);

			}
		}

		public object ShiftEffectiveFrom
		{
			/// <summary>The method to get the shiftEffectiveFrom</summary>
			/// <returns>object representing the shiftEffectiveFrom</returns>
			get
			{
				if((( this.GetKeyValue("$shift_effective_from")) != (null)))
				{
					return (object) this.GetKeyValue("$shift_effective_from");

				}
					return null;


			}
			/// <summary>The method to set the value to shiftEffectiveFrom</summary>
			/// <param name="shiftEffectiveFrom">object</param>
			set
			{
				 this.AddKeyValue("$shift_effective_from", value);

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

		public string State
		{
			/// <summary>The method to get the state</summary>
			/// <returns>string representing the state</returns>
			get
			{
				if((( this.GetKeyValue("state")) != (null)))
				{
					return (string) this.GetKeyValue("state");

				}
					return null;


			}
			/// <summary>The method to set the value to state</summary>
			/// <param name="state">string</param>
			set
			{
				 this.AddKeyValue("state", value);

			}
		}

		public string Fax
		{
			/// <summary>The method to get the fax</summary>
			/// <returns>string representing the fax</returns>
			get
			{
				if((( this.GetKeyValue("fax")) != (null)))
				{
					return (string) this.GetKeyValue("fax");

				}
					return null;


			}
			/// <summary>The method to set the value to fax</summary>
			/// <param name="fax">string</param>
			set
			{
				 this.AddKeyValue("fax", value);

			}
		}

		public string CountryLocale
		{
			/// <summary>The method to get the countryLocale</summary>
			/// <returns>string representing the countryLocale</returns>
			get
			{
				if((( this.GetKeyValue("country_locale")) != (null)))
				{
					return (string) this.GetKeyValue("country_locale");

				}
					return null;


			}
			/// <summary>The method to set the value to countryLocale</summary>
			/// <param name="countryLocale">string</param>
			set
			{
				 this.AddKeyValue("country_locale", value);

			}
		}

		public string Zip
		{
			/// <summary>The method to get the zip</summary>
			/// <returns>string representing the zip</returns>
			get
			{
				if((( this.GetKeyValue("zip")) != (null)))
				{
					return (string) this.GetKeyValue("zip");

				}
					return null;


			}
			/// <summary>The method to set the value to zip</summary>
			/// <param name="zip">string</param>
			set
			{
				 this.AddKeyValue("zip", value);

			}
		}

		public DateTimeOffset? CreatedTime
		{
			/// <summary>The method to get the createdTime</summary>
			/// <returns>DateTimeOffset? representing the createdTime</returns>
			get
			{
				if((( this.GetKeyValue("created_time")) != (null)))
				{
					return (DateTimeOffset?) this.GetKeyValue("created_time");

				}
					return null;


			}
			/// <summary>The method to set the value to createdTime</summary>
			/// <param name="createdTime">DateTimeOffset?</param>
			set
			{
				 this.AddKeyValue("created_time", value);

			}
		}

		public Choice<string> TimeFormat
		{
			/// <summary>The method to get the timeFormat</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				if((( this.GetKeyValue("time_format")) != (null)))
				{
					return (Choice<string>) this.GetKeyValue("time_format");

				}
					return null;


			}
			/// <summary>The method to set the value to timeFormat</summary>
			/// <param name="timeFormat">Instance of Choice<string></param>
			set
			{
				 this.AddKeyValue("time_format", value);

			}
		}

		public int? Offset
		{
			/// <summary>The method to get the offset</summary>
			/// <returns>int? representing the offset</returns>
			get
			{
				if((( this.GetKeyValue("offset")) != (null)))
				{
					return (int?) this.GetKeyValue("offset");

				}
					return null;


			}
			/// <summary>The method to set the value to offset</summary>
			/// <param name="offset">int?</param>
			set
			{
				 this.AddKeyValue("offset", value);

			}
		}

		public bool? ImapStatus
		{
			/// <summary>The method to get the imapStatus</summary>
			/// <returns>bool? representing the imapStatus</returns>
			get
			{
				if((( this.GetKeyValue("imap_status")) != (null)))
				{
					return (bool?) this.GetKeyValue("imap_status");

				}
					return null;


			}
			/// <summary>The method to set the value to imapStatus</summary>
			/// <param name="imapStatus">bool?</param>
			set
			{
				 this.AddKeyValue("imap_status", value);

			}
		}

		public string ImageLink
		{
			/// <summary>The method to get the imageLink</summary>
			/// <returns>string representing the imageLink</returns>
			get
			{
				if((( this.GetKeyValue("image_link")) != (null)))
				{
					return (string) this.GetKeyValue("image_link");

				}
					return null;


			}
			/// <summary>The method to set the value to imageLink</summary>
			/// <param name="imageLink">string</param>
			set
			{
				 this.AddKeyValue("image_link", value);

			}
		}

		public string Ezuid
		{
			/// <summary>The method to get the ezuid</summary>
			/// <returns>string representing the ezuid</returns>
			get
			{
				if((( this.GetKeyValue("ezuid")) != (null)))
				{
					return (string) this.GetKeyValue("ezuid");

				}
					return null;


			}
			/// <summary>The method to set the value to ezuid</summary>
			/// <param name="ezuid">string</param>
			set
			{
				 this.AddKeyValue("ezuid", value);

			}
		}

		public Profile Profile
		{
			/// <summary>The method to get the profile</summary>
			/// <returns>Instance of Profile</returns>
			get
			{
				if((( this.GetKeyValue("profile")) != (null)))
				{
					return (Profile) this.GetKeyValue("profile");

				}
					return null;


			}
			/// <summary>The method to set the value to profile</summary>
			/// <param name="profile">Instance of Profile</param>
			set
			{
				 this.AddKeyValue("profile", value);

			}
		}

		public Role Role
		{
			/// <summary>The method to get the role</summary>
			/// <returns>Instance of Role</returns>
			get
			{
				if((( this.GetKeyValue("role")) != (null)))
				{
					return (Role) this.GetKeyValue("role");

				}
					return null;


			}
			/// <summary>The method to set the value to role</summary>
			/// <param name="role">Instance of Role</param>
			set
			{
				 this.AddKeyValue("role", value);

			}
		}

		public MinifiedUser CreatedBy
		{
			/// <summary>The method to get the createdBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				if((( this.GetKeyValue("created_by")) != (null)))
				{
					return (MinifiedUser) this.GetKeyValue("created_by");

				}
					return null;


			}
			/// <summary>The method to set the value to createdBy</summary>
			/// <param name="createdBy">Instance of MinifiedUser</param>
			set
			{
				 this.AddKeyValue("created_by", value);

			}
		}

		public string FullName
		{
			/// <summary>The method to get the fullName</summary>
			/// <returns>string representing the fullName</returns>
			get
			{
				if((( this.GetKeyValue("full_name")) != (null)))
				{
					return (string) this.GetKeyValue("full_name");

				}
					return null;


			}
			/// <summary>The method to set the value to fullName</summary>
			/// <param name="fullName">string</param>
			set
			{
				 this.AddKeyValue("full_name", value);

			}
		}

		public string Zuid
		{
			/// <summary>The method to get the zuid</summary>
			/// <returns>string representing the zuid</returns>
			get
			{
				if((( this.GetKeyValue("zuid")) != (null)))
				{
					return (string) this.GetKeyValue("zuid");

				}
					return null;


			}
			/// <summary>The method to set the value to zuid</summary>
			/// <param name="zuid">string</param>
			set
			{
				 this.AddKeyValue("zuid", value);

			}
		}

		public string Phone
		{
			/// <summary>The method to get the phone</summary>
			/// <returns>string representing the phone</returns>
			get
			{
				if((( this.GetKeyValue("phone")) != (null)))
				{
					return (string) this.GetKeyValue("phone");

				}
					return null;


			}
			/// <summary>The method to set the value to phone</summary>
			/// <param name="phone">string</param>
			set
			{
				 this.AddKeyValue("phone", value);

			}
		}

		public DateTime? Dob
		{
			/// <summary>The method to get the dob</summary>
			/// <returns>DateTime? representing the dob</returns>
			get
			{
				if((( this.GetKeyValue("dob")) != (null)))
				{
					return (DateTime?) this.GetKeyValue("dob");

				}
					return null;


			}
			/// <summary>The method to set the value to dob</summary>
			/// <param name="dob">DateTime?</param>
			set
			{
				 this.AddKeyValue("dob", value);

			}
		}

		public string Status
		{
			/// <summary>The method to get the status</summary>
			/// <returns>string representing the status</returns>
			get
			{
				if((( this.GetKeyValue("status")) != (null)))
				{
					return (string) this.GetKeyValue("status");

				}
					return null;


			}
			/// <summary>The method to set the value to status</summary>
			/// <param name="status">string</param>
			set
			{
				 this.AddKeyValue("status", value);

			}
		}

		public CustomizeInfo CustomizeInfo
		{
			/// <summary>The method to get the customizeInfo</summary>
			/// <returns>Instance of CustomizeInfo</returns>
			get
			{
				if((( this.GetKeyValue("customize_info")) != (null)))
				{
					return (CustomizeInfo) this.GetKeyValue("customize_info");

				}
					return null;


			}
			/// <summary>The method to set the value to customizeInfo</summary>
			/// <param name="customizeInfo">Instance of CustomizeInfo</param>
			set
			{
				 this.AddKeyValue("customize_info", value);

			}
		}

		public string City
		{
			/// <summary>The method to get the city</summary>
			/// <returns>string representing the city</returns>
			get
			{
				if((( this.GetKeyValue("city")) != (null)))
				{
					return (string) this.GetKeyValue("city");

				}
					return null;


			}
			/// <summary>The method to set the value to city</summary>
			/// <param name="city">string</param>
			set
			{
				 this.AddKeyValue("city", value);

			}
		}

		public string Signature
		{
			/// <summary>The method to get the signature</summary>
			/// <returns>string representing the signature</returns>
			get
			{
				if((( this.GetKeyValue("signature")) != (null)))
				{
					return (string) this.GetKeyValue("signature");

				}
					return null;


			}
			/// <summary>The method to set the value to signature</summary>
			/// <param name="signature">string</param>
			set
			{
				 this.AddKeyValue("signature", value);

			}
		}

		public string SortOrderPreferenceS
		{
			/// <summary>The method to get the sortOrderPreferenceS</summary>
			/// <returns>string representing the sortOrderPreferenceS</returns>
			get
			{
				if((( this.GetKeyValue("sort_order_preference__s")) != (null)))
				{
					return (string) this.GetKeyValue("sort_order_preference__s");

				}
					return null;


			}
			/// <summary>The method to set the value to sortOrderPreferenceS</summary>
			/// <param name="sortOrderPreferenceS">string</param>
			set
			{
				 this.AddKeyValue("sort_order_preference__s", value);

			}
		}

		public string Category
		{
			/// <summary>The method to get the category</summary>
			/// <returns>string representing the category</returns>
			get
			{
				if((( this.GetKeyValue("category")) != (null)))
				{
					return (string) this.GetKeyValue("category");

				}
					return null;


			}
			/// <summary>The method to set the value to category</summary>
			/// <param name="category">string</param>
			set
			{
				 this.AddKeyValue("category", value);

			}
		}

		public Choice<string> DateFormat
		{
			/// <summary>The method to get the dateFormat</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				if((( this.GetKeyValue("date_format")) != (null)))
				{
					return (Choice<string>) this.GetKeyValue("date_format");

				}
					return null;


			}
			/// <summary>The method to set the value to dateFormat</summary>
			/// <param name="dateFormat">Instance of Choice<string></param>
			set
			{
				 this.AddKeyValue("date_format", value);

			}
		}

		public bool? Confirm
		{
			/// <summary>The method to get the confirm</summary>
			/// <returns>bool? representing the confirm</returns>
			get
			{
				if((( this.GetKeyValue("confirm")) != (null)))
				{
					return (bool?) this.GetKeyValue("confirm");

				}
					return null;


			}
			/// <summary>The method to set the value to confirm</summary>
			/// <param name="confirm">bool?</param>
			set
			{
				 this.AddKeyValue("confirm", value);

			}
		}

		public Choice<string> DecimalSeparator
		{
			/// <summary>The method to get the decimalSeparator</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				if((( this.GetKeyValue("decimal_separator")) != (null)))
				{
					return (Choice<string>) this.GetKeyValue("decimal_separator");

				}
					return null;


			}
			/// <summary>The method to set the value to decimalSeparator</summary>
			/// <param name="decimalSeparator">Instance of Choice<string></param>
			set
			{
				 this.AddKeyValue("decimal_separator", value);

			}
		}

		public Choice<string> NumberSeparator
		{
			/// <summary>The method to get the numberSeparator</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				if((( this.GetKeyValue("number_separator")) != (null)))
				{
					return (Choice<string>) this.GetKeyValue("number_separator");

				}
					return null;


			}
			/// <summary>The method to set the value to numberSeparator</summary>
			/// <param name="numberSeparator">Instance of Choice<string></param>
			set
			{
				 this.AddKeyValue("number_separator", value);

			}
		}

		public TimeZoneInfo TimeZone
		{
			/// <summary>The method to get the timeZone</summary>
			/// <returns>TimeZoneInfo representing the timeZone</returns>
			get
			{
				if((( this.GetKeyValue("time_zone")) != (null)))
				{
					return (TimeZoneInfo) this.GetKeyValue("time_zone");

				}
					return null;


			}
			/// <summary>The method to set the value to timeZone</summary>
			/// <param name="timeZone">TimeZoneInfo</param>
			set
			{
				 this.AddKeyValue("time_zone", value);

			}
		}

		public string LastName
		{
			/// <summary>The method to get the lastName</summary>
			/// <returns>string representing the lastName</returns>
			get
			{
				if((( this.GetKeyValue("last_name")) != (null)))
				{
					return (string) this.GetKeyValue("last_name");

				}
					return null;


			}
			/// <summary>The method to set the value to lastName</summary>
			/// <param name="lastName">string</param>
			set
			{
				 this.AddKeyValue("last_name", value);

			}
		}

		public string Mobile
		{
			/// <summary>The method to get the mobile</summary>
			/// <returns>string representing the mobile</returns>
			get
			{
				if((( this.GetKeyValue("mobile")) != (null)))
				{
					return (string) this.GetKeyValue("mobile");

				}
					return null;


			}
			/// <summary>The method to set the value to mobile</summary>
			/// <param name="mobile">string</param>
			set
			{
				 this.AddKeyValue("mobile", value);

			}
		}

		public Shift CurrentShift
		{
			/// <summary>The method to get the currentShift</summary>
			/// <returns>Instance of Shift</returns>
			get
			{
				if((( this.GetKeyValue("$current_shift")) != (null)))
				{
					return (Shift) this.GetKeyValue("$current_shift");

				}
					return null;


			}
			/// <summary>The method to set the value to currentShift</summary>
			/// <param name="currentShift">Instance of Shift</param>
			set
			{
				 this.AddKeyValue("$current_shift", value);

			}
		}

		public MinifiedUser ReportingTo
		{
			/// <summary>The method to get the reportingTo</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				if((( this.GetKeyValue("Reporting_To")) != (null)))
				{
					return (MinifiedUser) this.GetKeyValue("Reporting_To");

				}
					return null;


			}
			/// <summary>The method to set the value to reportingTo</summary>
			/// <param name="reportingTo">Instance of MinifiedUser</param>
			set
			{
				 this.AddKeyValue("Reporting_To", value);

			}
		}

		public string Currency
		{
			/// <summary>The method to get the currency</summary>
			/// <returns>string representing the currency</returns>
			get
			{
				if((( this.GetKeyValue("Currency")) != (null)))
				{
					return (string) this.GetKeyValue("Currency");

				}
					return null;


			}
			/// <summary>The method to set the value to currency</summary>
			/// <param name="currency">string</param>
			set
			{
				 this.AddKeyValue("Currency", value);

			}
		}

		public Shift NextShift
		{
			/// <summary>The method to get the nextShift</summary>
			/// <returns>Instance of Shift</returns>
			get
			{
				if((( this.GetKeyValue("$next_shift")) != (null)))
				{
					return (Shift) this.GetKeyValue("$next_shift");

				}
					return null;


			}
			/// <summary>The method to set the value to nextShift</summary>
			/// <param name="nextShift">Instance of Shift</param>
			set
			{
				 this.AddKeyValue("$next_shift", value);

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

		public string Website
		{
			/// <summary>The method to get the website</summary>
			/// <returns>string representing the website</returns>
			get
			{
				if((( this.GetKeyValue("website")) != (null)))
				{
					return (string) this.GetKeyValue("website");

				}
					return null;


			}
			/// <summary>The method to set the value to website</summary>
			/// <param name="website">string</param>
			set
			{
				 this.AddKeyValue("website", value);

			}
		}

		public string StatusReasonS
		{
			/// <summary>The method to get the statusReasonS</summary>
			/// <returns>string representing the statusReasonS</returns>
			get
			{
				if((( this.GetKeyValue("status_reason__s")) != (null)))
				{
					return (string) this.GetKeyValue("status_reason__s");

				}
					return null;


			}
			/// <summary>The method to set the value to statusReasonS</summary>
			/// <param name="statusReasonS">string</param>
			set
			{
				 this.AddKeyValue("status_reason__s", value);

			}
		}

		public string Email
		{
			/// <summary>The method to get the email</summary>
			/// <returns>string representing the email</returns>
			get
			{
				if((( this.GetKeyValue("email")) != (null)))
				{
					return (string) this.GetKeyValue("email");

				}
					return null;


			}
			/// <summary>The method to set the value to email</summary>
			/// <param name="email">string</param>
			set
			{
				 this.AddKeyValue("email", value);

			}
		}

		public string FirstName
		{
			/// <summary>The method to get the firstName</summary>
			/// <returns>string representing the firstName</returns>
			get
			{
				if((( this.GetKeyValue("first_name")) != (null)))
				{
					return (string) this.GetKeyValue("first_name");

				}
					return null;


			}
			/// <summary>The method to set the value to firstName</summary>
			/// <param name="firstName">string</param>
			set
			{
				 this.AddKeyValue("first_name", value);

			}
		}

		public bool? Sandboxdeveloper
		{
			/// <summary>The method to get the sandboxdeveloper</summary>
			/// <returns>bool? representing the sandboxdeveloper</returns>
			get
			{
				if((( this.GetKeyValue("sandboxDeveloper")) != (null)))
				{
					return (bool?) this.GetKeyValue("sandboxDeveloper");

				}
					return null;


			}
			/// <summary>The method to set the value to sandboxdeveloper</summary>
			/// <param name="sandboxdeveloper">bool?</param>
			set
			{
				 this.AddKeyValue("sandboxDeveloper", value);

			}
		}

		public string Alias
		{
			/// <summary>The method to get the alias</summary>
			/// <returns>string representing the alias</returns>
			get
			{
				if((( this.GetKeyValue("alias")) != (null)))
				{
					return (string) this.GetKeyValue("alias");

				}
					return null;


			}
			/// <summary>The method to set the value to alias</summary>
			/// <param name="alias">string</param>
			set
			{
				 this.AddKeyValue("alias", value);

			}
		}

		public string Street
		{
			/// <summary>The method to get the street</summary>
			/// <returns>string representing the street</returns>
			get
			{
				if((( this.GetKeyValue("street")) != (null)))
				{
					return (string) this.GetKeyValue("street");

				}
					return null;


			}
			/// <summary>The method to set the value to street</summary>
			/// <param name="street">string</param>
			set
			{
				 this.AddKeyValue("street", value);

			}
		}

		public MinifiedUser ModifiedBy
		{
			/// <summary>The method to get the modifiedBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				if((( this.GetKeyValue("Modified_By")) != (null)))
				{
					return (MinifiedUser) this.GetKeyValue("Modified_By");

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

		public bool? Isonline
		{
			/// <summary>The method to get the isonline</summary>
			/// <returns>bool? representing the isonline</returns>
			get
			{
				if((( this.GetKeyValue("Isonline")) != (null)))
				{
					return (bool?) this.GetKeyValue("Isonline");

				}
					return null;


			}
			/// <summary>The method to set the value to isonline</summary>
			/// <param name="isonline">bool?</param>
			set
			{
				 this.AddKeyValue("Isonline", value);

			}
		}

		public string Locale
		{
			/// <summary>The method to get the locale</summary>
			/// <returns>string representing the locale</returns>
			get
			{
				if((( this.GetKeyValue("locale")) != (null)))
				{
					return (string) this.GetKeyValue("locale");

				}
					return null;


			}
			/// <summary>The method to set the value to locale</summary>
			/// <param name="locale">string</param>
			set
			{
				 this.AddKeyValue("locale", value);

			}
		}

		public Choice<string> NameFormatS
		{
			/// <summary>The method to get the nameFormatS</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				if((( this.GetKeyValue("name_format__s")) != (null)))
				{
					return (Choice<string>) this.GetKeyValue("name_format__s");

				}
					return null;


			}
			/// <summary>The method to set the value to nameFormatS</summary>
			/// <param name="nameFormatS">Instance of Choice<string></param>
			set
			{
				 this.AddKeyValue("name_format__s", value);

			}
		}

		public bool? PersonalAccount
		{
			/// <summary>The method to get the personalAccount</summary>
			/// <returns>bool? representing the personalAccount</returns>
			get
			{
				if((( this.GetKeyValue("personal_account")) != (null)))
				{
					return (bool?) this.GetKeyValue("personal_account");

				}
					return null;


			}
			/// <summary>The method to set the value to personalAccount</summary>
			/// <param name="personalAccount">bool?</param>
			set
			{
				 this.AddKeyValue("personal_account", value);

			}
		}

		public string DefaultTabGroup
		{
			/// <summary>The method to get the defaultTabGroup</summary>
			/// <returns>string representing the defaultTabGroup</returns>
			get
			{
				if((( this.GetKeyValue("default_tab_group")) != (null)))
				{
					return (string) this.GetKeyValue("default_tab_group");

				}
					return null;


			}
			/// <summary>The method to set the value to defaultTabGroup</summary>
			/// <param name="defaultTabGroup">string</param>
			set
			{
				 this.AddKeyValue("default_tab_group", value);

			}
		}

		public Theme Theme
		{
			/// <summary>The method to get the theme</summary>
			/// <returns>Instance of Theme</returns>
			get
			{
				if((( this.GetKeyValue("theme")) != (null)))
				{
					return (Theme) this.GetKeyValue("theme");

				}
					return null;


			}
			/// <summary>The method to set the value to theme</summary>
			/// <param name="theme">Instance of Theme</param>
			set
			{
				 this.AddKeyValue("theme", value);

			}
		}

		public List<long?> NtcNotificationType
		{
			/// <summary>The method to get the ntcNotificationType</summary>
			/// <returns>Instance of List<Long></returns>
			get
			{
				if((( this.GetKeyValue("ntc_notification_type")) != (null)))
				{
					return (List<long?>) this.GetKeyValue("ntc_notification_type");

				}
					return null;


			}
			/// <summary>The method to set the value to ntcNotificationType</summary>
			/// <param name="ntcNotificationType">Instance of List<long?></param>
			set
			{
				 this.AddKeyValue("ntc_notification_type", value);

			}
		}

		public bool? NtcEnabled
		{
			/// <summary>The method to get the ntcEnabled</summary>
			/// <returns>bool? representing the ntcEnabled</returns>
			get
			{
				if((( this.GetKeyValue("ntc_enabled")) != (null)))
				{
					return (bool?) this.GetKeyValue("ntc_enabled");

				}
					return null;


			}
			/// <summary>The method to set the value to ntcEnabled</summary>
			/// <param name="ntcEnabled">bool?</param>
			set
			{
				 this.AddKeyValue("ntc_enabled", value);

			}
		}

		public bool? RtlEnabled
		{
			/// <summary>The method to get the rtlEnabled</summary>
			/// <returns>bool? representing the rtlEnabled</returns>
			get
			{
				if((( this.GetKeyValue("rtl_enabled")) != (null)))
				{
					return (bool?) this.GetKeyValue("rtl_enabled");

				}
					return null;


			}
			/// <summary>The method to set the value to rtlEnabled</summary>
			/// <param name="rtlEnabled">bool?</param>
			set
			{
				 this.AddKeyValue("rtl_enabled", value);

			}
		}

		public bool? TelephonyEnabled
		{
			/// <summary>The method to get the telephonyEnabled</summary>
			/// <returns>bool? representing the telephonyEnabled</returns>
			get
			{
				if((( this.GetKeyValue("telephony_enabled")) != (null)))
				{
					return (bool?) this.GetKeyValue("telephony_enabled");

				}
					return null;


			}
			/// <summary>The method to set the value to telephonyEnabled</summary>
			/// <param name="telephonyEnabled">bool?</param>
			set
			{
				 this.AddKeyValue("telephony_enabled", value);

			}
		}

		public string SortOrderPreference
		{
			/// <summary>The method to get the sortOrderPreference</summary>
			/// <returns>string representing the sortOrderPreference</returns>
			get
			{
				if((( this.GetKeyValue("sort_order_preference")) != (null)))
				{
					return (string) this.GetKeyValue("sort_order_preference");

				}
					return null;


			}
			/// <summary>The method to set the value to sortOrderPreference</summary>
			/// <param name="sortOrderPreference">string</param>
			set
			{
				 this.AddKeyValue("sort_order_preference", value);

			}
		}

		public MinifiedUser CreatedBy17
		{
			/// <summary>The method to get the createdBy17</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				if((( this.GetKeyValue("Created_By")) != (null)))
				{
					return (MinifiedUser) this.GetKeyValue("Created_By");

				}
					return null;


			}
			/// <summary>The method to set the value to createdBy17</summary>
			/// <param name="createdBy17">Instance of MinifiedUser</param>
			set
			{
				 this.AddKeyValue("Created_By", value);

			}
		}

		public DateTimeOffset? CreatedTime9
		{
			/// <summary>The method to get the createdTime9</summary>
			/// <returns>DateTimeOffset? representing the createdTime9</returns>
			get
			{
				if((( this.GetKeyValue("Created_Time")) != (null)))
				{
					return (DateTimeOffset?) this.GetKeyValue("Created_Time");

				}
					return null;


			}
			/// <summary>The method to set the value to createdTime9</summary>
			/// <param name="createdTime9">DateTimeOffset?</param>
			set
			{
				 this.AddKeyValue("Created_Time", value);

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