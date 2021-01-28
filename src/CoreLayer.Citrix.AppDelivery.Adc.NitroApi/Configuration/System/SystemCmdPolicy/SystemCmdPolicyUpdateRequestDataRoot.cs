using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemCmdPolicy;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemCmdPolicy
{
    internal class SystemCmdPolicyUpdateRequestDataRoot : INitroRequestDataRoot
    {
        public SystemCmdPolicyUpdateRequestData[] SystemCmdPolicy { get; set; }


        public SystemCmdPolicyUpdateRequestDataRoot(SystemCmdPolicyUpdateRequestData SystemCmdPolicyUpdateRequestData)
        {
            SystemCmdPolicy = new[] { SystemCmdPolicyUpdateRequestData };
        }

        public SystemCmdPolicyUpdateRequestDataRoot(SystemCmdPolicyUpdateRequestData[] SystemCmdPolicyUpdateRequestDatas)
        {
            SystemCmdPolicy = SystemCmdPolicyUpdateRequestDatas;
        }

        public override string ToString()
        {
            string result = "";

            foreach (var dataItem in SystemCmdPolicy)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}