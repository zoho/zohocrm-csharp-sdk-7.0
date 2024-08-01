using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UsersTerritories
{

	public class ValidationWrapper : Model, ValidationHandler
	{
		private List<ValidationGroup> validateBeforeTransfer;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<ValidationGroup> ValidateBeforeTransfer
		{
			/// <summary>The method to get the validateBeforeTransfer</summary>
			/// <returns>Instance of List<ValidationGroup></returns>
			get
			{
				return  this.validateBeforeTransfer;

			}
			/// <summary>The method to set the value to validateBeforeTransfer</summary>
			/// <param name="validateBeforeTransfer">Instance of List<ValidationGroup></param>
			set
			{
				 this.validateBeforeTransfer=value;

				 this.keyModified["validate_before_transfer"] = 1;

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