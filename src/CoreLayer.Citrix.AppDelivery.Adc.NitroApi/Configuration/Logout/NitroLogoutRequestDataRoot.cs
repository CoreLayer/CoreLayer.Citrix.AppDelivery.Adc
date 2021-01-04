using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Logout
{
    public class NitroLogoutRequestDataRoot : INitroRequestDataRoot
    {
        public NitroLogoutRequestDataRoot()
        {
            Logout = new NitroLogoutRequestData();
        }

        public INitroLogoutRequestData Logout { get; set; }
    }
}
