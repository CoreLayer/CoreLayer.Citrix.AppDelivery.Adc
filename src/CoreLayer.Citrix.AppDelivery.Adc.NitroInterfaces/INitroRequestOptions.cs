using System.Collections.Generic;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces
{
    public interface INitroRequestOptions
    {
        string ResourceName { get; set; }
        Dictionary<string, string> ResourceFilter { get; set; }
        List<string> PropertyFilter { get; set; }
        string Action { get; }
        bool Count { get; }
        string ToString();
    }
}
