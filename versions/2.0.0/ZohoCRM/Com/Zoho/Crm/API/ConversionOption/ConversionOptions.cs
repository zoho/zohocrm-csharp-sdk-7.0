using Com.Zoho.Crm.API.Modules;
using Com.Zoho.Crm.API.Record;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ConversionOption
{

	public class ConversionOptions : Model
	{
		private Modules.Modules modulePreference;
		private List<Record.Record> contacts;
		private List<Record.Record> deals;
		private List<Record.Record> accounts;
		private PreferenceFieldMatchedValue preferenceFieldMatchedValue;
		private List<Modules.Modules> modulesWithMultipleLayouts;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Modules.Modules ModulePreference
		{
			/// <summary>The method to get the modulePreference</summary>
			/// <returns>Instance of Modules</returns>
			get
			{
				return  this.modulePreference;

			}
			/// <summary>The method to set the value to modulePreference</summary>
			/// <param name="modulePreference">Instance of Modules</param>
			set
			{
				 this.modulePreference=value;

				 this.keyModified["module_preference"] = 1;

			}
		}

		public List<Record.Record> Contacts
		{
			/// <summary>The method to get the contacts</summary>
			/// <returns>Instance of List<Record></returns>
			get
			{
				return  this.contacts;

			}
			/// <summary>The method to set the value to contacts</summary>
			/// <param name="contacts">Instance of List<Record></param>
			set
			{
				 this.contacts=value;

				 this.keyModified["Contacts"] = 1;

			}
		}

		public List<Record.Record> Deals
		{
			/// <summary>The method to get the deals</summary>
			/// <returns>Instance of List<Record></returns>
			get
			{
				return  this.deals;

			}
			/// <summary>The method to set the value to deals</summary>
			/// <param name="deals">Instance of List<Record></param>
			set
			{
				 this.deals=value;

				 this.keyModified["Deals"] = 1;

			}
		}

		public List<Record.Record> Accounts
		{
			/// <summary>The method to get the accounts</summary>
			/// <returns>Instance of List<Record></returns>
			get
			{
				return  this.accounts;

			}
			/// <summary>The method to set the value to accounts</summary>
			/// <param name="accounts">Instance of List<Record></param>
			set
			{
				 this.accounts=value;

				 this.keyModified["Accounts"] = 1;

			}
		}

		public PreferenceFieldMatchedValue PreferenceFieldMatchedValue
		{
			/// <summary>The method to get the preferenceFieldMatchedValue</summary>
			/// <returns>Instance of PreferenceFieldMatchedValue</returns>
			get
			{
				return  this.preferenceFieldMatchedValue;

			}
			/// <summary>The method to set the value to preferenceFieldMatchedValue</summary>
			/// <param name="preferenceFieldMatchedValue">Instance of PreferenceFieldMatchedValue</param>
			set
			{
				 this.preferenceFieldMatchedValue=value;

				 this.keyModified["preference_field_matched_value"] = 1;

			}
		}

		public List<Modules.Modules> ModulesWithMultipleLayouts
		{
			/// <summary>The method to get the modulesWithMultipleLayouts</summary>
			/// <returns>Instance of List<Modules></returns>
			get
			{
				return  this.modulesWithMultipleLayouts;

			}
			/// <summary>The method to set the value to modulesWithMultipleLayouts</summary>
			/// <param name="modulesWithMultipleLayouts">Instance of List<Modules></param>
			set
			{
				 this.modulesWithMultipleLayouts=value;

				 this.keyModified["modules_with_multiple_layouts"] = 1;

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