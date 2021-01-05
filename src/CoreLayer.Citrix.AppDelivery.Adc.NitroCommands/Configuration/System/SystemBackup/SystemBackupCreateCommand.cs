using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemBackup
{
    /// <summary>
    /// TODO SystemBackupCreateCommand
    /// TODO SystemBackupCreateCommand Tests
    /// </summary>
    public class SystemBackupCreateCommand : NitroCommand<SystemBackupCreateResponse>
    {
        /// <summary>
        /// TODO SystemBackupCreateCommand constructor
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <param name="nitroRequest"></param>
        public SystemBackupCreateCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}