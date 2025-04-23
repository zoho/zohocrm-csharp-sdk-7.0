using Com.Zoho.Crm.API.Fields;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Wizards
{

	public class Segment : Model
	{
		private int? sequenceNumber;
		private string displayLabel;
		private int? columnCount;
		private long? id;
		private string type;
		private List<Fields.Fields> fields;
		private List<Button> buttons;
		private List<Element> elements;
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

		public int? ColumnCount
		{
			/// <summary>The method to get the columnCount</summary>
			/// <returns>int? representing the columnCount</returns>
			get
			{
				return  this.columnCount;

			}
			/// <summary>The method to set the value to columnCount</summary>
			/// <param name="columnCount">int?</param>
			set
			{
				 this.columnCount=value;

				 this.keyModified["column_count"] = 1;

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

		public List<Fields.Fields> Fields
		{
			/// <summary>The method to get the fields</summary>
			/// <returns>Instance of List<Fields></returns>
			get
			{
				return  this.fields;

			}
			/// <summary>The method to set the value to fields</summary>
			/// <param name="fields">Instance of List<Fields></param>
			set
			{
				 this.fields=value;

				 this.keyModified["fields"] = 1;

			}
		}

		public List<Button> Buttons
		{
			/// <summary>The method to get the buttons</summary>
			/// <returns>Instance of List<Button></returns>
			get
			{
				return  this.buttons;

			}
			/// <summary>The method to set the value to buttons</summary>
			/// <param name="buttons">Instance of List<Button></param>
			set
			{
				 this.buttons=value;

				 this.keyModified["buttons"] = 1;

			}
		}

		public List<Element> Elements
		{
			/// <summary>The method to get the elements</summary>
			/// <returns>Instance of List<Element></returns>
			get
			{
				return  this.elements;

			}
			/// <summary>The method to set the value to elements</summary>
			/// <param name="elements">Instance of List<Element></param>
			set
			{
				 this.elements=value;

				 this.keyModified["elements"] = 1;

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