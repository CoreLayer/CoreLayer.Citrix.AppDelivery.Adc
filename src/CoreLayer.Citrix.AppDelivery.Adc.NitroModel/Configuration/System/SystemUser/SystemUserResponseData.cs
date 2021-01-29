using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemUser
{
    public class SystemUserResponseData
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("externalauth")]
        public string ExternalAuthenticationStatus { get; set; }

        [JsonPropertyName("promptstring")]
        public string CommandLinePrompt { get; set; }

        [JsonPropertyName("timeout")]
        public double Timeout { get; set; }

        [JsonPropertyName("logging")]
        public string LoggingPrivilege { get; set; }

        [JsonPropertyName("maxsession")]
        public double MaximumUserSessions { get; set; }

        [JsonPropertyName("allowedmanagementinterface")]
        public string[] AllowedManagementInterface { get; set; }

        [JsonPropertyName("encrypted")]
        public bool? Encrypted { get; set; }

        [JsonPropertyName("hashmethod")]
        public string HashMethod { get; set; }

        [JsonPropertyName("promptinheritedfrom")]
        public string PromptInheritanceFrom { get; set; }

        [JsonPropertyName("timeoutkind")]
        public string TimeoutKind { get; set; }

        [JsonPropertyName("allowedmanagementinterfacekind")]
        public string AllowedManagementInterfaceKind { get; set; }
    }
}
