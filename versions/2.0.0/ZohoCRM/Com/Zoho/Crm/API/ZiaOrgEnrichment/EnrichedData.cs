using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaOrgEnrichment
{

	public class EnrichedData : Model
	{
		private string orgStatus;
		private List<Description> description;
		private string ceo;
		private string secondaryEmail;
		private string revenue;
		private string yearsInIndustry;
		private List<string> otherContacts;
		private string technoGraphicData;
		private string logo;
		private string secondaryContact;
		private string id;
		private List<string> otherEmails;
		private string signIn;
		private string website;
		private List<Address> address;
		private string signUp;
		private string orgType;
		private List<Address> headQuarters;
		private string noOfEmployees;
		private List<string> territoryList;
		private string foundingYear;
		private List<Industry> industries;
		private string name;
		private string primaryEmail;
		private List<string> businessModel;
		private string primaryContact;
		private List<SocialMedia> socialMedia;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string OrgStatus
		{
			/// <summary>The method to get the orgStatus</summary>
			/// <returns>string representing the orgStatus</returns>
			get
			{
				return  this.orgStatus;

			}
			/// <summary>The method to set the value to orgStatus</summary>
			/// <param name="orgStatus">string</param>
			set
			{
				 this.orgStatus=value;

				 this.keyModified["org_status"] = 1;

			}
		}

		public List<Description> Description
		{
			/// <summary>The method to get the description</summary>
			/// <returns>Instance of List<Description></returns>
			get
			{
				return  this.description;

			}
			/// <summary>The method to set the value to description</summary>
			/// <param name="description">Instance of List<Description></param>
			set
			{
				 this.description=value;

				 this.keyModified["description"] = 1;

			}
		}

		public string Ceo
		{
			/// <summary>The method to get the ceo</summary>
			/// <returns>string representing the ceo</returns>
			get
			{
				return  this.ceo;

			}
			/// <summary>The method to set the value to ceo</summary>
			/// <param name="ceo">string</param>
			set
			{
				 this.ceo=value;

				 this.keyModified["ceo"] = 1;

			}
		}

		public string SecondaryEmail
		{
			/// <summary>The method to get the secondaryEmail</summary>
			/// <returns>string representing the secondaryEmail</returns>
			get
			{
				return  this.secondaryEmail;

			}
			/// <summary>The method to set the value to secondaryEmail</summary>
			/// <param name="secondaryEmail">string</param>
			set
			{
				 this.secondaryEmail=value;

				 this.keyModified["secondary_email"] = 1;

			}
		}

		public string Revenue
		{
			/// <summary>The method to get the revenue</summary>
			/// <returns>string representing the revenue</returns>
			get
			{
				return  this.revenue;

			}
			/// <summary>The method to set the value to revenue</summary>
			/// <param name="revenue">string</param>
			set
			{
				 this.revenue=value;

				 this.keyModified["revenue"] = 1;

			}
		}

		public string YearsInIndustry
		{
			/// <summary>The method to get the yearsInIndustry</summary>
			/// <returns>string representing the yearsInIndustry</returns>
			get
			{
				return  this.yearsInIndustry;

			}
			/// <summary>The method to set the value to yearsInIndustry</summary>
			/// <param name="yearsInIndustry">string</param>
			set
			{
				 this.yearsInIndustry=value;

				 this.keyModified["years_in_industry"] = 1;

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

		public string TechnoGraphicData
		{
			/// <summary>The method to get the technoGraphicData</summary>
			/// <returns>string representing the technoGraphicData</returns>
			get
			{
				return  this.technoGraphicData;

			}
			/// <summary>The method to set the value to technoGraphicData</summary>
			/// <param name="technoGraphicData">string</param>
			set
			{
				 this.technoGraphicData=value;

				 this.keyModified["techno_graphic_data"] = 1;

			}
		}

		public string Logo
		{
			/// <summary>The method to get the logo</summary>
			/// <returns>string representing the logo</returns>
			get
			{
				return  this.logo;

			}
			/// <summary>The method to set the value to logo</summary>
			/// <param name="logo">string</param>
			set
			{
				 this.logo=value;

				 this.keyModified["logo"] = 1;

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

		public List<string> OtherEmails
		{
			/// <summary>The method to get the otherEmails</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.otherEmails;

			}
			/// <summary>The method to set the value to otherEmails</summary>
			/// <param name="otherEmails">Instance of List<string></param>
			set
			{
				 this.otherEmails=value;

				 this.keyModified["other_emails"] = 1;

			}
		}

		public string SignIn
		{
			/// <summary>The method to get the signIn</summary>
			/// <returns>string representing the signIn</returns>
			get
			{
				return  this.signIn;

			}
			/// <summary>The method to set the value to signIn</summary>
			/// <param name="signIn">string</param>
			set
			{
				 this.signIn=value;

				 this.keyModified["sign_in"] = 1;

			}
		}

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

		public List<Address> Address
		{
			/// <summary>The method to get the address</summary>
			/// <returns>Instance of List<Address></returns>
			get
			{
				return  this.address;

			}
			/// <summary>The method to set the value to address</summary>
			/// <param name="address">Instance of List<Address></param>
			set
			{
				 this.address=value;

				 this.keyModified["address"] = 1;

			}
		}

		public string SignUp
		{
			/// <summary>The method to get the signUp</summary>
			/// <returns>string representing the signUp</returns>
			get
			{
				return  this.signUp;

			}
			/// <summary>The method to set the value to signUp</summary>
			/// <param name="signUp">string</param>
			set
			{
				 this.signUp=value;

				 this.keyModified["sign_up"] = 1;

			}
		}

		public string OrgType
		{
			/// <summary>The method to get the orgType</summary>
			/// <returns>string representing the orgType</returns>
			get
			{
				return  this.orgType;

			}
			/// <summary>The method to set the value to orgType</summary>
			/// <param name="orgType">string</param>
			set
			{
				 this.orgType=value;

				 this.keyModified["org_type"] = 1;

			}
		}

		public List<Address> HeadQuarters
		{
			/// <summary>The method to get the headQuarters</summary>
			/// <returns>Instance of List<Address></returns>
			get
			{
				return  this.headQuarters;

			}
			/// <summary>The method to set the value to headQuarters</summary>
			/// <param name="headQuarters">Instance of List<Address></param>
			set
			{
				 this.headQuarters=value;

				 this.keyModified["head_quarters"] = 1;

			}
		}

		public string NoOfEmployees
		{
			/// <summary>The method to get the noOfEmployees</summary>
			/// <returns>string representing the noOfEmployees</returns>
			get
			{
				return  this.noOfEmployees;

			}
			/// <summary>The method to set the value to noOfEmployees</summary>
			/// <param name="noOfEmployees">string</param>
			set
			{
				 this.noOfEmployees=value;

				 this.keyModified["no_of_employees"] = 1;

			}
		}

		public List<string> TerritoryList
		{
			/// <summary>The method to get the territoryList</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.territoryList;

			}
			/// <summary>The method to set the value to territoryList</summary>
			/// <param name="territoryList">Instance of List<string></param>
			set
			{
				 this.territoryList=value;

				 this.keyModified["territory_list"] = 1;

			}
		}

		public string FoundingYear
		{
			/// <summary>The method to get the foundingYear</summary>
			/// <returns>string representing the foundingYear</returns>
			get
			{
				return  this.foundingYear;

			}
			/// <summary>The method to set the value to foundingYear</summary>
			/// <param name="foundingYear">string</param>
			set
			{
				 this.foundingYear=value;

				 this.keyModified["founding_year"] = 1;

			}
		}

		public List<Industry> Industries
		{
			/// <summary>The method to get the industries</summary>
			/// <returns>Instance of List<Industry></returns>
			get
			{
				return  this.industries;

			}
			/// <summary>The method to set the value to industries</summary>
			/// <param name="industries">Instance of List<Industry></param>
			set
			{
				 this.industries=value;

				 this.keyModified["industries"] = 1;

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

		public List<string> BusinessModel
		{
			/// <summary>The method to get the businessModel</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.businessModel;

			}
			/// <summary>The method to set the value to businessModel</summary>
			/// <param name="businessModel">Instance of List<string></param>
			set
			{
				 this.businessModel=value;

				 this.keyModified["business_model"] = 1;

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