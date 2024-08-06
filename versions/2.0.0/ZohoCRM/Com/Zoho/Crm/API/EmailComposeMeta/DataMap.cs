using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailComposeMeta
{

	public class DataMap : Model
	{
		private User user;
		private FeaturesAvailable featuresAvailable;
		private List<FromAddress> fromAddress;
		private List<string> relayDomains;
		private string mergefieldsdata;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public User User
		{
			/// <summary>The method to get the user</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.user;

			}
			/// <summary>The method to set the value to user</summary>
			/// <param name="user">Instance of User</param>
			set
			{
				 this.user=value;

				 this.keyModified["user"] = 1;

			}
		}

		public FeaturesAvailable FeaturesAvailable
		{
			/// <summary>The method to get the featuresAvailable</summary>
			/// <returns>Instance of FeaturesAvailable</returns>
			get
			{
				return  this.featuresAvailable;

			}
			/// <summary>The method to set the value to featuresAvailable</summary>
			/// <param name="featuresAvailable">Instance of FeaturesAvailable</param>
			set
			{
				 this.featuresAvailable=value;

				 this.keyModified["features_available"] = 1;

			}
		}

		public List<FromAddress> FromAddress
		{
			/// <summary>The method to get the fromAddress</summary>
			/// <returns>Instance of List<FromAddress></returns>
			get
			{
				return  this.fromAddress;

			}
			/// <summary>The method to set the value to fromAddress</summary>
			/// <param name="fromAddress">Instance of List<FromAddress></param>
			set
			{
				 this.fromAddress=value;

				 this.keyModified["from_address"] = 1;

			}
		}

		public List<string> RelayDomains
		{
			/// <summary>The method to get the relayDomains</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.relayDomains;

			}
			/// <summary>The method to set the value to relayDomains</summary>
			/// <param name="relayDomains">Instance of List<string></param>
			set
			{
				 this.relayDomains=value;

				 this.keyModified["relay_domains"] = 1;

			}
		}

		public string Mergefieldsdata
		{
			/// <summary>The method to get the mergefieldsdata</summary>
			/// <returns>string representing the mergefieldsdata</returns>
			get
			{
				return  this.mergefieldsdata;

			}
			/// <summary>The method to set the value to mergefieldsdata</summary>
			/// <param name="mergefieldsdata">string</param>
			set
			{
				 this.mergefieldsdata=value;

				 this.keyModified["mergeFieldsData"] = 1;

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