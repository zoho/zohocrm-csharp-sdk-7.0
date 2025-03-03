using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Timelines
{

	public class PathFinder : Model
	{
		private bool? processEntry;
		private bool? processExit;
		private State state;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? ProcessEntry
		{
			/// <summary>The method to get the processEntry</summary>
			/// <returns>bool? representing the processEntry</returns>
			get
			{
				return  this.processEntry;

			}
			/// <summary>The method to set the value to processEntry</summary>
			/// <param name="processEntry">bool?</param>
			set
			{
				 this.processEntry=value;

				 this.keyModified["process_entry"] = 1;

			}
		}

		public bool? ProcessExit
		{
			/// <summary>The method to get the processExit</summary>
			/// <returns>bool? representing the processExit</returns>
			get
			{
				return  this.processExit;

			}
			/// <summary>The method to set the value to processExit</summary>
			/// <param name="processExit">bool?</param>
			set
			{
				 this.processExit=value;

				 this.keyModified["process_exit"] = 1;

			}
		}

		public State State
		{
			/// <summary>The method to get the state</summary>
			/// <returns>Instance of State</returns>
			get
			{
				return  this.state;

			}
			/// <summary>The method to set the value to state</summary>
			/// <param name="state">Instance of State</param>
			set
			{
				 this.state=value;

				 this.keyModified["state"] = 1;

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