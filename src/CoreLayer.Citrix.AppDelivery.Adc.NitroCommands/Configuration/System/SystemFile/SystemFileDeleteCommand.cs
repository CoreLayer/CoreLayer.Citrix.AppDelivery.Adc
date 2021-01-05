using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemFile
{
    /// <summary>
    /// TODO SystemFileDeleteCommand
    /// TODO SystemFileDeleteCommand Tests
    /// </summary>
    public class SystemFileDeleteCommand : NitroCommand<SystemFileRemoveResponse>
    {
        /// <summary>
        /// TODO SystemFileDeleteCommand constructor
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <param name="nitroRequest"></param>
        public SystemFileDeleteCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
