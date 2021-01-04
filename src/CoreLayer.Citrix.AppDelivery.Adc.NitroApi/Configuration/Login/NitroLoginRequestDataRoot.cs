using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Login
{
    public class NitroLoginRequestDataRoot : INitroRequestDataRoot
    {
        public NitroLoginRequestDataRoot()
        {
            Login = new NitroLoginRequestData("nsroot", "nsroot");
        }
        public NitroLoginRequestDataRoot(NitroLoginRequestData data)
        {
            Login = data;
        }
        public INitroLoginRequestData Login { get; set; }
    }
}
