using System.Text.Json;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    public static class NitroResponseDeserializer
    {
        public static T DeserializeIntoObject<T>(string jsonText)
        {
            // TODO DeserializeAsync
            return (T)JsonSerializer.Deserialize(jsonText, typeof(T), NitroDeserializerOptions.DeserializerOptions);
        }
    }
}
