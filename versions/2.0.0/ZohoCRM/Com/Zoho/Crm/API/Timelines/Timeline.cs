using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Timelines
{

	public class Timeline : Model
	{
		private DateTimeOffset? auditedTime;
		private string action;
		private long? id;
		private string source;
		private string extension;
		private string type;
		private NameIdStructure doneBy;
		private RelatedRecord relatedRecord;
		private AutomationDetail automationDetails;
		private Record record;
		private List<FieldHistory> fieldHistory;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public DateTimeOffset? AuditedTime
		{
			/// <summary>The method to get the auditedTime</summary>
			/// <returns>DateTimeOffset? representing the auditedTime</returns>
			get
			{
				return  this.auditedTime;

			}
			/// <summary>The method to set the value to auditedTime</summary>
			/// <param name="auditedTime">DateTimeOffset?</param>
			set
			{
				 this.auditedTime=value;

				 this.keyModified["audited_time"] = 1;

			}
		}

		public string Action
		{
			/// <summary>The method to get the action</summary>
			/// <returns>string representing the action</returns>
			get
			{
				return  this.action;

			}
			/// <summary>The method to set the value to action</summary>
			/// <param name="action">string</param>
			set
			{
				 this.action=value;

				 this.keyModified[Constants.REQUEST_CATEGORY_ACTION] = 1;

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

		public string Source
		{
			/// <summary>The method to get the source</summary>
			/// <returns>string representing the source</returns>
			get
			{
				return  this.source;

			}
			/// <summary>The method to set the value to source</summary>
			/// <param name="source">string</param>
			set
			{
				 this.source=value;

				 this.keyModified["source"] = 1;

			}
		}

		public string Extension
		{
			/// <summary>The method to get the extension</summary>
			/// <returns>string representing the extension</returns>
			get
			{
				return  this.extension;

			}
			/// <summary>The method to set the value to extension</summary>
			/// <param name="extension">string</param>
			set
			{
				 this.extension=value;

				 this.keyModified["extension"] = 1;

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

		public NameIdStructure DoneBy
		{
			/// <summary>The method to get the doneBy</summary>
			/// <returns>Instance of NameIdStructure</returns>
			get
			{
				return  this.doneBy;

			}
			/// <summary>The method to set the value to doneBy</summary>
			/// <param name="doneBy">Instance of NameIdStructure</param>
			set
			{
				 this.doneBy=value;

				 this.keyModified["done_by"] = 1;

			}
		}

		public RelatedRecord RelatedRecord
		{
			/// <summary>The method to get the relatedRecord</summary>
			/// <returns>Instance of RelatedRecord</returns>
			get
			{
				return  this.relatedRecord;

			}
			/// <summary>The method to set the value to relatedRecord</summary>
			/// <param name="relatedRecord">Instance of RelatedRecord</param>
			set
			{
				 this.relatedRecord=value;

				 this.keyModified["related_record"] = 1;

			}
		}

		public AutomationDetail AutomationDetails
		{
			/// <summary>The method to get the automationDetails</summary>
			/// <returns>Instance of AutomationDetail</returns>
			get
			{
				return  this.automationDetails;

			}
			/// <summary>The method to set the value to automationDetails</summary>
			/// <param name="automationDetails">Instance of AutomationDetail</param>
			set
			{
				 this.automationDetails=value;

				 this.keyModified["automation_details"] = 1;

			}
		}

		public Record Record
		{
			/// <summary>The method to get the record</summary>
			/// <returns>Instance of Record</returns>
			get
			{
				return  this.record;

			}
			/// <summary>The method to set the value to record</summary>
			/// <param name="record">Instance of Record</param>
			set
			{
				 this.record=value;

				 this.keyModified["record"] = 1;

			}
		}

		public List<FieldHistory> FieldHistory
		{
			/// <summary>The method to get the fieldHistory</summary>
			/// <returns>Instance of List<FieldHistory></returns>
			get
			{
				return  this.fieldHistory;

			}
			/// <summary>The method to set the value to fieldHistory</summary>
			/// <param name="fieldHistory">Instance of List<FieldHistory></param>
			set
			{
				 this.fieldHistory=value;

				 this.keyModified["field_history"] = 1;

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