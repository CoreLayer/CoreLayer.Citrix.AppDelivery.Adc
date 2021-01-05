using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns;
using System.Text.Json.Serialization;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns.NsLicense;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsLicense
{
    /// <summary>
    /// TODO NsLicenseGetResponse
    /// </summary>
    public class NsLicenseGetResponse : NitroResponse
    {
        [JsonPropertyName("nslicense")]
        public NsLicenseResponseData NsLicenseResponse { get; set; }
    }
}
