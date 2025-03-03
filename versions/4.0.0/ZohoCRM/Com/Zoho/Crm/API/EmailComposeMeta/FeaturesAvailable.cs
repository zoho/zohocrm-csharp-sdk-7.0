using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.EmailComposeMeta
{

	public class FeaturesAvailable : Model
	{
		private Choice<bool?> zsurveyEnabled;
		private Choice<bool?> inlineComposeWindow;
		private Choice<bool?> scheduleMail;
		private Choice<bool?> emailCloudPicker;
		private Choice<bool?> formIntegrationEnabled;
		private Choice<bool?> isprivacyenabled;
		private Choice<bool?> autoSuggestion;
		private Choice<bool?> unsubscribeLink;
		private Choice<bool?> bestTimeToContact;
		private Choice<bool?> attachTeamdrive;
		private Choice<bool?> islivedeskenabled;
		private bool? subjectLineSuggestion;
		private bool? emailPreference;
		private bool? attachment;
		private bool? mandateunsublink;
		private bool? oldComposeRevert;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Choice<bool?> ZsurveyEnabled
		{
			/// <summary>The method to get the zsurveyEnabled</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.zsurveyEnabled;

			}
			/// <summary>The method to set the value to zsurveyEnabled</summary>
			/// <param name="zsurveyEnabled">Instance of Choice<bool?></param>
			set
			{
				 this.zsurveyEnabled=value;

				 this.keyModified["zsurvey_enabled"] = 1;

			}
		}

		public Choice<bool?> InlineComposeWindow
		{
			/// <summary>The method to get the inlineComposeWindow</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.inlineComposeWindow;

			}
			/// <summary>The method to set the value to inlineComposeWindow</summary>
			/// <param name="inlineComposeWindow">Instance of Choice<bool?></param>
			set
			{
				 this.inlineComposeWindow=value;

				 this.keyModified["inline_compose_window"] = 1;

			}
		}

		public Choice<bool?> ScheduleMail
		{
			/// <summary>The method to get the scheduleMail</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.scheduleMail;

			}
			/// <summary>The method to set the value to scheduleMail</summary>
			/// <param name="scheduleMail">Instance of Choice<bool?></param>
			set
			{
				 this.scheduleMail=value;

				 this.keyModified["Schedule_Mail"] = 1;

			}
		}

		public Choice<bool?> EmailCloudPicker
		{
			/// <summary>The method to get the emailCloudPicker</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.emailCloudPicker;

			}
			/// <summary>The method to set the value to emailCloudPicker</summary>
			/// <param name="emailCloudPicker">Instance of Choice<bool?></param>
			set
			{
				 this.emailCloudPicker=value;

				 this.keyModified["EMAIL_CLOUD_PICKER"] = 1;

			}
		}

		public Choice<bool?> FormIntegrationEnabled
		{
			/// <summary>The method to get the formIntegrationEnabled</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.formIntegrationEnabled;

			}
			/// <summary>The method to set the value to formIntegrationEnabled</summary>
			/// <param name="formIntegrationEnabled">Instance of Choice<bool?></param>
			set
			{
				 this.formIntegrationEnabled=value;

				 this.keyModified["form_integration_enabled"] = 1;

			}
		}

		public Choice<bool?> Isprivacyenabled
		{
			/// <summary>The method to get the isprivacyenabled</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.isprivacyenabled;

			}
			/// <summary>The method to set the value to isprivacyenabled</summary>
			/// <param name="isprivacyenabled">Instance of Choice<bool?></param>
			set
			{
				 this.isprivacyenabled=value;

				 this.keyModified["isPrivacyEnabled"] = 1;

			}
		}

		public Choice<bool?> AutoSuggestion
		{
			/// <summary>The method to get the autoSuggestion</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.autoSuggestion;

			}
			/// <summary>The method to set the value to autoSuggestion</summary>
			/// <param name="autoSuggestion">Instance of Choice<bool?></param>
			set
			{
				 this.autoSuggestion=value;

				 this.keyModified["auto_suggestion"] = 1;

			}
		}

		public Choice<bool?> UnsubscribeLink
		{
			/// <summary>The method to get the unsubscribeLink</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.unsubscribeLink;

			}
			/// <summary>The method to set the value to unsubscribeLink</summary>
			/// <param name="unsubscribeLink">Instance of Choice<bool?></param>
			set
			{
				 this.unsubscribeLink=value;

				 this.keyModified["UNSUBSCRIBE_LINK"] = 1;

			}
		}

		public Choice<bool?> BestTimeToContact
		{
			/// <summary>The method to get the bestTimeToContact</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.bestTimeToContact;

			}
			/// <summary>The method to set the value to bestTimeToContact</summary>
			/// <param name="bestTimeToContact">Instance of Choice<bool?></param>
			set
			{
				 this.bestTimeToContact=value;

				 this.keyModified["best_time_to_contact"] = 1;

			}
		}

		public Choice<bool?> AttachTeamdrive
		{
			/// <summary>The method to get the attachTeamdrive</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.attachTeamdrive;

			}
			/// <summary>The method to set the value to attachTeamdrive</summary>
			/// <param name="attachTeamdrive">Instance of Choice<bool?></param>
			set
			{
				 this.attachTeamdrive=value;

				 this.keyModified["attach_teamdrive"] = 1;

			}
		}

		public Choice<bool?> Islivedeskenabled
		{
			/// <summary>The method to get the islivedeskenabled</summary>
			/// <returns>Instance of Choice<Boolean></returns>
			get
			{
				return  this.islivedeskenabled;

			}
			/// <summary>The method to set the value to islivedeskenabled</summary>
			/// <param name="islivedeskenabled">Instance of Choice<bool?></param>
			set
			{
				 this.islivedeskenabled=value;

				 this.keyModified["isLiveDeskEnabled"] = 1;

			}
		}

		public bool? SubjectLineSuggestion
		{
			/// <summary>The method to get the subjectLineSuggestion</summary>
			/// <returns>bool? representing the subjectLineSuggestion</returns>
			get
			{
				return  this.subjectLineSuggestion;

			}
			/// <summary>The method to set the value to subjectLineSuggestion</summary>
			/// <param name="subjectLineSuggestion">bool?</param>
			set
			{
				 this.subjectLineSuggestion=value;

				 this.keyModified["subject_line_suggestion"] = 1;

			}
		}

		public bool? EmailPreference
		{
			/// <summary>The method to get the emailPreference</summary>
			/// <returns>bool? representing the emailPreference</returns>
			get
			{
				return  this.emailPreference;

			}
			/// <summary>The method to set the value to emailPreference</summary>
			/// <param name="emailPreference">bool?</param>
			set
			{
				 this.emailPreference=value;

				 this.keyModified["EMAIL_PREFERENCE"] = 1;

			}
		}

		public bool? Attachment
		{
			/// <summary>The method to get the attachment</summary>
			/// <returns>bool? representing the attachment</returns>
			get
			{
				return  this.attachment;

			}
			/// <summary>The method to set the value to attachment</summary>
			/// <param name="attachment">bool?</param>
			set
			{
				 this.attachment=value;

				 this.keyModified["ATTACHMENT"] = 1;

			}
		}

		public bool? Mandateunsublink
		{
			/// <summary>The method to get the mandateunsublink</summary>
			/// <returns>bool? representing the mandateunsublink</returns>
			get
			{
				return  this.mandateunsublink;

			}
			/// <summary>The method to set the value to mandateunsublink</summary>
			/// <param name="mandateunsublink">bool?</param>
			set
			{
				 this.mandateunsublink=value;

				 this.keyModified["mandateUnsubLink"] = 1;

			}
		}

		public bool? OldComposeRevert
		{
			/// <summary>The method to get the oldComposeRevert</summary>
			/// <returns>bool? representing the oldComposeRevert</returns>
			get
			{
				return  this.oldComposeRevert;

			}
			/// <summary>The method to set the value to oldComposeRevert</summary>
			/// <param name="oldComposeRevert">bool?</param>
			set
			{
				 this.oldComposeRevert=value;

				 this.keyModified["OLD_COMPOSE_REVERT"] = 1;

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