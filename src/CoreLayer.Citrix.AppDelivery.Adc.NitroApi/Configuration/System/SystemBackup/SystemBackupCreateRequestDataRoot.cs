using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    internal class SystemBackupCreateRequestDataRoot : INitroRequestDataRoot
    {
        // public dynamic[] SystemBackup { get; }
        public SystemBackupCreateRequestData[] SystemBackup;

        public SystemBackupCreateRequestDataRoot() { }

        // public SystemBackupCreateRequestDataRoot(dynamic data)
        // {
        //     SystemBackup = new[] { data };
        // }
        //
        // public SystemBackupCreateRequestDataRoot(dynamic[] data)
        // {
        //     SystemBackup = data;
        // }

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
/// TODO CLEANUP
