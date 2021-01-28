using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemFile;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    public class SystemFileGetResponse : NitroResponse
    {
        [JsonPropertyName("systemfile")]
        public SystemFileResponseData[] SystemFiles { get; set; }
    }
}