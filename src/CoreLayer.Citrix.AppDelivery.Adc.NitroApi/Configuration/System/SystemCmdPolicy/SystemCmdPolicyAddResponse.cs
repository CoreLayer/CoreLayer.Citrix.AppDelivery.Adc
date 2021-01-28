using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemCmdPolicy;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyAddResponse : NitroResponse
    {
        [JsonPropertyName("systemcmdpolicy")]
        public SystemCmdPolicyResponseData[] SystemCmdPolicy { get; set; }
    }
}
