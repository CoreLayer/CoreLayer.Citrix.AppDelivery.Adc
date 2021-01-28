using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemFile
{
    public class SystemFileGetCommand : NitroCommand<SystemFileGetResponse>
    {
        public SystemFileGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
