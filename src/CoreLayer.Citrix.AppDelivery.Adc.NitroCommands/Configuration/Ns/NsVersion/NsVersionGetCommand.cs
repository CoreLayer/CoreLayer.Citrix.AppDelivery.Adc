using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsVersion;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.Ns.NsVersion
{
    /// <summary>
    /// TODO NsVersionGetCommand
    /// </summary>
    public class NsVersionGetCommand : NitroCommand<NsLicenseGetResponse>
    {
        /// <summary>
        /// TODO NsVersionGetCommand constructor
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <param name="nitroRequest"></param>
        public NsVersionGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
