using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CoreLayer.Citrix.AppDelivery.Adc.NitroApi;
using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Login;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroClient
{
    public class NitroClient : INitroClient
    {
        private const string NitroTokenCookie = "NITRO_AUTH_TOKEN=";
        private readonly HttpClient _httpClient;
        private readonly NitroClientSettings _nitroSettings;

        public NitroClient(NitroClientSettings settings, HttpClient httpClient)
        {
            _nitroSettings = settings;
            _httpClient = httpClient;

            ConfigureHttpClient();
        }

        public NitroClient(NitroClientSettings settings, NitroClientFactoryCertificateValidationOption nitroClientFactoryCertificateValidationOption)
            : this(settings, NitroClientFactory.Generate(nitroClientFactoryCertificateValidationOption)) { }

        private void ConfigureHttpClient()
        {
            _httpClient.BaseAddress = _nitroSettings.BaseAddress;
            _httpClient.Timeout = TimeSpan.FromSeconds(_nitroSettings.Timeout);

            var task = ConfigureAutomaticLogin();
            task.Wait();
        }

        private async Task ConfigureAutomaticLogin()
        {
            switch (_nitroSettings.AuthenticationMethod)
            {
                case NitroClientAuthenticationMethod.HeaderInjection:
                    ConfigureAuthenticationHeaders();
                    break;
                case NitroClientAuthenticationMethod.Automatic:
                    await Login(new CancellationToken());
                    break;
                case NitroClientAuthenticationMethod.Manual:
                    break;
                default:
                    break;
            }
        }

        private void ConfigureAuthenticationHeaders()
        {
            _httpClient.DefaultRequestHeaders.Add("X-NITRO-USER", _nitroSettings.Username);
            _httpClient.DefaultRequestHeaders.Add("X-NITRO-PASS", _nitroSettings.Password);
        }

        private void ConfigureAuthenticationCookieHeader(string token)
        {
            _httpClient.DefaultRequestHeaders.Add("Cookie", NitroTokenCookie + token);
        }

        private bool IsLoggedIn()
        {
            while (true)
            {
                // Headers are automatically injected into the HttpClient for each request
                if (_nitroSettings.AuthenticationMethod == NitroClientAuthenticationMethod.HeaderInjection)
                    return true;

                // Login has been executed (either manually or automatically)
                // Cookie header is automatically injected into the HttpClient
                if (_httpClient.DefaultRequestHeaders.ToString().Contains("NITRO_AUTH_TOKEN"))
                    return true;

                // Login has not been executed
                // Cookie header is not yet injected into the HttpClient
                if (_nitroSettings.AuthenticationMethod == NitroClientAuthenticationMethod.Manual)
                    return false;
            }
        }

        public async Task Login(CancellationToken cancellationToken)
        {
            var loginRequestData = new NitroLoginRequestData(_nitroSettings.Username, _nitroSettings.Password);
            var loginRequestConfiguration = new NitroLoginRequest(new NitroLoginRequestDataRoot(loginRequestData));

            var response = await _httpClient.SendAsync(
                await loginRequestConfiguration.GenerateHttpRequestMessageAsync().ConfigureAwait(false),
                cancellationToken).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException("Could not log on.\n" + response);

            await using var contentStream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
            var content =
                await JsonSerializer.DeserializeAsync<NitroLoginResponse>(
                    contentStream,
                    NitroSerializerOptions.JsonSerializerOptions,
                    cancellationToken
                ).ConfigureAwait(false);

            ConfigureAuthenticationCookieHeader(content.SessionId);
        }

        public async Task Logout(CancellationToken cancellationToken)
        {
            if (!IsLoggedIn())
                return;

            var logoutRequestConfiguration = new NitroLoginRequest();
            var response = await _httpClient.SendAsync(
                await logoutRequestConfiguration.GenerateHttpRequestMessageAsync().ConfigureAwait(false),
                cancellationToken).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException("Could not log off.\n" + response);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">The request is null.</exception>
        /// <exception cref="InvalidOperationException">The request message was already sent by the HttpClient instance.</exception>
        /// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout</exception>
        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var task = _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);

            return await task.ConfigureAwait(false);
        }
    }
}
