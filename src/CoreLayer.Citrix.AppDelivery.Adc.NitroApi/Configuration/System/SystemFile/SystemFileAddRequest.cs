using System.Net.Http;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    /// <summary>
    /// TODO SystemFileAddRequest
    /// TODO SystemFileAddRequest Tests
    /// </summary>
    public class SystemFileAddRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/systemfile";
        public override INitroRequestOptions Options => new SystemFileAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        // TODO Check for INitroRequestDataRoot in all Requests
        /// <summary>
        /// TODO SystemFileAddRequest
        /// </summary>
        /// <param name="dataRoot"></param>
        public SystemFileAddRequest(SystemFileAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}