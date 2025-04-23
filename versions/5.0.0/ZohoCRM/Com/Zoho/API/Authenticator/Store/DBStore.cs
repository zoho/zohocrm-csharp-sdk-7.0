using System.Collections.Generic;
using Com.Zoho.API.Exception;
using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;
using MySql.Data.MySqlClient;
using System.Text;
using System;
using Com.Zoho.API.Authenticator;
using System.Xml.Linq;
using System.Management.Instrumentation;
using Newtonsoft.Json.Linq;

namespace Com.Zoho.API.Authenticator.Store
{
    /// <summary>
    /// This class stores the user token details to the MySQL DataBase.
    /// </summary>
    public class DBStore : ITokenStore
    {
        private string userName;
        private string portNumber;
        private string password;
        private string host;
        private string databaseName;
        private string connectionString;
        private string tableName;

        /// <summary>
        /// Creates an DBStore class instance with the specified parameters.
        /// </summary>
        /// <param name="host">A string containing the DataBase host name. Default value localhost.</param>
        /// <param name="databaseName">A String containing the DataBase name. Default value zohooauth.</param>
        /// <param name="tableName">A String containing the Table name. Default value oauthtoken.</param>
        /// <param name="userName">A string containing the DataBase user name. Default value root.</param>
        /// <param name="password">A string containing the DataBase password. Default value "".</param>
        /// <param name="portNumber">A string containing the DataBase port number. Default value 3306.</param>
        private DBStore(string host, string databaseName, string tableName, string userName, string password, string portNumber)
        {
            this.host = host;
            this.databaseName = databaseName;
            this.tableName = tableName;
            this.userName = userName;
            this.password = password;
            this.portNumber = portNumber;
            this.connectionString = $"{Constants.SERVER}={this.host};{Constants.USERNAME}={this.userName};{Constants.PASSWORD}={this.password};{Constants.DATABASE}={this.databaseName};{Constants.PORT}={this.portNumber};persistsecurityinfo=True;SslMode=none;";
        }

