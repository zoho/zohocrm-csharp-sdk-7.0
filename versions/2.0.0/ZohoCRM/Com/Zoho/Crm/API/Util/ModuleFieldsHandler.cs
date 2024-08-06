using System;
using System.IO;
using System.Runtime.Serialization;
using Com.Zoho.API.Exception;
using Com.Zoho.Crm.API.Logger;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Com.Zoho.Crm.API.Util
{
    /// <summary>
    /// The class contains methods to manipulate the module fields only when autoRefreshFields is set to false in Initializer.
    /// </summary>
    public class ModuleFieldsHandler
	{
		private static object LOCK = new object();

		/// <summary>
		/// The method to obtain resources directory path.
		/// </summary>
		/// <returns>A String representing the directory's absolute path.</returns>
		private static string GetDirectory()
	    {
		    return Initializer.GetInitializer().ResourcePath + Path.DirectorySeparatorChar + Constants.FIELD_DETAILS_DIRECTORY;
	    }

		///<summary>
		/// The method to delete fields JSON File of the current user.
		///</summary>
		public static void DeleteFieldsFile()
	    {
            lock (LOCK)
            {
				try
				{
                    Type classType = typeof(JSONConverter);
                    object instance = FormatterServices.GetUninitializedObject(classType);
                    Converter converterInstance = (Converter)instance;
                    string recordFieldDetailsPath = GetDirectory() + Path.DirectorySeparatorChar + converterInstance.GetEncodedFileName();
					if (File.Exists(recordFieldDetailsPath))
					{
                       File.Delete(recordFieldDetailsPath);
					}
				}
				catch (Exception e)
				{
					SDKException exception = new SDKException(e);
					SDKLogger.LogError(Constants.DELETE_FIELD_FILE_ERROR + JsonConvert.SerializeObject(exception));
					throw exception;
				}
			}
	    }

		///<summary>
		/// The method to delete all the field JSON files under resources directory.
		///</summary>
		public static void DeleteAllFieldFiles()
	    {
			lock (LOCK)
			{
				try
				{
					if (Directory.Exists(GetDirectory()))
					{
						string[] files = Directory.GetFiles(GetDirectory());
						if (files != null)
						{
							foreach (string file in files)
							{
								if(file.EndsWith(Constants.JSON_FILE_EXTENSION))
                                {
                                    File.Delete(file);
								}
							}
						}
					}
				}
				catch (Exception e)
				{
					SDKException exception = new SDKException(e);
					SDKLogger.LogError(Constants.DELETE_FIELD_FILES_ERROR + JsonConvert.SerializeObject(exception));
					throw exception;
				}
			}
	    }

		/// <summary>
		/// The method to delete fields of the given module from the current user's fields JSON file.
		/// </summary>
		/// <param name="module">A string representing the module.</param>
		public static void DeleteFields(string module)
	    {
		    try
		    {
                Type classType = typeof(JSONConverter);
                object instance = FormatterServices.GetUninitializedObject(classType);
                Converter converterInstance = (Converter)instance;
                string recordFieldDetailsPath = GetDirectory() + Path.DirectorySeparatorChar + converterInstance.GetEncodedFileName();
				if (File.Exists(recordFieldDetailsPath))
				{
				    JObject recordFieldDetailsJson = Initializer.GetJSON(recordFieldDetailsPath);
				    if(recordFieldDetailsJson.ContainsKey(module.ToLower()))
				    {
						Utility.DeleteFields(recordFieldDetailsJson, module);
						using (StreamWriter sw = System.IO.File.CreateText(recordFieldDetailsPath))
						{
							JsonSerializer serializer = new JsonSerializer();
							serializer.Serialize(sw, recordFieldDetailsJson);
							sw.Flush();
							sw.Close();
						}
					}
				}
		    }
		    catch (Exception e)
		    {
				SDKException exception = new SDKException(e);
				throw exception;
			}
	    }

		/// <summary>
		/// The method to force-refresh fields of a module.
		/// </summary>
		/// <param name="module">module A string representing the module.</param>
		public static void RefreshFields(string module)
		{
			lock (LOCK)
			{
				try
				{
					DeleteFields(module);
					Utility.GetFieldsInfo(module, null);
				}
				catch (SDKException e)
				{
					SDKLogger.LogError(Constants.REFRESH_SINGLE_MODULE_FIELDS_ERROR + module + JsonConvert.SerializeObject(e));
					throw e;
				}
				catch (Exception e)
				{
					SDKException exception = new SDKException(e);
					SDKLogger.LogError(Constants.REFRESH_SINGLE_MODULE_FIELDS_ERROR + module + JsonConvert.SerializeObject(exception));
					throw exception;
				}
			}
		}

		/**
		 * The method to force-refresh fields of all the available modules.
		 * @throws SDKException
		 */
		public static void RefreshAllModules()
		{
			lock (LOCK)
			{
				try
				{
					Utility.RefreshModules();
				}
				catch (SDKException e)
				{
					SDKLogger.LogError(Constants.REFRESH_ALL_MODULE_FIELDS_ERROR + JsonConvert.SerializeObject(e));

					throw e;
				}
				catch (Exception e)
				{
					SDKException exception = new SDKException(e);
					SDKLogger.LogError(Constants.REFRESH_ALL_MODULE_FIELDS_ERROR + JsonConvert.SerializeObject(exception));
					throw exception;
				}
			}
		}
    }
}