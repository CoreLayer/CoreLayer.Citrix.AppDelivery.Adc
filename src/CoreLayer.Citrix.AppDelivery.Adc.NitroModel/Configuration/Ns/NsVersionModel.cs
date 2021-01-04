using System;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns
{
    /// <summary>
    /// TODO NsVersionModel
    /// </summary>
    public class NsVersionModel
    {
        [JsonPropertyName("installedversion")]
        public bool InstalledVersion { get; set; }
        
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        public string Release => 
            Version.Substring(
                Version.IndexOf("NS", StringComparison.CurrentCulture) +2 ,
                4
                );

        public string Build => 
            Version.Substring(
                Version.IndexOf("Build ", StringComparison.CurrentCulture) + 6, 
                Version.IndexOf(',') - Version.IndexOf("Build ", StringComparison.CurrentCulture) - 6);

        public string ReleaseDate => 
            Version.Substring(
                Version.IndexOf("Date", StringComparison.CurrentCulture) + 6,
                Version.LastIndexOf(':') + 2 - Version.IndexOf("Date", StringComparison.CurrentCulture) - 5);
    }
}
