using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ScoringRules
{

	public class BodyWrapper : Model
	{
		private List<ScoringRule> scoringRules;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<ScoringRule> ScoringRules
		{
			/// <summary>The method to get the scoringRules</summary>
			/// <returns>Instance of List<ScoringRule></returns>
			get
			{
				return  this.scoringRules;

			}
			/// <summary>The method to set the value to scoringRules</summary>
			/// <param name="scoringRules">Instance of List<ScoringRule></param>
			set
			{
				 this.scoringRules=value;

				 this.keyModified["scoring_rules"] = 1;

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