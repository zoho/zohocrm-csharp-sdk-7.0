using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Wizards
{

	public class Screen : Model
	{
		private string displayLabel;
		private string apiName;
		private long? id;
		private string referenceId;
		private List<ConditionalRules> conditionalRules;
		private List<Segment> segments;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string DisplayLabel
		{
			/// <summary>The method to get the displayLabel</summary>
			/// <returns>string representing the displayLabel</returns>
			get
			{
				return  this.displayLabel;

			}
			/// <summary>The method to set the value to displayLabel</summary>
			/// <param name="displayLabel">string</param>
			set
			{
				 this.displayLabel=value;

				 this.keyModified["display_label"] = 1;

			}
		}

		public string APIName
		{
			/// <summary>The method to get the aPIName</summary>
			/// <returns>string representing the apiName</returns>
			get
			{
				return  this.apiName;

			}
			/// <summary>The method to set the value to aPIName</summary>
			/// <param name="apiName">string</param>
			set
			{
				 this.apiName=value;

				 this.keyModified["api_name"] = 1;

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

		public string ReferenceId
		{
			/// <summary>The method to get the referenceId</summary>
			/// <returns>string representing the referenceId</returns>
			get
			{
				return  this.referenceId;

			}
			/// <summary>The method to set the value to referenceId</summary>
			/// <param name="referenceId">string</param>
			set
			{
				 this.referenceId=value;

				 this.keyModified["reference_id"] = 1;

			}
		}

		public List<ConditionalRules> ConditionalRules
		{
			/// <summary>The method to get the conditionalRules</summary>
			/// <returns>Instance of List<ConditionalRules></returns>
			get
			{
				return  this.conditionalRules;

			}
			/// <summary>The method to set the value to conditionalRules</summary>
			/// <param name="conditionalRules">Instance of List<ConditionalRules></param>
			set
			{
				 this.conditionalRules=value;

				 this.keyModified["conditional_rules"] = 1;

			}
		}

		public List<Segment> Segments
		{
			/// <summary>The method to get the segments</summary>
			/// <returns>Instance of List<Segment></returns>
			get
			{
				return  this.segments;

			}
			/// <summary>The method to set the value to segments</summary>
			/// <param name="segments">Instance of List<Segment></param>
			set
			{
				 this.segments=value;

				 this.keyModified["segments"] = 1;

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