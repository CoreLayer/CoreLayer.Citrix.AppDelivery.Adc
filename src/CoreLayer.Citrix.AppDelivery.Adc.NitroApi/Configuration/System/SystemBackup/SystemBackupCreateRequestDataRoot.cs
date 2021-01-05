using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    /// <summary>
    /// TODO SystemBackupCreateRequestDataRoot
    /// </summary>
    public class SystemBackupCreateRequestDataRoot : INitroRequestDataRoot
    {
        /// <summary>
        /// TODO SystemBackupCreateRequestDataRoot constructor
        /// </summary>
        public SystemBackupCreateRequestDataRoot() { }




        /// <summary>
        /// TODO SystemBackupCreateRequestDataRoot constructor
        /// </summary>
        public SystemBackupCreateRequestDataRoot(dynamic data)
        {
            SystemBackup = new[] { data };
        }




        /// <summary>
        /// TODO SystemBackupCreateRequestDataRoot constructor
        /// </summary>
        public SystemBackupCreateRequestDataRoot(dynamic[] data)
        {
            SystemBackup = data;
        }




        public dynamic[] SystemBackup { get; }
    }
}
