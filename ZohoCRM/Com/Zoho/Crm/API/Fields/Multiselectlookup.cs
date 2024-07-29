using Com.Zoho.Crm.API.Modules;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Fields
{

	public class Multiselectlookup : Model
	{
		private string displayLabel;
		private Modules.MinifiedModule linkingModule;
		private Modules.MinifiedModule connectedModule;
		private string lookupApiname;
		private string apiName;
		private string connectedfieldApiname;
		private string connectedlookupApiname;
		private long? id;
		private bool? recordAccess;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string DisplayLabel
		{
			/// <summary>The method to get the displayLabel</summary>
			/// <returns>string representing the displayLabel</returns>
			get
			{
				return  this.displayLabel;

			}
			/// <summary>The method to set the value to displayLabel</summary>
			/// <param name="displayLabel">string</param>
			set
			{
				 this.displayLabel=value;

				 this.keyModified["display_label"] = 1;

			}
		}

		public Modules.MinifiedModule LinkingModule
		{
			/// <summary>The method to get the linkingModule</summary>
			/// <returns>Instance of MinifiedModule</returns>
			get
			{
				return  this.linkingModule;

			}
			/// <summary>The method to set the value to linkingModule</summary>
			/// <param name="linkingModule">Instance of MinifiedModule</param>
			set
			{
				 this.linkingModule=value;

				 this.keyModified["linking_module"] = 1;

			}
		}

		public Modules.MinifiedModule ConnectedModule
		{
			/// <summary>The method to get the connectedModule</summary>
			/// <returns>Instance of MinifiedModule</returns>
			get
			{
				return  this.connectedModule;

			}
			/// <summary>The method to set the value to connectedModule</summary>
			/// <param name="connectedModule">Instance of MinifiedModule</param>
			set
			{
				 this.connectedModule=value;

				 this.keyModified["connected_module"] = 1;

			}
		}

		public string LookupApiname
		{
			/// <summary>The method to get the lookupApiname</summary>
			/// <returns>string representing the lookupApiname</returns>
			get
			{
				return  this.lookupApiname;

			}
			/// <summary>The method to set the value to lookupApiname</summary>
			/// <param name="lookupApiname">string</param>
			set
			{
				 this.lookupApiname=value;

				 this.keyModified["lookup_apiname"] = 1;

			}
		}

		public string APIName
		{
			/// <summary>The method to get the aPIName</summary>
			/// <returns>string representing the apiName</returns>
			get
			{
				return  this.apiName;

			}
			/// <summary>The method to set the value to aPIName</summary>
			/// <param name="apiName">string</param>
			set
			{
				 this.apiName=value;

				 this.keyModified["api_name"] = 1;

			}
		}

		public string ConnectedfieldApiname
		{
			/// <summary>The method to get the connectedfieldApiname</summary>
			/// <returns>string representing the connectedfieldApiname</returns>
			get
			{
				return  this.connectedfieldApiname;

			}
			/// <summary>The method to set the value to connectedfieldApiname</summary>
			/// <param name="connectedfieldApiname">string</param>
			set
			{
				 this.connectedfieldApiname=value;

				 this.keyModified["connectedfield_apiname"] = 1;

			}
		}

		public string ConnectedlookupApiname
		{
			/// <summary>The method to get the connectedlookupApiname</summary>
			/// <returns>string representing the connectedlookupApiname</returns>
			get
			{
				return  this.connectedlookupApiname;

			}
			/// <summary>The method to set the value to connectedlookupApiname</summary>
			/// <param name="connectedlookupApiname">string</param>
			set
			{
				 this.connectedlookupApiname=value;

				 this.keyModified["connectedlookup_apiname"] = 1;

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

		public bool? RecordAccess
		{
			/// <summary>The method to get the recordAccess</summary>
			/// <returns>bool? representing the recordAccess</returns>
			get
			{
				return  this.recordAccess;

			}
			/// <summary>The method to set the value to recordAccess</summary>
			/// <param name="recordAccess">bool?</param>
			set
			{
				 this.recordAccess=value;

				 this.keyModified["record_access"] = 1;

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