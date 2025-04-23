using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Com.Zoho.API.Exception;
using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.API.Authenticator.Store
{
    /// <summary>
    /// This class stores the user token details to the file.
    /// </summary>
    public class FileStore : ITokenStore
    {
        private string filePath;
        private List<string> headers = new List<string>() { Constants.ID, Constants.USER_NAME, Constants.CLIENT_ID, Constants.CLIENT_SECRET, Constants.REFRESH_TOKEN, Constants.ACCESS_TOKEN, Constants.GRANT_TOKEN, Constants.EXPIRY_TIME, Constants.REDIRECT_URL, Constants.API_DOMAIN };

        /// <summary>
        /// Creates an FileStore class instance with the specified parameters.
        /// </summary>
        /// <param name="filePath">A String containing the absolute file path to store tokens.</param>
        public FileStore(string filePath)
        {
            this.filePath = filePath;
            string[] lines = null;
            if (File.Exists(this.filePath))
            {
                lines = File.ReadAllLines(this.filePath);
            }
            if (lines == null || lines.Length < 1)
            {
                using (FileStream fileStream = new FileStream(this.filePath, FileMode.Append))
                {
                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        writer.WriteLine(string.Join(",", headers));
                        writer.Close();
                    }
                    fileStream.Close();
                }
            }
        }

        public IToken FindToken(IToken token)
        {
            if (token is not OAuthToken)
		    {
                return token;
            }
            try
            {
                string[] allContents = File.ReadAllLines(this.filePath).Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
                if (allContents == null || allContents.Length < 1)
                {
                    return null;
                }
                OAuthToken oauthToken = (OAuthToken)token;
                bool isRowPresent = false;
                foreach (string line in allContents)
                {
                    string[] nextRecord = line.Split(',');
                    if(nextRecord.Length > 1)
                    {
                        isRowPresent = CheckCondition(oauthToken, nextRecord);
                        if (isRowPresent)
                        {
                            SetMergeData(oauthToken, nextRecord);
                            return oauthToken;
                        }
                    }
                }
                if (!isRowPresent)
                {
                    return null;
                }
            }
            catch (System.Exception ex)
            {
                throw new SDKException(Constants.TOKEN_STORE, Constants.GET_TOKEN_FILE_ERROR, ex);
            }

            return token;
        }

        public void SaveToken(IToken token)
        {
            if (token is not OAuthToken)
		    {
                return;
            }
            try
            {
                OAuthToken oauthToken = (OAuthToken)token;
                bool isRowPresent = false;
                string[] lines = File.ReadAllLines(this.filePath).Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
                if (lines == null || lines.Length < 1)
                {
                    return;
                }
                List<string> allContents = lines.ToList();
                for (int index = 1; index < allContents.Count; index++)
                {
                    string line = allContents[index];
                    string[] nextRecord = line.Split(',');
                    if(nextRecord.Length > 1)
                    {
                        if (oauthToken.Id != null)
                        {
                            string id = GetData(nextRecord[0]);
                            if (id != null && oauthToken.Id != null && id.Equals(oauthToken.Id))
                            {
                                isRowPresent = true;
                            }
                        }
                        else
                        {
                            isRowPresent = CheckCondition(oauthToken, nextRecord);
                        }
                        if (isRowPresent)
                        {
                            SetMergeData(oauthToken, nextRecord);
                            allContents[index] = string.Join(",", SetToken(oauthToken));
                            break;
                        }
                    }
                    else
                    {
                        allContents.RemoveAt(index);
                    }
                }
                if (!isRowPresent)
                {
                    if (oauthToken.Id != null || oauthToken.UserSignature != null)
                    {
                        if (oauthToken.RefreshToken == null && oauthToken.GrantToken == null && oauthToken.AccessToken == null)
                        {
                            throw new SDKException(Constants.TOKEN_STORE, Constants.GET_TOKEN_FILE_ERROR1);
                        }
                    }
                    if(oauthToken.Id == null)
                    {
                        string newId = GenerateId(allContents);
                        oauthToken.Id = newId;
                    }
                    allContents.Add(SetToken(oauthToken));
                }
                File.WriteAllText(this.filePath, string.Empty);
                using (StreamWriter writer = new StreamWriter(this.filePath))
                {
                    foreach (string item in allContents)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
            catch (System.Exception ex) when (ex is UnauthorizedAccessException || ex is DirectoryNotFoundException)
            {
                throw new SDKException(Constants.TOKEN_STORE, Constants.SAVE_TOKEN_FILE_ERROR, ex);
            }
        }

        public void DeleteToken(string id)
        {
            try
            {
                string[] lines = File.ReadAllLines(this.filePath).Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
                if (lines == null || lines.Length < 1)
                {
                    return;
                }
                File.WriteAllText(this.filePath, string.Empty);
                bool isRowPresent = false;
                List<string> allContents = lines.ToList();
                for (int index = 1; index < allContents.Count; index++)
                {
                    string[] nextRecord = allContents[index].Split(',');
                    if (nextRecord.Length > 1)
                    {
                        string recordId = GetData(nextRecord[0]);
                        if (recordId != null && recordId.Equals(id))
                        {
                            isRowPresent = true;
                            allContents.RemoveAt(index);
                            break;
                        }
                    }
                }
                using (StreamWriter writer = new StreamWriter(this.filePath))
                {
                    foreach (string item in allContents)
                    {
                        writer.WriteLine(item);
                    }
                }
                if (!isRowPresent)
                {
                    throw new SDKException(Constants.TOKEN_STORE, Constants.TOKEN_BY_ID_FILE_ERROR);
                }
            }
            catch (System.Exception ex) when (!(ex is SDKException) && (ex is UnauthorizedAccessException || ex is DirectoryNotFoundException))
            {
                throw new SDKException(Constants.TOKEN_STORE, Constants.DELETE_TOKEN_FILE_ERROR, ex);
            }
        }

        public List<IToken> GetTokens()
        {
            List<IToken> tokens = new List<IToken>();
            try
            {
                string[] allContents = File.ReadAllLines(this.filePath);
                if (allContents == null || allContents.Length < 1)
                {
                    return null;
                }
                for (int index = 1; index < allContents.Length; index++)
                {
                    string line = allContents[index];
                    string[] nextRecord = line.Split(',');
                   	OAuthToken oauthToken = new OAuthToken();
					SetMergeData(oauthToken, nextRecord);
                    tokens.Add(oauthToken);
                }
            }
            catch (System.Exception ex)
            {
                throw new SDKException(Constants.TOKEN_STORE, Constants.GET_TOKENS_FILE_ERROR, ex);
            }
            return tokens;
        }

        public void DeleteTokens()
        {
            try
            {
                File.WriteAllText(this.filePath, string.Empty);
                File.WriteAllText(this.filePath, string.Join(",", headers));
            }
            catch (System.Exception ex) when (ex is UnauthorizedAccessException || ex is DirectoryNotFoundException)
            {
                throw new SDKException(Constants.TOKEN_STORE, Constants.DELETE_TOKENS_FILE_ERROR, ex);
            }
        }

        public IToken FindTokenById(string id)
        {
            try
            {
                string[] allContents = File.ReadAllLines(this.filePath).Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
                bool isRowPresent = false;
                OAuthToken oauthToken = new OAuthToken();
                foreach (string line in allContents)
                {
                    string[] nextRecord = line.Split(',');
                    if (nextRecord[0].Equals(id))
                    {
                        isRowPresent = true;
                        SetMergeData(oauthToken, nextRecord);
                        return oauthToken;
                    }
                }
                if (!isRowPresent)
                {
                    throw new SDKException(Constants.TOKEN_STORE, Constants.GET_TOKEN_BY_ID_FILE_ERROR);
                }
            }
            catch (System.Exception ex)
            {
                throw new SDKException(Constants.TOKEN_STORE, Constants.GET_TOKEN_FILE_ERROR, ex);
            }

            return null;
        }

        private bool CheckCondition(OAuthToken oauthToken, string[] nextRecord)
        {
            bool isRowPresent = false;
            if (oauthToken.UserSignature != null)
            {
                string name = oauthToken.UserSignature.Name;
                string userName = GetData(nextRecord[1]);
                if (name != null && name.Length > 0 && userName != null && userName.Length > 0 && name.Equals(userName))
                {
                    isRowPresent = true;
                }
            }
            else if (oauthToken.AccessToken != null && AreAllObjectsNull(oauthToken.ClientId, oauthToken.ClientSecret))
            {
                string accessToken = GetData(nextRecord[5]);
                if (accessToken != null && accessToken.Length > 0 && oauthToken.AccessToken.Length > 0 && oauthToken.AccessToken.Equals(accessToken))
                {
                    isRowPresent = true;
                }
            }
            else if ((oauthToken.RefreshToken != null || oauthToken.GrantToken != null) && oauthToken.ClientId != null && oauthToken.ClientSecret != null)
            {
                string grantToken = GetData(nextRecord[6]);
                string refreshToken = GetData(nextRecord[4]);
                if (grantToken != null && grantToken.Length > 0 && oauthToken.GrantToken != null && oauthToken.GrantToken.Length > 0 && oauthToken.GrantToken.Equals(grantToken))
                {
                    isRowPresent = true;
                }
                else if (refreshToken != null && refreshToken.Length > 0 && oauthToken.RefreshToken!= null && oauthToken.RefreshToken.Length > 0 && oauthToken.RefreshToken.Equals(refreshToken))
                {
                    isRowPresent = true;
                }
            }
            return isRowPresent;
        }

        private string GetData(string value)
        {
            return (value != null && !String.IsNullOrEmpty(value) && value.Length > 0) ? value : null;
        }

        private void SetMergeData(OAuthToken oauthToken, string[] nextRecord)
        {
		    if (oauthToken.Id == null)
		    {
			    oauthToken.Id  = GetData(nextRecord[0]);
		    }
		    if (oauthToken.UserSignature == null)
		    {
			    string name = GetData(nextRecord[1]);
			    if (name != null)
			    {
				    oauthToken.UserSignature = new UserSignature(name);
			    }
		    }
		    if (oauthToken.ClientId == null)
            {
                oauthToken.ClientId = GetData(nextRecord[2]);
            }
            if (oauthToken.ClientSecret == null)
            {
                oauthToken.ClientSecret = GetData(nextRecord[3]);
            }
            if (oauthToken.RefreshToken == null)
            {
                oauthToken.RefreshToken = GetData(nextRecord[4]);
            }
            if (oauthToken.AccessToken == null)
            {
                oauthToken.AccessToken = GetData(nextRecord[5]);
            }
            if (oauthToken.GrantToken == null)
            {
                oauthToken.GrantToken = GetData(nextRecord[6]);
            }
            if (oauthToken.ExpiresIn == null)
            {
                string expiresIn = GetData(nextRecord[7]);
                if (expiresIn != null)
                {
                    oauthToken.ExpiresIn = expiresIn.ToString();
                }
            }
            if (oauthToken.RedirectURL == null)
            {
                oauthToken.RedirectURL = GetData(nextRecord[8]);
            }
            if (oauthToken.APIDomain == null)
            {
                oauthToken.APIDomain = GetData(nextRecord[9]);
            }
	    }

        private string SetToken(OAuthToken oauthToken)
        {
            List<string>  data = new List<string>
            {
                oauthToken.Id,
                oauthToken.UserSignature != null ? oauthToken.UserSignature.Name : null,
                oauthToken.ClientId,
                oauthToken.ClientSecret,
                oauthToken.RefreshToken,
                oauthToken.AccessToken,
                oauthToken.GrantToken,
                oauthToken.ExpiresIn,
                oauthToken.RedirectURL,
                oauthToken.APIDomain
            };
            return string.Join(",", data);
        }

        private string GenerateId(List<string> allContents)
        {
            int maxValue = 0;

            if (allContents.Count > 1)
            {
                for (int index = 1; index < allContents.Count; index++)
                {
                    string[] nextRecord = allContents[index].Split(',');
                    if (nextRecord.Length > 1 && nextRecord[0] != null && nextRecord[0].Length > 0)
                    {
                        if (maxValue < int.Parse(nextRecord[0]))
                        {
                            maxValue = int.Parse(nextRecord[0]);
                        }
                    }
                }
            }
            return (maxValue + 1).ToString();
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
    }
}
