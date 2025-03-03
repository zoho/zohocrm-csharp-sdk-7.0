using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.MassDeleteCvid
{

	public class CvidBodyWrapper : Model
	{
		private long? cvid;
		private Territory territory;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public long? Cvid
		{
			/// <summary>The method to get the cvid</summary>
			/// <returns>long? representing the cvid</returns>
			get
			{
				return  this.cvid;

			}
			/// <summary>The method to set the value to cvid</summary>
			/// <param name="cvid">long?</param>
			set
			{
				 this.cvid=value;

				 this.keyModified["cvid"] = 1;

			}
		}

		public Territory Territory
		{
			/// <summary>The method to get the territory</summary>
			/// <returns>Instance of Territory</returns>
			get
			{
				return  this.territory;

			}
			/// <summary>The method to set the value to territory</summary>
			/// <param name="territory">Instance of Territory</param>
			set
			{
				 this.territory=value;

				 this.keyModified["territory"] = 1;

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