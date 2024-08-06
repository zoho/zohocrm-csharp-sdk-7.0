using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PrivacyPreference
{

	public class Config : Model
	{
		private List<Tpt> tpt;
		private List<Section> section;
		private List<Tpt> zohoInteg;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<Tpt> Tpt
		{
			/// <summary>The method to get the tpt</summary>
			/// <returns>Instance of List<Tpt></returns>
			get
			{
				return  this.tpt;

			}
			/// <summary>The method to set the value to tpt</summary>
			/// <param name="tpt">Instance of List<Tpt></param>
			set
			{
				 this.tpt=value;

				 this.keyModified["tpt"] = 1;

			}
		}

		public List<Section> Section
		{
			/// <summary>The method to get the section</summary>
			/// <returns>Instance of List<Section></returns>
			get
			{
				return  this.section;

			}
			/// <summary>The method to set the value to section</summary>
			/// <param name="section">Instance of List<Section></param>
			set
			{
				 this.section=value;

				 this.keyModified["section"] = 1;

			}
		}

		public List<Tpt> ZohoInteg
		{
			/// <summary>The method to get the zohoInteg</summary>
			/// <returns>Instance of List<Tpt></returns>
			get
			{
				return  this.zohoInteg;

			}
			/// <summary>The method to set the value to zohoInteg</summary>
			/// <param name="zohoInteg">Instance of List<Tpt></param>
			set
			{
				 this.zohoInteg=value;

				 this.keyModified["zoho_integ"] = 1;

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