using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UnsubscribeLinks
{

	public class AssociationDetails : Model
	{
		private long? id;
		private List<AssociatedPlaces> associatedPlaces;
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

		public List<AssociatedPlaces> AssociatedPlaces
		{
			/// <summary>The method to get the associatedPlaces</summary>
			/// <returns>Instance of List<AssociatedPlaces></returns>
			get
			{
				return  this.associatedPlaces;

			}
			/// <summary>The method to set the value to associatedPlaces</summary>
			/// <param name="associatedPlaces">Instance of List<AssociatedPlaces></param>
			set
			{
				 this.associatedPlaces=value;

				 this.keyModified["associated_places"] = 1;

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