using System;
using System.Collections.Generic;
using System.Reflection;
using Com.Zoho.API.Exception;
using Com.Zoho.Crm.API.Logger;
using Com.Zoho.Crm.API.Util;
using Newtonsoft.Json;

namespace Com.Zoho.Crm.API
{
    /// <summary>
    /// This class represents the HTTP header name and value.
    /// </summary>
    public class HeaderMap
    {
        private Dictionary<string, string> headerMap = new Dictionary<string, string>();

        /// <summary>
        /// This is a getter method to get header map.
        /// </summary>
        /// <returns>A Dictionary&lt;string, string&gt; representing the API response headers.</returns>
        public Dictionary<string, string> HeaderMaps
        {
            get
            {
                return headerMap;
            }
        }

        /// <summary>
        /// This method is to add header name and value.
        /// </summary>
        /// <typeparam name="T">A T containing the specified data type.</typeparam>
        /// <param name="header">A Header&lt;T&gt; class instance.</param>
        /// <param name="value">A T containing the header value.</param>
        public void Add<T>(Header<T> header, T value)
        {
            if(header == null)
            {
                throw new SDKException(Constants.HEADER_NULL_ERROR, Constants.HEADER_INSTANCE_NULL_ERROR);
            }
            string headerName = header.Name;
            if(headerName == null)
            {
                throw new SDKException(Constants.HEADER_NAME_NULL_ERROR, Constants.HEADER_NAME_NULL_ERROR_MESSAGE);
            }
            if(value == null)
            {
                throw new SDKException(Constants.HEADER_NULL_ERROR, headerName + Constants.NULL_VALUE_ERROR_MESSAGE);
            }
            try
            {
                string headerClassName = header.ClassName;
                string parsedHeaderValue;
                if (headerClassName != null)
                {
                    HeaderParamValidator<T> headerParamValidator = new HeaderParamValidator<T>();
                    parsedHeaderValue = headerParamValidator.Validate(headerName, headerClassName, value);
                }
                else
                {
                    try
                    {
                        string type = value.GetType().FullName;
                        Type dataTypeConverter = Type.GetType(Constants.DATATYPECONVERTER.Replace(Constants._TYPE, type));
                        MethodInfo method = dataTypeConverter.GetMethod(Constants.POST_CONVERT);
                        parsedHeaderValue = (string)(method.Invoke(null, new object[] { value, type }));
                        if (value is bool)
                        {
                            parsedHeaderValue = parsedHeaderValue.ToLower();
                        }
                    }
                    catch (Exception)
                    {
                        parsedHeaderValue = value.ToString();
                    }
                }
                if (headerMap.ContainsKey(headerName) && !string.IsNullOrEmpty(headerMap[headerName]))
                {
                    string existingHeaderValue = this.headerMap[headerName];
                    existingHeaderValue = existingHeaderValue + "," + parsedHeaderValue.ToString();
                    headerMap[headerName] = existingHeaderValue;
                }
                else
                {
                    headerMap[headerName] = parsedHeaderValue.ToString();
                }
            }
            catch (SDKException e)
            {
                SDKLogger.LogError(Constants.HEADER_EXCEPTION + JsonConvert.SerializeObject(e));
                throw e;
            }
            catch (Exception e)
            {
                SDKException exception = new SDKException(e);
                SDKLogger.LogError(Constants.HEADER_EXCEPTION + JsonConvert.SerializeObject(exception));
                throw exception;
            }
        }
    }
}
