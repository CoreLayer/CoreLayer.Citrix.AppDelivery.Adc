using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUser;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemUser
{
    public class SystemUserGetCommand : NitroCommand<SystemUserGetResponse>
    {
        public SystemUserGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
