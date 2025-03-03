using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Webforms
{

	public class FormAttributes : Model
	{
		private string color;
		private int? width;
		private FontAttributes fontAttributes;
		private string align;
		private string displayFormName;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Color
		{
			/// <summary>The method to get the color</summary>
			/// <returns>string representing the color</returns>
			get
			{
				return  this.color;

			}
			/// <summary>The method to set the value to color</summary>
			/// <param name="color">string</param>
			set
			{
				 this.color=value;

				 this.keyModified["color"] = 1;

			}
		}

		public int? Width
		{
			/// <summary>The method to get the width</summary>
			/// <returns>int? representing the width</returns>
			get
			{
				return  this.width;

			}
			/// <summary>The method to set the value to width</summary>
			/// <param name="width">int?</param>
			set
			{
				 this.width=value;

				 this.keyModified["width"] = 1;

			}
		}

		public FontAttributes FontAttributes
		{
			/// <summary>The method to get the fontAttributes</summary>
			/// <returns>Instance of FontAttributes</returns>
			get
			{
				return  this.fontAttributes;

			}
			/// <summary>The method to set the value to fontAttributes</summary>
			/// <param name="fontAttributes">Instance of FontAttributes</param>
			set
			{
				 this.fontAttributes=value;

				 this.keyModified["font_attributes"] = 1;

			}
		}

		public string Align
		{
			/// <summary>The method to get the align</summary>
			/// <returns>string representing the align</returns>
			get
			{
				return  this.align;

			}
			/// <summary>The method to set the value to align</summary>
			/// <param name="align">string</param>
			set
			{
				 this.align=value;

				 this.keyModified["align"] = 1;

			}
		}

		public string DisplayFormName
		{
			/// <summary>The method to get the displayFormName</summary>
			/// <returns>string representing the displayFormName</returns>
			get
			{
				return  this.displayFormName;

			}
			/// <summary>The method to set the value to displayFormName</summary>
			/// <param name="displayFormName">string</param>
			set
			{
				 this.displayFormName=value;

				 this.keyModified["display_form_name"] = 1;

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