using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaPeopleEnrichment
{

	public class EnrichedData : Model
	{
		private string website;
		private List<EmailInfo> emailInfos;
		private string gender;
		private CompanyInfo companyInfo;
		private string lastName;
		private List<object> educations;
		private string middleName;
		private List<object> skills;
		private List<string> otherContacts;
		private List<Address> addressListInfo;
		private Address primaryAddressInfo;
		private string name;
		private string secondaryContact;
		private string primaryEmail;
		private string designation;
		private string id;
		private List<object> interests;
		private string firstName;
		private string primaryContact;
		private List<SocialMedia> socialMedia;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Website
		{
			/// <summary>The method to get the website</summary>
			/// <returns>string representing the website</returns>
			get
			{
				return  this.website;

			}
			/// <summary>The method to set the value to website</summary>
			/// <param name="website">string</param>
			set
			{
				 this.website=value;

				 this.keyModified["website"] = 1;

			}
		}

		public List<EmailInfo> EmailInfos
		{
			/// <summary>The method to get the emailInfos</summary>
			/// <returns>Instance of List<EmailInfo></returns>
			get
			{
				return  this.emailInfos;

			}
			/// <summary>The method to set the value to emailInfos</summary>
			/// <param name="emailInfos">Instance of List<EmailInfo></param>
			set
			{
				 this.emailInfos=value;

				 this.keyModified["email_infos"] = 1;

			}
		}

		public string Gender
		{
			/// <summary>The method to get the gender</summary>
			/// <returns>string representing the gender</returns>
			get
			{
				return  this.gender;

			}
			/// <summary>The method to set the value to gender</summary>
			/// <param name="gender">string</param>
			set
			{
				 this.gender=value;

				 this.keyModified["gender"] = 1;

			}
		}

		public CompanyInfo CompanyInfo
		{
			/// <summary>The method to get the companyInfo</summary>
			/// <returns>Instance of CompanyInfo</returns>
			get
			{
				return  this.companyInfo;

			}
			/// <summary>The method to set the value to companyInfo</summary>
			/// <param name="companyInfo">Instance of CompanyInfo</param>
			set
			{
				 this.companyInfo=value;

				 this.keyModified["company_info"] = 1;

			}
		}

		public string LastName
		{
			/// <summary>The method to get the lastName</summary>
			/// <returns>string representing the lastName</returns>
			get
			{
				return  this.lastName;

			}
			/// <summary>The method to set the value to lastName</summary>
			/// <param name="lastName">string</param>
			set
			{
				 this.lastName=value;

				 this.keyModified["last_name"] = 1;

			}
		}

		public List<object> Educations
		{
			/// <summary>The method to get the educations</summary>
			/// <returns>Instance of List<Object></returns>
			get
			{
				return  this.educations;

			}
			/// <summary>The method to set the value to educations</summary>
			/// <param name="educations">Instance of List<object></param>
			set
			{
				 this.educations=value;

				 this.keyModified["educations"] = 1;

			}
		}

		public string MiddleName
		{
			/// <summary>The method to get the middleName</summary>
			/// <returns>string representing the middleName</returns>
			get
			{
				return  this.middleName;

			}
			/// <summary>The method to set the value to middleName</summary>
			/// <param name="middleName">string</param>
			set
			{
				 this.middleName=value;

				 this.keyModified["middle_name"] = 1;

			}
		}

		public List<object> Skills
		{
			/// <summary>The method to get the skills</summary>
			/// <returns>Instance of List<Object></returns>
			get
			{
				return  this.skills;

			}
			/// <summary>The method to set the value to skills</summary>
			/// <param name="skills">Instance of List<object></param>
			set
			{
				 this.skills=value;

				 this.keyModified["skills"] = 1;

			}
		}

		public List<string> OtherContacts
		{
			/// <summary>The method to get the otherContacts</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.otherContacts;

			}
			/// <summary>The method to set the value to otherContacts</summary>
			/// <param name="otherContacts">Instance of List<string></param>
			set
			{
				 this.otherContacts=value;

				 this.keyModified["other_contacts"] = 1;

			}
		}

		public List<Address> AddressListInfo
		{
			/// <summary>The method to get the addressListInfo</summary>
			/// <returns>Instance of List<Address></returns>
			get
			{
				return  this.addressListInfo;

			}
			/// <summary>The method to set the value to addressListInfo</summary>
			/// <param name="addressListInfo">Instance of List<Address></param>
			set
			{
				 this.addressListInfo=value;

				 this.keyModified["address_list_info"] = 1;

			}
		}

		public Address PrimaryAddressInfo
		{
			/// <summary>The method to get the primaryAddressInfo</summary>
			/// <returns>Instance of Address</returns>
			get
			{
				return  this.primaryAddressInfo;

			}
			/// <summary>The method to set the value to primaryAddressInfo</summary>
			/// <param name="primaryAddressInfo">Instance of Address</param>
			set
			{
				 this.primaryAddressInfo=value;

				 this.keyModified["primary_address_info"] = 1;

			}
		}

		public string Name
		{
			/// <summary>The method to get the name</summary>
			/// <returns>string representing the name</returns>
			get
			{
				return  this.name;

			}
			/// <summary>The method to set the value to name</summary>
			/// <param name="name">string</param>
			set
			{
				 this.name=value;

				 this.keyModified["name"] = 1;

			}
		}

		public string SecondaryContact
		{
			/// <summary>The method to get the secondaryContact</summary>
			/// <returns>string representing the secondaryContact</returns>
			get
			{
				return  this.secondaryContact;

			}
			/// <summary>The method to set the value to secondaryContact</summary>
			/// <param name="secondaryContact">string</param>
			set
			{
				 this.secondaryContact=value;

				 this.keyModified["secondary_contact"] = 1;

			}
		}

		public string PrimaryEmail
		{
			/// <summary>The method to get the primaryEmail</summary>
			/// <returns>string representing the primaryEmail</returns>
			get
			{
				return  this.primaryEmail;

			}
			/// <summary>The method to set the value to primaryEmail</summary>
			/// <param name="primaryEmail">string</param>
			set
			{
				 this.primaryEmail=value;

				 this.keyModified["primary_email"] = 1;

			}
		}

		public string Designation
		{
			/// <summary>The method to get the designation</summary>
			/// <returns>string representing the designation</returns>
			get
			{
				return  this.designation;

			}
			/// <summary>The method to set the value to designation</summary>
			/// <param name="designation">string</param>
			set
			{
				 this.designation=value;

				 this.keyModified["designation"] = 1;

			}
		}

		public string Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>string representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">string</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

			}
		}

		public List<object> Interests
		{
			/// <summary>The method to get the interests</summary>
			/// <returns>Instance of List<Object></returns>
			get
			{
				return  this.interests;

			}
			/// <summary>The method to set the value to interests</summary>
			/// <param name="interests">Instance of List<object></param>
			set
			{
				 this.interests=value;

				 this.keyModified["interests"] = 1;

			}
		}

		public string FirstName
		{
			/// <summary>The method to get the firstName</summary>
			/// <returns>string representing the firstName</returns>
			get
			{
				return  this.firstName;

			}
			/// <summary>The method to set the value to firstName</summary>
			/// <param name="firstName">string</param>
			set
			{
				 this.firstName=value;

				 this.keyModified["first_name"] = 1;

			}
		}

		public string PrimaryContact
		{
			/// <summary>The method to get the primaryContact</summary>
			/// <returns>string representing the primaryContact</returns>
			get
			{
				return  this.primaryContact;

			}
			/// <summary>The method to set the value to primaryContact</summary>
			/// <param name="primaryContact">string</param>
			set
			{
				 this.primaryContact=value;

				 this.keyModified["primary_contact"] = 1;

			}
		}

		public List<SocialMedia> SocialMedia
		{
			/// <summary>The method to get the socialMedia</summary>
			/// <returns>Instance of List<SocialMedia></returns>
			get
			{
				return  this.socialMedia;

			}
			/// <summary>The method to set the value to socialMedia</summary>
			/// <param name="socialMedia">Instance of List<SocialMedia></param>
			set
			{
				 this.socialMedia=value;

				 this.keyModified["social_media"] = 1;

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