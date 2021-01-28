using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup
{
    public class SystemBackupResponseData
    {
        [JsonPropertyName("filename")]
        public string FileName { get; set; }
        [JsonPropertyName("level")]
        public string Level { get; set; }
        [JsonPropertyName("includekernel")]
        public string IncludeKernel { get; set; }
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
        [JsonPropertyName("size")]
        public double Size { get; set; }
        [JsonPropertyName("uselocaltimezone")]
        public bool UseLocalTimeZone { get; set; }
        [JsonPropertyName("creationtime")]
        public string CreationTime { get; set; }
        [JsonPropertyName("version")]
        public string Version { get; set; }
        [JsonPropertyName("createdby")]
        public string CreatedBy { get; set; }
        [JsonPropertyName("ipaddress")]
        public string IpAddress { get; set; }
    }
}
