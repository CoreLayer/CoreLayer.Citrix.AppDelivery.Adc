using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    /// <summary>
    /// TODO NitroRequestBulkBindingsOptions
    /// </summary>
    public class NitroRequestBulkBindingsOptions : NitroRequestOptions
    {
        /// <summary>
        /// TODO GenerateQueryParameterList
        /// </summary>
        /// <returns></returns>
        protected override List<string> GenerateQueryParameterList()
        {
            List<string> queryParameters = new List<string>();

            if (ResourceName == string.Empty)
            {
                queryParameters.Add("bulkbindings=yes");
            }
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
    }
}
