using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using Com.Zoho.API.Authenticator.Store;
using Com.Zoho.API.Exception;
using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.Logger;
using Com.Zoho.Crm.API.Util;
using Newtonsoft.Json.Linq;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;

namespace Com.Zoho.API.Authenticator
{
    /// <summary>
    /// This class gets the tokens and checks the expiry time.
    /// </summary>
    public class OAuthToken : IToken
    {
        private string clientID;
        private string clientSecret;
        private string redirectURL;
        private string grantToken;
        private string refreshToken;
        private string accessToken;
        private string expiresIn;
        private UserSignature userSignature;
        private string id;
        private string apiDomain;
        private bool findUser;

        public OAuthToken()
        {

        }

        private OAuthToken(string clientID, string clientSecret, string grantToken, string refreshToken, string redirectURL, string id, string accessToken, UserSignature userSignature, bool findUser)
        {
            this.clientID = clientID;
            this.clientSecret = clientSecret;
            this.grantToken = grantToken;
            this.refreshToken = refreshToken;
            this.redirectURL = redirectURL;
            this.accessToken = accessToken;
            this.id = id;
            this.userSignature = userSignature;
            this.findUser = findUser;
        }

        /// <summary>
        /// This is a getter method to get OAuth client id.
        /// </summary>
        /// <returns>A string representing the OAuth client id.</returns>
        public string ClientId
        {
            get
            {
                return clientID;
            }
            set
            {
                clientID = value;
            }
        }

        /// <summary>
        /// This is a getter method to get OAuth client secret.
        /// </summary>
        /// <returns>A string representing the OAuth client secret.</returns>
        public string ClientSecret
        {
            get
            {
                return clientSecret;
            }
            set
            {
                clientSecret = value;
            }
        }

        /// <summary>
        /// This is a getter method to get OAuth redirect URL.
        /// </summary>
        /// <returns>A string representing the OAuth redirect URL.</returns>
        public string RedirectURL
        {
            get
            {
                return redirectURL;
            }
            set
            {
                redirectURL = value;
            }
        }

        /// <summary>
        /// This is a getter method to get grant token.
        /// </summary>
        /// <returns>A string representing the grant token.</returns>
        public string GrantToken
        {
            get
            {
                return grantToken;
            }
            set
            {
                grantToken = value;
            }
        }

        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        /// <value>A string containing the refresh token.</value>
        /// <returns>A string representing the refresh token.</returns>
        public string RefreshToken
        {
            get
            {
                return refreshToken;
            }
            set
            {
                refreshToken = value;
            }
        }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>A string containing the access token.</value>
        /// <returns>A string representing the access token.</returns>
        public string AccessToken
        {
            get
            {
                return accessToken;
            }
            set
            {
                accessToken = value;
            }
        }

