using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Login;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Login
{
    internal class NitroLoginRequestDataRoot : INitroRequestDataRoot
    {
        public NitroLoginRequestData Login { get; set; }


        public NitroLoginRequestDataRoot()
        {
            Login = new NitroLoginRequestData("nsroot", "nsroot");
        }

        public NitroLoginRequestDataRoot(NitroLoginRequestData nitroLoginRequestData)
        {
            Login = nitroLoginRequestData;
        }
    }
}
