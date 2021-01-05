using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemBackup
{
    /// <summary>
    /// TODO SystemBackupAddCommand
    /// TODO SystemBackupAddCommand Tests
    /// </summary>
    public class SystemBackupAddCommand : NitroCommand<SystemBackupAddResponse>
    {
        /// <summary>
        /// TODO SystemBackupAddCommand constructor
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <param name="nitroRequest"></param>
        public SystemBackupAddCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
