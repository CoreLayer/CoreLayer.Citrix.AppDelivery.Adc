using System.Text.Json;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    /// <summary>
    /// TODO NitroSerializerOptions
    /// </summary>
    public static class NitroSerializerOptions
    {
        public static JsonSerializerOptions JsonSerializerOptions =>
            new JsonSerializerOptions
            {
                PropertyNamingPolicy = new NitroRequestPropertyNamingPolicy(),
                IgnoreNullValues = true,
            };
    }
}
