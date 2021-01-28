using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns.NsLicense;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsLicense
{
    public class NsLicenseGetResponse : NitroResponse
    {
        [JsonPropertyName("nslicense")]
        public NsLicenseResponseData NsLicenseResponse { get; set; }
    }
}
