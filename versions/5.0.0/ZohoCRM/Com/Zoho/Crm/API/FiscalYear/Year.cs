using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.FiscalYear
{

	public class Year : Model
	{
		private Choice<string> startMonth;
		private Choice<string> displayBasedOn;
		private long? id;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Choice<string> StartMonth
		{
			/// <summary>The method to get the startMonth</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.startMonth;

			}
			/// <summary>The method to set the value to startMonth</summary>
			/// <param name="startMonth">Instance of Choice<string></param>
			set
			{
				 this.startMonth=value;

				 this.keyModified["start_month"] = 1;

			}
		}

		public Choice<string> DisplayBasedOn
		{
			/// <summary>The method to get the displayBasedOn</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.displayBasedOn;

			}
			/// <summary>The method to set the value to displayBasedOn</summary>
			/// <param name="displayBasedOn">Instance of Choice<string></param>
			set
			{
				 this.displayBasedOn=value;

				 this.keyModified["display_based_on"] = 1;

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