using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyUpdateRequestData : INitroRequestData
    {
        public string PolicyName { get; set; }
        public string Action { get; }

        [JsonPropertyName("cmdspec")]
        public string CommandSpecification { get; set; }


        public SystemCmdPolicyUpdateRequestData(string policyName, SystemCmdPolicyAction systemCmdPolicyAction, string commandSpecification)
        {
            PolicyName = policyName;
            Action = systemCmdPolicyAction.ToString();
            CommandSpecification = commandSpecification;
        }
    }
}
