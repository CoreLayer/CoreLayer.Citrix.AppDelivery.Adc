using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    public class SystemFileRemoveRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/systemfile";
        public override INitroRequestOptions Options { get; set; } = new SystemFileRemoveRequestOptions(null);
        public override INitroRequestDataRoot DataRoot => new SystemFileRemoveRequestDataRoot();
    }
}