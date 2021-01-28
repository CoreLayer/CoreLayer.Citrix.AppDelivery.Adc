using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    public class NitroArgumentRequestOptions : NitroRequestOptions
    {
        public Dictionary<string, string> Arguments { get; set; } = new Dictionary<string, string>();


        public NitroArgumentRequestOptions() { }

        public NitroArgumentRequestOptions(Dictionary<string, string> arguments)
        {
            Arguments = arguments;
        }

        public override string ToString()
        {
            return base.ToString() + ArgumentsToString();
        }

        private string ArgumentsToString()
        {
            string returnString = "";
            if (Arguments != null)
            {
                if (Arguments.Count > 0)
                {
                    if (ResourceFilter.Count == 0 && PropertyFilter.Count == 0 && Count == false)
                    {
                        returnString += "?args=";
                    }
                    else
                    {
                        returnString += "&args=";
                    }

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
