using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Webforms
{

	public class WebForm : Model
	{
		private string googleSite;
		private string encryptedFormId;
		private Owner owner;
		private User userType;
		private AcknowledgeVisitors acknowledgeVisitor;
		private List<ButtonAttributes> buttonAttributes;
		private string encryptedZgid;
		private DateTimeOffset? createdTime;
		private AnalyticsData analyticsData;
		private Module module;
		private string encryptedModule;
		private bool? active;
		private bool? adwordEnabled;
		private Owner notifyOwner;
		private User createdBy;
		private FormAttributes formAttributes;
		private List<string> locationUrl;
		private string landingUrl;
		private bool? doubleOptinEnabled;
		private Layout layout;
		private List<Tags> tags;
		private bool? approvalRequest;
		private string type;
		private bool? createContact;
		private AssignmentRule assignmentRule;
		private string name;
		private long? id;
		private SpamControll spamControl;
		private List<Fields> fields;
		private List<Fields> formFields;
		private List<Abtesting> abtesting;
		private string visitorTracking;
		private DateTimeOffset? lastSubmittedTime;
		private string actionOnSubmit;
		private string actionValue;
		private Suggestion suggestion;
		private string embedCode;
		private List<string> codeFormats;
		private string sourceCode;
		private string iframeCode;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string GoogleSite
		{
			/// <summary>The method to get the googleSite</summary>
			/// <returns>string representing the googleSite</returns>
			get
			{
				return  this.googleSite;

			}
			/// <summary>The method to set the value to googleSite</summary>
			/// <param name="googleSite">string</param>
			set
			{
				 this.googleSite=value;

				 this.keyModified["google_site"] = 1;

			}
		}

		public string EncryptedFormId
		{
			/// <summary>The method to get the encryptedFormId</summary>
			/// <returns>string representing the encryptedFormId</returns>
			get
			{
				return  this.encryptedFormId;

			}
			/// <summary>The method to set the value to encryptedFormId</summary>
			/// <param name="encryptedFormId">string</param>
			set
			{
				 this.encryptedFormId=value;

				 this.keyModified["encrypted_form_id"] = 1;

			}
		}

		public Owner Owner
		{
			/// <summary>The method to get the owner</summary>
			/// <returns>Instance of Owner</returns>
			get
			{
				return  this.owner;

			}
			/// <summary>The method to set the value to owner</summary>
			/// <param name="owner">Instance of Owner</param>
			set
			{
				 this.owner=value;

				 this.keyModified["owner"] = 1;

			}
		}

		public User UserType
		{
			/// <summary>The method to get the userType</summary>
			/// <returns>Instance of User</returns>
			get
			{
				return  this.userType;

			}
			/// <summary>The method to set the value to userType</summary>
			/// <param name="userType">Instance of User</param>
			set
			{
				 this.userType=value;

				 this.keyModified["user_type"] = 1;

			}
		}

		public AcknowledgeVisitors AcknowledgeVisitor
		{
			/// <summary>The method to get the acknowledgeVisitor</summary>
			/// <returns>Instance of AcknowledgeVisitors</returns>
			get
			{
				return  this.acknowledgeVisitor;

			}
			/// <summary>The method to set the value to acknowledgeVisitor</summary>
			/// <param name="acknowledgeVisitor">Instance of AcknowledgeVisitors</param>
			set
			{
				 this.acknowledgeVisitor=value;

				 this.keyModified["acknowledge_visitor"] = 1;

			}
		}

		public List<ButtonAttributes> ButtonAttributes
		{
			/// <summary>The method to get the buttonAttributes</summary>
			/// <returns>Instance of List<ButtonAttributes></returns>
			get
			{
				return  this.buttonAttributes;

			}
			/// <summary>The method to set the value to buttonAttributes</summary>
			/// <param name="buttonAttributes">Instance of List<ButtonAttributes></param>
			set
			{
				 this.buttonAttributes=value;

				 this.keyModified["button_attributes"] = 1;

			}
		}

		public string EncryptedZgid
		{
			/// <summary>The method to get the encryptedZgid</summary>
			/// <returns>string representing the encryptedZgid</returns>
			get
			{
				return  this.encryptedZgid;

			}
			/// <summary>The method to set the value to encryptedZgid</summary>
			/// <param name="encryptedZgid">string</param>
			set
			{
				 this.encryptedZgid=value;

				 this.keyModified["encrypted_zgid"] = 1;

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

		public AnalyticsData AnalyticsData
		{
			/// <summary>The method to get the analyticsData</summary>
			/// <returns>Instance of AnalyticsData</returns>
			get
			{
				return  this.analyticsData;

			}
			/// <summary>The method to set the value to analyticsData</summary>
			/// <param name="analyticsData">Instance of AnalyticsData</param>
			set
			{
				 this.analyticsData=value;

				 this.keyModified["analytics_data"] = 1;

			}
		}

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

		public string EncryptedModule
		{
			/// <summary>The method to get the encryptedModule</summary>
			/// <returns>string representing the encryptedModule</returns>
			get
			{
				return  this.encryptedModule;

			}
			/// <summary>The method to set the value to encryptedModule</summary>
			/// <param name="encryptedModule">string</param>
			set
			{
				 this.encryptedModule=value;

				 this.keyModified["encrypted_module"] = 1;

			}
		}

		public bool? Active
		{
			/// <summary>The method to get the active</summary>
			/// <returns>bool? representing the active</returns>
			get
			{
				return  this.active;

			}
			/// <summary>The method to set the value to active</summary>
			/// <param name="active">bool?</param>
			set
			{
				 this.active=value;

				 this.keyModified["active"] = 1;

			}
		}

		public bool? AdwordEnabled
		{
			/// <summary>The method to get the adwordEnabled</summary>
			/// <returns>bool? representing the adwordEnabled</returns>
			get
			{
				return  this.adwordEnabled;

			}
			/// <summary>The method to set the value to adwordEnabled</summary>
			/// <param name="adwordEnabled">bool?</param>
			set
			{
				 this.adwordEnabled=value;

				 this.keyModified["adword_enabled"] = 1;

			}
		}

		public Owner NotifyOwner
		{
			/// <summary>The method to get the notifyOwner</summary>
			/// <returns>Instance of Owner</returns>
			get
			{
				return  this.notifyOwner;

			}
			/// <summary>The method to set the value to notifyOwner</summary>
			/// <param name="notifyOwner">Instance of Owner</param>
			set
			{
				 this.notifyOwner=value;

				 this.keyModified["notify_owner"] = 1;

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

		public FormAttributes FormAttributes
		{
			/// <summary>The method to get the formAttributes</summary>
			/// <returns>Instance of FormAttributes</returns>
			get
			{
				return  this.formAttributes;

			}
			/// <summary>The method to set the value to formAttributes</summary>
			/// <param name="formAttributes">Instance of FormAttributes</param>
			set
			{
				 this.formAttributes=value;

				 this.keyModified["form_attributes"] = 1;

			}
		}

		public List<string> LocationUrl
		{
			/// <summary>The method to get the locationUrl</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.locationUrl;

			}
			/// <summary>The method to set the value to locationUrl</summary>
			/// <param name="locationUrl">Instance of List<string></param>
			set
			{
				 this.locationUrl=value;

				 this.keyModified["location_url"] = 1;

			}
		}

		public string LandingUrl
		{
			/// <summary>The method to get the landingUrl</summary>
			/// <returns>string representing the landingUrl</returns>
			get
			{
				return  this.landingUrl;

			}
			/// <summary>The method to set the value to landingUrl</summary>
			/// <param name="landingUrl">string</param>
			set
			{
				 this.landingUrl=value;

				 this.keyModified["landing_url"] = 1;

			}
		}

		public bool? DoubleOptinEnabled
		{
			/// <summary>The method to get the doubleOptinEnabled</summary>
			/// <returns>bool? representing the doubleOptinEnabled</returns>
			get
			{
				return  this.doubleOptinEnabled;

			}
			/// <summary>The method to set the value to doubleOptinEnabled</summary>
			/// <param name="doubleOptinEnabled">bool?</param>
			set
			{
				 this.doubleOptinEnabled=value;

				 this.keyModified["double_optin_enabled"] = 1;

			}
		}

		public Layout Layout
		{
			/// <summary>The method to get the layout</summary>
			/// <returns>Instance of Layout</returns>
			get
			{
				return  this.layout;

			}
			/// <summary>The method to set the value to layout</summary>
			/// <param name="layout">Instance of Layout</param>
			set
			{
				 this.layout=value;

				 this.keyModified["layout"] = 1;

			}
		}

		public List<Tags> Tags
		{
			/// <summary>The method to get the tags</summary>
			/// <returns>Instance of List<Tags></returns>
			get
			{
				return  this.tags;

			}
			/// <summary>The method to set the value to tags</summary>
			/// <param name="tags">Instance of List<Tags></param>
			set
			{
				 this.tags=value;

				 this.keyModified["tags"] = 1;

			}
		}

		public bool? ApprovalRequest
		{
			/// <summary>The method to get the approvalRequest</summary>
			/// <returns>bool? representing the approvalRequest</returns>
			get
			{
				return  this.approvalRequest;

			}
			/// <summary>The method to set the value to approvalRequest</summary>
			/// <param name="approvalRequest">bool?</param>
			set
			{
				 this.approvalRequest=value;

				 this.keyModified["approval_request"] = 1;

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

		public bool? CreateContact
		{
			/// <summary>The method to get the createContact</summary>
			/// <returns>bool? representing the createContact</returns>
			get
			{
				return  this.createContact;

			}
			/// <summary>The method to set the value to createContact</summary>
			/// <param name="createContact">bool?</param>
			set
			{
				 this.createContact=value;

				 this.keyModified["create_contact"] = 1;

			}
		}

		public AssignmentRule AssignmentRule
		{
			/// <summary>The method to get the assignmentRule</summary>
			/// <returns>Instance of AssignmentRule</returns>
			get
			{
				return  this.assignmentRule;

			}
			/// <summary>The method to set the value to assignmentRule</summary>
			/// <param name="assignmentRule">Instance of AssignmentRule</param>
			set
			{
				 this.assignmentRule=value;

				 this.keyModified["assignment_rule"] = 1;

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

				 this.keyModified["name"] = 1;

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

		public SpamControll SpamControl
		{
			/// <summary>The method to get the spamControl</summary>
			/// <returns>Instance of SpamControll</returns>
			get
			{
				return  this.spamControl;

			}
			/// <summary>The method to set the value to spamControl</summary>
			/// <param name="spamControl">Instance of SpamControll</param>
			set
			{
				 this.spamControl=value;

				 this.keyModified["spam_control"] = 1;

			}
		}

		public List<Fields> Fields
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

		public List<Fields> FormFields
		{
			/// <summary>The method to get the formFields</summary>
			/// <returns>Instance of List<Fields></returns>
			get
			{
				return  this.formFields;

			}
			/// <summary>The method to set the value to formFields</summary>
			/// <param name="formFields">Instance of List<Fields></param>
			set
			{
				 this.formFields=value;

				 this.keyModified["form_fields"] = 1;

			}
		}

		public List<Abtesting> Abtesting
		{
			/// <summary>The method to get the abtesting</summary>
			/// <returns>Instance of List<Abtesting></returns>
			get
			{
				return  this.abtesting;

			}
			/// <summary>The method to set the value to abtesting</summary>
			/// <param name="abtesting">Instance of List<Abtesting></param>
			set
			{
				 this.abtesting=value;

				 this.keyModified["abtesting"] = 1;

			}
		}

		public string VisitorTracking
		{
			/// <summary>The method to get the visitorTracking</summary>
			/// <returns>string representing the visitorTracking</returns>
			get
			{
				return  this.visitorTracking;

			}
			/// <summary>The method to set the value to visitorTracking</summary>
			/// <param name="visitorTracking">string</param>
			set
			{
				 this.visitorTracking=value;

				 this.keyModified["visitor_tracking"] = 1;

			}
		}

		public DateTimeOffset? LastSubmittedTime
		{
			/// <summary>The method to get the lastSubmittedTime</summary>
			/// <returns>DateTimeOffset? representing the lastSubmittedTime</returns>
			get
			{
				return  this.lastSubmittedTime;

			}
			/// <summary>The method to set the value to lastSubmittedTime</summary>
			/// <param name="lastSubmittedTime">DateTimeOffset?</param>
			set
			{
				 this.lastSubmittedTime=value;

				 this.keyModified["last_submitted_time"] = 1;

			}
		}

		public string ActionOnSubmit
		{
			/// <summary>The method to get the actionOnSubmit</summary>
			/// <returns>string representing the actionOnSubmit</returns>
			get
			{
				return  this.actionOnSubmit;

			}
			/// <summary>The method to set the value to actionOnSubmit</summary>
			/// <param name="actionOnSubmit">string</param>
			set
			{
				 this.actionOnSubmit=value;

				 this.keyModified["action_on_submit"] = 1;

			}
		}

		public string ActionValue
		{
			/// <summary>The method to get the actionValue</summary>
			/// <returns>string representing the actionValue</returns>
			get
			{
				return  this.actionValue;

			}
			/// <summary>The method to set the value to actionValue</summary>
			/// <param name="actionValue">string</param>
			set
			{
				 this.actionValue=value;

				 this.keyModified["action_value"] = 1;

			}
		}

		public Suggestion Suggestion
		{
			/// <summary>The method to get the suggestion</summary>
			/// <returns>Instance of Suggestion</returns>
			get
			{
				return  this.suggestion;

			}
			/// <summary>The method to set the value to suggestion</summary>
			/// <param name="suggestion">Instance of Suggestion</param>
			set
			{
				 this.suggestion=value;

				 this.keyModified["suggestion"] = 1;

			}
		}

		public string EmbedCode
		{
			/// <summary>The method to get the embedCode</summary>
			/// <returns>string representing the embedCode</returns>
			get
			{
				return  this.embedCode;

			}
			/// <summary>The method to set the value to embedCode</summary>
			/// <param name="embedCode">string</param>
			set
			{
				 this.embedCode=value;

				 this.keyModified["embed_code"] = 1;

			}
		}

		public List<string> CodeFormats
		{
			/// <summary>The method to get the codeFormats</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.codeFormats;

			}
			/// <summary>The method to set the value to codeFormats</summary>
			/// <param name="codeFormats">Instance of List<string></param>
			set
			{
				 this.codeFormats=value;

				 this.keyModified["code_formats"] = 1;

			}
		}

		public string SourceCode
		{
			/// <summary>The method to get the sourceCode</summary>
			/// <returns>string representing the sourceCode</returns>
			get
			{
				return  this.sourceCode;

			}
			/// <summary>The method to set the value to sourceCode</summary>
			/// <param name="sourceCode">string</param>
			set
			{
				 this.sourceCode=value;

				 this.keyModified["source_code"] = 1;

			}
		}

		public string IframeCode
		{
			/// <summary>The method to get the iframeCode</summary>
			/// <returns>string representing the iframeCode</returns>
			get
			{
				return  this.iframeCode;

			}
			/// <summary>The method to set the value to iframeCode</summary>
			/// <param name="iframeCode">string</param>
			set
			{
				 this.iframeCode=value;

				 this.keyModified["iframe_code"] = 1;

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