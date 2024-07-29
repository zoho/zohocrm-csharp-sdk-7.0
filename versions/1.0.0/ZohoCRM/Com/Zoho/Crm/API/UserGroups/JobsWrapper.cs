using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UserGroups
{

	public class JobsWrapper : Model
	{
		private List<Jobs> deletionJobs;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<Jobs> DeletionJobs
		{
			/// <summary>The method to get the deletionJobs</summary>
			/// <returns>Instance of List<Jobs></returns>
			get
			{
				return  this.deletionJobs;

			}
			/// <summary>The method to set the value to deletionJobs</summary>
			/// <param name="deletionJobs">Instance of List<Jobs></param>
			set
			{
				 this.deletionJobs=value;

				 this.keyModified["deletion_jobs"] = 1;

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