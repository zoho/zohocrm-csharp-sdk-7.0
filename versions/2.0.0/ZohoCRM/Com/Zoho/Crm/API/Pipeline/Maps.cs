using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Pipeline
{

	public class Maps : Model
	{
		private string displayValue;
		private int? sequenceNumber;
		private ForecastCategory forecastCategory;
		private bool? delete;
		private string actualValue;
		private long? id;
		private string colourCode;
		private string forecastType;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string DisplayValue
		{
			/// <summary>The method to get the displayValue</summary>
			/// <returns>string representing the displayValue</returns>
			get
			{
				return  this.displayValue;

			}
			/// <summary>The method to set the value to displayValue</summary>
			/// <param name="displayValue">string</param>
			set
			{
				 this.displayValue=value;

				 this.keyModified["display_value"] = 1;

			}
		}

		public int? SequenceNumber
		{
			/// <summary>The method to get the sequenceNumber</summary>
			/// <returns>int? representing the sequenceNumber</returns>
			get
			{
				return  this.sequenceNumber;

			}
			/// <summary>The method to set the value to sequenceNumber</summary>
			/// <param name="sequenceNumber">int?</param>
			set
			{
				 this.sequenceNumber=value;

				 this.keyModified["sequence_number"] = 1;

			}
		}

		public ForecastCategory ForecastCategory
		{
			/// <summary>The method to get the forecastCategory</summary>
			/// <returns>Instance of ForecastCategory</returns>
			get
			{
				return  this.forecastCategory;

			}
			/// <summary>The method to set the value to forecastCategory</summary>
			/// <param name="forecastCategory">Instance of ForecastCategory</param>
			set
			{
				 this.forecastCategory=value;

				 this.keyModified["forecast_category"] = 1;

			}
		}

		public bool? Delete
		{
			/// <summary>The method to get the delete</summary>
			/// <returns>bool? representing the delete</returns>
			get
			{
				return  this.delete;

			}
			/// <summary>The method to set the value to delete</summary>
			/// <param name="delete">bool?</param>
			set
			{
				 this.delete=value;

				 this.keyModified["_delete"] = 1;

			}
		}

		public string ActualValue
		{
			/// <summary>The method to get the actualValue</summary>
			/// <returns>string representing the actualValue</returns>
			get
			{
				return  this.actualValue;

			}
			/// <summary>The method to set the value to actualValue</summary>
			/// <param name="actualValue">string</param>
			set
			{
				 this.actualValue=value;

				 this.keyModified["actual_value"] = 1;

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

		public string ColourCode
		{
			/// <summary>The method to get the colourCode</summary>
			/// <returns>string representing the colourCode</returns>
			get
			{
				return  this.colourCode;

			}
			/// <summary>The method to set the value to colourCode</summary>
			/// <param name="colourCode">string</param>
			set
			{
				 this.colourCode=value;

				 this.keyModified["colour_code"] = 1;

			}
		}

		public string ForecastType
		{
			/// <summary>The method to get the forecastType</summary>
			/// <returns>string representing the forecastType</returns>
			get
			{
				return  this.forecastType;

			}
			/// <summary>The method to set the value to forecastType</summary>
			/// <param name="forecastType">string</param>
			set
			{
				 this.forecastType=value;

				 this.keyModified["forecast_type"] = 1;

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