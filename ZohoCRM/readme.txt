————————————————————————
Zoho CRM C# SDK 5.0.0
————————————————————————

This is the readme file for Zoho CRM’s C# SDK version 5.0.0.

This file gives a brief of the enhancements and/or bug fixes in the latest version.

--------------------------
Enhancements and Bug fixes
--------------------------
  - Added new **page_token** param in **GetAttachmentsParam** class.
  - **CadencesExecutionOperations** class method name changed(**EnrolCadences** to **EnrollCadences**).
  - **CadencesExecutionOperations** class method name changed(**UnenrolCadences** to **UnenrollCadences**).
  - **DealContactRolesOperations** class method name changed(**DeleteContactRoleRealation** to **DeleteContactRoleRelation**).
  - **EmailRelatedRecords** **Email** class **threadId** field datatype changed(long? to string).
  - Added new params **category**, **sort_by**, **sort_order**, and **filters** in **GetEmailTemplatesParam** class.
  - Added new fields **referenceValue**, **dealCategory**, and **showValue** in **PickListValue** class.
  - Added new field **delete** in **PickListValue** class in **Fields** API.
  - Added new param **filters** in **GetInventoryTemplatesParam** class.
  - Added new field **delete** in **SectionField** class in **Layouts** API.
  - Added new field **delete** in **Sections** class in **Layouts** API.
  - **Modules** class **displayField** field datatype changed(string to object).
  - Added new method param **paramInstance**  in **ModulesOperations** class **GetModules** method.
  - Added new param **status** in **GetModulesParam** class.
  - Added new param **type** in SearchRecordsParam class.
  - Added new param **cvid** in RecordCountParam class.
  - Added new params **page_token**, **page**, and **per_page** in **GetRecordLockingInformationsParam** class.
  - Removed **module** param in **ScoringRulesOperations** class **GetScoringRule** method.
  - Update **recordId**, **moduleAPIName** to **moduleAPIName**, **recordId** param location in **TagsOperations** class **AddTags** method.
  - Update **recordId**, **moduleAPIName** to **moduleAPIName**, **recordId** param location in **TagsOperations** class **RemoveTags** method.
  - Added new param **color_code** in **CreateTagsParam** class.
  - **RemoveTagsFromMultipleRecordsParam** class **ids** param datatype changed(Long to String). 
  - Added new param **ids** in **GetTerritoriesParam** class.
  - Added new param **page** and **per_page** in **GetChildTerritoryParam** class.
  - Added new method param**paramInstance** in **UserGroupsOperations** class **GetAssociatedUsersCount** method.
  - Added new params **filters**, **page**, and **per_page** in **GetAssociatedUsersCountParam** class.
  - Handled FileStore save and update token method issue.
  
  - Deprecated and removed API methods:
    - UsersTerritories
      - ValidateBeforeTransferForAllTerritories
      - ValidateBeforeTransfer
      - DelinkAndTransferFromAllTerritories
      - DelinkAndTransferFromSpecificTerritory

  - Support for the following new APIs
    - AuditLogExport
      - [Download Export Audit Log Result](https://www.zoho.com/crm/developer/docs/api/v7/download-export-audit-log-result.html)
    - Cadences
      - [Cadence API](https://www.zoho.com/crm/developer/docs/api/v7/cadences/get-cadences.html)
    - DealContactRoles
      - [Remove Contact Role from a Specific Deal](https://www.zoho.com/crm/developer/docs/api/v7/remove-contact-role-from-a-specific-deal.html)
    - InventoryConvert
      - [Convert Inventory Records](https://www.zoho.com/crm/developer/docs/api/v7/inventory-convert.html)
    - InventoryMassConvert
      - [Mass Convert Inventory Records](https://www.zoho.com/crm/developer/docs/api/v7/mass-inventory-convert.html)
      - [Get Mass Inventory Conversion Status](https://www.zoho.com/crm/developer/docs/api/v7/mass-inventory-conversion-status-api.html)
    - Layouts
      - [Update Custom Layout](https://www.zoho.com/crm/developer/docs/api/v7/update-custom-layout.html)
      - [Delete Custom Layout](https://www.zoho.com/crm/developer/docs/api/v7/delete-custom-layout.html)
      - [Activate Custom Layout](https://www.zoho.com/crm/developer/docs/api/v7/activate-custom-layout.html)
      - [Deactivate Custom Layout](https://www.zoho.com/crm/developer/docs/api/v7/deactivate-custom-layout.html)
    - Modules
      - [Create Custom Module](https://www.zoho.com/crm/developer/docs/api/v7/create-custom-module-api.html)
    - Record
      - [Get Rich Text Fields](https://www.zoho.com/crm/developer/docs/api/v7/get-rich-text-fields.html)
    - RecordLockingConfiguration
      - [Record Locking Configuration APIs](https://www.zoho.com/crm/developer/docs/api/v7/get-record-locking-config.html)
      - [Add Record Locking Configuration](https://www.zoho.com/crm/developer/docs/api/v7/add-record-locking-config.html)
      - [Update Record Locking Configuration](https://www.zoho.com/crm/developer/docs/api/v7/update-record-locking-config.html)
      - [Delete Record Locking Configuration](https://www.zoho.com/crm/developer/docs/api/v7/delete-record-locking-config.html)
    - RecycleBin
      - [Get Recycle Bin Records](https://www.zoho.com/crm/developer/docs/api/v7/get-recycle-bin.html)
      - [Delete Recycle Bin Records](https://www.zoho.com/crm/developer/docs/api/v7/del-recycle-bin-records.html)
    - UserGroups
      - [Associated Groups of a User](https://www.zoho.com/crm/developer/docs/api/v7/associated-groups-of-a-user.html)
    - UsersTerritories
      - [Remove Territories from User](https://www.zoho.com/crm/developer/docs/api/v7/remove-territories-from-user.html)
    - ZiaEnrichment
      - [Enrichment Configuration](https://www.zoho.com/crm/developer/docs/api/v7/zia-enrichment/get-config.html)

You can also take a look at our GitHub page here (https://github.com/zoho/zohocrm-csharp-sdk-7.0/blob/master/README.md)