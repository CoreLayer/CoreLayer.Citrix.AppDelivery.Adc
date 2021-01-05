using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup
{
    /// <summary>
    /// TODO SystemBackupCreateRequestData
    /// </summary>
    public class SystemBackupCreateRequestData : INitroRequestData
    {
        public SystemBackupCreateRequestData(string level)
        {
            Level = level;
        }

        public SystemBackupCreateRequestData(string level, string filename) : this(level)
        {
            Filename = filename;
        }

        public SystemBackupCreateRequestData(string level, string filename, string comment) : this(level, filename)
        {
            Comment = comment;
        }

        public string Level { get; }
        public string Filename { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        
    }
}
