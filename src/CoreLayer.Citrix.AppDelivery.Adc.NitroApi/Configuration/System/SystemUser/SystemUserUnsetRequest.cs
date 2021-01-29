using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemUser;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUser
{
    public class SystemUserUnsetRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Post;
        public sealed override string ResourcePath => "/nitro/v1/config/systemuser";
        public sealed override INitroRequestOptions Options => new SystemUserUnsetRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot { get; }


        public SystemUserUnsetRequest(SystemUserUnsetRequestData SystemUserUnsetRequestData)
        {
            DataRoot = new SystemUserUnsetRequestDataRoot(SystemUserUnsetRequestData);
        }
    }
}
