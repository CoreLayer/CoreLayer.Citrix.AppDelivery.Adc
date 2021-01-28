using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemFile
{
    public class SystemFileAddCommand : NitroCommand<SystemFileAddResponse>
    {
        public SystemFileAddCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
