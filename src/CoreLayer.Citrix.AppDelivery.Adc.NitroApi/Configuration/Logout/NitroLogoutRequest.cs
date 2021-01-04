using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Logout
{
    /// <summary>
    /// TODO NitroLogoutRequest
    /// </summary>
    public class NitroLogoutRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/logout";
        public override INitroRequestOptions Options => new NitroLogoutRequestOptions();
        public override INitroRequestDataRoot DataRoot => new NitroLogoutRequestDataRoot();
    }
}
