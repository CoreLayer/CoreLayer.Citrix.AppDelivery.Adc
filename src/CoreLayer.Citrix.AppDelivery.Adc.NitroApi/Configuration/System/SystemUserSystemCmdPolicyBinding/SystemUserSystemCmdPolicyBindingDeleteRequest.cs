using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingDeleteRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Delete;
        public sealed override string ResourcePath => "/nitro/v1/config/systemuser_systemcmdpolicy_binding";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemUserSystemCmdPolicyBindingDeleteRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new SystemUserSystemCmdPolicyBindingDeleteRequestDataRoot();


        public SystemUserSystemCmdPolicyBindingDeleteRequest() { }

        public SystemUserSystemCmdPolicyBindingDeleteRequest(string username, string policyName)
        {
            Options = new SystemUserSystemCmdPolicyBindingDeleteRequestOptions(username, policyName);
        }
    }
}
