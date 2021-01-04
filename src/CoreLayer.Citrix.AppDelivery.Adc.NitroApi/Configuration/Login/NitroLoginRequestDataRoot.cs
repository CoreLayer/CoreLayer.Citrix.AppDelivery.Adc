using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Login
{
    /// <summary>
    /// TODO NitroLoginRequestDataRoot
    /// </summary>
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
        public NitroLoginRequestData Login { get; set; }
    }
}
