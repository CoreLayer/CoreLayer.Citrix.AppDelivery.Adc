using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup
{
    public class SystemBackupCreateRequestData : INitroRequestData
    {
        public string Level { get; }
        public string Filename { get; } = string.Empty;
        public string Comment { get; } = string.Empty;


        public SystemBackupCreateRequestData(SystemBackupLevel level)
        {
            Level = level.ToString().ToLower();
        }

        public SystemBackupCreateRequestData(SystemBackupLevel level, string fileName) : this(level)
        {
            Filename = fileName.Replace(".tgz", "");
        }

        public SystemBackupCreateRequestData(SystemBackupLevel level, string fileName, string comment) : this(level, fileName)
        {
            Comment = comment;
        }
    }
}
