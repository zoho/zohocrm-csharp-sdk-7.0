using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Functions
{

	public class FileBodyWrapper : Model
	{
		private StreamWrapper inputfile;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public StreamWrapper Inputfile
		{
			/// <summary>The method to get the inputfile</summary>
			/// <returns>Instance of StreamWrapper</returns>
			get
			{
				return  this.inputfile;

			}
			/// <summary>The method to set the value to inputfile</summary>
			/// <param name="inputfile">Instance of StreamWrapper</param>
			set
			{
				 this.inputfile=value;

				 this.keyModified["inputFile"] = 1;

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