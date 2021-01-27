using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Login;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Login
{
    public class NitroLoginRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/login";
        public override INitroRequestOptions Options => new NitroLoginRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }
        

        public NitroLoginRequest(NitroLoginRequestData nitroLoginRequestData)
        {
            DataRoot = new NitroLoginRequestDataRoot(nitroLoginRequestData);
        }
    }
}
