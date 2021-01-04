using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    /// <summary>
    /// TODO NitroRequestRemoveOptions
    /// </summary>
    public class NitroRequestRemoveOptions : NitroRequestOptions
    {
        public new string ResourceName { get; }
        public new Dictionary<string, string> ResourceFilter { get; }
        public new List<string> PropertyFilter { get; }
        public new string Action { get; }
        public new bool Count { get; }
        public Dictionary<string, string> Arguments { get; set; }




        /// <summary>
        /// TODO NitroRequestRemoveOptions
        /// </summary>
        public NitroRequestRemoveOptions() { }




        /// <summary>
        /// TODO NitroRequestRemoveOptions
        /// </summary>
        /// <param name="resourceName"></param>
        public NitroRequestRemoveOptions(string resourceName)
        {
            ResourceName = resourceName;
        }





        public override string ToString()
        {
            string result = AddArgumentsToQuery();
            return result;
        }




        /// <summary>
        /// TODO AddArgumentsToQuery
        /// </summary>
        /// <returns></returns>
        private string AddArgumentsToQuery()
        {
            string returnString = "";
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