        /// <summary>
        /// Gets or sets the token expire time.
        /// </summary>
        /// <value>A string containing the token expire time.</value>
        /// <returns>A string representing the token expire time.</returns>
        public string ExpiresIn
        {
            get
            {
                return expiresIn;
            }
            set
            {
                expiresIn = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public UserSignature UserSignature
        {
            get
            {
                return userSignature;
            }
            set
            {
                userSignature = value;
            }
        }

        public string APIDomain
        {
            get
            {
                return apiDomain;
            }
            set
            {
                apiDomain = value;
            }
        }

        public void GenerateToken()
        {
            GetToken();
        }

        public string GetToken()
        {
            lock (this)
            {
                try
                {
                    Initializer initializer = Initializer.GetInitializer();
                    ITokenStore store = initializer.Store;
                    OAuthToken oauthToken = null;
                    if (this.Id != null)
                    {
                        oauthToken = (OAuthToken)store.FindTokenById(this.Id);
                        MergeObjects(this, oauthToken);
                        oauthToken.findUser = this.findUser;
                    }
                    else
                    {
                        oauthToken = (OAuthToken)store.FindToken(this);
                    }
                    if (oauthToken == null)
                    {
                        if(this.UserSignature != null)
                        {
                            CheckTokenDetails();
                        }
                        oauthToken = this;
                    }
                    if(oauthToken.APIDomain == null || oauthToken.APIDomain.Length <= 0)
                    {
                        if(initializer.Environment == null)
                        {
                            throw new SDKException(Constants.ENVIRONMENT_ERROR_1, Constants.ENVIRONMENT_ERROR_MESSAGE + " : ");
                        }
                        oauthToken.APIDomain = initializer.Environment.GetUrl();
                    }
                    Environment environment = DataCenter.Get(oauthToken.APIDomain);
                    if(environment != null)
                    {
                        Type cl = initializer.GetType();
                        try
                        {
                            FieldInfo field = GetPrivateFieldInfo(cl, Constants.ENVIRONMENT);
                            field.SetValue(initializer, environment);
                        }
                        catch (System.Exception e)
                        {
                            throw new SDKException(Constants.ENVIRONMENT_ERROR_RESPONSE + " : ", e);
                        }
                    }
                    else
                    {
                        if(initializer.Environment == null)
                        {
                            throw new SDKException(Constants.ENVIRONMENT_ERROR_1, Constants.ENVIRONMENT_ERROR_MESSAGE + " : ");
                        }
                    }
                    string url = initializer.Environment.GetAccountsUrl();
                    bool save = false;
                    if (oauthToken.AccessToken == null || oauthToken.AccessToken.Length == 0)
                    {
                        if (oauthToken.RefreshToken != null && oauthToken.RefreshToken.Length > 0)
                        {
                            SDKLogger.LogInfo(Constants.ACCESS_TOKEN_USING_REFRESH_TOKEN_MESSAGE);
                            oauthToken.RefreshAccessToken(oauthToken, url);
                        }
                        else
                        {
                            SDKLogger.LogInfo(Constants.ACCESS_TOKEN_USING_GRANT_TOKEN_MESSAGE);
                            oauthToken.GenerateAccessToken(oauthToken, url);
                        }
                        save = true;
                    }
                    else if (oauthToken.ExpiresIn != null && oauthToken.ExpiresIn.Length > 0 && GetExpiryLapseInMillis(oauthToken.ExpiresIn) < 5L)//access token will expire in next 5 seconds or less
                    {
                        SDKLogger.LogInfo(Constants.REFRESH_TOKEN_MESSAGE);
                        oauthToken.RefreshAccessToken(oauthToken, url);
                        save = true;
                    }
                    else if (oauthToken.ExpiresIn == null && oauthToken.AccessToken != null && oauthToken.Id == null)
                    {
                        save = true;
                    }
                    if(save)
                    {
                        try
                        {
                            if(oauthToken.UserSignature == null && oauthToken.findUser)
                            {
                                try
                                {
                                    string userName = new Utility().GetUserName(oauthToken.accessToken);
                                    if(userName != null)
                                    {
                                        oauthToken.UserSignature = new UserSignature(userName);
                                    }
                                }
                                catch (SDKException ex)
                                {
                                    SDKLogger.LogError(ex);
                                }
                            }
                            store.SaveToken(oauthToken);
                        }
                        catch(System.Exception ex)
                        {
                            throw new SDKException(Constants.SAVE_TOKEN_ERROR, ex);
                        }
                    }
                    return oauthToken.AccessToken;
                }
                catch (System.Exception ex) when (!(ex is SDKException))
                {
                    throw new SDKException(ex);
                }
            }
        }

        private bool CheckTokenDetails()
        {
            if (AreAllObjectsNull(this.grantToken, this.refreshToken))
            {
                throw new SDKException(Constants.MANDATORY_VALUE_ERROR, Constants.GET_TOKEN_BY_USER_NAME_ERROR + " - " + string.Join(", ", Constants.OAUTH_MANDATORY_KEYS2));
            }
            return true;
        }

        public void Authenticate(APIHTTPConnector urlConnection)
        {
            if(!urlConnection.Headers.ContainsKey(Constants.AUTHORIZATION))
            {
                urlConnection.AddHeader(Constants.AUTHORIZATION, Constants.OAUTH_HEADER_PREFIX + GetToken());
            }
        }

        private string GetResponseFromServer(Dictionary<string, string> requestParams, string url)
        {
            try
            {
                string USER_AGENT = Constants.USER_AGENT;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                string urlParameters = null;
                if (requestParams != null && requestParams.Count != 0)
                {
                    foreach (KeyValuePair<string, string> param in requestParams)
                    {
                        if (urlParameters == null)
                        {
                            urlParameters = param.Key + "=" + param.Value;
                        }
                        else
                        {
                            urlParameters += "&" + param.Key + "=" + param.Value;
                        }
                    }
                }
                request.UserAgent = USER_AGENT;
                var data = Encoding.UTF8.GetBytes(urlParameters);
                request.ContentType = Constants.URL_ENCODEED;
                request.ContentLength = data.Length;
                request.Method = Constants.REQUEST_METHOD_POST;
                using (var dataStream = request.GetRequestStream())
                {
                    dataStream.Write(data, 0, data.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();
                return new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (System.Exception ex)
            {
                throw new SDKException(ex);
            }
        }

        public string ToString(string url)
        {
            StringBuilder requestStringBuilder = new StringBuilder();
            requestStringBuilder.Append("POST - ");
            requestStringBuilder.Append(Constants.URL).Append(" = ").Append(url.ToString()).Append(".");
            return requestStringBuilder.ToString();
        }

        private OAuthToken RefreshAccessToken(OAuthToken oauthToken, string url)
        {
            try
            {
                Dictionary<string, string> requestParams = new Dictionary<string, string>
                {
                    { Constants.CLIENT_ID, oauthToken.ClientId },
                    { Constants.CLIENT_SECRET, oauthToken.ClientSecret },
                    { Constants.GRANT_TYPE, Constants.REFRESH_TOKEN },
                    { Constants.REFRESH_TOKEN, oauthToken.RefreshToken }
                };
                ParseResponse(oauthToken, GetResponseFromServer(requestParams, url));
            }
            catch (System.Exception ex) when (!(ex is SDKException))
            {
                throw new SDKException(Constants.REFRESH_TOKEN_ERROR, ex);
            }
            return oauthToken;
        }

        private OAuthToken GenerateAccessToken(OAuthToken oauthToken, string url)
        {
            try
            {
                Dictionary<string, string> requestParams = new Dictionary<string, string>
                {
                    { Constants.CLIENT_ID, oauthToken.ClientId },
                    { Constants.CLIENT_SECRET, oauthToken.ClientSecret }
                };
                if (oauthToken.RedirectURL != null)
                {
                    requestParams.Add(Constants.REDIRECT_URI, oauthToken.RedirectURL);
                }
                requestParams.Add(Constants.GRANT_TYPE, Constants.GRANT_TYPE_AUTH_CODE);
                requestParams.Add(Constants.CODE, oauthToken.GrantToken);
                ParseResponse(oauthToken, GetResponseFromServer(requestParams, url));
            }
            catch (System.Exception ex) when (!(ex is SDKException))
            {
                throw new SDKException(Constants.ACCESS_TOKEN_ERROR, ex);
            }
            return oauthToken;
        }

        private bool RevokeRefreshToken(string refreshToken, string url)
        {
            Dictionary<string, string> requestParams = new Dictionary<string, string>
            {
                { Constants.TOKEN, refreshToken }
            };
            try
            {
                string response = GetResponseFromServer(requestParams, url);
                JObject responseJSON = new JObject(response);
                if (responseJSON != null && responseJSON.ContainsKey(Constants.STATUS) && responseJSON.GetValue(Constants.STATUS).Equals(Constants.SUCCESS))
                {
                    return true;
                }
                return false;
            }
            catch (System.Exception ex) when (!(ex is SDKException))
            {
                throw new SDKException(Constants.REVOKE_TOKEN_ERROR, ex);
            }
        }

        private void ParseResponse(OAuthToken oauthToken, string response)
        {
            try
            {
                JObject responseJSON = JObject.Parse(response);
                if (!responseJSON.ContainsKey(Constants.ACCESS_TOKEN))
                {
                    throw new SDKException(Constants.INVALID_TOKEN_ERROR, (responseJSON.ContainsKey(Constants.ERROR_KEY))? responseJSON[Constants.ERROR_KEY].ToString() : Constants.NO_ACCESS_TOKEN_ERROR);
                }
                oauthToken.AccessToken = responseJSON[Constants.ACCESS_TOKEN].ToString();
                oauthToken.ExpiresIn = GetTokenExpiresIn(responseJSON).ToString();
                if (responseJSON.ContainsKey(Constants.REFRESH_TOKEN))
                {
                    oauthToken.RefreshToken = responseJSON[Constants.REFRESH_TOKEN].ToString();
                }
                if (responseJSON.ContainsKey(Constants.API_DOMAIN))
                {
                    oauthToken.APIDomain = responseJSON[Constants.API_DOMAIN].ToString();
                }
            }
            catch (System.Exception ex)
            {
                throw new SDKException(Constants.PARSE_RESPONSE + " : " + response, ex);
            }
        }

        private long GetTokenExpiresIn(JObject response)
        {
            long expiresInTime = response.ContainsKey(Constants.EXPIRES_IN_SEC) ? Convert.ToInt64(response[Constants.EXPIRES_IN]) : Convert.ToInt64(response[Constants.EXPIRES_IN]) * 1000;
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + expiresInTime - 600000;
        }

        public long GetExpiryLapseInMillis(string ExpiryTime)
        {
            long time = Convert.ToInt64(ExpiryTime) - (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            return time;
        }

        /// <summary>
        /// The method to remove the current token from the Store.
        /// </summary>
        public void Remove()
        {
            try
            {
                if (Initializer.GetInitializer() == null)
                {
                    throw new SDKException(Constants.SDK_UNINITIALIZATION_ERROR, Constants.SDK_UNINITIALIZATION_MESSAGE);
                }
                Initializer.GetInitializer().Store.DeleteToken(this.Id);
            }
            catch (System.Exception ex) when (!(ex is SDKException))
            {
                throw ex;
            }
        }

        public bool Revoke(string id)
        {
            try
            {
                if (Initializer.GetInitializer() == null)
                {
                    throw new SDKException(Constants.SDK_UNINITIALIZATION_ERROR, Constants.SDK_UNINITIALIZATION_MESSAGE);
                }

                Initializer initializer = Initializer.GetInitializer();
                ITokenStore store = initializer.Store;
                string url = initializer.Environment.GetAccountsUrl();
                bool isRevoke = false;
                OAuthToken oauthToken = new OAuthToken();
                oauthToken.Id = id;
                store.FindToken(oauthToken);
                if (oauthToken != null && oauthToken.RefreshToken != null)
                {
                    isRevoke = this.RevokeRefreshToken(oauthToken.RefreshToken, url + Constants.REVOKE_URL);
                    SDKLogger.LogInfo(new StringBuilder().Append(Constants.ID).Append(" : ").Append(id).Append(Constants.REFRESH_TOKEN_REMOVED).ToString());
                }
                else
                {
                    SDKLogger.LogWarning(new StringBuilder().Append(Constants.ID).Append(" : ").Append(id).Append(Constants.TOKEN_NOT_FOUND).ToString());
                }
                return isRevoke;
            }
            catch (System.Exception ex) when (!(ex is SDKException))
            {
                throw ex;
            }
        }

        public static T MergeObjects<T>(T first, T second)
        {
            try
            {
                Type type = typeof(T);
                T result = (T)Activator.CreateInstance(type);
                foreach (PropertyInfo property in type.GetProperties())
                {
                    object value1 = property.GetValue(first);
                    object value2 = property.GetValue(second);
                    Object value = (value1 != null) ? value1 : value2;
                    property.SetValue(result, value);
                }
                return result;
            }
            catch (System.Exception ex)
            {
                throw new SDKException(Constants.MERGE_OBJECT, ex);
            }
        }

        public static bool AreAllObjectsNull(params Object[] objects)
        {
            foreach (Object o in objects)
            {
                if (o != null)
                {
                    return false;
                }
            }
            return true;
        }

        public static FieldInfo GetPrivateFieldInfo(Type type, string fieldName)
        {
            BindingFlags Flags = BindingFlags.Instance
                                            | BindingFlags.GetProperty
                                            | BindingFlags.SetProperty
                                            | BindingFlags.GetField
                                            | BindingFlags.SetField
                                            | BindingFlags.NonPublic
                                            | BindingFlags.Public;

            FieldInfo[] fields = type.GetFields(Flags);
            return fields.FirstOrDefault(fieldInfo => fieldInfo.Name == fieldName);
        }

        public string GetId()
        {
            return this.Id;
        }

        public class Builder
        {
            private string clientId;
            private string clientSecret;
            private string redirectURL;
            private string refreshToken;
            private string grantToken;
            private string accessToken;
            private string id;
            private UserSignature userSignature;
            private bool findUser = true;

            public Builder Id(string id)
            {
                this.id = id;
                return this;
            }

            public Builder ClientId(string clientId)
            {
                Utility.AssertNotNull(clientId, Constants.TOKEN_ERROR, Constants.CLIENT_ID_NULL_ERROR_MESSAGE);
                this.clientId = clientId;
                return this;
            }

            public Builder ClientSecret(string clientSecret)
            {
                Utility.AssertNotNull(clientSecret, Constants.TOKEN_ERROR, Constants.CLIENT_SECRET_NULL_ERROR_MESSAGE);
                this.clientSecret = clientSecret;
                return this;
            }

            public Builder RedirectURL(string redirectURL)
            {
                this.redirectURL = redirectURL;
                return this;
            }

            public Builder RefreshToken(string refreshToken)
            {
                this.refreshToken = refreshToken;
                return this;
            }

            public Builder GrantToken(string grantToken)
            {
                this.grantToken = grantToken;
                return this;
            }

            public Builder AccessToken(string accessToken)
            {
                this.accessToken = accessToken;
                return this;
            }

            public Builder UserSignature(UserSignature userSignature)
            {
                this.userSignature = userSignature;
                return this;
            }

            public Builder FindUser(bool findUser)
            {
                this.findUser = findUser;
                return this;
            }

            public OAuthToken Build()
            {
                if (AreAllObjectsNull(this.grantToken, this.refreshToken, this.id, this.accessToken, this.userSignature))
			    {
				    throw new SDKException(Constants.MANDATORY_VALUE_ERROR, Constants.MANDATORY_KEY_ERROR + " - " + string.Join(", ", Constants.OAUTH_MANDATORY_KEYS));
			    }
			    if (!AreAllObjectsNull(this.grantToken, this.refreshToken))
			    {
				    if (AreAllObjectsNull(this.clientId, this.clientSecret))
				    {
					    throw new SDKException(Constants.MANDATORY_VALUE_ERROR, Constants.MANDATORY_KEY_ERROR + " - " + string.Join(", ", Constants.OAUTH_MANDATORY_KEYS1));
				    }
				    else
				    {
					    Utility.AssertNotNull(this.clientId, Constants.MANDATORY_VALUE_ERROR, Constants.MANDATORY_KEY_ERROR + " - " + Constants.CLIENT_ID);
					    Utility.AssertNotNull(this.clientSecret, Constants.MANDATORY_VALUE_ERROR, Constants.MANDATORY_KEY_ERROR + " - " + Constants.CLIENT_SECRET);
				    }
			    }
			    return new OAuthToken(this.clientId, this.clientSecret, this.grantToken, this.refreshToken, this.redirectURL, this.id, this.accessToken, this.userSignature, this.findUser);
            }
        }
    }
}
