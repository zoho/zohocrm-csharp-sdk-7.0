using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PrivacyPreference
{

	public class Tpt : Model
	{
		private string isenabled;
		private string name;
		private string issupported;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Isenabled
		{
			/// <summary>The method to get the isenabled</summary>
			/// <returns>string representing the isenabled</returns>
			get
			{
				return  this.isenabled;

			}
			/// <summary>The method to set the value to isenabled</summary>
			/// <param name="isenabled">string</param>
			set
			{
				 this.isenabled=value;

				 this.keyModified["isEnabled"] = 1;

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

		public string Issupported
		{
			/// <summary>The method to get the issupported</summary>
			/// <returns>string representing the issupported</returns>
			get
			{
				return  this.issupported;

			}
			/// <summary>The method to set the value to issupported</summary>
			/// <param name="issupported">string</param>
			set
			{
				 this.issupported=value;

				 this.keyModified["isSupported"] = 1;

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