using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    public abstract class NitroResponse : INitroResponse
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public string Severity { get; set; }
        public string StatusCode { get; set; }
    }
}
