using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUser;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemUser
{
    public class SystemUserAddCommand : NitroCommand<SystemUserAddResponse>
    {
        public SystemUserAddCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
