using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemFile
{
    /// <summary>
    /// TODO SystemFileResponseData
    /// </summary>
    public class SystemFileResponseData
    {
        [JsonPropertyName("filename")]
        public string FileName { get; set; }
        [JsonPropertyName("filelocation")]
        public string FileLocation { get; set; }
        [JsonPropertyName("filecontent")]
        public string FileContent { get; set; }
        [JsonPropertyName("fileencoding")]
        public string FileEncoding { get; set; }
        [JsonPropertyName("fileaccesstime")]
        public string FileAccessTime { get; set; }
        [JsonPropertyName("filemodifiedtime")]
        public string FileModifiedTime { get; set; }
        [JsonPropertyName("filemode")]
        public string[] FileMode { get; set; }
        [JsonPropertyName("filesize")]
        public string FileSize { get; set; }
    }
}
