using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PickListValues
{

	public class ResponseWrapper : Model, ResponseHandler
	{
		private List<PickListValues> pickListValues;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<PickListValues> PickListValues
		{
			/// <summary>The method to get the pickListValues</summary>
			/// <returns>Instance of List<PickListValues></returns>
			get
			{
				return  this.pickListValues;

			}
			/// <summary>The method to set the value to pickListValues</summary>
			/// <param name="pickListValues">Instance of List<PickListValues></param>
			set
			{
				 this.pickListValues=value;

				 this.keyModified["pick_list_values"] = 1;

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