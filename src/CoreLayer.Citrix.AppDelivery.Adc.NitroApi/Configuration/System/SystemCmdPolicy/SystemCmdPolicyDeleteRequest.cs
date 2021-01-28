using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyDeleteRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Delete;
        public sealed override string ResourcePath => "/nitro/v1/config/systemcmdpolicy";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemCmdPolicyDeleteRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new SystemCmdPolicyDeleteRequestDataRoot();


        public SystemCmdPolicyDeleteRequest() { }

        public SystemCmdPolicyDeleteRequest(string resourceName)
        {
            Options = new SystemCmdPolicyDeleteRequestOptions(resourceName);
        }
    }
}
