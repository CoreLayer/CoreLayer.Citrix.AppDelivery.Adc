using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemCmdPolicy;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemCmdPolicy
{
    internal class SystemCmdPolicyAddRequestDataRoot : INitroRequestDataRoot
    {
        public SystemCmdPolicyAddRequestData[] SystemCmdPolicy { get; set; }


        public SystemCmdPolicyAddRequestDataRoot(SystemCmdPolicyAddRequestData systemCmdPolicyAddRequestData)
        {
            SystemCmdPolicy = new[] { systemCmdPolicyAddRequestData };
        }

        public SystemCmdPolicyAddRequestDataRoot(SystemCmdPolicyAddRequestData[] systemCmdPolicyAddRequestDatas)
        {
            SystemCmdPolicy = systemCmdPolicyAddRequestDatas;
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