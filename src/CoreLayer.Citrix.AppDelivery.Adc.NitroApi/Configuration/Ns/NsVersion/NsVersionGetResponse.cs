using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns;
using System.Text.Json.Serialization;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns.NsVersion;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsVersion
{
    /// <summary>
    /// TODO NsLicenseGetResponse
    /// </summary>
    public class NsLicenseGetResponse : NitroResponse
    {
        [JsonPropertyName("nsversion")]
        public NsVersionResponseData NsVersionResponse { get; set; }
    }
}
