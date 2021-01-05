using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemBackup
{
    /// <summary>
    /// TODO SystemBackupDeleteCommand
    /// TODO SystemBackupDeleteCommand Tests
    /// </summary>
    public class SystemBackupDeleteCommand : NitroCommand<SystemBackupDeleteResponse>
    {
        /// <summary>
        /// TODO SystemBackupDeleteCommand constructor
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <param name="nitroRequest"></param>
        public SystemBackupDeleteCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
