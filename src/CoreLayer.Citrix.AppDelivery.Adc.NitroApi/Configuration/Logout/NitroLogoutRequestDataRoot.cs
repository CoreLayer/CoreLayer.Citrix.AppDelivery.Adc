using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Logout;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Logout
{
    internal class NitroLogoutRequestDataRoot : INitroRequestDataRoot
    {
        public NitroLogoutRequestData Logout { get; set; }


        public NitroLogoutRequestDataRoot()
        {
            Logout = new NitroLogoutRequestData();
        }
    }
}
