using System.Net;
using System.Net.Http;
using System.Security.Authentication;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroClient
{
    /// <summary>
    /// TODO NitroClientFactory
    /// </summary>
    public static class NitroClientFactory
    {
        /// <summary>
        /// TODO Generate
        /// </summary>
        /// <param name="certificateValidation"></param>
        /// <returns></returns>
        public static HttpClient Generate(NitroClientFactoryCertificateValidationOption certificateValidation)
        {
            var httpClient = certificateValidation == NitroClientFactoryCertificateValidationOption.Enabled
                ? new HttpClient(GetSecureHttpMessageHandler())
                : new HttpClient(GetInSecureHttpMessageHandler());

            return httpClient;
        }




        /// <summary>
        /// TODO GetInSecureHttpMessageHandler
        /// </summary>
        /// <returns></returns>
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




        /// <summary>
        /// TODO GetSecureHttpMessageHandler
        /// </summary>
        /// <returns></returns>
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
