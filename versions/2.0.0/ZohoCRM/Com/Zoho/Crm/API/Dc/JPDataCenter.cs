using System;

namespace Com.Zoho.Crm.API.Dc
{
    /// <summary>
    /// This class represents the properties of Zoho CRM in Japan Domain.
    /// </summary>
    public class JPDataCenter : DataCenter
    {
        private static readonly JPDataCenter JP = new JPDataCenter();

        private JPDataCenter()
        {
        }

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Production Environment in Japan Domain.
        /// </summary>
        public static readonly Environment PRODUCTION = new Environment("https://www.zohoapis.jp", JP.GetIAMUrl(), JP.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Sandbox Environment in Japan Domain.
        /// </summary>
        public static readonly Environment SANDBOX = new Environment("https://sandbox.zohoapis.jp", JP.GetIAMUrl(), JP.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Developer Environment in Japan Domain.
        /// </summary>
        public static readonly Environment DEVELOPER = new Environment("https://developer.zohoapis.jp", JP.GetIAMUrl(), JP.GetFileUploadUrl());

        public override string GetIAMUrl()
        {
            return "https://accounts.zoho.jp/oauth/v2/token";
        }

        public override string GetFileUploadUrl()
        {
            return "https://content.zohoapis.jp";
        }
    }
}
