using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUser
{
    public class SystemUserGetRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Get;
        public sealed override string ResourcePath => "/nitro/v1/config/systemuser";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemUserGetRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new SystemUserGetRequestDataRoot();


        public SystemUserGetRequest() { }

        public SystemUserGetRequest(string resourceName)
        {
            Options = new SystemUserGetRequestOptions(resourceName);
        }
    }
}
