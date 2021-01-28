using System.Text.Json;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommon
{
    public class NitroJsonNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            return name.ToLower();
        }
    }
}
