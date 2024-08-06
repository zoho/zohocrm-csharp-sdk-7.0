using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.DuplicateCheckPreference
{

	public class FieldMappings : Model
	{
		private CurrentField currentField;
		private MappedField mappedField;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public CurrentField CurrentField
		{
			/// <summary>The method to get the currentField</summary>
			/// <returns>Instance of CurrentField</returns>
			get
			{
				return  this.currentField;

			}
			/// <summary>The method to set the value to currentField</summary>
			/// <param name="currentField">Instance of CurrentField</param>
			set
			{
				 this.currentField=value;

				 this.keyModified["current_field"] = 1;

			}
		}

		public MappedField MappedField
		{
			/// <summary>The method to get the mappedField</summary>
			/// <returns>Instance of MappedField</returns>
			get
			{
				return  this.mappedField;

			}
			/// <summary>The method to set the value to mappedField</summary>
			/// <param name="mappedField">Instance of MappedField</param>
			set
			{
				 this.mappedField=value;

				 this.keyModified["mapped_field"] = 1;

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