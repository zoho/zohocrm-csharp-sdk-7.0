/**
Copyright (c) 2021, ZOHO CORPORATION PRIVATE LIMITED 
All rights reserved. 
 
   Licensed under the Apache License, Version 2.0 (the "License"); 
   you may not use this file except in compliance with the License. 
   You may obtain a copy of the License at 
 
       http://www.apache.org/licenses/LICENSE-2.0 
 
   Unless required by applicable law or agreed to in writing, software 
   distributed under the License is distributed on an "AS IS" BASIS, 
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
   See the License for the specific language governing permissions and 
   limitations under the License.
*/

using System;
using System.IO;
using System.Reflection;
using Com.Zoho.API.Authenticator;
using Com.Zoho.API.Authenticator.Store;
using Com.Zoho.Crm.API.Logger;
using Com.Zoho.Crm.API.Util;
using Newtonsoft.Json.Linq;
using System.Threading;
using Com.Zoho.API.Exception;
using System.Text;

namespace Com.Zoho.Crm.API
{
    /// <summary>
    /// This class to initialize Zoho CRM SDK.
    /// </summary>
    public class Initializer : IDisposable
    {
        private static  ThreadLocal<Initializer> LOCAL = new ThreadLocal<Initializer>();
        private static Initializer initializer;
        private Dc.DataCenter.Environment environment;
        private ITokenStore store;
        private IToken token;
        public static JObject jsonDetails;
	    private string resourcePath;
        private RequestProxy requestProxy;
        private SDKConfig sdkConfig;

        private Initializer()
        {
        }

