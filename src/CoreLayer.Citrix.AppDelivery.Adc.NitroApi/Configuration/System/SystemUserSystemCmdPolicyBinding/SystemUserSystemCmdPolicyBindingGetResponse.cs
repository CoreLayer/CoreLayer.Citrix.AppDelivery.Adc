using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemUserSystemCmdPolicyBinding;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("systemuser_systemcmdpolicy_binding")]
        public SystemUserSystemCmdPolicyBindingResponseData[] SystemUserSystemCmdPolicyBinding { get; set; }
    }
}