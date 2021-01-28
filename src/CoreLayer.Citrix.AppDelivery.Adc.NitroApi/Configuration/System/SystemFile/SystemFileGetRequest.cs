using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    public class SystemFileGetRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/systemfile";
        public override INitroRequestDataRoot DataRoot => new SystemFileGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new SystemFileGetRequestOptions();

    }
}