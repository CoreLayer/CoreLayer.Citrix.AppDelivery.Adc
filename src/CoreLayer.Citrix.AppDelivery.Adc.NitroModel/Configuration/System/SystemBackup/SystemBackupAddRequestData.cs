using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup
{
    public class SystemBackupAddRequestData : INitroRequestData
    {
        public string FileName { get; }

        public SystemBackupAddRequestData(string fileName)
        {
            FileName = fileName;
        }
    }
}
