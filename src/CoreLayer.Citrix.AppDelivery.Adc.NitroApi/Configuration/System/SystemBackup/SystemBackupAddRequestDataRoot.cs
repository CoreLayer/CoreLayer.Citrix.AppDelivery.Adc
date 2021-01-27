using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    internal class SystemBackupAddRequestDataRoot : INitroRequestDataRoot
    {
        public SystemBackupAddRequestData[] SystemBackup { get; set; }


        public SystemBackupAddRequestDataRoot(SystemBackupAddRequestData systemBackupAddRequestData)
        {
            SystemBackup = new []{ systemBackupAddRequestData };
        }

        public SystemBackupAddRequestDataRoot(SystemBackupAddRequestData[] systemBackupAddRequestDatas)
        {
            SystemBackup = systemBackupAddRequestDatas;
        }

        public override string ToString()
        {
            string result = "";

            foreach (var dataItem in SystemBackup)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}