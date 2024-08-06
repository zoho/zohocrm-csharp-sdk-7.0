using Com.Zoho.Crm.API.Record;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.MassConvert
{

	public class BodyWrapper : Model
	{
		private Record.Record deals;
		private MoveAttachmentsTo moveAttachmentsTo;
		private AssignTo assignTo;
		private List<MoveAttachmentsTo> carryOverTags;
		private List<RelatedModule> relatedModules;
		private PortalUserType portalUserType;
		private List<long?> ids;
		private bool? applyAssignmentThreshold;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Record.Record Deals
		{
			/// <summary>The method to get the deals</summary>
			/// <returns>Instance of Record</returns>
			get
			{
				return  this.deals;

			}
			/// <summary>The method to set the value to deals</summary>
			/// <param name="deals">Instance of Record</param>
			set
			{
				 this.deals=value;

				 this.keyModified["Deals"] = 1;

			}
		}

		public MoveAttachmentsTo MoveAttachmentsTo
		{
			/// <summary>The method to get the moveAttachmentsTo</summary>
			/// <returns>Instance of MoveAttachmentsTo</returns>
			get
			{
				return  this.moveAttachmentsTo;

			}
			/// <summary>The method to set the value to moveAttachmentsTo</summary>
			/// <param name="moveAttachmentsTo">Instance of MoveAttachmentsTo</param>
			set
			{
				 this.moveAttachmentsTo=value;

				 this.keyModified["move_attachments_to"] = 1;

			}
		}

		public AssignTo AssignTo
		{
			/// <summary>The method to get the assignTo</summary>
			/// <returns>Instance of AssignTo</returns>
			get
			{
				return  this.assignTo;

			}
			/// <summary>The method to set the value to assignTo</summary>
			/// <param name="assignTo">Instance of AssignTo</param>
			set
			{
				 this.assignTo=value;

				 this.keyModified["assign_to"] = 1;

			}
		}

		public List<MoveAttachmentsTo> CarryOverTags
		{
			/// <summary>The method to get the carryOverTags</summary>
			/// <returns>Instance of List<MoveAttachmentsTo></returns>
			get
			{
				return  this.carryOverTags;

			}
			/// <summary>The method to set the value to carryOverTags</summary>
			/// <param name="carryOverTags">Instance of List<MoveAttachmentsTo></param>
			set
			{
				 this.carryOverTags=value;

				 this.keyModified["carry_over_tags"] = 1;

			}
		}

		public List<RelatedModule> RelatedModules
		{
			/// <summary>The method to get the relatedModules</summary>
			/// <returns>Instance of List<RelatedModule></returns>
			get
			{
				return  this.relatedModules;

			}
			/// <summary>The method to set the value to relatedModules</summary>
			/// <param name="relatedModules">Instance of List<RelatedModule></param>
			set
			{
				 this.relatedModules=value;

				 this.keyModified["related_modules"] = 1;

			}
		}

		public PortalUserType PortalUserType
		{
			/// <summary>The method to get the portalUserType</summary>
			/// <returns>Instance of PortalUserType</returns>
			get
			{
				return  this.portalUserType;

			}
			/// <summary>The method to set the value to portalUserType</summary>
			/// <param name="portalUserType">Instance of PortalUserType</param>
			set
			{
				 this.portalUserType=value;

				 this.keyModified["portal_user_type"] = 1;

			}
		}

		public List<long?> Ids
		{
			/// <summary>The method to get the ids</summary>
			/// <returns>Instance of List<Long></returns>
			get
			{
				return  this.ids;

			}
			/// <summary>The method to set the value to ids</summary>
			/// <param name="ids">Instance of List<long?></param>
			set
			{
				 this.ids=value;

				 this.keyModified["ids"] = 1;

			}
		}

		public bool? ApplyAssignmentThreshold
		{
			/// <summary>The method to get the applyAssignmentThreshold</summary>
			/// <returns>bool? representing the applyAssignmentThreshold</returns>
			get
			{
				return  this.applyAssignmentThreshold;

			}
			/// <summary>The method to set the value to applyAssignmentThreshold</summary>
			/// <param name="applyAssignmentThreshold">bool?</param>
			set
			{
				 this.applyAssignmentThreshold=value;

				 this.keyModified["apply_assignment_threshold"] = 1;

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