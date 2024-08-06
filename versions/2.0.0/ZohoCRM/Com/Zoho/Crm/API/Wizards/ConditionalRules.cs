using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Wizards
{

	public class ConditionalRules : Model
	{
		private long? queryId;
		private Choice<string> executeOn;
		private Criteria criteria;
		private List<Actions> actions;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public long? QueryId
		{
			/// <summary>The method to get the queryId</summary>
			/// <returns>long? representing the queryId</returns>
			get
			{
				return  this.queryId;

			}
			/// <summary>The method to set the value to queryId</summary>
			/// <param name="queryId">long?</param>
			set
			{
				 this.queryId=value;

				 this.keyModified["query_id"] = 1;

			}
		}

		public Choice<string> ExecuteOn
		{
			/// <summary>The method to get the executeOn</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.executeOn;

			}
			/// <summary>The method to set the value to executeOn</summary>
			/// <param name="executeOn">Instance of Choice<string></param>
			set
			{
				 this.executeOn=value;

				 this.keyModified["execute_on"] = 1;

			}
		}

		public Criteria Criteria
		{
			/// <summary>The method to get the criteria</summary>
			/// <returns>Instance of Criteria</returns>
			get
			{
				return  this.criteria;

			}
			/// <summary>The method to set the value to criteria</summary>
			/// <param name="criteria">Instance of Criteria</param>
			set
			{
				 this.criteria=value;

				 this.keyModified["criteria"] = 1;

			}
		}

		public List<Actions> Actions
		{
			/// <summary>The method to get the actions</summary>
			/// <returns>Instance of List<Actions></returns>
			get
			{
				return  this.actions;

			}
			/// <summary>The method to set the value to actions</summary>
			/// <param name="actions">Instance of List<Actions></param>
			set
			{
				 this.actions=value;

				 this.keyModified["actions"] = 1;

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