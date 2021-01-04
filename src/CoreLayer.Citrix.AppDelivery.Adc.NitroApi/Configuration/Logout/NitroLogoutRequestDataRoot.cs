using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Logout
{
    /// <summary>
    /// TODO NitroLogoutRequestDataRoot
    /// </summary>
    public class NitroLogoutRequestDataRoot : INitroRequestDataRoot
    {
        public NitroLogoutRequestDataRoot()
        {
            Logout = new NitroLogoutRequestData();
        }

        public NitroLogoutRequestData Logout { get; set; }
    }
}
