using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Login;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Login
{
    /// <summary>
    /// TODO NitroLoginRequestDataRoot
    /// </summary>
    public class NitroLoginRequestDataRoot : INitroRequestDataRoot
    {
        /// <summary>
        /// TODO NitroLoginRequestDataRoot constructor
        /// </summary>
        public NitroLoginRequestDataRoot()
        {
            Login = new NitroLoginRequestData("nsroot", "nsroot");
        }




        /// <summary>
        /// TODO NitroLoginRequestDataRoot constructor
        /// </summary>
        /// <param name="data"></param>
        public NitroLoginRequestDataRoot(NitroLoginRequestData data)
        {
            Login = data;
        }




        public NitroLoginRequestData Login { get; set; }
    }
}
