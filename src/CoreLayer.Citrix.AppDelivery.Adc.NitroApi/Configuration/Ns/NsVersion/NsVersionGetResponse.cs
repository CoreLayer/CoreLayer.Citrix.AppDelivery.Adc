using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns.NsVersion;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsVersion
{
    public class NsLicenseGetResponse : NitroResponse
    {
        [JsonPropertyName("nsversion")]
        public NsVersionResponseData NsVersionResponse { get; set; }
    }
}
