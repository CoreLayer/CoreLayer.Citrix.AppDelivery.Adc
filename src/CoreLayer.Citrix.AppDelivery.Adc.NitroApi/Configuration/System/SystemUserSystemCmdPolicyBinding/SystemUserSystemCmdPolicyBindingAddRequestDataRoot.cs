using System.Text.Json.Serialization;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemUserSystemCmdPolicyBinding;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    internal class SystemUserSystemCmdPolicyBindingAddRequestDataRoot : INitroRequestDataRoot
    {
        [JsonPropertyName("systemuser_systemcmdpolicy_binding")]
        public SystemUserSystemCmdPolicyBindingAddRequestData[] SystemUserSystemCmdPolicyBinding { get; set; }


        public SystemUserSystemCmdPolicyBindingAddRequestDataRoot(SystemUserSystemCmdPolicyBindingAddRequestData systemCmdPolicyAddRequestData)
        {
            SystemUserSystemCmdPolicyBinding = new[] { systemCmdPolicyAddRequestData };
        }

        public SystemUserSystemCmdPolicyBindingAddRequestDataRoot(SystemUserSystemCmdPolicyBindingAddRequestData[] systemCmdPolicyAddRequestDatas)
        {
            SystemUserSystemCmdPolicyBinding = systemCmdPolicyAddRequestDatas;
        }

        public override string ToString()
        {
            string result = "";

            foreach (var dataItem in SystemUserSystemCmdPolicyBinding)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}