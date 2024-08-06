using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ChangeOwner
{

	public class BodyWrapper : Model
	{
		private Owner owner;
		private bool? notify;
		private List<RelatedModules> relatedModules;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Owner Owner
		{
			/// <summary>The method to get the owner</summary>
			/// <returns>Instance of Owner</returns>
			get
			{
				return  this.owner;

			}
			/// <summary>The method to set the value to owner</summary>
			/// <param name="owner">Instance of Owner</param>
			set
			{
				 this.owner=value;

				 this.keyModified["owner"] = 1;

			}
		}

		public bool? Notify
		{
			/// <summary>The method to get the notify</summary>
			/// <returns>bool? representing the notify</returns>
			get
			{
				return  this.notify;

			}
			/// <summary>The method to set the value to notify</summary>
			/// <param name="notify">bool?</param>
			set
			{
				 this.notify=value;

				 this.keyModified["notify"] = 1;

			}
		}

		public List<RelatedModules> RelatedModules
		{
			/// <summary>The method to get the relatedModules</summary>
			/// <returns>Instance of List<RelatedModules></returns>
			get
			{
				return  this.relatedModules;

			}
			/// <summary>The method to set the value to relatedModules</summary>
			/// <param name="relatedModules">Instance of List<RelatedModules></param>
			set
			{
				 this.relatedModules=value;

				 this.keyModified["related_modules"] = 1;

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