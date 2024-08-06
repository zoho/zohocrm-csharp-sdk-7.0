using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Users
{

	public class Tab : Model
	{
		private Choice<string> fontColor;
		private Choice<string> background;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Choice<string> FontColor
		{
			/// <summary>The method to get the fontColor</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.fontColor;

			}
			/// <summary>The method to set the value to fontColor</summary>
			/// <param name="fontColor">Instance of Choice<string></param>
			set
			{
				 this.fontColor=value;

				 this.keyModified["font_color"] = 1;

			}
		}

		public Choice<string> Background
		{
			/// <summary>The method to get the background</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.background;

			}
			/// <summary>The method to set the value to background</summary>
			/// <param name="background">Instance of Choice<string></param>
			set
			{
				 this.background=value;

				 this.keyModified["background"] = 1;

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