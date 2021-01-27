using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemBackup
{
    public class SystemBackupDeleteCommand : NitroCommand<SystemBackupDeleteResponse>
    {
        public SystemBackupDeleteCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
