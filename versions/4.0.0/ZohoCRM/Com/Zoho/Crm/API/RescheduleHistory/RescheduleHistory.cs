using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.RescheduleHistory
{

	public class RescheduleHistory : Model
	{
		private string currencySymbol;
		private DateTimeOffset? rescheduledTo;
		private bool? reviewProcess;
		private string rescheduleReason;
		private string sharingPermission;
		private string name;
		private User modifiedBy;
		private bool? review;
		private User rescheduledBy;
		private string state;
		private string canvasId;
		private bool? processFlow;
		private long? id;
		private DateTimeOffset? rescheduledTime;
		private bool? ziaVisions;
		private bool? approved;
		private DateTimeOffset? modifiedTime;
		private Approval approval;
		private DateTimeOffset? createdTime;
		private DateTimeOffset? rescheduledFrom;
		private AppointmentName appointmentName;
		private bool? editable;
		private bool? orchestration;
		private bool? inMerge;
		private User createdBy;
		private string approvalState;
		private string rescheduleNote;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string CurrencySymbol
		{
			/// <summary>The method to get the currencySymbol</summary>
			/// <returns>string representing the currencySymbol</returns>
			get
			{
				return  this.currencySymbol;

			}
			/// <summary>The method to set the value to currencySymbol</summary>
			/// <param name="currencySymbol">string</param>
			set
			{
				 this.currencySymbol=value;

				 this.keyModified["$currency_symbol"] = 1;

			}
		}

		public DateTimeOffset? RescheduledTo
		{
			/// <summary>The method to get the rescheduledTo</summary>
			/// <returns>DateTimeOffset? representing the rescheduledTo</returns>
			get
			{
				return  this.rescheduledTo;

			}
			/// <summary>The method to set the value to rescheduledTo</summary>
			/// <param name="rescheduledTo">DateTimeOffset?</param>
			set
			{
				 this.rescheduledTo=value;

				 this.keyModified["Rescheduled_To"] = 1;

			}
		}

		public bool? ReviewProcess
		{
			/// <summary>The method to get the reviewProcess</summary>
			/// <returns>bool? representing the reviewProcess</returns>
			get
			{
				return  this.reviewProcess;

			}
			/// <summary>The method to set the value to reviewProcess</summary>
			/// <param name="reviewProcess">bool?</param>
			set
			{
				 this.reviewProcess=value;

				 this.keyModified["$review_process"] = 1;

			}
		}

		public string RescheduleReason
		{
			/// <summary>The method to get the rescheduleReason</summary>
			/// <returns>string representing the rescheduleReason</returns>
			get
			{
				return  this.rescheduleReason;

			}
			/// <summary>The method to set the value to rescheduleReason</summary>
			/// <param name="rescheduleReason">string</param>
			set
			{
				 this.rescheduleReason=value;

				 this.keyModified["Reschedule_Reason"] = 1;

			}
		}

		public string SharingPermission
		{
			/// <summary>The method to get the sharingPermission</summary>
			/// <returns>string representing the sharingPermission</returns>
			get
			{
				return  this.sharingPermission;

			}
			/// <summary>The method to set the value to sharingPermission</summary>
			/// <param name="sharingPermission">string</param>
			set
			{
				 this.sharingPermission=value;

				 this.keyModified["$sharing_permission"] = 1;

			}
		}

		public string Name
		{
			/// <summary>The method to get the name</summary>
			/// <returns>string representing the name</returns>
			get
			{
				return  this.name;

			}
			/// <summary>The method to set the value to name</summary>
			/// <param name="name">string</param>
			set
			{
				 this.name=value;

				 this.keyModified["Name"] = 1;

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

				 this.keyModified["Modified_By"] = 1;

			}
		}

		public bool? Review
		{
			/// <summary>The method to get the review</summary>
			/// <returns>bool? representing the review</returns>
			get
			{
				return  this.review;

			}
			/// <summary>The method to set the value to review</summary>
			/// <param name="review">bool?</param>
			set
			{
				 this.review=value;

				 this.keyModified["$review"] = 1;

			}
		}

		public User RescheduledBy
		{
			/// <summary>The method to get the rescheduledBy</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.rescheduledBy;

			}
			/// <summary>The method to set the value to rescheduledBy</summary>
			/// <param name="rescheduledBy">Instance of User</param>
			set
			{
				 this.rescheduledBy=value;

				 this.keyModified["Rescheduled_By"] = 1;

			}
		}

		public string State
		{
			/// <summary>The method to get the state</summary>
			/// <returns>string representing the state</returns>
			get
			{
				return  this.state;

			}
			/// <summary>The method to set the value to state</summary>
			/// <param name="state">string</param>
			set
			{
				 this.state=value;

				 this.keyModified["$state"] = 1;

			}
		}

		public string CanvasId
		{
			/// <summary>The method to get the canvasId</summary>
			/// <returns>string representing the canvasId</returns>
			get
			{
				return  this.canvasId;

			}
			/// <summary>The method to set the value to canvasId</summary>
			/// <param name="canvasId">string</param>
			set
			{
				 this.canvasId=value;

				 this.keyModified["$canvas_id"] = 1;

			}
		}

		public bool? ProcessFlow
		{
			/// <summary>The method to get the processFlow</summary>
			/// <returns>bool? representing the processFlow</returns>
			get
			{
				return  this.processFlow;

			}
			/// <summary>The method to set the value to processFlow</summary>
			/// <param name="processFlow">bool?</param>
			set
			{
				 this.processFlow=value;

				 this.keyModified["$process_flow"] = 1;

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

		public DateTimeOffset? RescheduledTime
		{
			/// <summary>The method to get the rescheduledTime</summary>
			/// <returns>DateTimeOffset? representing the rescheduledTime</returns>
			get
			{
				return  this.rescheduledTime;

			}
			/// <summary>The method to set the value to rescheduledTime</summary>
			/// <param name="rescheduledTime">DateTimeOffset?</param>
			set
			{
				 this.rescheduledTime=value;

				 this.keyModified["Rescheduled_Time"] = 1;

			}
		}

		public bool? ZiaVisions
		{
			/// <summary>The method to get the ziaVisions</summary>
			/// <returns>bool? representing the ziaVisions</returns>
			get
			{
				return  this.ziaVisions;

			}
			/// <summary>The method to set the value to ziaVisions</summary>
			/// <param name="ziaVisions">bool?</param>
			set
			{
				 this.ziaVisions=value;

				 this.keyModified["$zia_visions"] = 1;

			}
		}

		public bool? Approved
		{
			/// <summary>The method to get the approved</summary>
			/// <returns>bool? representing the approved</returns>
			get
			{
				return  this.approved;

			}
			/// <summary>The method to set the value to approved</summary>
			/// <param name="approved">bool?</param>
			set
			{
				 this.approved=value;

				 this.keyModified["$approved"] = 1;

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

				 this.keyModified["Modified_Time"] = 1;

			}
		}

		public Approval Approval
		{
			/// <summary>The method to get the approval</summary>
			/// <returns>Instance of Approval</returns>
			get
			{
				return  this.approval;

			}
			/// <summary>The method to set the value to approval</summary>
			/// <param name="approval">Instance of Approval</param>
			set
			{
				 this.approval=value;

				 this.keyModified["$approval"] = 1;

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

				 this.keyModified["Created_Time"] = 1;

			}
		}

		public DateTimeOffset? RescheduledFrom
		{
			/// <summary>The method to get the rescheduledFrom</summary>
			/// <returns>DateTimeOffset? representing the rescheduledFrom</returns>
			get
			{
				return  this.rescheduledFrom;

			}
			/// <summary>The method to set the value to rescheduledFrom</summary>
			/// <param name="rescheduledFrom">DateTimeOffset?</param>
			set
			{
				 this.rescheduledFrom=value;

				 this.keyModified["Rescheduled_From"] = 1;

			}
		}

		public AppointmentName AppointmentName
		{
			/// <summary>The method to get the appointmentName</summary>
			/// <returns>Instance of AppointmentName</returns>
			get
			{
				return  this.appointmentName;

			}
			/// <summary>The method to set the value to appointmentName</summary>
			/// <param name="appointmentName">Instance of AppointmentName</param>
			set
			{
				 this.appointmentName=value;

				 this.keyModified["Appointment_Name"] = 1;

			}
		}

		public bool? Editable
		{
			/// <summary>The method to get the editable</summary>
			/// <returns>bool? representing the editable</returns>
			get
			{
				return  this.editable;

			}
			/// <summary>The method to set the value to editable</summary>
			/// <param name="editable">bool?</param>
			set
			{
				 this.editable=value;

				 this.keyModified["$editable"] = 1;

			}
		}

		public bool? Orchestration
		{
			/// <summary>The method to get the orchestration</summary>
			/// <returns>bool? representing the orchestration</returns>
			get
			{
				return  this.orchestration;

			}
			/// <summary>The method to set the value to orchestration</summary>
			/// <param name="orchestration">bool?</param>
			set
			{
				 this.orchestration=value;

				 this.keyModified["$orchestration"] = 1;

			}
		}

		public bool? InMerge
		{
			/// <summary>The method to get the inMerge</summary>
			/// <returns>bool? representing the inMerge</returns>
			get
			{
				return  this.inMerge;

			}
			/// <summary>The method to set the value to inMerge</summary>
			/// <param name="inMerge">bool?</param>
			set
			{
				 this.inMerge=value;

				 this.keyModified["$in_merge"] = 1;

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

				 this.keyModified["Created_By"] = 1;

			}
		}

		public string ApprovalState
		{
			/// <summary>The method to get the approvalState</summary>
			/// <returns>string representing the approvalState</returns>
			get
			{
				return  this.approvalState;

			}
			/// <summary>The method to set the value to approvalState</summary>
			/// <param name="approvalState">string</param>
			set
			{
				 this.approvalState=value;

				 this.keyModified["$approval_state"] = 1;

			}
		}

		public string RescheduleNote
		{
			/// <summary>The method to get the rescheduleNote</summary>
			/// <returns>string representing the rescheduleNote</returns>
			get
			{
				return  this.rescheduleNote;

			}
			/// <summary>The method to set the value to rescheduleNote</summary>
			/// <param name="rescheduleNote">string</param>
			set
			{
				 this.rescheduleNote=value;

				 this.keyModified["Reschedule_Note"] = 1;

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