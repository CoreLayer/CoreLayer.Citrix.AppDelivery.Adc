using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Login
{
    /// <summary>
    /// TODO NitroLoginRequest
    /// </summary>
    public class NitroLoginRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/login";
        public override INitroRequestOptions Options => new NitroLoginRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; } = new NitroLoginRequestDataRoot();




        /// <summary>
        /// TODO NitroLoginRequest constructor
        /// </summary>
        public NitroLoginRequest()
        {
            DataRoot = new NitroLoginRequestDataRoot();
        }



        
        /// <summary>
        /// TODO NitroLoginRequest constructor
        /// </summary>
        /// <param name="dataRoot"></param>
        public NitroLoginRequest(NitroLoginRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
