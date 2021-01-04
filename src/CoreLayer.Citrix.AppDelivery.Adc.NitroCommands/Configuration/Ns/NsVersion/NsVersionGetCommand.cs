using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsVersion;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.Ns.NsVersion
{
    public class NsVersionGetCommand : NitroCommand<NsVersionGetResponse>
    {
        public NsVersionGetCommand(INitroClient serviceClient, INitroRequest requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {

        }
    }
}
