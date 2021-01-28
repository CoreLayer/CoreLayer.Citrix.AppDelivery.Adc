using System;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroClient
{
    public class NitroClientSettings {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Hostname { get; set; }
        public bool UseSsl { get; set; } = true;
        public NitroClientFactoryCertificateValidationOption ValidateCertificate { get; set; } = NitroClientFactoryCertificateValidationOption.Enabled;
        public NitroClientAuthenticationMethod AuthenticationMethod { get; set; }
        public int Timeout { get; set; } = 300;
        public Uri BaseAddress => UseSsl ? new Uri("https://" + Hostname) : new Uri("http://" + Hostname);
    }
}
