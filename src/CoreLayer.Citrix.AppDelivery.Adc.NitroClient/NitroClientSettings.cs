using System;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroClient
{
    public class NitroClientSettings {
        public string Username { get; set; }
        public string Password { get; set; }
        public Uri BaseAddress { get; set; }
        public int Timeout { get; set; }
        public NitroClientAuthenticationMethod AuthenticationMethod { get; set; }
    }
}
