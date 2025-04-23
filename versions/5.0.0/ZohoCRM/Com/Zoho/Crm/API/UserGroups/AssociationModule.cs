using Com.Zoho.Crm.API.Modules;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserGroups
{

	public class AssociationModule : Model
	{
		private Modules.MinifiedModule module;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Modules.MinifiedModule Module
		{
			/// <summary>The method to get the module</summary>
			/// <returns>Instance of MinifiedModule</returns>
			get
			{
				return  this.module;

			}
			/// <summary>The method to set the value to module</summary>
			/// <param name="module">Instance of MinifiedModule</param>
			set
			{
				 this.module=value;

				 this.keyModified["module"] = 1;

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