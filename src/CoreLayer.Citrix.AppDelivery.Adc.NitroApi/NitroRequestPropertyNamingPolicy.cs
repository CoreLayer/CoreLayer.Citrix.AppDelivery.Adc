using System.Text.Json;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    /// <summary>
    /// TODO NitroRequestPropertyNamingPolicy
    /// </summary>
    public class NitroRequestPropertyNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            return name.ToLower();
        }
    }
}