        private static void Initialize(Dc.DataCenter.Environment environment, IToken token, ITokenStore store, SDKConfig sdkConfig, string resourcePath, Logger.Logger logger, RequestProxy proxy)
        {
            try
            {
                SDKLogger.Initialize(logger);
                try
                {
                    string result = "";
                    using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Constants.JSON_DETAILS_FILE_PATH))
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            result = reader.ReadToEnd();
                        }
                    }
                    jsonDetails = JObject.Parse(result);
                }
                catch (System.Exception e)
                {
                    throw new SDKException(Constants.JSON_DETAILS_ERROR, e);
                }
                initializer = new Initializer();
                initializer.environment = environment;
                initializer.sdkConfig = sdkConfig;
                initializer.resourcePath = resourcePath;
                initializer.requestProxy = proxy;
                initializer.store = store;
                initializer.token = token;
                if (initializer.token != null)
                {
                    initializer.token.GenerateToken();
                }
                SDKLogger.LogInfo(Constants.INITIALIZATION_SUCCESSFUL + initializer.ToString());
            }
            catch(SDKException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new SDKException(Constants.INITIALIZATION_EXCEPTION, e);
            }
        }

        private static void SwitchUser(Dc.DataCenter.Environment environment, IToken token, SDKConfig sdkConfig, RequestProxy proxy)
        {
            Initializer initializer = new Initializer();
            initializer.environment = environment;
            initializer.store = Initializer.initializer.store;
            initializer.sdkConfig = sdkConfig;
            initializer.resourcePath = Initializer.initializer.resourcePath;
            initializer.requestProxy = proxy;
            initializer.token = token;
            LOCAL.Value = initializer;
            if (initializer.token != null)
            {
                initializer.token.GenerateToken();
            }
            SDKLogger.LogInfo(Constants.INITIALIZATION_SWITCHED + initializer.ToString());
        }

        /// <summary>
        /// This method to get record field information details.
        /// </summary>
        /// <param name="filePath">A String containing the class information details file path.</param>
        /// <returns></returns>
        public static JObject GetJSON(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string fileContent = sr.ReadToEnd();
            sr.Close();
            return JObject.Parse(fileContent);
        }

        /// <summary>
        /// This method to get Initializer class instance.
        /// </summary>
        /// <returns>A Initializer class instance representing the SDK configuration details.</returns>
        public static Initializer GetInitializer()
        {
            if (Initializer.LOCAL.Value != null)
            {
                return Initializer.LOCAL.Value;
            }
            return initializer;
        }

        /// <summary>
        /// This is a getter method to get API environment.
        /// </summary>
        /// <returns>A Environment representing the API environment.</returns>
        public Dc.DataCenter.Environment Environment
        {
            get
            {
                return environment;
            }
        }

        /// <summary>
        /// This is a getter method to get API environment.
        /// </summary>
        /// <returns>A TokenStore class instance containing the token store information.</returns>
        public ITokenStore Store
        {
            get
            {
                return store;
            }
        }

        /// <summary>
        /// This is a getter method to get OAuth client application information.
        /// </summary>
        /// <returns>A Token class instance representing the OAuth client application information.</returns>
        public IToken Token
        {
            get
            {
                return token;
            }
        }

        public string ResourcePath
        {
            get
            {
                return resourcePath;
            }
        }
        
        /// <summary>
        /// This is a getter method to get Proxy information.
        /// </summary>
        /// <returns>A RequestProxy class instance representing the API Proxy information.</returns>
        public RequestProxy RequestProxy
        {
            get
            {
                return requestProxy;
            }
        }
        
        /// <summary>
        /// This is a getter method to get the SDK Configuration
        /// </summary>
        /// <returns>A SDKConfig instance representing the configuration</returns>
        public SDKConfig SDKConfig
        {
            get
            {
                return sdkConfig;
            }
        }

        public override string ToString()
        {
            return new StringBuilder().Append(Constants.IN_ENVIRONMENT).Append(GetInitializer().Environment.GetUrl()).Append(".").ToString();
        }

        public void Dispose()
        {
            ((IDisposable)LOCAL).Dispose();
        }

        public class Builder
        {
            private Dc.DataCenter.Environment environment;
            private ITokenStore store;
            private IToken token;
            private string resourcePath;
            private RequestProxy requestProxy;
            private SDKConfig sdkConfig;
            private Logger.Logger logger;
            private string errorMessage = (Initializer.initializer != null) ? Constants.SWITCH_USER_ERROR : Constants.INITIALIZATION_ERROR;

            public Builder()
            {
                if(Initializer.initializer != null)
                {
                    environment = Initializer.initializer.Environment;
                    token = Initializer.initializer.Token;
                    sdkConfig = Initializer.initializer.SDKConfig;
                }
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

            public void Initialize()
            {
                Utility.AssertNotNull(token, errorMessage, Constants.TOKEN_ERROR_MESSAGE);
                if (store == null)
                {
                    store = new FileStore(Path.GetDirectoryName(Assembly.GetCallingAssembly().Location) + Path.DirectorySeparatorChar + Constants.TOKEN_FILE);
                }
                if (sdkConfig == null)
                {
                    sdkConfig = new SDKConfig.Builder().Build();
                }
                if (resourcePath == null)
                {
                    resourcePath = Path.GetDirectoryName(Assembly.GetCallingAssembly().Location);
                }
                if (logger == null)
                {
                    logger = new Logger.Logger.Builder().Level(API.Logger.Logger.Levels.OFF).FilePath(null).Build();
                }
                Initializer.Initialize(this.environment, this.token, this.store, this.sdkConfig, this.resourcePath, this.logger, this.requestProxy);
            }

            public void SwitchUser()
            {
                Utility.AssertNotNull(Initializer.initializer, Constants.SDK_UNINITIALIZATION_ERROR, Constants.SDK_UNINITIALIZATION_MESSAGE);
                if (this.sdkConfig == null)
                {
                    this.sdkConfig = new SDKConfig.Builder().Build();
                }
                Initializer.SwitchUser(this.environment, this.token, this.sdkConfig, this.requestProxy);
            }

            public Builder Logger(Logger.Logger logger)
            {
                this.logger = logger;
                return this;
            }

            public Builder Token(IToken token)
            {
                Utility.AssertNotNull(token, errorMessage, Constants.TOKEN_ERROR_MESSAGE);
                this.token = token;
                return this;
            }

            public Builder SDKConfig(SDKConfig sdkConfig)
            {
			    this.sdkConfig = sdkConfig;
			    return this;
		    }

            public Builder RequestProxy(RequestProxy requestProxy)
            {
                this.requestProxy = requestProxy;
                return this;
            }

            public Builder ResourcePath(string resourcePath)
            {
                if(resourcePath != null && !Directory.Exists(resourcePath))
                {
                    throw new SDKException(errorMessage, Constants.RESOURCE_PATH_INVALID_ERROR_MESSAGE);
                }
                this.resourcePath = resourcePath;
                return this;
            }

            public Builder Store(ITokenStore store)
            {
			    this.store = store;
			    return this;
		    }

            public Builder Environment(Dc.DataCenter.Environment environment)
            {
                Utility.AssertNotNull(environment, errorMessage, Constants.ENVIRONMENT_ERROR_MESSAGE);
			    this.environment = environment;
			    return this;
            }
        }
    }
}
