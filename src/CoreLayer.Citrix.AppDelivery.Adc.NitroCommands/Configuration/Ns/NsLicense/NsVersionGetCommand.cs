using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsLicense;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.Ns.NsLicense
{
    /// <summary>
    /// TODO NsLicenseGetCommand
    /// </summary>
    public class NsLicenseGetCommand : NitroCommand<NsLicenseGetResponse>
    {
        /// <summary>
        /// TODO NsLicenseGetCommand constructor
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <param name="nitroRequest"></param>
        public NsLicenseGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
