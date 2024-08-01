using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.InventoryMassConvert
{

	public class BodyWrapper : Model
	{
		private List<ConvertTo> convertTo;
		private User assignTo;
		private List<RelatedModules> relatedModules;
		private List<long?> ids;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<ConvertTo> ConvertTo
		{
			/// <summary>The method to get the convertTo</summary>
			/// <returns>Instance of List<ConvertTo></returns>
			get
			{
				return  this.convertTo;

			}
			/// <summary>The method to set the value to convertTo</summary>
			/// <param name="convertTo">Instance of List<ConvertTo></param>
			set
			{
				 this.convertTo=value;

				 this.keyModified["convert_to"] = 1;

			}
		}

		public User AssignTo
		{
			/// <summary>The method to get the assignTo</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.assignTo;

			}
			/// <summary>The method to set the value to assignTo</summary>
			/// <param name="assignTo">Instance of User</param>
			set
			{
				 this.assignTo=value;

				 this.keyModified["assign_to"] = 1;

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

		public List<long?> Ids
		{
			/// <summary>The method to get the ids</summary>
			/// <returns>Instance of List<Long></returns>
			get
			{
				return  this.ids;

			}
			/// <summary>The method to set the value to ids</summary>
			/// <param name="ids">Instance of List<long?></param>
			set
			{
				 this.ids=value;

				 this.keyModified["ids"] = 1;

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