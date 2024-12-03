using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Fields
{

	public class PickListValue : Model
	{
		private string colourCode;
		private string actualValue;
		private Choice<string> type;
		private long? id;
		private int? sequenceNumber;
		private string displayValue;
		private int? probability;
		private ForecastCategory forecastCategory;
		private string expectedDataType;
		private string sysRefName;
		private string forecastType;
		private List<Maps> maps;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public Choice<string> Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">Instance of Choice<string></param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

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

		public int? Probability
		{
			/// <summary>The method to get the probability</summary>
			/// <returns>int? representing the probability</returns>
			get
			{
				return  this.probability;

			}
			/// <summary>The method to set the value to probability</summary>
			/// <param name="probability">int?</param>
			set
			{
				 this.probability=value;

				 this.keyModified["probability"] = 1;

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

		public string ExpectedDataType
		{
			/// <summary>The method to get the expectedDataType</summary>
			/// <returns>string representing the expectedDataType</returns>
			get
			{
				return  this.expectedDataType;

			}
			/// <summary>The method to set the value to expectedDataType</summary>
			/// <param name="expectedDataType">string</param>
			set
			{
				 this.expectedDataType=value;

				 this.keyModified["expected_data_type"] = 1;

			}
		}

		public string SysRefName
		{
			/// <summary>The method to get the sysRefName</summary>
			/// <returns>string representing the sysRefName</returns>
			get
			{
				return  this.sysRefName;

			}
			/// <summary>The method to set the value to sysRefName</summary>
			/// <param name="sysRefName">string</param>
			set
			{
				 this.sysRefName=value;

				 this.keyModified["sys_ref_name"] = 1;

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

		public List<Maps> Maps
		{
			/// <summary>The method to get the maps</summary>
			/// <returns>Instance of List<Maps></returns>
			get
			{
				return  this.maps;

			}
			/// <summary>The method to set the value to maps</summary>
			/// <param name="maps">Instance of List<Maps></param>
			set
			{
				 this.maps=value;

				 this.keyModified["maps"] = 1;

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