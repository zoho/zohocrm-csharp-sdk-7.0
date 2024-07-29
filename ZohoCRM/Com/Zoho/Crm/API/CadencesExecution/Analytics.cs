using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.CadencesExecution
{

	public class Analytics : Model
	{
		private Dictionary<string, object> analytics;
		private ParentFollowUp parentFollowUp;
		private Action action;
		private long? id;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Dictionary<string, object> Analytics_1
		{
			/// <summary>The method to get the analytics</summary>
			/// <returns>Dictionary representing the analytics<String,Object></returns>
			get
			{
				return  this.analytics;

			}
			/// <summary>The method to set the value to analytics</summary>
			/// <param name="analytics">Dictionary<string,object></param>
			set
			{
				 this.analytics=value;

				 this.keyModified["analytics"] = 1;

			}
		}

		public ParentFollowUp ParentFollowUp
		{
			/// <summary>The method to get the parentFollowUp</summary>
			/// <returns>Instance of ParentFollowUp</returns>
			get
			{
				return  this.parentFollowUp;

			}
			/// <summary>The method to set the value to parentFollowUp</summary>
			/// <param name="parentFollowUp">Instance of ParentFollowUp</param>
			set
			{
				 this.parentFollowUp=value;

				 this.keyModified["parent_follow_up"] = 1;

			}
		}

		public Action Action
		{
			/// <summary>The method to get the action</summary>
			/// <returns>Instance of Action</returns>
			get
			{
				return  this.action;

			}
			/// <summary>The method to set the value to action</summary>
			/// <param name="action">Instance of Action</param>
			set
			{
				 this.action=value;

				 this.keyModified[Constants.REQUEST_CATEGORY_ACTION] = 1;

			}
		}

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