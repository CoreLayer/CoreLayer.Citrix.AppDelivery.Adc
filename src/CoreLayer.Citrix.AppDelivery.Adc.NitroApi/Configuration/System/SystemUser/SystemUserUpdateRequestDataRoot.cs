using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemUser;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUser
{
    internal class SystemUserUpdateRequestDataRoot : INitroRequestDataRoot
    {
        public SystemUserUpdateRequestData[] SystemUser { get; set; }


        public SystemUserUpdateRequestDataRoot(SystemUserUpdateRequestData SystemUserUpdateRequestData)
        {
            SystemUser = new[] { SystemUserUpdateRequestData };
        }

        public SystemUserUpdateRequestDataRoot(SystemUserUpdateRequestData[] SystemUserUpdateRequestDatas)
        {
            SystemUser = SystemUserUpdateRequestDatas;
        }

        public override string ToString()
        {
            string result = "";

            foreach (var dataItem in SystemUser)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}