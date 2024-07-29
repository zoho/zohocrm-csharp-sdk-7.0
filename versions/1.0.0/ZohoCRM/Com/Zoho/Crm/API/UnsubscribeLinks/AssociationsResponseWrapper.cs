using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UnsubscribeLinks
{

	public class AssociationsResponseWrapper : Model, AssociationsResponseHandler
	{
		private List<AssociationDetails> associations;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<AssociationDetails> Associations
		{
			/// <summary>The method to get the associations</summary>
			/// <returns>Instance of List<AssociationDetails></returns>
			get
			{
				return  this.associations;

			}
			/// <summary>The method to set the value to associations</summary>
			/// <param name="associations">Instance of List<AssociationDetails></param>
			set
			{
				 this.associations=value;

				 this.keyModified["associations"] = 1;

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