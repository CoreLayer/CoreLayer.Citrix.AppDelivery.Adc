using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsVersion
{
    /// <summary>
    /// TODO NsVersionGetRequest
    /// </summary>
    public class NsVersionGetRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/nsversion";
        public override INitroRequestDataRoot DataRoot => new NsVersionGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new NsLicenseGetRequestOptions();
    }
}
