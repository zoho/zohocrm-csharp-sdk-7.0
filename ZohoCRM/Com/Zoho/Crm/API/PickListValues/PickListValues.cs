using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PickListValues
{

	public class PickListValues : Model
	{
		private int? sequenceNumber;
		private string displayValue;
		private string referenceValue;
		private string colourCode;
		private string actualValue;
		private long? id;
		private string type;
		private List<LayoutAssociation> layoutAssociations;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public string ReferenceValue
		{
			/// <summary>The method to get the referenceValue</summary>
			/// <returns>string representing the referenceValue</returns>
			get
			{
				return  this.referenceValue;

			}
			/// <summary>The method to set the value to referenceValue</summary>
			/// <param name="referenceValue">string</param>
			set
			{
				 this.referenceValue=value;

				 this.keyModified["reference_value"] = 1;

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

		public List<LayoutAssociation> LayoutAssociations
		{
			/// <summary>The method to get the layoutAssociations</summary>
			/// <returns>Instance of List<LayoutAssociation></returns>
			get
			{
				return  this.layoutAssociations;

			}
			/// <summary>The method to set the value to layoutAssociations</summary>
			/// <param name="layoutAssociations">Instance of List<LayoutAssociation></param>
			set
			{
				 this.layoutAssociations=value;

				 this.keyModified["layout_associations"] = 1;

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