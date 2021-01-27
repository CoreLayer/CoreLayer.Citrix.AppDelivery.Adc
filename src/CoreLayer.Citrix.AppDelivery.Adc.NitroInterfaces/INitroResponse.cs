namespace CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces
{
    public interface INitroResponse
    {
        int ErrorCode { get; set; }
        string Message { get; set; }
        string Severity { get; set; }
        string StatusCode { get; set; }
    }
}
