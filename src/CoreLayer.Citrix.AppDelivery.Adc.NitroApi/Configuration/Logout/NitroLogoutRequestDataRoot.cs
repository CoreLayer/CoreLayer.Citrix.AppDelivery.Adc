using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Logout;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Logout
{
    /// <summary>
    /// TODO NitroLogoutRequestDataRoot
    /// </summary>
    public class NitroLogoutRequestDataRoot : INitroRequestDataRoot
    {
        /// <summary>
        /// TODO NitroLogoutRequestDataRoot constructor
        /// </summary>
        public NitroLogoutRequestDataRoot()
        {
            Logout = new NitroLogoutRequestData();
        }




        public NitroLogoutRequestData Logout { get; set; }
    }
}
