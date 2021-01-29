using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUser;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemUser
{
    public class SystemUserUnsetCommand : NitroCommand<SystemUserUnsetResponse>
    {
        public SystemUserUnsetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
