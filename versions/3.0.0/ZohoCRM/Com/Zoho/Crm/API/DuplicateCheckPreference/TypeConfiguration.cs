using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.DuplicateCheckPreference
{

	public class TypeConfiguration : Model
	{
		private List<FieldMappings> fieldMappings;
		private MappedModule mappedModule;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<FieldMappings> FieldMappings
		{
			/// <summary>The method to get the fieldMappings</summary>
			/// <returns>Instance of List<FieldMappings></returns>
			get
			{
				return  this.fieldMappings;

			}
			/// <summary>The method to set the value to fieldMappings</summary>
			/// <param name="fieldMappings">Instance of List<FieldMappings></param>
			set
			{
				 this.fieldMappings=value;

				 this.keyModified["field_mappings"] = 1;

			}
		}

		public MappedModule MappedModule
		{
			/// <summary>The method to get the mappedModule</summary>
			/// <returns>Instance of MappedModule</returns>
			get
			{
				return  this.mappedModule;

			}
			/// <summary>The method to set the value to mappedModule</summary>
			/// <param name="mappedModule">Instance of MappedModule</param>
			set
			{
				 this.mappedModule=value;

				 this.keyModified["mapped_module"] = 1;

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