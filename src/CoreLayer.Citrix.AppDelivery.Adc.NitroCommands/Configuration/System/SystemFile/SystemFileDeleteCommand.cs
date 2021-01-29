using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemFile
{
    public class SystemFileDeleteCommand : NitroCommand<SystemFileDeleteResponse>
    {
        public SystemFileDeleteCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
