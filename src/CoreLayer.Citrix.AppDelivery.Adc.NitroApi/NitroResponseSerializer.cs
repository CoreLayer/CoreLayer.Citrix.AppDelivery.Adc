using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    public static class NitroResponseDeserializer
    {
        public static T GenerateObject<T>(string jsonResponse)
        {
            return DeserializeIntoObject<T>(jsonResponse);
        }

        private static T DeserializeIntoObject<T>(string jsonText)
        {
            return (T)JsonSerializer.Deserialize(jsonText,
              typeof(T), NitroDeserializerOptions.DeserializerOptions);
        }
    }
}
