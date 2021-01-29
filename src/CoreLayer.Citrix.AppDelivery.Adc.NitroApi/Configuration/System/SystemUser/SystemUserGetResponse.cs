using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemUser;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUser
{
    public class SystemUserGetResponse : NitroResponse
    {
        [JsonPropertyName("systemuser")]
        public SystemUserResponseData[] SystemUser { get; set; }
    }
}