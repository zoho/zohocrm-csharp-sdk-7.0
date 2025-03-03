using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.DuplicateCheckPreference
{

	public class DuplicateCheckPreference : Model
	{
		private Choice<string> type;
		private List<TypeConfiguration> typeConfigurations;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Choice<string> Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">Instance of Choice<string></param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

		public List<TypeConfiguration> TypeConfigurations
		{
			/// <summary>The method to get the typeConfigurations</summary>
			/// <returns>Instance of List<TypeConfiguration></returns>
			get
			{
				return  this.typeConfigurations;

			}
			/// <summary>The method to set the value to typeConfigurations</summary>
			/// <param name="typeConfigurations">Instance of List<TypeConfiguration></param>
			set
			{
				 this.typeConfigurations=value;

				 this.keyModified["type_configurations"] = 1;

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