        public IToken FindToken(IToken token)
        {
            try
            {
                OAuthToken oauthToken = (OAuthToken)token;
                StringBuilder query = new StringBuilder().Append("select * from ").Append(this.tableName);
                if (oauthToken.UserSignature != null)
                {
                    string name = oauthToken.UserSignature.Name;
                    if (name != null && name.Length > 0)
                    {
                        query.Append(" where user_name='").Append(name).Append("'");
                    }
                }
                else if (oauthToken.AccessToken != null && AreAllObjectsNull(oauthToken.ClientId, oauthToken.ClientSecret))
                {
                    query.Append(" where access_token='").Append(oauthToken.AccessToken).Append("'");
                }
                else if ((oauthToken.RefreshToken != null || oauthToken.GrantToken != null) && oauthToken.ClientId != null && oauthToken.ClientSecret != null)
                {
                    if (oauthToken.GrantToken != null && oauthToken.GrantToken.Length > 0)
                    {
                        query.Append(" where grant_token='").Append(oauthToken.GrantToken).Append("'");
                    }
                    else if (oauthToken.RefreshToken != null && oauthToken.RefreshToken.Length > 0)
                    {
                        query.Append(" where refresh_token='").Append(oauthToken.RefreshToken).Append("'");
                    }
                }
                query.Append(" limit 1");
                using (MySqlConnection connection = new MySqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (MySqlCommand statement = new MySqlCommand(query.ToString(), connection))
                    {
                        using (MySqlDataReader result = statement.ExecuteReader())
                        {
                            while (result.Read())
                            {
                                SetMergeData(oauthToken, result);
                                return oauthToken;
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new SDKException(Constants.TOKEN_STORE, Constants.GET_TOKEN_DB_ERROR, ex);
            }
            return null;
        }

        public void SaveToken(IToken token)
        {
            if (token is not OAuthToken)
		    {
                return;
            }
            try
            {
                using (MySqlConnection connection = new MySqlConnection(this.connectionString))
                {
                    connection.Open();
                    OAuthToken oauthToken = (OAuthToken)token;
                    StringBuilder query = new StringBuilder().Append("update ").Append(this.tableName).Append(" set ");
                    if (oauthToken.UserSignature != null)
                    {
                        string name = oauthToken.UserSignature.Name;
                        if (name != null && name.Length > 0)
                        {
                            query.Append(SetToken(oauthToken)).Append(" where user_name='").Append(name).Append("'");
                        }
                    }
                    else if (oauthToken.AccessToken != null && oauthToken.AccessToken.Length > 0 && AreAllObjectsNull(oauthToken.ClientId, oauthToken.ClientSecret))
                    {
                        query.Append(SetToken(oauthToken)).Append(" where access_token='").Append(oauthToken.AccessToken).Append("'");
                    }
                    else if (((oauthToken.RefreshToken != null && oauthToken.RefreshToken.Length > 0) || (oauthToken.GrantToken != null && oauthToken.GrantToken.Length > 0)) && oauthToken.ClientId != null && oauthToken.ClientSecret != null)
                    {
                        if (oauthToken.GrantToken != null && oauthToken.GrantToken.Length > 0)
                        {
                            query.Append(SetToken(oauthToken)).Append(" where grant_token='").Append(oauthToken.GrantToken).Append("'");
                        }
                        else if (oauthToken.RefreshToken != null && oauthToken.RefreshToken.Length > 0)
                        {
                            query.Append(SetToken(oauthToken)).Append(" where refresh_token='").Append(oauthToken.RefreshToken).Append("'");
                        }
                    }
                    query.Append(" limit 1");
                    int rowsAffected = 0;
                    using (MySqlCommand command = new MySqlCommand(query.ToString(), connection))
                    {
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    if(rowsAffected == 0)
                    {
                        string createquery = "insert into " + this.tableName + "(id,user_name,client_id,client_secret,refresh_token,access_token,grant_token,expiry_time,redirect_url,api_domain) values (@id, @user_name, @client_id, @client_secret, @refresh_token, @access_token, @grant_token, @expiry_time, @redirect_url,@api_domain);";
                        if (oauthToken.Id != null || oauthToken.UserSignature != null)
                        {
                            if (oauthToken.RefreshToken == null && oauthToken.GrantToken == null && oauthToken.AccessToken == null)
                            {
                                throw new SDKException(Constants.TOKEN_STORE, Constants.GET_TOKEN_DB_ERROR1);
                            }
                        }
                        if (oauthToken.Id == null)
                        {
                            string newId = GenerateId().ToString();
                            oauthToken.Id = newId;
                        }
                        using (MySqlCommand statement = new MySqlCommand(createquery, connection))
                        {
                            statement.Parameters.AddWithValue("@id", oauthToken.Id);
                            statement.Parameters.AddWithValue("@user_name", oauthToken.UserSignature != null ? oauthToken.UserSignature.Name : null);
                            statement.Parameters.AddWithValue("@client_id", oauthToken.ClientId);
                            statement.Parameters.AddWithValue("@client_secret", oauthToken.ClientSecret);
                            statement.Parameters.AddWithValue("@refresh_token", oauthToken.RefreshToken);
                            statement.Parameters.AddWithValue("@access_token", oauthToken.AccessToken);
                            statement.Parameters.AddWithValue("@grant_token", oauthToken.GrantToken);
                            statement.Parameters.AddWithValue("@expiry_time", oauthToken.ExpiresIn);
                            statement.Parameters.AddWithValue("@redirect_url", oauthToken.RedirectURL);
                            statement.Parameters.AddWithValue("@api_domain", oauthToken.APIDomain);
                            statement.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new SDKException(Constants.TOKEN_STORE, Constants.SAVE_TOKEN_DB_ERROR, ex);
            }
        }

        public void DeleteToken(string id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = new StringBuilder().Append("delete from ").Append(this.tableName).Append(" where id='").Append(id).Append("';").ToString();
                    using (MySqlCommand statement = new MySqlCommand(query, connection))
                    {
                        statement.ExecuteNonQuery();
                    }
                }
            }
            catch (System.Exception ex) when (!(ex is SDKException))
            {
                throw new SDKException(Constants.TOKEN_STORE, Constants.DELETE_TOKEN_DB_ERROR, ex);
            }
        }

        public List<IToken> GetTokens()
        {
            List<IToken> tokens = new List<IToken>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(this.connectionString))
                {
                    connection.Open();
                    string query = "select * from " + this.tableName + ";";
                    using (MySqlCommand statement = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader result = statement.ExecuteReader())
                        {
                            while (result.Read())
                            {
                                OAuthToken oauthToken = new OAuthToken();
                                SetMergeData(oauthToken, result);
                                tokens.Add(oauthToken);
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new SDKException(Constants.TOKEN_STORE, Constants.GET_TOKENS_DB_ERROR, ex);
            }
            return tokens;
        }

        public void DeleteTokens()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "delete from " + this.tableName + ";";
                    using (MySqlCommand statement = new MySqlCommand(query, connection))
                    {
                        statement.ExecuteNonQuery();
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new SDKException(Constants.TOKEN_STORE, Constants.DELETE_TOKENS_DB_ERROR, ex);
            }
        }

        public IToken FindTokenById(string id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(this.connectionString))
                {
                    connection.Open();
                    string query = "select * from " + this.tableName + " where id='" + id + "'";
                    using (MySqlCommand statement = new MySqlCommand(query, connection))
                    {
                        OAuthToken oauthToken = new OAuthToken();
                        using (MySqlDataReader result = statement.ExecuteReader())
                        {
                            if (!result.HasRows)
                            {
                                throw new SDKException(Constants.TOKEN_STORE, Constants.GET_TOKEN_BY_ID_DB_ERROR);
                            }
                            while (result.Read())
                            {
                                SetMergeData(oauthToken, result);
                                return oauthToken;
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new SDKException(Constants.TOKEN_STORE, Constants.GET_TOKEN_DB_ERROR, ex);
            }
            return null;
        }

        private void SetMergeData(OAuthToken oauthToken, MySqlDataReader result)
	    {
		    if (oauthToken.Id == null)
		    {
                oauthToken.Id = result[Constants.ID].ToString();
		    }
		    if (oauthToken.UserSignature == null)
		    {
			    string name = result[Constants.USER_NAME].ToString();
			    if (name != null)
			    {
				    oauthToken.UserSignature = new UserSignature(name);
			    }
		    }
		    if (oauthToken.ClientId == null)
            {
                oauthToken.ClientId = result[Constants.CLIENT_ID].ToString();
            }
            if (oauthToken.ClientSecret == null)
            {
                oauthToken.ClientSecret = result[Constants.CLIENT_SECRET].ToString();
            }
            if (oauthToken.RefreshToken == null)
            {
                oauthToken.RefreshToken = result[Constants.REFRESH_TOKEN].ToString();
            }
            if (oauthToken.AccessToken == null)
            {
                oauthToken.AccessToken = result[Constants.ACCESS_TOKEN].ToString();
            }
            if (oauthToken.GrantToken == null)
            {
                oauthToken.GrantToken = result[Constants.GRANT_TOKEN].ToString();
            }
            if (oauthToken.ExpiresIn == null)
            {
                string expiresIn = Convert.ToString(result[Constants.EXPIRY_TIME]);
                if (expiresIn != null)
                {
                    oauthToken.ExpiresIn = expiresIn;
                }
            }
            if (oauthToken.RedirectURL == null)
            {
                oauthToken.RedirectURL = result[Constants.REDIRECT_URL].ToString();
            }
            if (oauthToken.APIDomain == null)
            {
                oauthToken.APIDomain = result[Constants.API_DOMAIN].ToString();
            }
	    }

        private string SetToken(OAuthToken oauthToken)
        {
            List<string> query = new List<string>();
            if (oauthToken.UserSignature != null)
            {
                string name = oauthToken.UserSignature.Name;
                if (name != null && name.Length > 0)
                {
                    query.Add(SetTokenInfo(Constants.USER_NAME, name));
                }
            }
            if (oauthToken.ClientId != null)
            {
                query.Add(SetTokenInfo(Constants.CLIENT_ID, oauthToken.ClientId));
            }
            if (oauthToken.ClientSecret != null)
            {
                query.Add(SetTokenInfo(Constants.CLIENT_SECRET, oauthToken.ClientSecret));
            }
            if (oauthToken.RefreshToken != null)
            {
                query.Add(SetTokenInfo(Constants.REFRESH_TOKEN, oauthToken.RefreshToken));
            }
            if (oauthToken.AccessToken != null)
            {
                query.Add(SetTokenInfo(Constants.ACCESS_TOKEN, oauthToken.AccessToken));
            }
            if (oauthToken.GrantToken != null)
            {
                query.Add(SetTokenInfo(Constants.GRANT_TOKEN, oauthToken.GrantToken));
            }
            if (oauthToken.ExpiresIn != null)
            {
                query.Add(SetTokenInfo(Constants.EXPIRY_TIME, oauthToken.ExpiresIn));
            }
            if (oauthToken.RedirectURL != null)
            {
                query.Add(SetTokenInfo(Constants.REDIRECT_URL, oauthToken.RedirectURL));
            }
            if (oauthToken.APIDomain != null)
            {
                query.Add(SetTokenInfo(Constants.API_DOMAIN, oauthToken.APIDomain));
            }
            return string.Join(",", query);
        }

        private string SetTokenInfo(string key, string value)
        {
            return new StringBuilder().Append(key).Append("='").Append(value).Append("'").ToString();
        }

        private int GenerateId()
        {
            int id = 0;
		    try
		    {
                using (MySqlConnection connection = new MySqlConnection(this.connectionString))
                {
                    connection.Open();
                    string query = "select coalesce(max(`id`), 0) as id from " + this.tableName + ";"; // No i18N
                    using (MySqlCommand statement = new MySqlCommand(query.ToString(), connection))
                    {
                        using (MySqlDataReader result = statement.ExecuteReader())
                        {
                            while (result.Read())
                            {
                                int? max = Convert.ToInt32(result[Constants.ID]);
                                if (max != null)
                                {
                                    return (int)(max + 1);
                                }
                            }
					    }
				    }
			    }
		    }
            catch (System.Exception ex)
            {
                throw new SDKException(Constants.TOKEN_STORE, Constants.GENERATE_TOKEN_ID_ERROR, ex);
            }
            return id;
        }

        private string GetData(object value)
        {
            return value != null && !value.ToString().Equals(Constants.NULL_VALUE, System.StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(value.ToString()) ? value.ToString() : null;
        }

        public bool AreAllObjectsNull(params Object[] objects)
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

        public class Builder
        {
            private string userName = Constants.MYSQL_USER_NAME;
            private string portNumber = Constants.MYSQL_PORT_NUMBER;
            private string password = "";
            private string host = Constants.MYSQL_HOST;
            private string databaseName = Constants.MYSQL_DATABASE_NAME;
            private string tableName = Constants.MYSQL_TABLE_NAME;

            public Builder UserName(string userName)
            {
                this.userName = userName;
                return this;
            }

            public Builder PortNumber(string portNumber)
            {
                this.portNumber = portNumber;
                return this;
            }

            public Builder Password(string password)
            {
                this.password = password;
                return this;
            }

            public Builder Host(string host)
            {
                this.host = host;
                return this;
            }

            public Builder DatabaseName(string databaseName)
            {
                this.databaseName = databaseName;

                return this;
            }

            public Builder TableName(string tableName)
            {
                this.tableName = tableName;
                return this;
            }

            public DBStore Build()
            {
                return new DBStore(this.host, this.databaseName, this.tableName, this.userName, this.password, this.portNumber);
            }
        }
    }
}
