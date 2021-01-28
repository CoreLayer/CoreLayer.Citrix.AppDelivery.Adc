using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsLicense;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.Ns.NsLicense
{
    public class NsLicenseGetCommand : NitroCommand<NsLicenseGetResponse>
    {
        public NsLicenseGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
