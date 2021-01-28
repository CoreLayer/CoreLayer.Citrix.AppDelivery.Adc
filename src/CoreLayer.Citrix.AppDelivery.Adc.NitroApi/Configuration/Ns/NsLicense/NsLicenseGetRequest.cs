using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsLicense
{
    public class NsLicenseGetRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/nslicense";
        public override INitroRequestDataRoot DataRoot => new NsLicenseGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new NsLicenseGetRequestOptions();
    }
}
