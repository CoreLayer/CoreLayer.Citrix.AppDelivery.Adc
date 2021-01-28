using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Login;
using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Logout;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommon;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Login;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroClient
{
    public class NitroClient : INitroClient
    {
        private const string NitroTokenCookie = "NITRO_AUTH_TOKEN=";
        private readonly HttpClient _httpClient;
        private readonly NitroClientSettings _nitroClientSettings;

        
        public NitroClient(NitroClientSettings nitroClientSettings, HttpClient httpClient)
        {
            _nitroClientSettings = nitroClientSettings;
            _httpClient = httpClient;

            ConfigureHttpClient();
        }
        
        public NitroClient(NitroClientSettings nitroClientSettings) : 
            this(nitroClientSettings, NitroClientFactory.Generate(nitroClientSettings.ValidateCertificate)) { }
        
        private void ConfigureHttpClient()
        {
            _httpClient.BaseAddress = _nitroClientSettings.BaseAddress;
            _httpClient.Timeout = TimeSpan.FromSeconds(_nitroClientSettings.Timeout);

            var task = ConfigureAutomaticLogin();
            task.Wait();
        }
        
        private async Task ConfigureAutomaticLogin()
        {
            switch (_nitroClientSettings.AuthenticationMethod)
            {
                case NitroClientAuthenticationMethod.HeaderInjection:
                    ConfigureAuthenticationHeaders();
                    break;
                case NitroClientAuthenticationMethod.Automatic:
                    await Login(new CancellationToken());
                    break;
                case NitroClientAuthenticationMethod.Manual:
                    break;
            }
        }
        
        private void ConfigureAuthenticationHeaders()
        {
            _httpClient.DefaultRequestHeaders.Add("X-NITRO-USER", _nitroClientSettings.Username);
            _httpClient.DefaultRequestHeaders.Add("X-NITRO-PASS", _nitroClientSettings.Password);
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
                if (_nitroClientSettings.AuthenticationMethod == NitroClientAuthenticationMethod.HeaderInjection)
                    return true;

                // Login has been executed (either manually or automatically)
                // Cookie header is automatically injected into the HttpClient
                if (_httpClient.DefaultRequestHeaders.ToString().Contains("NITRO_AUTH_TOKEN"))
                    return true;

                // Login has not been executed
                // Cookie header is not yet injected into the HttpClient
                if (_nitroClientSettings.AuthenticationMethod == NitroClientAuthenticationMethod.Manual)
                    return false;
            }
        }

        public async Task Login(CancellationToken cancellationToken)
        {
            var loginRequestData = new NitroLoginRequestData(_nitroClientSettings.Username, _nitroClientSettings.Password, _nitroClientSettings.Timeout);
            var loginRequest = new NitroLoginRequest(loginRequestData);

            var response = await _httpClient.SendAsync(
                await loginRequest.GetHttpRequestMessageAsync().ConfigureAwait(false),
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

            if (content == null)
                throw new NullReferenceException("Could not extract SessionId.\n" + response);

            ConfigureAuthenticationCookieHeader(content.SessionId);
        }
        
        public async Task Logout(CancellationToken cancellationToken)
        {
            if (!IsLoggedIn())
                return;

            var logoutRequest = new NitroLogoutRequest();
            var response = await _httpClient
                .SendAsync(
                    await logoutRequest
                        .GetHttpRequestMessageAsync()
                        .ConfigureAwait(false), 
                    cancellationToken)
                .ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException("Could not log off.\n" + response);
        }




        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken)
        {
            var task = _httpClient.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseHeadersRead, cancellationToken);

            return await task.ConfigureAwait(false);
        }
    }
}
