using System;

namespace Com.Zoho.Crm.API.Dc
{
    /// <summary>
    /// This class represents the properties of Zoho CRM in CA Domain.
    /// </summary>
    public class CADataCenter : DataCenter
    {
        private static readonly CADataCenter CA = new CADataCenter();

        private CADataCenter()
        {
        }

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Production Environment in CA Domain.
        /// </summary>
        public static readonly Environment PRODUCTION = new Environment("https://www.zohoapis.ca", CA.GetIAMUrl(), CA.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Sandbox Environment in CA Domain.
        /// </summary>
        public static readonly Environment SANDBOX = new Environment("https://sandbox.zohoapis.ca", CA.GetIAMUrl(), CA.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Developer Environment in CA Domain.
        /// </summary>
        public static readonly Environment DEVELOPER = new Environment("https://developer.zohoapis.ca", CA.GetIAMUrl(), CA.GetFileUploadUrl());

        public override string GetIAMUrl()
        {
            return "https://accounts.zohocloud.ca/oauth/v2/token";
        }

        public override string GetFileUploadUrl()
        {
            return "https://upload.zohocloud.ca";
        }
    }
}

