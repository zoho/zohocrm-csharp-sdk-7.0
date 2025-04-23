using Com.Zoho.Crm.API.CustomViews;
using Com.Zoho.Crm.API.Fields;
using Com.Zoho.Crm.API.Profiles;
using Com.Zoho.Crm.API.RelatedLists;
using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Modules
{

	public class Modules : Model
	{
		private bool? hasMoreProfiles;
		private bool? subMenuAvailable;
		private bool? globalSearchSupported;
		private bool? deletable;
		private string description;
		private bool? creatable;
		private bool? recycleBinOnDelete;
		private bool? inventoryTemplateSupported;
		private DateTimeOffset? modifiedTime;
		private string pluralLabel;
		private bool? presenceSubMenu;
		private bool? triggersSupported;
		private long? id;
		private bool? chartView;
		private bool? isblueprintsupported;
		private int? visibility;
		private bool? visible;
		private bool? convertable;
		private bool? editable;
		private bool? emailtemplateSupport;
		private bool? emailParserSupported;
		private bool? filterSupported;
		private bool? showAsTab;
		private string webLink;
		private int? sequenceNumber;
		private string singularLabel;
		private bool? viewable;
		private bool? apiSupported;
		private string apiName;
		private bool? quickCreate;
		private Choice<string> generatedType;
		private bool? feedsRequired;
		private bool? scoringSupported;
		private bool? webformSupported;
		private Territory territory;
		private List<Argument> arguments;
		private string moduleName;
		private bool? chartViewSupported;
		private int? profileCount;
		private int? businessCardFieldLimit;
		private bool? trackCurrentData;
		private Users.MinifiedUser modifiedBy;
		private List<Profiles.MinifiedProfile> profiles;
		private MinifiedModule parentModule;
		private Choice<string> activityBadge;
		private List<string> fieldStates;
		private List<string> businessCardFields;
		private int? perPage;
		private List<string> properties;
		private List<string> onDemandProperties;
		private List<string> searchLayoutFields;
		private bool? kanbanViewSupported;
		private LookupFieldProperties lookupFieldProperties;
		private bool? kanbanView;
		private List<RelatedLists.RelatedList> relatedLists;
		private bool? filterStatus;
		private RelatedListProperties relatedListProperties;
		private object displayField;
		private List<object> layouts;
		private List<ModuleFields> fields;
		private CustomViews.CustomViews customView;
		private bool? ziaView;
		private List<Fields.MinifiedField> defaultMappingFields;
		private string status;
		private StaticSubformProperties staticSubformProperties;
		private List<Fields.LayoutAssociation> layoutAssociations;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? HasMoreProfiles
		{
			/// <summary>The method to get the hasMoreProfiles</summary>
			/// <returns>bool? representing the hasMoreProfiles</returns>
			get
			{
				return  this.hasMoreProfiles;

			}
			/// <summary>The method to set the value to hasMoreProfiles</summary>
			/// <param name="hasMoreProfiles">bool?</param>
			set
			{
				 this.hasMoreProfiles=value;

				 this.keyModified["has_more_profiles"] = 1;

			}
		}

		public bool? SubMenuAvailable
		{
			/// <summary>The method to get the subMenuAvailable</summary>
			/// <returns>bool? representing the subMenuAvailable</returns>
			get
			{
				return  this.subMenuAvailable;

			}
			/// <summary>The method to set the value to subMenuAvailable</summary>
			/// <param name="subMenuAvailable">bool?</param>
			set
			{
				 this.subMenuAvailable=value;

				 this.keyModified["sub_menu_available"] = 1;

			}
		}

		public bool? GlobalSearchSupported
		{
			/// <summary>The method to get the globalSearchSupported</summary>
			/// <returns>bool? representing the globalSearchSupported</returns>
			get
			{
				return  this.globalSearchSupported;

			}
			/// <summary>The method to set the value to globalSearchSupported</summary>
			/// <param name="globalSearchSupported">bool?</param>
			set
			{
				 this.globalSearchSupported=value;

				 this.keyModified["global_search_supported"] = 1;

			}
		}

		public bool? Deletable
		{
			/// <summary>The method to get the deletable</summary>
			/// <returns>bool? representing the deletable</returns>
			get
			{
				return  this.deletable;

			}
			/// <summary>The method to set the value to deletable</summary>
			/// <param name="deletable">bool?</param>
			set
			{
				 this.deletable=value;

				 this.keyModified["deletable"] = 1;

			}
		}

		public string Description
		{
			/// <summary>The method to get the description</summary>
			/// <returns>string representing the description</returns>
			get
			{
				return  this.description;

			}
			/// <summary>The method to set the value to description</summary>
			/// <param name="description">string</param>
			set
			{
				 this.description=value;

				 this.keyModified["description"] = 1;

			}
		}

		public bool? Creatable
		{
			/// <summary>The method to get the creatable</summary>
			/// <returns>bool? representing the creatable</returns>
			get
			{
				return  this.creatable;

			}
			/// <summary>The method to set the value to creatable</summary>
			/// <param name="creatable">bool?</param>
			set
			{
				 this.creatable=value;

				 this.keyModified["creatable"] = 1;

			}
		}

		public bool? RecycleBinOnDelete
		{
			/// <summary>The method to get the recycleBinOnDelete</summary>
			/// <returns>bool? representing the recycleBinOnDelete</returns>
			get
			{
				return  this.recycleBinOnDelete;

			}
			/// <summary>The method to set the value to recycleBinOnDelete</summary>
			/// <param name="recycleBinOnDelete">bool?</param>
			set
			{
				 this.recycleBinOnDelete=value;

				 this.keyModified["recycle_bin_on_delete"] = 1;

			}
		}

		public bool? InventoryTemplateSupported
		{
			/// <summary>The method to get the inventoryTemplateSupported</summary>
			/// <returns>bool? representing the inventoryTemplateSupported</returns>
			get
			{
				return  this.inventoryTemplateSupported;

			}
			/// <summary>The method to set the value to inventoryTemplateSupported</summary>
			/// <param name="inventoryTemplateSupported">bool?</param>
			set
			{
				 this.inventoryTemplateSupported=value;

				 this.keyModified["inventory_template_supported"] = 1;

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

		public string PluralLabel
		{
			/// <summary>The method to get the pluralLabel</summary>
			/// <returns>string representing the pluralLabel</returns>
			get
			{
				return  this.pluralLabel;

			}
			/// <summary>The method to set the value to pluralLabel</summary>
			/// <param name="pluralLabel">string</param>
			set
			{
				 this.pluralLabel=value;

				 this.keyModified["plural_label"] = 1;

			}
		}

		public bool? PresenceSubMenu
		{
			/// <summary>The method to get the presenceSubMenu</summary>
			/// <returns>bool? representing the presenceSubMenu</returns>
			get
			{
				return  this.presenceSubMenu;

			}
			/// <summary>The method to set the value to presenceSubMenu</summary>
			/// <param name="presenceSubMenu">bool?</param>
			set
			{
				 this.presenceSubMenu=value;

				 this.keyModified["presence_sub_menu"] = 1;

			}
		}

		public bool? TriggersSupported
		{
			/// <summary>The method to get the triggersSupported</summary>
			/// <returns>bool? representing the triggersSupported</returns>
			get
			{
				return  this.triggersSupported;

			}
			/// <summary>The method to set the value to triggersSupported</summary>
			/// <param name="triggersSupported">bool?</param>
			set
			{
				 this.triggersSupported=value;

				 this.keyModified["triggers_supported"] = 1;

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

		public bool? ChartView
		{
			/// <summary>The method to get the chartView</summary>
			/// <returns>bool? representing the chartView</returns>
			get
			{
				return  this.chartView;

			}
			/// <summary>The method to set the value to chartView</summary>
			/// <param name="chartView">bool?</param>
			set
			{
				 this.chartView=value;

				 this.keyModified["chart_view"] = 1;

			}
		}

		public bool? Isblueprintsupported
		{
			/// <summary>The method to get the isblueprintsupported</summary>
			/// <returns>bool? representing the isblueprintsupported</returns>
			get
			{
				return  this.isblueprintsupported;

			}
			/// <summary>The method to set the value to isblueprintsupported</summary>
			/// <param name="isblueprintsupported">bool?</param>
			set
			{
				 this.isblueprintsupported=value;

				 this.keyModified["isBlueprintSupported"] = 1;

			}
		}

		public int? Visibility
		{
			/// <summary>The method to get the visibility</summary>
			/// <returns>int? representing the visibility</returns>
			get
			{
				return  this.visibility;

			}
			/// <summary>The method to set the value to visibility</summary>
			/// <param name="visibility">int?</param>
			set
			{
				 this.visibility=value;

				 this.keyModified["visibility"] = 1;

			}
		}

		public bool? Visible
		{
			/// <summary>The method to get the visible</summary>
			/// <returns>bool? representing the visible</returns>
			get
			{
				return  this.visible;

			}
			/// <summary>The method to set the value to visible</summary>
			/// <param name="visible">bool?</param>
			set
			{
				 this.visible=value;

				 this.keyModified["visible"] = 1;

			}
		}

		public bool? Convertable
		{
			/// <summary>The method to get the convertable</summary>
			/// <returns>bool? representing the convertable</returns>
			get
			{
				return  this.convertable;

			}
			/// <summary>The method to set the value to convertable</summary>
			/// <param name="convertable">bool?</param>
			set
			{
				 this.convertable=value;

				 this.keyModified["convertable"] = 1;

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

				 this.keyModified["editable"] = 1;

			}
		}

		public bool? EmailtemplateSupport
		{
			/// <summary>The method to get the emailtemplateSupport</summary>
			/// <returns>bool? representing the emailtemplateSupport</returns>
			get
			{
				return  this.emailtemplateSupport;

			}
			/// <summary>The method to set the value to emailtemplateSupport</summary>
			/// <param name="emailtemplateSupport">bool?</param>
			set
			{
				 this.emailtemplateSupport=value;

				 this.keyModified["emailTemplate_support"] = 1;

			}
		}

		public bool? EmailParserSupported
		{
			/// <summary>The method to get the emailParserSupported</summary>
			/// <returns>bool? representing the emailParserSupported</returns>
			get
			{
				return  this.emailParserSupported;

			}
			/// <summary>The method to set the value to emailParserSupported</summary>
			/// <param name="emailParserSupported">bool?</param>
			set
			{
				 this.emailParserSupported=value;

				 this.keyModified["email_parser_supported"] = 1;

			}
		}

		public bool? FilterSupported
		{
			/// <summary>The method to get the filterSupported</summary>
			/// <returns>bool? representing the filterSupported</returns>
			get
			{
				return  this.filterSupported;

			}
			/// <summary>The method to set the value to filterSupported</summary>
			/// <param name="filterSupported">bool?</param>
			set
			{
				 this.filterSupported=value;

				 this.keyModified["filter_supported"] = 1;

			}
		}

		public bool? ShowAsTab
		{
			/// <summary>The method to get the showAsTab</summary>
			/// <returns>bool? representing the showAsTab</returns>
			get
			{
				return  this.showAsTab;

			}
			/// <summary>The method to set the value to showAsTab</summary>
			/// <param name="showAsTab">bool?</param>
			set
			{
				 this.showAsTab=value;

				 this.keyModified["show_as_tab"] = 1;

			}
		}

		public string WebLink
		{
			/// <summary>The method to get the webLink</summary>
			/// <returns>string representing the webLink</returns>
			get
			{
				return  this.webLink;

			}
			/// <summary>The method to set the value to webLink</summary>
			/// <param name="webLink">string</param>
			set
			{
				 this.webLink=value;

				 this.keyModified["web_link"] = 1;

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

		public string SingularLabel
		{
			/// <summary>The method to get the singularLabel</summary>
			/// <returns>string representing the singularLabel</returns>
			get
			{
				return  this.singularLabel;

			}
			/// <summary>The method to set the value to singularLabel</summary>
			/// <param name="singularLabel">string</param>
			set
			{
				 this.singularLabel=value;

				 this.keyModified["singular_label"] = 1;

			}
		}

		public bool? Viewable
		{
			/// <summary>The method to get the viewable</summary>
			/// <returns>bool? representing the viewable</returns>
			get
			{
				return  this.viewable;

			}
			/// <summary>The method to set the value to viewable</summary>
			/// <param name="viewable">bool?</param>
			set
			{
				 this.viewable=value;

				 this.keyModified["viewable"] = 1;

			}
		}

		public bool? APISupported
		{
			/// <summary>The method to get the aPISupported</summary>
			/// <returns>bool? representing the apiSupported</returns>
			get
			{
				return  this.apiSupported;

			}
			/// <summary>The method to set the value to aPISupported</summary>
			/// <param name="apiSupported">bool?</param>
			set
			{
				 this.apiSupported=value;

				 this.keyModified["api_supported"] = 1;

			}
		}

		public string APIName
		{
			/// <summary>The method to get the aPIName</summary>
			/// <returns>string representing the apiName</returns>
			get
			{
				return  this.apiName;

			}
			/// <summary>The method to set the value to aPIName</summary>
			/// <param name="apiName">string</param>
			set
			{
				 this.apiName=value;

				 this.keyModified["api_name"] = 1;

			}
		}

		public bool? QuickCreate
		{
			/// <summary>The method to get the quickCreate</summary>
			/// <returns>bool? representing the quickCreate</returns>
			get
			{
				return  this.quickCreate;

			}
			/// <summary>The method to set the value to quickCreate</summary>
			/// <param name="quickCreate">bool?</param>
			set
			{
				 this.quickCreate=value;

				 this.keyModified["quick_create"] = 1;

			}
		}

		public Choice<string> GeneratedType
		{
			/// <summary>The method to get the generatedType</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.generatedType;

			}
			/// <summary>The method to set the value to generatedType</summary>
			/// <param name="generatedType">Instance of Choice<string></param>
			set
			{
				 this.generatedType=value;

				 this.keyModified["generated_type"] = 1;

			}
		}

		public bool? FeedsRequired
		{
			/// <summary>The method to get the feedsRequired</summary>
			/// <returns>bool? representing the feedsRequired</returns>
			get
			{
				return  this.feedsRequired;

			}
			/// <summary>The method to set the value to feedsRequired</summary>
			/// <param name="feedsRequired">bool?</param>
			set
			{
				 this.feedsRequired=value;

				 this.keyModified["feeds_required"] = 1;

			}
		}

		public bool? ScoringSupported
		{
			/// <summary>The method to get the scoringSupported</summary>
			/// <returns>bool? representing the scoringSupported</returns>
			get
			{
				return  this.scoringSupported;

			}
			/// <summary>The method to set the value to scoringSupported</summary>
			/// <param name="scoringSupported">bool?</param>
			set
			{
				 this.scoringSupported=value;

				 this.keyModified["scoring_supported"] = 1;

			}
		}

		public bool? WebformSupported
		{
			/// <summary>The method to get the webformSupported</summary>
			/// <returns>bool? representing the webformSupported</returns>
			get
			{
				return  this.webformSupported;

			}
			/// <summary>The method to set the value to webformSupported</summary>
			/// <param name="webformSupported">bool?</param>
			set
			{
				 this.webformSupported=value;

				 this.keyModified["webform_supported"] = 1;

			}
		}

		public Territory Territory
		{
			/// <summary>The method to get the territory</summary>
			/// <returns>Instance of Territory</returns>
			get
			{
				return  this.territory;

			}
			/// <summary>The method to set the value to territory</summary>
			/// <param name="territory">Instance of Territory</param>
			set
			{
				 this.territory=value;

				 this.keyModified["territory"] = 1;

			}
		}

		public List<Argument> Arguments
		{
			/// <summary>The method to get the arguments</summary>
			/// <returns>Instance of List<Argument></returns>
			get
			{
				return  this.arguments;

			}
			/// <summary>The method to set the value to arguments</summary>
			/// <param name="arguments">Instance of List<Argument></param>
			set
			{
				 this.arguments=value;

				 this.keyModified["arguments"] = 1;

			}
		}

		public string ModuleName
		{
			/// <summary>The method to get the moduleName</summary>
			/// <returns>string representing the moduleName</returns>
			get
			{
				return  this.moduleName;

			}
			/// <summary>The method to set the value to moduleName</summary>
			/// <param name="moduleName">string</param>
			set
			{
				 this.moduleName=value;

				 this.keyModified["module_name"] = 1;

			}
		}

		public bool? ChartViewSupported
		{
			/// <summary>The method to get the chartViewSupported</summary>
			/// <returns>bool? representing the chartViewSupported</returns>
			get
			{
				return  this.chartViewSupported;

			}
			/// <summary>The method to set the value to chartViewSupported</summary>
			/// <param name="chartViewSupported">bool?</param>
			set
			{
				 this.chartViewSupported=value;

				 this.keyModified["chart_view_supported"] = 1;

			}
		}

		public int? ProfileCount
		{
			/// <summary>The method to get the profileCount</summary>
			/// <returns>int? representing the profileCount</returns>
			get
			{
				return  this.profileCount;

			}
			/// <summary>The method to set the value to profileCount</summary>
			/// <param name="profileCount">int?</param>
			set
			{
				 this.profileCount=value;

				 this.keyModified["profile_count"] = 1;

			}
		}

		public int? BusinessCardFieldLimit
		{
			/// <summary>The method to get the businessCardFieldLimit</summary>
			/// <returns>int? representing the businessCardFieldLimit</returns>
			get
			{
				return  this.businessCardFieldLimit;

			}
			/// <summary>The method to set the value to businessCardFieldLimit</summary>
			/// <param name="businessCardFieldLimit">int?</param>
			set
			{
				 this.businessCardFieldLimit=value;

				 this.keyModified["business_card_field_limit"] = 1;

			}
		}

		public bool? TrackCurrentData
		{
			/// <summary>The method to get the trackCurrentData</summary>
			/// <returns>bool? representing the trackCurrentData</returns>
			get
			{
				return  this.trackCurrentData;

			}
			/// <summary>The method to set the value to trackCurrentData</summary>
			/// <param name="trackCurrentData">bool?</param>
			set
			{
				 this.trackCurrentData=value;

				 this.keyModified["track_current_data"] = 1;

			}
		}

		public Users.MinifiedUser ModifiedBy
		{
			/// <summary>The method to get the modifiedBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.modifiedBy;

			}
			/// <summary>The method to set the value to modifiedBy</summary>
			/// <param name="modifiedBy">Instance of MinifiedUser</param>
			set
			{
				 this.modifiedBy=value;

				 this.keyModified["modified_by"] = 1;

			}
		}

		public List<Profiles.MinifiedProfile> Profiles
		{
			/// <summary>The method to get the profiles</summary>
			/// <returns>Instance of List<MinifiedProfile></returns>
			get
			{
				return  this.profiles;

			}
			/// <summary>The method to set the value to profiles</summary>
			/// <param name="profiles">Instance of List<MinifiedProfile></param>
			set
			{
				 this.profiles=value;

				 this.keyModified["profiles"] = 1;

			}
		}

		public MinifiedModule ParentModule
		{
			/// <summary>The method to get the parentModule</summary>
			/// <returns>Instance of MinifiedModule</returns>
			get
			{
				return  this.parentModule;

			}
			/// <summary>The method to set the value to parentModule</summary>
			/// <param name="parentModule">Instance of MinifiedModule</param>
			set
			{
				 this.parentModule=value;

				 this.keyModified["parent_module"] = 1;

			}
		}

		public Choice<string> ActivityBadge
		{
			/// <summary>The method to get the activityBadge</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.activityBadge;

			}
			/// <summary>The method to set the value to activityBadge</summary>
			/// <param name="activityBadge">Instance of Choice<string></param>
			set
			{
				 this.activityBadge=value;

				 this.keyModified["activity_badge"] = 1;

			}
		}

		public List<string> FieldStates
		{
			/// <summary>The method to get the fieldStates</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.fieldStates;

			}
			/// <summary>The method to set the value to fieldStates</summary>
			/// <param name="fieldStates">Instance of List<string></param>
			set
			{
				 this.fieldStates=value;

				 this.keyModified["$field_states"] = 1;

			}
		}

		public List<string> BusinessCardFields
		{
			/// <summary>The method to get the businessCardFields</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.businessCardFields;

			}
			/// <summary>The method to set the value to businessCardFields</summary>
			/// <param name="businessCardFields">Instance of List<string></param>
			set
			{
				 this.businessCardFields=value;

				 this.keyModified["business_card_fields"] = 1;

			}
		}

		public int? PerPage
		{
			/// <summary>The method to get the perPage</summary>
			/// <returns>int? representing the perPage</returns>
			get
			{
				return  this.perPage;

			}
			/// <summary>The method to set the value to perPage</summary>
			/// <param name="perPage">int?</param>
			set
			{
				 this.perPage=value;

				 this.keyModified["per_page"] = 1;

			}
		}

		public List<string> Properties
		{
			/// <summary>The method to get the properties</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.properties;

			}
			/// <summary>The method to set the value to properties</summary>
			/// <param name="properties">Instance of List<string></param>
			set
			{
				 this.properties=value;

				 this.keyModified["$properties"] = 1;

			}
		}

		public List<string> OnDemandProperties
		{
			/// <summary>The method to get the onDemandProperties</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.onDemandProperties;

			}
			/// <summary>The method to set the value to onDemandProperties</summary>
			/// <param name="onDemandProperties">Instance of List<string></param>
			set
			{
				 this.onDemandProperties=value;

				 this.keyModified["$on_demand_properties"] = 1;

			}
		}

		public List<string> SearchLayoutFields
		{
			/// <summary>The method to get the searchLayoutFields</summary>
			/// <returns>Instance of List<String></returns>
			get
			{
				return  this.searchLayoutFields;

			}
			/// <summary>The method to set the value to searchLayoutFields</summary>
			/// <param name="searchLayoutFields">Instance of List<string></param>
			set
			{
				 this.searchLayoutFields=value;

				 this.keyModified["search_layout_fields"] = 1;

			}
		}

		public bool? KanbanViewSupported
		{
			/// <summary>The method to get the kanbanViewSupported</summary>
			/// <returns>bool? representing the kanbanViewSupported</returns>
			get
			{
				return  this.kanbanViewSupported;

			}
			/// <summary>The method to set the value to kanbanViewSupported</summary>
			/// <param name="kanbanViewSupported">bool?</param>
			set
			{
				 this.kanbanViewSupported=value;

				 this.keyModified["kanban_view_supported"] = 1;

			}
		}

		public LookupFieldProperties LookupFieldProperties
		{
			/// <summary>The method to get the lookupFieldProperties</summary>
			/// <returns>Instance of LookupFieldProperties</returns>
			get
			{
				return  this.lookupFieldProperties;

			}
			/// <summary>The method to set the value to lookupFieldProperties</summary>
			/// <param name="lookupFieldProperties">Instance of LookupFieldProperties</param>
			set
			{
				 this.lookupFieldProperties=value;

				 this.keyModified["lookup_field_properties"] = 1;

			}
		}

		public bool? KanbanView
		{
			/// <summary>The method to get the kanbanView</summary>
			/// <returns>bool? representing the kanbanView</returns>
			get
			{
				return  this.kanbanView;

			}
			/// <summary>The method to set the value to kanbanView</summary>
			/// <param name="kanbanView">bool?</param>
			set
			{
				 this.kanbanView=value;

				 this.keyModified["kanban_view"] = 1;

			}
		}

		public List<RelatedLists.RelatedList> RelatedLists
		{
			/// <summary>The method to get the relatedLists</summary>
			/// <returns>Instance of List<RelatedList></returns>
			get
			{
				return  this.relatedLists;

			}
			/// <summary>The method to set the value to relatedLists</summary>
			/// <param name="relatedLists">Instance of List<RelatedList></param>
			set
			{
				 this.relatedLists=value;

				 this.keyModified["related_lists"] = 1;

			}
		}

		public bool? FilterStatus
		{
			/// <summary>The method to get the filterStatus</summary>
			/// <returns>bool? representing the filterStatus</returns>
			get
			{
				return  this.filterStatus;

			}
			/// <summary>The method to set the value to filterStatus</summary>
			/// <param name="filterStatus">bool?</param>
			set
			{
				 this.filterStatus=value;

				 this.keyModified["filter_status"] = 1;

			}
		}

		public RelatedListProperties RelatedListProperties
		{
			/// <summary>The method to get the relatedListProperties</summary>
			/// <returns>Instance of RelatedListProperties</returns>
			get
			{
				return  this.relatedListProperties;

			}
			/// <summary>The method to set the value to relatedListProperties</summary>
			/// <param name="relatedListProperties">Instance of RelatedListProperties</param>
			set
			{
				 this.relatedListProperties=value;

				 this.keyModified["related_list_properties"] = 1;

			}
		}

		public object DisplayField
		{
			/// <summary>The method to get the displayField</summary>
			/// <returns>object representing the displayField</returns>
			get
			{
				return  this.displayField;

			}
			/// <summary>The method to set the value to displayField</summary>
			/// <param name="displayField">object</param>
			set
			{
				 this.displayField=value;

				 this.keyModified["display_field"] = 1;

			}
		}

		public List<object> Layouts
		{
			/// <summary>The method to get the layouts</summary>
			/// <returns>Instance of List<Object></returns>
			get
			{
				return  this.layouts;

			}
			/// <summary>The method to set the value to layouts</summary>
			/// <param name="layouts">Instance of List<object></param>
			set
			{
				 this.layouts=value;

				 this.keyModified["layouts"] = 1;

			}
		}

		public List<ModuleFields> Fields
		{
			/// <summary>The method to get the fields</summary>
			/// <returns>Instance of List<ModuleFields></returns>
			get
			{
				return  this.fields;

			}
			/// <summary>The method to set the value to fields</summary>
			/// <param name="fields">Instance of List<ModuleFields></param>
			set
			{
				 this.fields=value;

				 this.keyModified["fields"] = 1;

			}
		}

		public CustomViews.CustomViews CustomView
		{
			/// <summary>The method to get the customView</summary>
			/// <returns>Instance of CustomViews</returns>
			get
			{
				return  this.customView;

			}
			/// <summary>The method to set the value to customView</summary>
			/// <param name="customView">Instance of CustomViews</param>
			set
			{
				 this.customView=value;

				 this.keyModified["custom_view"] = 1;

			}
		}

		public bool? ZiaView
		{
			/// <summary>The method to get the ziaView</summary>
			/// <returns>bool? representing the ziaView</returns>
			get
			{
				return  this.ziaView;

			}
			/// <summary>The method to set the value to ziaView</summary>
			/// <param name="ziaView">bool?</param>
			set
			{
				 this.ziaView=value;

				 this.keyModified["zia_view"] = 1;

			}
		}

		public List<Fields.MinifiedField> DefaultMappingFields
		{
			/// <summary>The method to get the defaultMappingFields</summary>
			/// <returns>Instance of List<MinifiedField></returns>
			get
			{
				return  this.defaultMappingFields;

			}
			/// <summary>The method to set the value to defaultMappingFields</summary>
			/// <param name="defaultMappingFields">Instance of List<MinifiedField></param>
			set
			{
				 this.defaultMappingFields=value;

				 this.keyModified["default_mapping_fields"] = 1;

			}
		}

		public string Status
		{
			/// <summary>The method to get the status</summary>
			/// <returns>string representing the status</returns>
			get
			{
				return  this.status;

			}
			/// <summary>The method to set the value to status</summary>
			/// <param name="status">string</param>
			set
			{
				 this.status=value;

				 this.keyModified["status"] = 1;

			}
		}

		public StaticSubformProperties StaticSubformProperties
		{
			/// <summary>The method to get the staticSubformProperties</summary>
			/// <returns>Instance of StaticSubformProperties</returns>
			get
			{
				return  this.staticSubformProperties;

			}
			/// <summary>The method to set the value to staticSubformProperties</summary>
			/// <param name="staticSubformProperties">Instance of StaticSubformProperties</param>
			set
			{
				 this.staticSubformProperties=value;

				 this.keyModified["static_subform_properties"] = 1;

			}
		}

		public List<Fields.LayoutAssociation> LayoutAssociations
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