License
=======

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

# ZOHO CRM C# SDK 7.0 for API version 7

## Table Of Contents

* [Overview](#overview)
* [Registering a Zoho Client](#registering-a-zoho-client)
* [Environmental Setup](#environmental-setup)
* [Including the SDK in your project](#including-the-sdk-in-your-project)
* [Persistence](#token-persistence)
  * [DataBase Persistence](#database-persistence)
  * [File Persistence](#file-persistence)
  * [Custom Persistence](#custom-persistence)
* [Configuration](#configuration)
* [Initialization](#initializing-the-application)
* [Class Hierarchy](#class-hierarchy)
* [Responses And Exceptions](#responses-and-exceptions)
* [Threading](#threading-in-the-c#-sdk)
  * [Multithreading in a Multi-User App](#multithreading-in-a-multi-user-app)
  * [Multi-threading in a Single User App](#multi-threading-in-a-single-user-app)
* [Sample Code](#sdk-sample-code)

## Overview

Zoho CRM C# SDK offers a way to create client C# applications that can be integrated with Zoho CRM.

## Registering a Zoho Client

Since Zoho CRM APIs are authenticated with OAuth2 standards, you should register your client app with Zoho. To register your app:

- Visit this page [https://api-console.zoho.com/](https://api-console.zoho.com)

- Click `ADD CLIENT`.

- Choose the `Client Type`.

- Enter **Client Name**, **Client Domain** or **Homepage URL** and **Authorized Redirect URIs**. Click `CREATE`.

- Your Client app will be created.

- Select the created OAuth client.

- Generate grant token by providing the necessary scopes, time duration (the duration for which the generated token is valid) and Scope Description.

## Environmental Setup

C# SDK requires .NET Framework 4.6.1 or above to be set up in your development environment.

## Including the SDK in your project

You can include the SDK to your project using:

1. Install Visual Studio IDE from [Visual Studio](https://visualstudio.microsoft.com/downloads/) (if not installed).

2. C# SDK is available as a Nuget package. The ZOHOCRMSDK-7.0 assembly can be installed through the Nuget Package Manager or through the following options:

    - Package Manager

        ```sh
        Install-Package ZOHOCRMSDK-7.0 -Version 4.0.0
        Install-Package MySql.Data -Version 6.9.12
        Install-Package Newtonsoft.Json -Version 13.0.1
        ```

    - .NET  CLI

        ```sh
        dotnet add package ZOHOCRMSDK-7.0 --version 4.0.0
        dotnet add package Newtonsoft.Json --version 13.0.1
        dotnet add package MySql.Data --version 6.9.12
        ```

    - PackageReference

        For projects that support PackageReference, copy this XML node into the project file to refer the package.

        ```sh
        <ItemGroup>
            <PackageReference Include="ZOHOCRMSDK-7.0" Version="4.0.0" />
            <PackageReference Include="Newtonsoft.Json" Version="13.0.1" />
            <PackageReference Include="MySql.Data" Version="6.9.12" />
        </ItemGroup>
        ```

## Token Persistence

Token persistence refers to storing and utilizing the authentication tokens that are provided by Zoho. Token persistence enables the SDK to automatically refresh the access token after initialization using the refresh token without the need for user intervention. There are three ways provided by the SDK in which persistence can be utilized. They are DataBase Persistence, File Persistence, and Custom Persistence. Please note that the default method of token persistence provided by the Zoho CRM SDK is File persistence.

### Table of Contents

- [DataBase Persistence](#database-persistence)

- [File Persistence](#file-persistence)

- [Custom Persistence](#custom-persistence)

### Implementing OAuth Persistence

Once the application is authorized, OAuth access and refresh tokens can be used for subsequent user data requests to Zoho CRM. Hence, they need to be persisted by the client app.

The persistence is achieved by writing an implementation of the inbuilt **ITokenStore interface**, which has the following callback methods.

- **FindToken(IToken token)** - invoked before firing a request to fetch the saved tokens. This method should return an implementation of **IToken interface** object for the library to process it.

- **SaveToken(IToken token)** - invoked after fetching access and refresh tokens from Zoho.

- **DeleteToken(string id)** - invoked before saving the latest tokens.

- **GetTokens()** - The method to retrieve all the stored tokens.

- **DeleteTokens()** - The method to delete all the stored tokens.

- **GetTokenById(string id)** - This method is used to retrieve the user token details based on unique ID.

### DataBase Persistence

Database persistence is a technique that involves storing and retrieving data from a database. In case the user prefers to use the default DataBase persistence, **MySQL** can be used.

- Create a table in your Database with required columns

  - id varchar(10)

  - user_name varchar(255)

  - client_id varchar(255)

  - client_secret varchar(255)

  - refresh_token varchar(255)

  - access_token varchar(255)

  - grant_token varchar(255)

  - expiry_time varchar(20)

  - redirect_url varchar(255)

  - api_domain varchar(255)

Note:

- Custom database name and table name can be set in DBStore instance

#### MySQL Query

```sql
CREATE DATABASE zohooauth;
CREATE TABLE oauthtoken (
  id varchar(10) NOT NULL,
  user_name varchar(255),
  client_id varchar(255),
  client_secret varchar(255),
  refresh_token varchar(255),
  access_token varchar(255),
  grant_token varchar(255),
  expiry_time varchar(20),
  redirect_url varchar(255),
  api_domain varchar(255),
  primary key (id)
);
```

#### Create DBStore object

```C#
/*
* Create an instance of ITokenStore.
* Host -> DataBase host name. Default value "localhost"
* DatabaseName -> DataBase name. Default  value "zohooauth"
* UserName -> DataBase user name. Default value "root"
* Password -> DataBase password. Default value ""
* PortNumber -> DataBase port number. Default value "3306"
* TableName -> Table Name. Default value "oauthtoken"
*/
ITokenStore tokenstore = new DBStore.Builder().Build();

//ITokenStore interface
ITokenStore tokenstore = new DBStore.Builder()
.Host("hostName")
.DatabaseName("dataBaseName")
.TableName("tableName")
.UserName("userName")
.Password("password")
.PortNumber("portNumber")
.Build();
```

### File Persistence

In case of default File Persistence, the user can persist tokens in the local drive, by providing the the absolute file path to the FileStore object.

- The File contains

  - id

  - user_name

  - client_id

  - client_secret

  - refresh_token

  - access_token

  - grant_token

  - expiry_time

  - redirect_url

  - api_domain

#### Create FileStore object

```C#
//Parameter containing the absolute file path to store tokens
ITokenStore tokenstore = new FileStore("/Users/user_name/Documents/csharp_sdk_token.txt");
```

### Custom Persistence

Users can create their own logic for storing and retrieving authentication tokens using the custom persistence technique. To use Custom Persistence, you must implement **ITokenStore interface**(**Com.Zoho.API.Authenticator.Store.ITokenStore**) and override the methods.

```C#
using System;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using Com.Zoho.API.Authenticator.Store;

namespace Samples
{
    public class CustomStore : ITokenStore
    {
        public CustomStore()
        {
        }

        public IToken FindToken(IToken token)
        {
            throw new NotImplementedException();
        }

        public IToken FindTokenById(string id)
        {
            throw new NotImplementedException();
        }

        public void SaveToken(IToken token)
        {
            throw new NotImplementedException();
        }

        public void DeleteToken(string id)
        {
            throw new NotImplementedException();
        }

        public List<IToken> GetTokens()
        {
            throw new NotImplementedException();
        }

        public void DeleteTokens()
        {
            throw new NotImplementedException();
        }
    }
}
```

## Configuration

Before you get started with creating your C# application, you need to register your client and authenticate the app with Zoho.

| Mandatory Keys    | Optional Keys |
| :---------------- | :------------ |
|  environment      | logger        |
|  token            | store         |
|                   | SDKConfig     |
|                   | requestProxy  |
|                   | resourcePath  |
----

The **environment** key contains the domain information to make API calls. The **token** key represents the OAuth info, including the clientID, clientSecret, grantToken, redirectURL, refreshToken or accessToken depending on the flow that you use. Refer to ##create an instance of OAuthToken## for more details.

- Configure the API environment which decides the domain and the URL to make API calls.

    ```C#
    /*
    * Configure the environment
    * which is of the pattern Domain.Environment
    * Available Domains: USDataCenter, EUDataCenter, INDataCenter, CNDataCenter, AUDataCenter,CADataCenter
    * Available Environments: PRODUCTION, DEVELOPER, SANDBOX
    */
    Environment environment = USDataCenter.PRODUCTION;
    ```

- Create an instance of **OAuthToken** with the information that you get after registering your Zoho client. In the context of token persistence, the grant token flow and refresh token flow involve storing and persisting the token. However, the access token flow does not involve token persistence and the access token is directly utilized for API calls. Depending on the tokens available with you, choose grantToken flow, refreshToken flow or accessToken flow.  

    - By default, the findUser key is set to true, to set userSignature. However, this requires the ***ZohoCRM.users.READ*** and ***ZohoCRM.org.READ*** scopes to be mandatory. If you do not want to set userSignature, you must set the findUser key to false.

    - Use the following method for **GrantToken flow :**    
    ```C#
        IToken token = new OAuthToken.Builder()
        .ClientId("clientId")
        .ClientSecret("clientSecret")
        .GrantToken("grantToken")
        .RedirectURL("redirectURL")
        .FindUser(false)// by default true
        .Build();
    ```
    - Use the following method for **RefreshToken flow :**
    ```C#
        IToken token = new OAuthToken.Builder()
        .ClientId("clientId")
        .ClientSecret("clientSecret")
        .RefreshToken("refreshToken")
        .FindUser(false)// by default true
        .Build();
    ```
    - Use the following method for **AccessToken flow :**
    ```C#
        IToken token = new OAuthToken.Builder()
        .AccessToken("accessToken")
        .FindUser(false)// by default true
        .Build();
    ```
    - Use the following method for **Id flow :**
    ```C#
        IToken token = new OAuthToken.Builder()
        .Id("id")// available in token store
        .Build();
    ```

- Create an instance of **Logger** Class to log exception and API information. By default, the SDK constructs a Logger instance with level - INFO and file_path - (sdk_logs.log parallel to bin/(Debug or Release) folder )

    ```C#
    /*
    * Create an instance of Logger Class that requires the following
    * Level -> Level of the log messages to be logged. Can be configured by typing Levels "." and choose any level from the list displayed.
    * FilePath -> Absolute file path, where messages need to be logged.
    */
    Logger logger = new Logger.Builder()
    .Level(Logger.Levels.ALL)
    .FilePath("/Users/csharp_sdk_log.log")
    .Build();
    ```

- Create an instance of **ITokenStore** to persist tokens, used for authenticating all the requests. By default, the SDK creates the sdk_tokens.txt file (parallel to to bin/(Debug or Release) folder) to persist the tokens.

    - Use the following method for DB Store
    ```C#
    /*
    * Create an instance of DBStore that requires the following
    * Host -> DataBase host name. Default "localhost"
    * DatabaseName -> DataBase name. Default "zohooauth"
    * UserName -> DataBase user name. Default "root"
    * Password -> DataBase password. Default ""
    * PortNumber -> DataBase port number. Default "3306"
    * TableName -> Table Name. Default value "oauthtoken"
    */
    //ITokenStore tokenstore = new DBStore.Builder().Build();

    ITokenStore tokenstore = new DBStore.Builder()
    .Host("hostName")
    .DatabaseName("dataBaseName")
    .TableName("tableName")
    .UserName("userName")
    .Password("password")
    .PortNumber("portNumber")
    .Build();
    ```
    - Use the following method for File Store
    ```C#
    ITokenStore tokenstore = new FileStore("absolute_file_path");
    ```
    - Use the following method for Custom Store
    ```C#
    ITokenStore tokenStore = new CustomStore();
    ```

- Create an instance of **SDKConfig** containing the SDK configuration.

    ```C#
    /*
    * By default, the SDK creates the SDKConfig instance
    * autoRefreshFields (default - false)
    * if true - all the modules' fields will be auto-refreshed in the background, every hour.
    * if false - the fields will not be auto-refreshed in the background. The user can manually delete the file(s) or refresh the fields using methods from ModuleFieldsHandler(com.zoho.crm.api.util.ModuleFieldsHandler)
    *
    * pickListValidation (default - true)
    * A boolean field that validates user input for a pick list field and allows or disallows the addition of a new value to the list.
    * true - the SDK validates the input. If the value does not exist in the pick list, the SDK throws an error.
    * false - the SDK does not validate the input and makes the API request with the user’s input to the pick list
    */
    SDKConfig config = new SDKConfig.Builder()
    .AutoRefreshFields(false)
    .PickListValidation(true)
    .Timeout(10)
    .Build();
    ```

- The path containing the absolute directory path to store user-specific files containing module fields information. By default, the SDK stores the user-specific files in a folder parallel to bin/(Debug or Release)

    ```C#
    string resourcePath = "/Users";
    ```

- Create an instance of **RequestProxy** containing the proxy properties of the user.

    ```C#
    /*
    * Create an instance of RequestProxy
    * host -> proxyHost
    * port -> proxyPort
    * user -> proxyUser
    * password -> password
    * userDomain -> userDomain
    */
    RequestProxy requestProxy = new RequestProxy.Builder()
    .Host("proxyHost")
    .Port(proxyPort)
    .User("proxyUser")
    .Password("password")
    .UserDomain("userDomain")
    .Build();
    ```

## Initializing the Application

Initialize the SDK using the following code.

```C#
using Com.Zoho.API.Authenticator;
using Com.Zoho.API.Authenticator.Store;
using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.Logger;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using SDKInitializer = Com.Zoho.Crm.API.Initializer;

namespace Samples
{
    public class Initialize
    {
        public static void SDKInitialize()
        {
            Logger logger = new Logger.Builder()
            .Level(Logger.Levels.ALL)
            .FilePath("/Users/csharp_sdk_log.log")
            .Build();

            Environment environment = USDataCenter.PRODUCTION;

            IToken token = new OAuthToken.Builder()
            .ClientId("clientId")
            .ClientSecret("clientSecret")
            .GrantToken("GRANT token")
            .RedirectURL("redirectURL")
            .Build();

            ITokenStore tokenstore = new DBStore.Builder()
            .Host("hostName")
            .DatabaseName("dataBaseName")
            .TableName("tableName")
            .UserName("userName")
            .Password("password")
            .PortNumber("portNumber")
            .Build();

            SDKConfig config = new SDKConfig.Builder()
            .AutoRefreshFields(false)
            .PickListValidation(true)
            .Timeout(10)
            .Build();

            string resourcePath = "/Users";

            RequestProxy requestProxy = new RequestProxy.Builder()
            .Host("proxyHost")
            .Port(00)
            .User("proxyUser")
            .Password("password")
            .UserDomain("userDomain")
            .Build();

            new SDKInitializer.Builder()
            .Environment(environment)
            .Token(token)
            .Store(tokenstore)
            .SDKConfig(config)
            .ResourcePath(resourcePath)
            .Logger(logger)
            .RequestProxy(requestProxy)
            .Initialize();
        }
    }
}
```

- You can now access the functionalities of the SDK. Refer to the sample codes to make various API calls through the SDK.

## Class Hierarchy

![classdiagram](class_hierarchy.png)

## Responses and Exceptions

All SDK method calls return an instance of the **[APIResponse](Com/Zoho/Crm/API/Util/APIResponse.cs)** class

Use the **Object** Property in the returned **[APIResponse](Com/Zoho/Crm/API/Util/APIResponse.cs)** object to obtain the response handler interface depending on the type of request (**GET, POST,PUT,DELETE**).

**APIResponse&lt;ResponseHandler&gt;** and **APIResponse&lt;ActionHandler&gt;** are the common wrapper objects for Zoho CRM APIs’ responses.

Whenever the API returns an error response, the response will be an instance of **APIException** class.

All other exceptions such as SDK anomalies and other unexpected behaviours are thrown under the **[SDKException](Com/Zoho/Crm/API/Exception/SDKException.cs)** class.

### GET Requests

- The **Object** of the returned APIResponse instance returns the response as follows.

- Most of the APIs follows the **Common** Structure as below.

  - The **ResponseHandler interface** encompasses the following
    - **ResponseWrapper class** (for **application/json** responses)
    - **FileBodyWrapper class** (for File download responses)
    - **APIException class**


- Some of the APIs follow the **Particular** Structure as below.

    - **HistoryWrapper class** (for **application/json** responses in **backup** API, holds the list of instances of **History class** and instance of **Info class**)
    - **UrlsWrapper class** (for **application/json** responses in **backup** API, holds the instance of **Urls class**)
    - **SourcesCountWrapper class** (for **application/json** responses in **UserGroups** API, holds the List of instances of **SourceCount class**)
    - **SourcesWrapper class** (for **application/json** responses in **Usergroups** APi, holds the List of instances of **Sources class** and instance of **Info class**)

  - The **ResponseWrapper interface** in **BulkWrite** API encompasses the following
    - **BulkWriteResponse class** (for **application/json** responses)
    - **APIException class**

  - The **CountHandler interface** encompasses the following
    - **CountWrapper class** (for **application/json** responses in **Record** API, holds the Long **count**)
    - **APIException class**

  - The **DeletedRecordsHandler interface** encompasses the following
    - **DeletedRecordsWrapper class** (for **application/json** responses in **Record** API, holds the list of instances of **DeletedRecord class** and instance of **Info class**)
    - **APIException class**

  - The **DownloadHandler interface** encompasses the following
    - **FileBodyWrapper class** (for File download responses)
    - **APIException class**

  - The **MassUpdateResponseHandler interface** encompasses the following
    - **MassUpdateResponseWrapper class** (for **application/json** responses in **Record** API, holds the list of instances of **MassUpdateResponse interface**)
    - **APIException class**

  - The **MassUpdateResponse interface** encompasses of following
    - **MassUpdate class** (for **application/json** responses)
    - **APIException class**

  - The **ValidationHandler interface** in **UserTerritories** API encomposses the following
    - **ValidationWrapper class** (for **application/json** responses, holds the list of instances of **ValidationGroup interface**)
    - **APIException class**

  - The **ValidationGroup interface** in **UserTerritories** API encompasses the following
    - **Validation class**
    - **BulkValidation class**

### POST, PUT, DELETE Requests

- The **getObject()** of the returned APIResponse instance returns the response as follows.

- Most of the APIs follows the **Common** Structure as.

  - The **ActionHandler interface** encompasses the following
    - **ActionWrapper class** (for **application/json** responses)
    - **APIException class**

  - The **ActionWrapper class** contains **Property/Properties** that may contain one/list of **ActionResponse interfaces**.

  - The **ActionResponse interface** encompasses the following
    - **SuccessResponse class** (for **application/json** responses)
    - **APIException class**

- Some of the APIs follow the **Particular** Structure as.

  - The **ActionHandler interface** encompasses the following
    - **ActionWrapper class** (for **application/json** responses)
    - **APIException class**

  - The **ActionWrapper class** contains **Property/Properties** that may contain one/list of **ActionResponse interface**.

  - The **ActionResponse interface** encompasses the following
    - **BusinessHoursCreated class** (for **application/json** responses in **BusinessHours** API)
    - **MassDeleteScheduled class** (for **application/json** responses in **MassDeleteCVID** API)
    - **APIEXception class**

  - The **RecordActionHandler interface** encompasses the following
    - **RecordActionWrapper class** (for **application/json** responses in **Tags** API, holds the list of instance of **RecordActionResponse interface**, Boolean **wfScheduler**, String **successCount** and Boolean **lockedCount**)
    - **APIException class**

  - **RecordActionResponse interface** encompasses the following
    - **RecordSuccessResponse class** (for **application/json** responses)
    - **APIException class**

  - The **ActionHandler interface** in **Currencies** API encompasses the following
    - **BaseCurrencyActionWrapper class** (for **application/json** responses)
    - **APIException class**

  - The **BaseCurrencyActionWrapper class** contains **Property/Properties** that contain **BaseCurrencyActionResponse interface**.

  - The **BaseCurrencyActionResponse interface** encompasses the following
    - **SuccessResponse class** (for **application/json** responses)
    - **APIException class**

  - The **MassUpdateActionHandler interface** encompasses the following
    - **MassUpdateActionWrapper class** (for **application/json** responses in **Record** API, holds the list of instances of **MassUpdateActionResponse interface**)
    - **APIException class**

  - The **MassUpdateActionResponse interface** encompasses of following
    - **MassUpdateSuccessResponse class** (for **application/json** responses)
    - **APIException class**

  - The **FileHandler interface** in **Record** API encompasses the following 
    - **SuccessResponse class** (for **application/json** responses)
    - **APIException class**

  - The **SignActionHandler interface** in **MailMerge** API encompasses the following
    - **SignActionWrapper class** (for **application/json** responses)
    - **APIException class**
    
  - The **DeleteActionHandler interface** encompasses the following
    - **DeleteActionWrapper class** (for **application/json** responses in **ShareRecords** API, holds the instance of **DeleteActionResponse interface**)
    - **APIException class**

  - The **DeleteActionResponse interface** encompasses the following
    - **SuccessResponse class** (for **application/json** responses)
    - **APIException class**

  - The **TransferActionHandler interface** in **UserTerritories** API encompasses the following
    - **TransferActionWrapper class** (fro **application/json** responses , holds the list of instances of **TransferActionResponse interface**)

  - The **TransferActionResponse interface** encompasses the following 
    - **SuccessResponse class** (for **application/json** responses)
    - **APIException class**

  - The **ActionResponse interface** in **Territories** API encompasses the following
    - **Success class** (for **application/json** responses)
    - **APIException class**

  - The **TransferPipelineActionHandler interface** in **Pipeline** API encompasses the following
    - **TransferPipelineActionWrapper class** (for **application/json** responses, holds the list of insatnces of **TransferPipelineActionResponse interface**)
    - **APIException class**
  
  - The **TransferPipelineActionResponse interface** in **Pipeline** API encompasses the following
    - **TransferPipelineSuccessResponse class** (for **application/json** responses)
    - **APIException class**


## Threading in the C# SDK

Threads in a C# program help you achieve parallelism. By using multiple threads, you can make a C# program run faster and do multiple things simultaneously.

### Multithreading in a Multi-User App

Multi-users functionality is achieved using **SwitchUser()** method.

```C#
new Initializer.Builder()
.Environment(environment)
.Token(token)
.SDKConfig(config)
.SwitchUser();
```

Here is a sample code to depict multi-threading for a multi-user app.

```C#
using System;
using System.Threading;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.Logger;
using Com.Zoho.Crm.API.Record;
using Com.Zoho.Crm.API.Util;
using Newtonsoft.Json;
using SDKInitializer = Com.Zoho.Crm.API.Initializer;

namespace Samples
{
    public class MultiThread
    {
        DataCenter.Environment environment;
        IToken token;
        string moduleAPIName;

        public MultiThread(DataCenter.Environment environment, IToken token, string moduleAPIName)
        {
            this.environment = environment;
            this.token = token;
            this.moduleAPIName = moduleAPIName;
        }

        static void Main(string[] args)
        {
            Logger logger = new Logger.Builder()
            .Level(Logger.Levels.ALL)
            .FilePath("/Users/csharp_sdk_log.log")
            .Build();
            DataCenter.Environment environment1 = USDataCenter.PRODUCTION;
            IToken token1 = new OAuthToken.Builder()
            .ClientId("clientId1")
            .ClientSecret("clientSecret1")
            .RefreshToken("refreshToken1")
            .RedirectURL("redirectURL1")
            .Build();
            new SDKInitializer.Builder()
            .Environment(environment1)
            .Token(token1)
            .Logger(logger)
            .Initialize();
            DataCenter.Environment environment2 = EUDataCenter.PRODUCTION;
            IToken token2 = new OAuthToken.Builder()
            .ClientId("clientId2")
            .ClientSecret("clientSecret2")
            .RefreshToken("refreshToken2")
            .RedirectURL("redirectURL2")
            .Build();
            MultiThread multiThread1 = new MultiThread(environment1, token1, "Vendors");
            Thread thread1 = new Thread(() => multiThread1.GetRecords());
            thread1.Start();
            MultiThread multiThread2 = new MultiThread(environment2, token2, "Quotes");
            Thread thread2 = new Thread(() => multiThread2.GetRecords());
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }

        public void GetRecords()
        {
            try
            {
                SDKConfig config = new SDKConfig.Builder().AutoRefreshFields(true).Build();
                new SDKInitializer.Builder()
                .Environment(this.environment)
                .Token(this.token)
                .SDKConfig(config).SwitchUser();
                RecordOperations recordOperation = new RecordOperations(this.moduleAPIName);
                APIResponse<ResponseHandler> response = recordOperation.GetRecords(null, null);
                if (response != null)
                {
                    Console.WriteLine("Status Code: " + response.StatusCode);
                    Console.WriteLine(response.Object);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }
    }
}
```

- The program execution starts from **Main()**.

- The details of **"user1"** is given in the variables user1, token1, environment1.

- Similarly, the details of another user **"user2"** is given in the variables user2, token2, environment2.

- For each user, an instance of **MultiThread class** is created.

- When the **Start()** is called which in-turn invokes the **run()**,  the details of user1 are passed to the **SwitchUser** function through the **MultiThread object**. Therefore, this creates a thread for user1.

- Similarly, When the **Start()** is invoked again,  the details of user2 are passed to the **SwitchUser** function through the **MultiThread object**. Therefore, this creates a thread for user2.

### Multi-threading in a Single User App

```C#
using System;
using System.Threading;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API.ContactRoles;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.Logger;
using Com.Zoho.Crm.API.Record;
using Com.Zoho.Crm.API.Util;
using Newtonsoft.Json;
using ResponseHandler = Com.Zoho.Crm.API.ContactRoles.ResponseHandler;
using SDKInitializer = Com.Zoho.Crm.API.Initializer;

namespace Samples
{
    public class MultiThread
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger.Builder()
            .Level(Logger.Levels.ALL)
            .FilePath("/Users/csharp_sdk_log.log")
            .Build();
            DataCenter.Environment env = USDataCenter.PRODUCTION;
            IToken token = new OAuthToken.Builder()
            .ClientId("clientId")
            .ClientSecret("clientSecret1")
            .GrantToken("GrantToken")
            .RedirectURL("redirectURL1")
            .Build();
            new SDKInitializer.Builder()
                .Environment(env)
                .Token(token)
                .Logger(logger)
                .Initialize();
            MultiThread multiThread1 = new MultiThread();
            Thread thread1 = new Thread(() => multiThread1.GetRecords("Quotes"));
            thread1.Start();
            Thread thread2 = new Thread(() => multiThread1.GetContactRoles());
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }

        public void GetRecords(string moduleAPIName)
        {
            try
            {
                RecordOperations recordOperation = new RecordOperations(moduleAPIName);
                APIResponse<Com.Zoho.Crm.API.Record.ResponseHandler> response = recordOperation.GetRecords(null, null);
                if (response != null)
                {
                    Console.WriteLine("Status Code: " + response.StatusCode);
                    Console.WriteLine(response.Object);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public void GetContactRoles()
        {
            try
            {
                ContactRolesOperations contactRolesOperations = new ContactRolesOperations();
                APIResponse<ResponseHandler> response = contactRolesOperations.GetRoles();
                if (response != null)
                {
                    Console.WriteLine("Status Code: " + response.StatusCode);
                    Console.WriteLine(response.Object);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }
    }
}
```

- The program execution starts from **Main()** where the SDK is initialized with the details of user and an instance of **MultiThread class** is created .

- When the **Start()** is called which in-turn invokes the **Run()**,  the moduleAPIName is switched through the method parameter. Therefore, this creates a thread for the particular method called with the **MultiThread** instance.

## SDK Sample code

```C#
using System;
using System.Collections.Generic;
using System.Reflection;
using Com.Zoho.API.Authenticator;
using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.Record;
using Com.Zoho.Crm.API.Tags;
using Com.Zoho.Crm.API.Util;
using Newtonsoft.Json;
using ActionHandler = Com.Zoho.Crm.API.Record.ActionHandler;
using ActionResponse = Com.Zoho.Crm.API.Record.ActionResponse;
using ActionWrapper = Com.Zoho.Crm.API.Record.ActionWrapper;
using APIException = Com.Zoho.Crm.API.Record.APIException;
using BodyWrapper = Com.Zoho.Crm.API.Record.BodyWrapper;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using SuccessResponse = Com.Zoho.Crm.API.Record.SuccessResponse;

namespace Samples
{
    public class CreateRecords
    {
        public static void Main(string[] args)
        {
            Environment environment = USDataCenter.PRODUCTION;
            IToken token = new OAuthToken.Builder().ClientId("ClientId").ClientSecret("ClientSecret").RefreshToken("RefreshToken").RedirectURL("Redirect_URL").Build();
            new Initializer.Builder().Environment(environment).Token(token).Initialize();
            CreateRecords_1("Leads");
        }
        public static void CreateRecords_1(string moduleAPIName)
        {
            RecordOperations recordOperations = new RecordOperations(moduleAPIName);
            BodyWrapper bodyWrapper = new BodyWrapper();
            List<Com.Zoho.Crm.API.Record.Record> records = new List<Com.Zoho.Crm.API.Record.Record>();
            Com.Zoho.Crm.API.Record.Record record1 = new Com.Zoho.Crm.API.Record.Record();
            record1.AddFieldValue(Leads.CITY, "City");
            record1.AddFieldValue(Leads.LAST_NAME, "Last Name");
            record1.AddFieldValue(Leads.FIRST_NAME, "First Name");
            record1.AddFieldValue(Leads.COMPANY, "KKRNP");
            List<Tag> tagList = new List<Tag>();
            Tag tag = new Tag();
            tag.Name = "Testtask";
            tagList.Add(tag);
            record1.Tag = tagList;
            records.Add(record1);
            bodyWrapper.Data = records;
            HeaderMap headerInstance = new HeaderMap();
            APIResponse<ActionHandler> response = recordOperations.CreateRecords(bodyWrapper, headerInstance);
            if (response != null)
            {
                Console.WriteLine("Status Code: " + response.StatusCode);
                if (response.IsExpected)
                {
                    ActionHandler actionHandler = response.Object;

                    if (actionHandler is ActionWrapper)
                    {
                        ActionWrapper actionWrapper = (ActionWrapper)actionHandler;
                        List<ActionResponse> actionResponses = actionWrapper.Data;
                        foreach (ActionResponse actionResponse in actionResponses)
                        {
                            if (actionResponse is SuccessResponse)
                            {
                                SuccessResponse successResponse = (SuccessResponse)actionResponse;
                                Console.WriteLine("Status: " + successResponse.Status.Value);
                                Console.WriteLine("Code: " + successResponse.Code.Value);
                                Console.WriteLine("Details: ");
                                foreach (KeyValuePair<string, object> entry in successResponse.Details)
                                {
                                    Console.WriteLine(entry.Key + ": " + JsonConvert.SerializeObject(entry.Value));
                                }
                                Console.WriteLine("Message: " + successResponse.Message.Value);
                            }
                            else if (actionResponse is APIException)
                            {
                                APIException exception = (APIException)actionResponse;
                                Console.WriteLine("Status: " + exception.Status.Value);
                                Console.WriteLine("Code: " + exception.Code.Value);
                                Console.WriteLine("Details: ");
                                foreach (KeyValuePair<string, object> entry in exception.Details)
                                {
                                    Console.WriteLine(entry.Key + ": " + JsonConvert.SerializeObject(entry.Value));
                                }
                                Console.WriteLine("Message: " + exception.Message.Value);
                            }
                        }
                    }
                    else if (actionHandler is APIException)
                    {
                        APIException exception = (APIException)actionHandler;
                        Console.WriteLine("Status: " + exception.Status.Value);
                        Console.WriteLine("Code: " + exception.Code.Value);
                        Console.WriteLine("Details: ");
                        foreach (KeyValuePair<string, object> entry in exception.Details)
                        {
                            Console.WriteLine(entry.Key + ": " + JsonConvert.SerializeObject(entry.Value));
                        }
                        Console.WriteLine("Message: " + exception.Message.Value);
                    }
                }
                else
                {
                    Model responseObject = response.Model;
                    System.Type type = responseObject.GetType();
                    Console.WriteLine("Type is: {0}", type.Name);
                    PropertyInfo[] props = type.GetProperties();
                    Console.WriteLine("Properties (N = {0}):", props.Length);
                    foreach (var prop in props)
                    {
                        if (prop.GetIndexParameters().Length == 0)
                        {
                            Console.WriteLine("{0} ({1}) : {2}", prop.Name, prop.PropertyType.Name, prop.GetValue(responseObject));
                        }
                        else
                        {
                            Console.WriteLine("{0} ({1}) : <Indexed>", prop.Name, prop.PropertyType.Name);
                        }
                    }
                }
            }
        }
    }
}
```

