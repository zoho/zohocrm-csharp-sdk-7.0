using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Record
{

	public class ImageUpload : Model
	{
		private string previewIdS;
		private string fileNameS;
		private string descriptionS;
		private string sizeS;
		private string id;
		private long? sequenceNumberS;
		private string stateS;
		private string fileIdS;
		private string delete;
		private DateTimeOffset? createdTimeS;
		private DateTimeOffset? modifiedTimeS;
		private Users.MinifiedUser createdByS;
		private Users.MinifiedUser ownerS;
		private Users.MinifiedUser modifiedByS;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string PreviewIdS
		{
			/// <summary>The method to get the previewIdS</summary>
			/// <returns>string representing the previewIdS</returns>
			get
			{
				return  this.previewIdS;

			}
			/// <summary>The method to set the value to previewIdS</summary>
			/// <param name="previewIdS">string</param>
			set
			{
				 this.previewIdS=value;

				 this.keyModified["Preview_Id__s"] = 1;

			}
		}

		public string FileNameS
		{
			/// <summary>The method to get the fileNameS</summary>
			/// <returns>string representing the fileNameS</returns>
			get
			{
				return  this.fileNameS;

			}
			/// <summary>The method to set the value to fileNameS</summary>
			/// <param name="fileNameS">string</param>
			set
			{
				 this.fileNameS=value;

				 this.keyModified["File_Name__s"] = 1;

			}
		}

		public string DescriptionS
		{
			/// <summary>The method to get the descriptionS</summary>
			/// <returns>string representing the descriptionS</returns>
			get
			{
				return  this.descriptionS;

			}
			/// <summary>The method to set the value to descriptionS</summary>
			/// <param name="descriptionS">string</param>
			set
			{
				 this.descriptionS=value;

				 this.keyModified["Description__s"] = 1;

			}
		}

		public string SizeS
		{
			/// <summary>The method to get the sizeS</summary>
			/// <returns>string representing the sizeS</returns>
			get
			{
				return  this.sizeS;

			}
			/// <summary>The method to set the value to sizeS</summary>
			/// <param name="sizeS">string</param>
			set
			{
				 this.sizeS=value;

				 this.keyModified["Size__s"] = 1;

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

		public long? SequenceNumberS
		{
			/// <summary>The method to get the sequenceNumberS</summary>
			/// <returns>long? representing the sequenceNumberS</returns>
			get
			{
				return  this.sequenceNumberS;

			}
			/// <summary>The method to set the value to sequenceNumberS</summary>
			/// <param name="sequenceNumberS">long?</param>
			set
			{
				 this.sequenceNumberS=value;

				 this.keyModified["Sequence_Number__s"] = 1;

			}
		}

		public string StateS
		{
			/// <summary>The method to get the stateS</summary>
			/// <returns>string representing the stateS</returns>
			get
			{
				return  this.stateS;

			}
			/// <summary>The method to set the value to stateS</summary>
			/// <param name="stateS">string</param>
			set
			{
				 this.stateS=value;

				 this.keyModified["State__s"] = 1;

			}
		}

		public string FileIdS
		{
			/// <summary>The method to get the fileIdS</summary>
			/// <returns>string representing the fileIdS</returns>
			get
			{
				return  this.fileIdS;

			}
			/// <summary>The method to set the value to fileIdS</summary>
			/// <param name="fileIdS">string</param>
			set
			{
				 this.fileIdS=value;

				 this.keyModified["File_Id__s"] = 1;

			}
		}

		public string Delete
		{
			/// <summary>The method to get the delete</summary>
			/// <returns>string representing the delete</returns>
			get
			{
				return  this.delete;

			}
			/// <summary>The method to set the value to delete</summary>
			/// <param name="delete">string</param>
			set
			{
				 this.delete=value;

				 this.keyModified["_delete"] = 1;

			}
		}

		public DateTimeOffset? CreatedTimeS
		{
			/// <summary>The method to get the createdTimeS</summary>
			/// <returns>DateTimeOffset? representing the createdTimeS</returns>
			get
			{
				return  this.createdTimeS;

			}
			/// <summary>The method to set the value to createdTimeS</summary>
			/// <param name="createdTimeS">DateTimeOffset?</param>
			set
			{
				 this.createdTimeS=value;

				 this.keyModified["Created_Time__s"] = 1;

			}
		}

		public DateTimeOffset? ModifiedTimeS
		{
			/// <summary>The method to get the modifiedTimeS</summary>
			/// <returns>DateTimeOffset? representing the modifiedTimeS</returns>
			get
			{
				return  this.modifiedTimeS;

			}
			/// <summary>The method to set the value to modifiedTimeS</summary>
			/// <param name="modifiedTimeS">DateTimeOffset?</param>
			set
			{
				 this.modifiedTimeS=value;

				 this.keyModified["Modified_Time__s"] = 1;

			}
		}

		public Users.MinifiedUser CreatedByS
		{
			/// <summary>The method to get the createdByS</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.createdByS;

			}
			/// <summary>The method to set the value to createdByS</summary>
			/// <param name="createdByS">Instance of MinifiedUser</param>
			set
			{
				 this.createdByS=value;

				 this.keyModified["Created_By__s"] = 1;

			}
		}

		public Users.MinifiedUser OwnerS
		{
			/// <summary>The method to get the ownerS</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.ownerS;

			}
			/// <summary>The method to set the value to ownerS</summary>
			/// <param name="ownerS">Instance of MinifiedUser</param>
			set
			{
				 this.ownerS=value;

				 this.keyModified["Owner__s"] = 1;

			}
		}

		public Users.MinifiedUser ModifiedByS
		{
			/// <summary>The method to get the modifiedByS</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.modifiedByS;

			}
			/// <summary>The method to set the value to modifiedByS</summary>
			/// <param name="modifiedByS">Instance of MinifiedUser</param>
			set
			{
				 this.modifiedByS=value;

				 this.keyModified["Modified_By__s"] = 1;

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