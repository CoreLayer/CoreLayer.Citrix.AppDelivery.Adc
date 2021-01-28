using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Logout
{
    public class NitroLogoutRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Post;
        public sealed override string ResourcePath => "/nitro/v1/config/logout";
        public sealed override INitroRequestOptions Options => new NitroLogoutRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new NitroLogoutRequestDataRoot();
    }
}
