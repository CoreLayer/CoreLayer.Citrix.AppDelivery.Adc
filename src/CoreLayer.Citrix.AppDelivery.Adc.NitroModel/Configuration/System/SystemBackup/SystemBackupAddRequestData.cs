namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup
{
    public class SystemBackupAddRequestData
    {
        public string FileName { get; }

        public SystemBackupAddRequestData(string fileName)
        {
            FileName = fileName;
        }
    }
}
