using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailSharingDetails
{

	public class EmailSharings : Model
	{
		private List<ShareFromUser> shareFromUsers;
		private List<string> availableTypes;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<ShareFromUser> ShareFromUsers
		{
			/// <summary>The method to get the shareFromUsers</summary>
			/// <returns>Instance of List<ShareFromUser></returns>
			get
			{
				return  this.shareFromUsers;

			}
			/// <summary>The method to set the value to shareFromUsers</summary>
			/// <param name="shareFromUsers">Instance of List<ShareFromUser></param>
			set
			{
				 this.shareFromUsers=value;

				 this.keyModified["share_from_users"] = 1;

			}
		}

		public List<string> AvailableTypes
		{
			/// <summary>The method to get the availableTypes</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.availableTypes;

			}
			/// <summary>The method to set the value to availableTypes</summary>
			/// <param name="availableTypes">Instance of List<string></param>
			set
			{
				 this.availableTypes=value;

				 this.keyModified["available_types"] = 1;

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