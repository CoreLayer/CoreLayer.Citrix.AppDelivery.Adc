using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    /// <summary>
    /// TODO NitroResponseDeserializer
    /// </summary>
    public static class NitroResponseDeserializer
    {
        /// <summary>
        /// TODO DeserializeIntoObject
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonText"></param>
        /// <returns></returns>
        public static T DeserializeIntoObject<T>(string jsonText)
        {
            // TODO DeserializeAsync
            return (T)JsonSerializer.Deserialize(jsonText, typeof(T), NitroDeserializerOptions.DeserializerOptions);
        }
    }
}
