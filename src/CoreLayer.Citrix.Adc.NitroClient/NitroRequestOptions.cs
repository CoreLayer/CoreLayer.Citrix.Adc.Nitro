using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public abstract class NitroRequestOptions : INitroRequestOptions
    {
        public string ResourceName { get; set; } = "";
        public Dictionary<string, string> ResourceFilter { get; set; } = new Dictionary<string, string>();
        public List<string> PropertyFilter { get; set; } = new List<string>();
        public string Action { get; set; } = string.Empty; // TODO - implement action query parameter
        public bool Count { get; set; } = false;

        protected NitroRequestOptions() { }
        
        public override string ToString()
        {
            var queryParameters = GenerateQueryParameterList();

            return AddResourceNameToRequestPath() + AddQueryParametersToRequestQuery(queryParameters);
        }

        private List<string> GenerateQueryParameterList()
        {
            var queryParameters = new List<string>();

            if (!Action.Equals(string.Empty))
                queryParameters.Add("action=" + Action);
            else
            {
                if(Count)
                    queryParameters.Add("count=yes");
                
                if (ResourceFilter.Count > 0)
                    queryParameters.Add(ResourceFilterToString());

                if (PropertyFilter.Count > 0)
                    queryParameters.Add(PropertyFilterToString());
            }

            return queryParameters;
        }

        private string AddResourceNameToRequestPath()
        {
            if (!ResourceName.Equals(String.Empty))
            {
                return "/" + UrlEncoder.Default.Encode(ResourceName);
            }
            return ResourceName;
        }
        
        private static string AddQueryParametersToRequestQuery(ICollection<string> queryParameters)
        {
            return queryParameters.Count > 0
                ? ConvertListParametersToString(queryParameters, "?", "&") 
                : string.Empty;
        }

        private string ResourceFilterToString()
        {
            return ResourceFilter.Count > 0
                ? ConvertDictionaryParametersToString(ResourceFilter, "filter=", ",")
                : string.Empty;
        }

        private static string ConvertDictionaryParametersToString(IDictionary<string, string> dictionary,string prefix, string separator)
        {
            var result = new StringBuilder();
            var i = 0;
            foreach (var (key, value) in dictionary)
            {
                if (value.Equals(string.Empty)) continue;

                if (i.Equals(0))
                    result.Append(prefix);
                
                result.Append(key);
                result.Append(":");
                result.Append(UrlEncoder.Default.Encode(value));
                i++;
                if (i >= 1 && i < dictionary.Count)
                {
                    result.Append(separator);
                }
            }

            return result.ToString().TrimEnd(',');
        }

        private string PropertyFilterToString()
        {
            return PropertyFilter.Count > 0
                ? ConvertListParametersToString(PropertyFilter, "attrs=", ",")
                : string.Empty;
        }

        private static string ConvertListParametersToString(ICollection<string> list, string prefix, string separator)
        {
            var result = new StringBuilder();
            var i = 0;
            foreach (var item in list)
            {
                if (item.Equals(string.Empty)) continue;

                if (i.Equals(0))
                    result.Append(prefix);
                
                result.Append(item);
                i++;
                if (i >= 1 && i < list.Count)
                {
                    result.Append(separator);
                }
            }

            return result.ToString().TrimEnd(',');
        }
        
    }
}