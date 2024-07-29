using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Wizards
{

	public class ButtonBackground : Model
	{
		private List<string> buttonBackground;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<string> ButtonBackground_1
		{
			/// <summary>The method to get the buttonBackground</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.buttonBackground;

			}
			/// <summary>The method to set the value to buttonBackground</summary>
			/// <param name="buttonBackground">Instance of List<string></param>
			set
			{
				 this.buttonBackground=value;

				 this.keyModified["button_background"] = 1;

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