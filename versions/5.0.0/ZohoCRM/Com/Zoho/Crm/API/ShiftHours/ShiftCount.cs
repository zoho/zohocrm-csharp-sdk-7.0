using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ShiftHours
{

	public class ShiftCount : Model
	{
		private int? totalShiftWithUser;
		private int? totalShift;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public int? TotalShiftWithUser
		{
			/// <summary>The method to get the totalShiftWithUser</summary>
			/// <returns>int? representing the totalShiftWithUser</returns>
			get
			{
				return  this.totalShiftWithUser;

			}
			/// <summary>The method to set the value to totalShiftWithUser</summary>
			/// <param name="totalShiftWithUser">int?</param>
			set
			{
				 this.totalShiftWithUser=value;

				 this.keyModified["total_shift_with_user"] = 1;

			}
		}

		public int? TotalShift
		{
			/// <summary>The method to get the totalShift</summary>
			/// <returns>int? representing the totalShift</returns>
			get
			{
				return  this.totalShift;

			}
			/// <summary>The method to set the value to totalShift</summary>
			/// <param name="totalShift">int?</param>
			set
			{
				 this.totalShift=value;

				 this.keyModified["total_shift"] = 1;

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