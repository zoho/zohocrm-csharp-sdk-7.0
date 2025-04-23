using System.Linq;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.Dc
{
    /// <summary>
    /// The abstract class represents the properties of Zoho CRM DataCenter.
    /// </summary>
    public abstract class DataCenter
    {
        /// <summary>
        /// This method to get accounts URL. URL to be used when calling an OAuth accounts.
        /// </summary>
        /// <returns>A String representing the accounts URL.</returns>
        public abstract string GetIAMUrl();

        /// <summary>
        /// This method to get File Upload URL.
        /// </summary>
        /// <returns>A String representing the FileUpload URL.</returns>
        public abstract string GetFileUploadUrl();

        /// <summary>
        /// The abstract class represents the properties of Zoho CRM Environment.
        /// </summary>
        public class Environment
        {
            private string url;

            private string accountsUrl;

            private string fileUploadUrl;

            public Environment(string url, string accountsUrl, string fileUploadUrl)
            {
                this.accountsUrl = accountsUrl;
                this.url = url;
                this.fileUploadUrl = fileUploadUrl;
            }

            /// <summary>
            /// This method to get Zoho CRM API URL.
            /// </summary>
            /// <returns>A String representing the Zoho CRM API URL.</returns>
            public string GetUrl()
            {
                return this.url;
            }

            /// <summary>
            /// This method to get Zoho CRM Accounts URL.
            /// </summary>
            /// <returns>A String representing the accounts URL.</returns>
            public string GetAccountsUrl()
            {
                return this.accountsUrl;
            }

            /// <summary>
            /// This method to get Zoho CRM File Upload URL.
            /// </summary>
            /// <returns>A String representing the FileUpload URL.</returns>
            public string GetFileUploadUrl()
            {
                return this.fileUploadUrl;
            }
        }

        public static Environment Get(string config)
        {
		    if(Constants.US_DATACENTER.Any(a => a.Equals(config)))
		    {
			    if(config.Contains(Constants.SANDBOX))
			    {
				    return USDataCenter.SANDBOX;
			    }
			    else if(config.Contains(Constants.DEVELOPER))
			    {
				    return USDataCenter.DEVELOPER;
			    }
                return USDataCenter.PRODUCTION;
		    }
		    if (Constants.JP_DATACENTER.Any(a=>a.Equals(config)))
            {
                if (config.Contains(Constants.SANDBOX))
                {
                    return JPDataCenter.SANDBOX;
                }
                else if (config.Contains(Constants.DEVELOPER))
                {
                    return JPDataCenter.DEVELOPER;
                }
                return JPDataCenter.PRODUCTION;
            }
            if (Constants.IN_DATACENTER.Any(a=>a.Equals(config)))
            {
                if (config.Contains(Constants.SANDBOX))
                {
                    return INDataCenter.SANDBOX;
                }
                else if (config.Contains(Constants.DEVELOPER))
                {
                    return INDataCenter.DEVELOPER;
                }
                return INDataCenter.PRODUCTION;
            }
            else if (Constants.EU_DATACENTER.Any(a=>a.Equals(config)))
            {
                if (config.Contains(Constants.SANDBOX))
                {
                    return EUDataCenter.SANDBOX;
                }
                else if (config.Contains(Constants.DEVELOPER))
                {
                    return EUDataCenter.DEVELOPER;
                }
                return EUDataCenter.PRODUCTION;
            }
            else if (Constants.CN_DATACENTER.Any(a=>a.Equals(config)))
            {
                if (config.Contains(Constants.SANDBOX))
                {
                    return CNDataCenter.SANDBOX;
                }
                else if (config.Contains(Constants.DEVELOPER))
                {
                    return CNDataCenter.DEVELOPER;
                }
                return CNDataCenter.PRODUCTION;
            }
            else if (Constants.AU_DATACENTER.Any(a=>a.Equals(config)))
            {
                if (config.Contains(Constants.SANDBOX))
                {
                    return AUDataCenter.SANDBOX;
                }
                else if (config.Contains(Constants.DEVELOPER))
                {
                    return AUDataCenter.DEVELOPER;
                }
                return AUDataCenter.PRODUCTION;
            }
            else if (Constants.CA_DATACENTER.Any(a => a.Equals(config)))
            {
                if (config.Contains(Constants.SANDBOX))
                {
                    return CADataCenter.SANDBOX;
                }
                else if (config.Contains(Constants.DEVELOPER))
                {
                    return CADataCenter.DEVELOPER;
                }
                return CADataCenter.PRODUCTION;
            }
            else if (Constants.SA_DATACENTER.Any(a => a.Equals(config)))
            {
                if (config.Contains(Constants.SANDBOX))
                {
                    return SADataCenter.SANDBOX;
                }
                else if (config.Contains(Constants.DEVELOPER))
                {
                    return SADataCenter.DEVELOPER;
                }
                return SADataCenter.PRODUCTION;
            }
            return null;
	    }
    }
}
