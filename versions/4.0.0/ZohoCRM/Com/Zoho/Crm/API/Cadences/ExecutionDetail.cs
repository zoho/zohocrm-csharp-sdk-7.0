using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Cadences
{

	public class ExecutionDetail : Model
	{
		private UnenrollProperty unenrollProperties;
		private string endDate;
		private bool? automaticUnenroll;
		private string type;
		private ExecuteEvery executeEvery;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public UnenrollProperty UnenrollProperties
		{
			/// <summary>The method to get the unenrollProperties</summary>
			/// <returns>Instance of UnenrollProperty</returns>
			get
			{
				return  this.unenrollProperties;

			}
			/// <summary>The method to set the value to unenrollProperties</summary>
			/// <param name="unenrollProperties">Instance of UnenrollProperty</param>
			set
			{
				 this.unenrollProperties=value;

				 this.keyModified["unenroll_properties"] = 1;

			}
		}

		public string EndDate
		{
			/// <summary>The method to get the endDate</summary>
			/// <returns>string representing the endDate</returns>
			get
			{
				return  this.endDate;

			}
			/// <summary>The method to set the value to endDate</summary>
			/// <param name="endDate">string</param>
			set
			{
				 this.endDate=value;

				 this.keyModified["end_date"] = 1;

			}
		}

		public bool? AutomaticUnenroll
		{
			/// <summary>The method to get the automaticUnenroll</summary>
			/// <returns>bool? representing the automaticUnenroll</returns>
			get
			{
				return  this.automaticUnenroll;

			}
			/// <summary>The method to set the value to automaticUnenroll</summary>
			/// <param name="automaticUnenroll">bool?</param>
			set
			{
				 this.automaticUnenroll=value;

				 this.keyModified["automatic_unenroll"] = 1;

			}
		}

		public string Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>string representing the type</returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">string</param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

		public ExecuteEvery ExecuteEvery
		{
			/// <summary>The method to get the executeEvery</summary>
			/// <returns>Instance of ExecuteEvery</returns>
			get
			{
				return  this.executeEvery;

			}
			/// <summary>The method to set the value to executeEvery</summary>
			/// <param name="executeEvery">Instance of ExecuteEvery</param>
			set
			{
				 this.executeEvery=value;

				 this.keyModified["execute_every"] = 1;

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