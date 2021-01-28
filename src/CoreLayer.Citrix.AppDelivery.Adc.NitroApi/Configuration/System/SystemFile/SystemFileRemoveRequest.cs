using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    public class SystemFileRemoveRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Delete;
        public sealed override string ResourcePath => "/nitro/v1/config/systemfile";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemFileRemoveRequestOptions(null);
        public sealed override INitroRequestDataRoot DataRoot => new SystemFileRemoveRequestDataRoot();
    }
}