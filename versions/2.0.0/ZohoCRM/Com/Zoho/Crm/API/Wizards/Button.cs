using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Wizards
{

	public class Button : Model
	{
		private long? id;
		private int? sequenceNumber;
		private string displayLabel;
		private Criteria criteria;
		private Screen targetScreen;
		private string type;
		private Message message;
		private string color;
		private string shape;
		private string backgroundColor;
		private string visibility;
		private object resource;
		private Transition transition;
		private string category;
		private string referenceId;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public Screen TargetScreen
		{
			/// <summary>The method to get the targetScreen</summary>
			/// <returns>Instance of Screen</returns>
			get
			{
				return  this.targetScreen;

			}
			/// <summary>The method to set the value to targetScreen</summary>
			/// <param name="targetScreen">Instance of Screen</param>
			set
			{
				 this.targetScreen=value;

				 this.keyModified["target_screen"] = 1;

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

		public Message Message
		{
			/// <summary>The method to get the message</summary>
			/// <returns>Instance of Message</returns>
			get
			{
				return  this.message;

			}
			/// <summary>The method to set the value to message</summary>
			/// <param name="message">Instance of Message</param>
			set
			{
				 this.message=value;

				 this.keyModified["message"] = 1;

			}
		}

		public string Color
		{
			/// <summary>The method to get the color</summary>
			/// <returns>string representing the color</returns>
			get
			{
				return  this.color;

			}
			/// <summary>The method to set the value to color</summary>
			/// <param name="color">string</param>
			set
			{
				 this.color=value;

				 this.keyModified["color"] = 1;

			}
		}

		public string Shape
		{
			/// <summary>The method to get the shape</summary>
			/// <returns>string representing the shape</returns>
			get
			{
				return  this.shape;

			}
			/// <summary>The method to set the value to shape</summary>
			/// <param name="shape">string</param>
			set
			{
				 this.shape=value;

				 this.keyModified["shape"] = 1;

			}
		}

		public string BackgroundColor
		{
			/// <summary>The method to get the backgroundColor</summary>
			/// <returns>string representing the backgroundColor</returns>
			get
			{
				return  this.backgroundColor;

			}
			/// <summary>The method to set the value to backgroundColor</summary>
			/// <param name="backgroundColor">string</param>
			set
			{
				 this.backgroundColor=value;

				 this.keyModified["background_color"] = 1;

			}
		}

		public string Visibility
		{
			/// <summary>The method to get the visibility</summary>
			/// <returns>string representing the visibility</returns>
			get
			{
				return  this.visibility;

			}
			/// <summary>The method to set the value to visibility</summary>
			/// <param name="visibility">string</param>
			set
			{
				 this.visibility=value;

				 this.keyModified["visibility"] = 1;

			}
		}

		public object Resource
		{
			/// <summary>The method to get the resource</summary>
			/// <returns>object representing the resource</returns>
			get
			{
				return  this.resource;

			}
			/// <summary>The method to set the value to resource</summary>
			/// <param name="resource">object</param>
			set
			{
				 this.resource=value;

				 this.keyModified["resource"] = 1;

			}
		}

		public Transition Transition
		{
			/// <summary>The method to get the transition</summary>
			/// <returns>Instance of Transition</returns>
			get
			{
				return  this.transition;

			}
			/// <summary>The method to set the value to transition</summary>
			/// <param name="transition">Instance of Transition</param>
			set
			{
				 this.transition=value;

				 this.keyModified["transition"] = 1;

			}
		}

		public string Category
		{
			/// <summary>The method to get the category</summary>
			/// <returns>string representing the category</returns>
			get
			{
				return  this.category;

			}
			/// <summary>The method to set the value to category</summary>
			/// <param name="category">string</param>
			set
			{
				 this.category=value;

				 this.keyModified["category"] = 1;

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