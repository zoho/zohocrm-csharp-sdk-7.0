using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.API.Authenticator
{
    /// <summary>
    /// This interface verifies and sets token to APIHTTPConnector instance.
    /// </summary>
    public interface IToken
    {
        /// <summary>
        /// This method to set authentication token to APIHTTPConnector instance.
        /// </summary>
        /// <param name="urlConnection">A APIHTTPConnector class instance.</param>
        public void Authenticate(APIHTTPConnector urlConnection);

        public bool Revoke(string id);

        public void Remove();

        public void GenerateToken();

        public string GetId();
    }
}
