using System;

namespace Com.Zoho.Crm.API.Dc
{
    /// <summary>
    /// This class represents the properties of Zoho CRM in SA Domain.
    /// </summary>
    public class SADataCenter : DataCenter
    {
        private static readonly SADataCenter SA = new SADataCenter();

        private SADataCenter()
        {
        }

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Production Environment in SA Domain.
        /// </summary>
        public static readonly Environment PRODUCTION = new Environment("https://www.zohoapis.sa", SA.GetIAMUrl(), SA.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Sandbox Environment in SA Domain.
        /// </summary>
        public static readonly Environment SANDBOX = new Environment("https://sandbox.zohoapis.sa", SA.GetIAMUrl(), SA.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Developer Environment in SA Domain.
        /// </summary>
        public static readonly Environment DEVELOPER = new Environment("https://developer.zohoapis.sa", SA.GetIAMUrl(), SA.GetFileUploadUrl());

        public override string GetIAMUrl()
        {
            return "https://accounts.zoho.sa/oauth/v2/token";
        }

        public override string GetFileUploadUrl()
        {
            return "https://files.zoho.sa";
        }
    }
}
