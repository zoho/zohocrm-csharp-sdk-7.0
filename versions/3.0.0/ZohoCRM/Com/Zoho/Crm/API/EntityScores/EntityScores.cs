using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EntityScores
{

	public class EntityScores : Model
	{
		private Entity entity;
		private int? positiveScore;
		private int? touchPointScore;
		private int? score;
		private int? negativeScore;
		private int? touchPointNegativeScore;
		private ScoringRule scoringRule;
		private List<string> fieldStates;
		private long? id;
		private bool? ziaVisions;
		private int? touchPointPositiveScore;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Entity Entity
		{
			/// <summary>The method to get the entity</summary>
			/// <returns>Instance of Entity</returns>
			get
			{
				return  this.entity;

			}
			/// <summary>The method to set the value to entity</summary>
			/// <param name="entity">Instance of Entity</param>
			set
			{
				 this.entity=value;

				 this.keyModified["Entity"] = 1;

			}
		}

		public int? PositiveScore
		{
			/// <summary>The method to get the positiveScore</summary>
			/// <returns>int? representing the positiveScore</returns>
			get
			{
				return  this.positiveScore;

			}
			/// <summary>The method to set the value to positiveScore</summary>
			/// <param name="positiveScore">int?</param>
			set
			{
				 this.positiveScore=value;

				 this.keyModified["Positive_Score"] = 1;

			}
		}

		public int? TouchPointScore
		{
			/// <summary>The method to get the touchPointScore</summary>
			/// <returns>int? representing the touchPointScore</returns>
			get
			{
				return  this.touchPointScore;

			}
			/// <summary>The method to set the value to touchPointScore</summary>
			/// <param name="touchPointScore">int?</param>
			set
			{
				 this.touchPointScore=value;

				 this.keyModified["Touch_Point_Score"] = 1;

			}
		}

		public int? Score
		{
			/// <summary>The method to get the score</summary>
			/// <returns>int? representing the score</returns>
			get
			{
				return  this.score;

			}
			/// <summary>The method to set the value to score</summary>
			/// <param name="score">int?</param>
			set
			{
				 this.score=value;

				 this.keyModified["Score"] = 1;

			}
		}

		public int? NegativeScore
		{
			/// <summary>The method to get the negativeScore</summary>
			/// <returns>int? representing the negativeScore</returns>
			get
			{
				return  this.negativeScore;

			}
			/// <summary>The method to set the value to negativeScore</summary>
			/// <param name="negativeScore">int?</param>
			set
			{
				 this.negativeScore=value;

				 this.keyModified["Negative_Score"] = 1;

			}
		}

		public int? TouchPointNegativeScore
		{
			/// <summary>The method to get the touchPointNegativeScore</summary>
			/// <returns>int? representing the touchPointNegativeScore</returns>
			get
			{
				return  this.touchPointNegativeScore;

			}
			/// <summary>The method to set the value to touchPointNegativeScore</summary>
			/// <param name="touchPointNegativeScore">int?</param>
			set
			{
				 this.touchPointNegativeScore=value;

				 this.keyModified["Touch_Point_Negative_Score"] = 1;

			}
		}

		public ScoringRule ScoringRule
		{
			/// <summary>The method to get the scoringRule</summary>
			/// <returns>Instance of ScoringRule</returns>
			get
			{
				return  this.scoringRule;

			}
			/// <summary>The method to set the value to scoringRule</summary>
			/// <param name="scoringRule">Instance of ScoringRule</param>
			set
			{
				 this.scoringRule=value;

				 this.keyModified["Scoring_Rule"] = 1;

			}
		}

		public List<string> FieldStates
		{
			/// <summary>The method to get the fieldStates</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.fieldStates;

			}
			/// <summary>The method to set the value to fieldStates</summary>
			/// <param name="fieldStates">Instance of List<string></param>
			set
			{
				 this.fieldStates=value;

				 this.keyModified["$field_states"] = 1;

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

		public bool? ZiaVisions
		{
			/// <summary>The method to get the ziaVisions</summary>
			/// <returns>bool? representing the ziaVisions</returns>
			get
			{
				return  this.ziaVisions;

			}
			/// <summary>The method to set the value to ziaVisions</summary>
			/// <param name="ziaVisions">bool?</param>
			set
			{
				 this.ziaVisions=value;

				 this.keyModified["$zia_visions"] = 1;

			}
		}

		public int? TouchPointPositiveScore
		{
			/// <summary>The method to get the touchPointPositiveScore</summary>
			/// <returns>int? representing the touchPointPositiveScore</returns>
			get
			{
				return  this.touchPointPositiveScore;

			}
			/// <summary>The method to set the value to touchPointPositiveScore</summary>
			/// <param name="touchPointPositiveScore">int?</param>
			set
			{
				 this.touchPointPositiveScore=value;

				 this.keyModified["Touch_Point_Positive_Score"] = 1;

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