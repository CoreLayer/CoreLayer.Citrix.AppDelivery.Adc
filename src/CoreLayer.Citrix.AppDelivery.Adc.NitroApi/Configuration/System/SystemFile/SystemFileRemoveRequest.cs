using System.Net.Http;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    /// <summary>
    /// TODO SystemFileRemoveRequest
    /// </summary>
    public class SystemFileRemoveRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/systemfile";
        public override INitroRequestDataRoot DataRoot => new SystemFileRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new SystemFileRemoveRequestOptions(null);
    }
}