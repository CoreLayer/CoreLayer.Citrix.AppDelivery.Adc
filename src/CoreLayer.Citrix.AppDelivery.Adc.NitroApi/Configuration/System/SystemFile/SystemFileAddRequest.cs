using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemFile;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    public class SystemFileAddRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/systemfile";
        public override INitroRequestOptions Options => new SystemFileAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }


        public SystemFileAddRequest(SystemFileAddRequestData systemFileAddRequestData)
        {
            DataRoot = new SystemFileAddRequestDataRoot(systemFileAddRequestData);
        }

        public SystemFileAddRequest(SystemFileAddRequestData[] systemFileAddRequestData)
        {
            DataRoot = new SystemFileAddRequestDataRoot(systemFileAddRequestData);
        }
    }
}