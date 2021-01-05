using System.Text.Json.Serialization;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemFile;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    /// <summary>
    /// TODO SystemFileGetResponse
    /// </summary>
    public class SystemFileGetResponse : NitroResponse
    {
        [JsonPropertyName("systemfile")]
        public SystemFileResponseData[] SystemFiles { get; set; }
    }
}