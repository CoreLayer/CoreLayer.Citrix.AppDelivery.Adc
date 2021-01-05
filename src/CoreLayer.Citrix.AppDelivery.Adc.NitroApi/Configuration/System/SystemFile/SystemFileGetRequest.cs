using System.Net.Http;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    /// <summary>
    /// TODO SystemFileGetRequest
    /// </summary>
    public class SystemFileGetRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/systemfile";
        public override INitroRequestDataRoot DataRoot => new SystemFileGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new SystemFileGetRequestOptions();

    }
}