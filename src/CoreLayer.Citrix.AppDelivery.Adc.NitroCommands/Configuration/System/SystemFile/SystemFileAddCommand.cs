using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemFile
{
    /// <summary>
    /// TODO SystemFileAddCommand
    /// TODO SystemFileAddCommand Tests
    /// </summary>
    public class SystemFileAddCommand : NitroCommand<SystemFileAddResponse>
    {
        /// <summary>
        /// TODO SystemFileAddCommand constructor
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <param name="nitroRequest"></param>
        public SystemFileAddCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
