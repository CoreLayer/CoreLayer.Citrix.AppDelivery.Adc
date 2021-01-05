using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemFile
{
    /// <summary>
    /// TODO SystemFileGetCommand
    /// TODO SystemFileGetCommand Tests
    /// </summary>
    public class SystemFileGetCommand : NitroCommand<SystemFileGetResponse>
    {
        /// <summary>
        /// TODO SystemFileGetCommand constructor
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <param name="nitroRequest"></param>
        public SystemFileGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
