using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ZiaEnrichment
{

	public class DataEnrichment : Model
	{
		private Module module;
		private string type;
		private List<OutputData> outputDataFieldMapping;
		private List<InputData> inputDataFieldMapping;
		private long? id;
		private bool? status;
		private DateTimeOffset? createdTime;
		private User createdBy;
		private DateTimeOffset? modifiedTime;
		private User modifiedBy;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Module Module
		{
			/// <summary>The method to get the module</summary>
			/// <returns>Instance of Module</returns>
			get
			{
				return  this.module;

			}
			/// <summary>The method to set the value to module</summary>
			/// <param name="module">Instance of Module</param>
			set
			{
				 this.module=value;

				 this.keyModified["module"] = 1;

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

		public List<OutputData> OutputDataFieldMapping
		{
			/// <summary>The method to get the outputDataFieldMapping</summary>
			/// <returns>Instance of List<OutputData></returns>
			get
			{
				return  this.outputDataFieldMapping;

			}
			/// <summary>The method to set the value to outputDataFieldMapping</summary>
			/// <param name="outputDataFieldMapping">Instance of List<OutputData></param>
			set
			{
				 this.outputDataFieldMapping=value;

				 this.keyModified["output_data_field_mapping"] = 1;

			}
		}

		public List<InputData> InputDataFieldMapping
		{
			/// <summary>The method to get the inputDataFieldMapping</summary>
			/// <returns>Instance of List<InputData></returns>
			get
			{
				return  this.inputDataFieldMapping;

			}
			/// <summary>The method to set the value to inputDataFieldMapping</summary>
			/// <param name="inputDataFieldMapping">Instance of List<InputData></param>
			set
			{
				 this.inputDataFieldMapping=value;

				 this.keyModified["input_data_field_mapping"] = 1;

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

		public bool? Status
		{
			/// <summary>The method to get the status</summary>
			/// <returns>bool? representing the status</returns>
			get
			{
				return  this.status;

			}
			/// <summary>The method to set the value to status</summary>
			/// <param name="status">bool?</param>
			set
			{
				 this.status=value;

				 this.keyModified["status"] = 1;

			}
		}

		public DateTimeOffset? CreatedTime
		{
			/// <summary>The method to get the createdTime</summary>
			/// <returns>DateTimeOffset? representing the createdTime</returns>
			get
			{
				return  this.createdTime;

			}
			/// <summary>The method to set the value to createdTime</summary>
			/// <param name="createdTime">DateTimeOffset?</param>
			set
			{
				 this.createdTime=value;

				 this.keyModified["created_time"] = 1;

			}
		}

		public User CreatedBy
		{
			/// <summary>The method to get the createdBy</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.createdBy;

			}
			/// <summary>The method to set the value to createdBy</summary>
			/// <param name="createdBy">Instance of User</param>
			set
			{
				 this.createdBy=value;

				 this.keyModified["created_by"] = 1;

			}
		}

		public DateTimeOffset? ModifiedTime
		{
			/// <summary>The method to get the modifiedTime</summary>
			/// <returns>DateTimeOffset? representing the modifiedTime</returns>
			get
			{
				return  this.modifiedTime;

			}
			/// <summary>The method to set the value to modifiedTime</summary>
			/// <param name="modifiedTime">DateTimeOffset?</param>
			set
			{
				 this.modifiedTime=value;

				 this.keyModified["modified_time"] = 1;

			}
		}

		public User ModifiedBy
		{
			/// <summary>The method to get the modifiedBy</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.modifiedBy;

			}
			/// <summary>The method to set the value to modifiedBy</summary>
			/// <param name="modifiedBy">Instance of User</param>
			set
			{
				 this.modifiedBy=value;

				 this.keyModified["modified_by"] = 1;

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