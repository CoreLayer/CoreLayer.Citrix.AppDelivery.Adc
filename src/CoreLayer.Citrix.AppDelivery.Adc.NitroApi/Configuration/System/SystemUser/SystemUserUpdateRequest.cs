using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemUser;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUser
{
    public class SystemUserUpdateRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Put;
        public sealed override string ResourcePath => "/nitro/v1/config/systemuser";
        public sealed override INitroRequestOptions Options => new SystemUserUpdateRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot { get; }


        public SystemUserUpdateRequest(SystemUserUpdateRequestData SystemUserUpdateRequestData)
        {
            DataRoot = new SystemUserUpdateRequestDataRoot(SystemUserUpdateRequestData);
        }
    }
}
