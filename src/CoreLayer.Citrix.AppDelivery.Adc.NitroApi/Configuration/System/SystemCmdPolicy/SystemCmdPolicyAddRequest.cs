using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemCmdPolicy;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyAddRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/systemcmdpolicy";
        public override INitroRequestOptions Options => new SystemCmdPolicyAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }


        public SystemCmdPolicyAddRequest(SystemCmdPolicyAddRequestData systemCmdPolicyAddRequestData)
        {
            DataRoot = new SystemCmdPolicyAddRequestDataRoot(systemCmdPolicyAddRequestData);
        }
    }
}
