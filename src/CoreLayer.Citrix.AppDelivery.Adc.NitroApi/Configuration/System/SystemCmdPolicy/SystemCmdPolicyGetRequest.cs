using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyGetRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/systemcmdpolicy";
        public override INitroRequestOptions Options { get; set; } = new SystemCmdPolicyGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new SystemCmdPolicyGetRequestDataRoot();


        public SystemCmdPolicyGetRequest() { }

        public SystemCmdPolicyGetRequest(string resourceName)
        {
            Options = new SystemCmdPolicyGetRequestOptions(resourceName);
        }
    }
}
