using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Wizards
{

	public class Connection : Model
	{
		private Button sourceButton;
		private Screen targetScreen;
		private long? id;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Button SourceButton
		{
			/// <summary>The method to get the sourceButton</summary>
			/// <returns>Instance of Button</returns>
			get
			{
				return  this.sourceButton;

			}
			/// <summary>The method to set the value to sourceButton</summary>
			/// <param name="sourceButton">Instance of Button</param>
			set
			{
				 this.sourceButton=value;

				 this.keyModified["source_button"] = 1;

			}
		}

		public Screen TargetScreen
		{
			/// <summary>The method to get the targetScreen</summary>
			/// <returns>Instance of Screen</returns>
			get
			{
				return  this.targetScreen;

			}
			/// <summary>The method to set the value to targetScreen</summary>
			/// <param name="targetScreen">Instance of Screen</param>
			set
			{
				 this.targetScreen=value;

				 this.keyModified["target_screen"] = 1;

			}
		}

		public long? Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>long? representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">long?</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

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