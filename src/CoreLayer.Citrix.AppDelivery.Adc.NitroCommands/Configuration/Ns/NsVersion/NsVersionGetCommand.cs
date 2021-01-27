using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsVersion;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.Ns.NsVersion
{
    public class NsVersionGetCommand : NitroCommand<NsLicenseGetResponse>
    {
        public NsVersionGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
