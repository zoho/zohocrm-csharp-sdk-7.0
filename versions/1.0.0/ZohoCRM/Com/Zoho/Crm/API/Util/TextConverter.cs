using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace Com.Zoho.Crm.API.Util
{
    public class TextConverter : Converter
    {
        public TextConverter(CommonAPIHandler commonAPIHandler) : base(commonAPIHandler) { }

        public override object FormRequest(object requestInstance, string pack, int? instanceNumber, JObject memberDetail)
        {
            return null;
        }

        public override void AppendToRequest(HttpWebRequest requestBase, object requestObject)
        {
        }

        public override object GetWrappedResponse(object response, string pack)
        {
            HttpWebResponse responseEntity = ((HttpWebResponse)response);
            string responseString = new StreamReader(responseEntity.GetResponseStream()).ReadToEnd();
            responseEntity.Close();
            if (responseString != null && !string.IsNullOrEmpty(responseString) && !string.IsNullOrWhiteSpace(responseString))
            {
                return GetResponse(responseString, pack);
            }
            return null;
        }

        public override object GetResponse(object response, string pack)
        {
            JObject classDetail = (JObject)Initializer.jsonDetails.GetValue(pack);
            JValue value = response is JValue ? (JValue)response : null;
            if (response == null || response.ToString().Equals("null") || (response.ToString().Trim()).Length == 0 || (value != null && value.Value == null))
            {
                return null;
            }
            string responseString = response.ToString();
            object instance = null;
            try
            {
                // create an instance of that type
                instance = Activator.CreateInstance(Type.GetType(pack));
            }
            catch (MissingMethodException) //when there is no public constructor- invoke the private constructor
            {
                instance = Activator.CreateInstance(Type.GetType(pack), true);
            }
            foreach (KeyValuePair<string, JToken> member in classDetail)
            {
                string memberName = member.Key;
                JObject keyDetail = (JObject)classDetail[memberName];
                string keyName = keyDetail.ContainsKey(Constants.NAME) ? keyDetail[Constants.NAME].ToString() : null;
                if (keyName != null)
                {
                    FieldInfo field = GetPrivateFieldInfo(instance.GetType(), memberName);
                    field.SetValue(instance, responseString);
                }
            }
            return instance;
        }
	}
}

