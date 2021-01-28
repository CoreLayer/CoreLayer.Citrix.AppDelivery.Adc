using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsVersion
{
    public class NsVersionGetRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Get;
        public sealed override string ResourcePath => "/nitro/v1/config/nsversion";
        public sealed override INitroRequestDataRoot DataRoot => new NsVersionGetRequestDataRoot();
        public sealed override INitroRequestOptions Options { get; set; } = new NsLicenseGetRequestOptions();
    }
}
