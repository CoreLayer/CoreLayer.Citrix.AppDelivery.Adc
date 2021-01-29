using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    public class NitroDeleteRequestOptions : NitroRequestOptions
    {
        public override string ResourceName { get; set; }
        public override Dictionary<string, string> ResourceFilter { get; set; }
        public override List<string> PropertyFilter { get; set; }
        public override string Action { get; }
        public override bool Count { get; set; }
        public Dictionary<string, string> Arguments { get; set; }


        public NitroDeleteRequestOptions() { }

        public NitroDeleteRequestOptions(string resourceName)
        {
            ResourceName = resourceName;
        }


        public override string ToString()
        {
            var result = AddArgumentsToQuery();
            return result;
        }

        private string AddArgumentsToQuery()
        {
            var returnString = "";

            if (!string.IsNullOrEmpty(ResourceName))
            {
                returnString += "/" + ResourceName;
            }

            if (Arguments != null)
            {
                if (Arguments.Count > 0)
                {
                    returnString += "?args=";
                    foreach (var (key, value) in Arguments)
                    {
                        returnString += key + ":" + UrlEncoder.Default.Encode(value) + ",";
                    }
                }
            }

            return returnString.TrimEnd(',');
        }
    }
}
