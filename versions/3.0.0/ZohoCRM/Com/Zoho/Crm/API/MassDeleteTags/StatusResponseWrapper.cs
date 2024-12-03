using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.MassDeleteTags
{

	public class StatusResponseWrapper : Model, StatusResponseHandler
	{
		private List<StatusActionResponse> massDelete;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<StatusActionResponse> MassDelete
		{
			/// <summary>The method to get the massDelete</summary>
			/// <returns>Instance of List<StatusActionResponse></returns>
			get
			{
				return  this.massDelete;

			}
			/// <summary>The method to set the value to massDelete</summary>
			/// <param name="massDelete">Instance of List<StatusActionResponse></param>
			set
			{
				 this.massDelete=value;

				 this.keyModified["mass_delete"] = 1;

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