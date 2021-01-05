using System.Text.Json.Serialization;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    /// <summary>
    /// TODO SystemBackupGetResponse
    /// </summary>
    public class SystemBackupGetResponse : NitroResponse
    {
        [JsonPropertyName("systembackup")]
        public SystemBackupResponseData[] SystemBackups { get; set; }
    }
}