using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ScoringRules
{

	public class SignalRule : Model
	{
		private int? score;
		private Signal signal;
		private string id;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

				 this.keyModified["score"] = 1;

			}
		}

		public Signal Signal
		{
			/// <summary>The method to get the signal</summary>
			/// <returns>Instance of Signal</returns>
			get
			{
				return  this.signal;

			}
			/// <summary>The method to set the value to signal</summary>
			/// <param name="signal">Instance of Signal</param>
			set
			{
				 this.signal=value;

				 this.keyModified["signal"] = 1;

			}
		}

		public string Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>string representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">string</param>
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