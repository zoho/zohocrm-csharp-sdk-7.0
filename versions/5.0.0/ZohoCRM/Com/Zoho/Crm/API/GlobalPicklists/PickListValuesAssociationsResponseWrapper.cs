using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.GlobalPicklists
{

	public class PickListValuesAssociationsResponseWrapper : Model, PickListValuesAssociationsResponseHandler
	{
		private List<PickListValuesAssociation> pickListValuesAssociations;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<PickListValuesAssociation> PickListValuesAssociations
		{
			/// <summary>The method to get the pickListValuesAssociations</summary>
			/// <returns>Instance of List<PickListValuesAssociation></returns>
			get
			{
				return  this.pickListValuesAssociations;

			}
			/// <summary>The method to set the value to pickListValuesAssociations</summary>
			/// <param name="pickListValuesAssociations">Instance of List<PickListValuesAssociation></param>
			set
			{
				 this.pickListValuesAssociations=value;

				 this.keyModified["pick_list_values_associations"] = 1;

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