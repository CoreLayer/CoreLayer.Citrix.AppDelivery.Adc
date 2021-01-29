using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUser;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemUser
{
    public class SystemUserUpdateCommand : NitroCommand<SystemUserUpdateResponse>
    {
        public SystemUserUpdateCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
