using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.RescheduleHistory
{

	public class Approval : Model
	{
		private bool? delegate1;
		private bool? approve;
		private bool? reject;
		private bool? resubmit;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? Delegate
		{
			/// <summary>The method to get the delegate</summary>
			/// <returns>bool? representing the delegate1</returns>
			get
			{
				return  this.delegate1;

			}
			/// <summary>The method to set the value to delegate</summary>
			/// <param name="delegate1">bool?</param>
			set
			{
				 this.delegate1=value;

				 this.keyModified["delegate"] = 1;

			}
		}

		public bool? Approve
		{
			/// <summary>The method to get the approve</summary>
			/// <returns>bool? representing the approve</returns>
			get
			{
				return  this.approve;

			}
			/// <summary>The method to set the value to approve</summary>
			/// <param name="approve">bool?</param>
			set
			{
				 this.approve=value;

				 this.keyModified["approve"] = 1;

			}
		}

		public bool? Reject
		{
			/// <summary>The method to get the reject</summary>
			/// <returns>bool? representing the reject</returns>
			get
			{
				return  this.reject;

			}
			/// <summary>The method to set the value to reject</summary>
			/// <param name="reject">bool?</param>
			set
			{
				 this.reject=value;

				 this.keyModified["reject"] = 1;

			}
		}

		public bool? Resubmit
		{
			/// <summary>The method to get the resubmit</summary>
			/// <returns>bool? representing the resubmit</returns>
			get
			{
				return  this.resubmit;

			}
			/// <summary>The method to set the value to resubmit</summary>
			/// <param name="resubmit">bool?</param>
			set
			{
				 this.resubmit=value;

				 this.keyModified["resubmit"] = 1;

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