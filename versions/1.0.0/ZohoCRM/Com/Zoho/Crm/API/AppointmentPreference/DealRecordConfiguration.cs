using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.AppointmentPreference
{

	public class DealRecordConfiguration : Model
	{
		private Layout layout;
		private List<FieldMappings> fieldMappings;
		private long? id;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Layout Layout
		{
			/// <summary>The method to get the layout</summary>
			/// <returns>Instance of Layout</returns>
			get
			{
				return  this.layout;

			}
			/// <summary>The method to set the value to layout</summary>
			/// <param name="layout">Instance of Layout</param>
			set
			{
				 this.layout=value;

				 this.keyModified["layout"] = 1;

			}
		}

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