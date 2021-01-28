using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    public abstract class NitroRequestOptions : INitroRequestOptions
    {
        public virtual string ResourceName { get; set; } = "";
        public virtual Dictionary<string, string> ResourceFilter { get; set; } = new Dictionary<string, string>();
        public virtual List<string> PropertyFilter { get; set; } = new List<string>();
        public virtual string Action { get; set; } = string.Empty; // TODO - implement action query parameter
        public virtual bool Count { get; set; } = false;


        protected NitroRequestOptions() { }

        public override string ToString()
        {
            var queryParameters = GenerateQueryParameterList();

            return AddResourceNameToRequestPath() + AddQueryParametersToRequestQuery(queryParameters);
        }

        protected virtual List<string> GenerateQueryParameterList()
        {
            List<string> queryParameters = new List<string>();

            if (!Action.Equals(string.Empty))
                queryParameters.Add("action=" + Action);
            else
            {
                if (Count)
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

        protected static string AddQueryParametersToRequestQuery(ICollection<string> queryParameters)
        {
            return queryParameters.Count > 0
                ? ConvertListParametersToString(queryParameters, "?", "&")
                : string.Empty;
        }


        protected string ResourceFilterToString()
        {
            return ResourceFilter.Count > 0
                ? ConvertDictionaryParametersToString(ResourceFilter, "filter=", ",")
                : string.Empty;
        }

        private static string ConvertDictionaryParametersToString(IDictionary<string, string> dictionary, string prefix, string separator)
        {
            var result = new StringBuilder();
            var i = 0;
            foreach (var (key, value) in dictionary)
            {
                if (value.Equals(string.Empty)) continue;

                if (i.Equals(0))
                    result.Append(prefix);

                result.Append(key);
                result.Append(':');
                result.Append(UrlEncoder.Default.Encode(value));
                i++;
                if (i >= 1 && i < dictionary.Count)
                {
                    result.Append(separator);
                }
            }

            return result.ToString().TrimEnd(',');
        }

        protected string PropertyFilterToString()
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
