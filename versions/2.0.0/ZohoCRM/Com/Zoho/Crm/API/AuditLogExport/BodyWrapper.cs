using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.AuditLogExport
{

	public class BodyWrapper : Model
	{
		private List<AuditLogExport> auditLogExport;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<AuditLogExport> AuditLogExport
		{
			/// <summary>The method to get the auditLogExport</summary>
			/// <returns>Instance of List<AuditLogExport></returns>
			get
			{
				return  this.auditLogExport;

			}
			/// <summary>The method to set the value to auditLogExport</summary>
			/// <param name="auditLogExport">Instance of List<AuditLogExport></param>
			set
			{
				 this.auditLogExport=value;

				 this.keyModified["audit_log_export"] = 1;

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