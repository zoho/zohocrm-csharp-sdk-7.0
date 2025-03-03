
using System;
using System.Collections.Generic;

using Com.Zoho.Crm.API;

namespace Com.Zoho.API.Authenticator.Store
{
    /// <summary>
    /// This interface stores the user token details.
    /// </summary>
    public interface ITokenStore
    {
        public IToken FindToken(IToken token);
        
        public IToken FindTokenById(string id);

        public void SaveToken(IToken token);

        public void DeleteToken(string id);

        public List<IToken> GetTokens();

        public void DeleteTokens();
    }
}
