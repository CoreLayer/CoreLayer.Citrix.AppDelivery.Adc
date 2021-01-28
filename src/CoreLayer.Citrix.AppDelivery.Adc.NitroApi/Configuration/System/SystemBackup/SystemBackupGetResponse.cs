using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    public class SystemBackupGetResponse : NitroResponse
    {
        [JsonPropertyName("systembackup")]
        public SystemBackupResponseData[] SystemBackups { get; set; }
    }
}