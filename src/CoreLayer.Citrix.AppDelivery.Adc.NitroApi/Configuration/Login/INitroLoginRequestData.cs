using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Login
{
    public interface INitroLoginRequestData : INitroRequestData
    {
        string Username { get; }
        string Password { get; }
        int Timeout { get; }
    }
}
