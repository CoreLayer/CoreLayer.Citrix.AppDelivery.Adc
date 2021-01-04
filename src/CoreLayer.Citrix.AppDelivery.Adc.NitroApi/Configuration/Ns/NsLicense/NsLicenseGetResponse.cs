using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsLicense
{
    /// <summary>
    /// TODO NsLicenseGetResponse
    /// </summary>
    public class NsLicenseGetResponse : NitroResponse
    {
        [JsonPropertyName("nslicense")]
        public NsLicenseModel NsLicense { get; set; }
    }
}
