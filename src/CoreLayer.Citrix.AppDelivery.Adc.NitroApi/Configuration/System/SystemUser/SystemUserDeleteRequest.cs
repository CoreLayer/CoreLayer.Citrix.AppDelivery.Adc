using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUser
{
    public class SystemUserDeleteRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Delete;
        public sealed override string ResourcePath => "/nitro/v1/config/systemuser";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemUserDeleteRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new SystemUserDeleteRequestDataRoot();


        public SystemUserDeleteRequest() { }

        public SystemUserDeleteRequest(string resourceName)
        {
            Options = new SystemUserDeleteRequestOptions(resourceName);
        }
    }
}
