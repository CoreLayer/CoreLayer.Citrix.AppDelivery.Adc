using System.Net;
using System.Net.Http;
using System.Security.Authentication;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroClient
{
    public static class NitroClientFactory
    {
        public static HttpClient Generate(NitroClientFactoryCertificateValidationOption certificateValidation)
        {
            var httpClient = certificateValidation == NitroClientFactoryCertificateValidationOption.Enabled
                ? new HttpClient(GetSecureHttpMessageHandler())
                : new HttpClient(GetInSecureHttpMessageHandler());

            return httpClient;
        }

        private static HttpClientHandler GetInSecureHttpMessageHandler()
        {
            return new HttpClientHandler
            {
                UseCookies = false,
                SslProtocols = SslProtocols.Tls12,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                ServerCertificateCustomValidationCallback = (req, cert, chain, errors) => true
            };
        }

        private static HttpClientHandler GetSecureHttpMessageHandler()
        {
            return new HttpClientHandler
            {
                UseCookies = false,
                SslProtocols = SslProtocols.Tls12,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            };
        }
    }
}
