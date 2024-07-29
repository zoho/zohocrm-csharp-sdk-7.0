using Com.Zoho.Crm.API.Fields;
using Com.Zoho.Crm.API.Profiles;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Wizards
{

	public class Actions : Model
	{
		private long? id;
		private string type;
		private Segment segment;
		private Fields.Fields fields;
		private Fields.Fields field;
		private object value;
		private List<Profiles.Profile> exemptedProfiles;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public string Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>string representing the type</returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">string</param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

		public Segment Segment
		{
			/// <summary>The method to get the segment</summary>
			/// <returns>Instance of Segment</returns>
			get
			{
				return  this.segment;

			}
			/// <summary>The method to set the value to segment</summary>
			/// <param name="segment">Instance of Segment</param>
			set
			{
				 this.segment=value;

				 this.keyModified["segment"] = 1;

			}
		}

		public Fields.Fields Fields
		{
			/// <summary>The method to get the fields</summary>
			/// <returns>Instance of Fields</returns>
			get
			{
				return  this.fields;

			}
			/// <summary>The method to set the value to fields</summary>
			/// <param name="fields">Instance of Fields</param>
			set
			{
				 this.fields=value;

				 this.keyModified["fields"] = 1;

			}
		}

		public Fields.Fields Field
		{
			/// <summary>The method to get the field</summary>
			/// <returns>Instance of Fields</returns>
			get
			{
				return  this.field;

			}
			/// <summary>The method to set the value to field</summary>
			/// <param name="field">Instance of Fields</param>
			set
			{
				 this.field=value;

				 this.keyModified["field"] = 1;

			}
		}

		public object Value
		{
			/// <summary>The method to get the value</summary>
			/// <returns>object representing the value</returns>
			get
			{
				return  this.value;

			}
			/// <summary>The method to set the value to value</summary>
			/// <param name="value">object</param>
			set
			{
				 this.value=value;

				 this.keyModified["value"] = 1;

			}
		}

		public List<Profiles.Profile> ExemptedProfiles
		{
			/// <summary>The method to get the exemptedProfiles</summary>
			/// <returns>Instance of List<Profile></returns>
			get
			{
				return  this.exemptedProfiles;

			}
			/// <summary>The method to set the value to exemptedProfiles</summary>
			/// <param name="exemptedProfiles">Instance of List<Profile></param>
			set
			{
				 this.exemptedProfiles=value;

				 this.keyModified["exempted_profiles"] = 1;

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