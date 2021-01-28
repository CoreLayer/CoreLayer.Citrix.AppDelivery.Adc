using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    internal class SystemBackupCreateRequestDataRoot : INitroRequestDataRoot
    {
        public SystemBackupCreateRequestData[] SystemBackup { get; }


        public SystemBackupCreateRequestDataRoot() { }
        
        public SystemBackupCreateRequestDataRoot(SystemBackupCreateRequestData systemBackupCreateRequestData)
        {
            SystemBackup = new[] { systemBackupCreateRequestData };
        }
        
        public SystemBackupCreateRequestDataRoot(SystemBackupCreateRequestData[] systemBackupCreateRequestDatas)
        {
            SystemBackup = systemBackupCreateRequestDatas;
        }
    }
}