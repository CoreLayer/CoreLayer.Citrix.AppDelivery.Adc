using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsVersion
{
    public class NsVersionGetResponse : NitroResponse
    {
        [JsonPropertyName("nsversion")]
        public NsVersionModel NsVersion { get; set; }
    }
}
