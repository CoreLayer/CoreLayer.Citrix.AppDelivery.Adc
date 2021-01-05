using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Login;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommon;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Logout;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Login;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroClient
{
    /// <summary>
    /// TODO NitroClient
    /// </summary>
    public class NitroClient : INitroClient
    {
        private const string NitroTokenCookie = "NITRO_AUTH_TOKEN=";
        private readonly HttpClient _httpClient;
        private readonly NitroClientSettings _nitroSettings;



        /// <summary>
        /// TODO NitroClient
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="httpClient"></param>
        public NitroClient(NitroClientSettings settings, HttpClient httpClient)
        {
            _nitroSettings = settings;
            _httpClient = httpClient;

            ConfigureHttpClient();
        }



        /// <summary>
        /// TODO NitroClient
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="nitroClientFactoryCertificateValidationOption"></param>
        public NitroClient(NitroClientSettings settings) : this(settings, NitroClientFactory.Generate(settings.ValidateCertificate)) { }



        /// <summary>
        /// TODO ConfigureHttpClient
        /// </summary>
        private void ConfigureHttpClient()
        {
            _httpClient.BaseAddress = _nitroSettings.BaseAddress;
            _httpClient.Timeout = TimeSpan.FromSeconds(_nitroSettings.Timeout);

            var task = ConfigureAutomaticLogin();
            task.Wait();
        }



        /// <summary>
        /// TODO ConfigureAutomaticLogin
        /// </summary>
        /// <returns></returns>
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



        /// <summary>
        /// TODO ConfigureAuthenticationHeaders
        /// </summary>
        private void ConfigureAuthenticationHeaders()
        {
            _httpClient.DefaultRequestHeaders.Add("X-NITRO-USER", _nitroSettings.Username);
            _httpClient.DefaultRequestHeaders.Add("X-NITRO-PASS", _nitroSettings.Password);
        }



        /// <summary>
        /// TODO ConfigureAuthenticationCookieHeader
        /// </summary>
        /// <param name="token"></param>
        private void ConfigureAuthenticationCookieHeader(string token)
        {
            _httpClient.DefaultRequestHeaders.Add("Cookie", NitroTokenCookie + token);
        }



        /// <summary>
        /// TODO IsLoggedIn
        /// </summary>
        /// <returns></returns>
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



        /// <summary>
        /// TODO Login
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task Login(CancellationToken cancellationToken)
        {
            var loginRequestData = new NitroLoginRequestData(_nitroSettings.Username, _nitroSettings.Password, _nitroSettings.Timeout);
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



        /// <summary>
        /// TODO Logout
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task Logout(CancellationToken cancellationToken)
        {
            if (!IsLoggedIn())
                return;

            var logoutRequestConfiguration = new NitroLogoutRequest();
            var response = await _httpClient.SendAsync(
                await logoutRequestConfiguration.GenerateHttpRequestMessageAsync().ConfigureAwait(false),
                cancellationToken).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException("Could not log off.\n" + response);
        }

        /// <summary>
        /// TODO SendAsync
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
