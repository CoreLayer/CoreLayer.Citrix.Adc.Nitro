using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login;
using CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Login;
using CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Logout;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public class NitroServiceClient : INitroServiceClient
    {
        private const string NitroTokenCookie = "NITRO_AUTH_TOKEN=";
        private readonly INitroLoginRequestData _credentials;
        private readonly INitroServiceConnectionSettings _settings;
        private readonly HttpClient _httpClient;

        public NitroServiceClient(
            INitroLoginRequestData credentials,
            INitroServiceConnectionSettings settings,
            NitroHttpClientCertificateValidation certificateValidation)
        {
            _credentials = credentials;
            _settings = settings;
            _httpClient = NitroServiceHttpClientGenerator.Generate(certificateValidation);
            
            ConfigureHttpClient();
        }

        public NitroServiceClient(
            INitroLoginRequestData credentials,
            INitroServiceConnectionSettings settings,
            HttpClient httpClient)
        {
            _credentials = credentials;
            _settings = settings;
            _httpClient = httpClient;
            
            ConfigureHttpClient();
        }

        private void ConfigureHttpClient()
        {
            _httpClient.BaseAddress = _settings.BaseAddress;
            _httpClient.Timeout = TimeSpan.FromSeconds(_settings.Timeout);
            
            var task = ConfigureAutomaticLogin();
            task.Wait();
        }

        private async Task ConfigureAutomaticLogin()
        {
            switch (_settings.AuthenticationMethod)
            {
                case NitroServiceConnectionAuthenticationMethod.AutomaticHeaderInjection:
                    ConfigureAuthenticationHeaders();
                    break;
                case NitroServiceConnectionAuthenticationMethod.AutomaticLogin:
                    await Login(new CancellationToken());
                    break;
                case NitroServiceConnectionAuthenticationMethod.ManualLogin:
                    break;
                default:
                    break;
            }
        }

        private void ConfigureAuthenticationHeaders()
        {
            _httpClient.DefaultRequestHeaders.Add("X-NITRO-USER", _credentials.Username);
            _httpClient.DefaultRequestHeaders.Add("X-NITRO-PASS", _credentials.Password);
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
                if (_settings.AuthenticationMethod == NitroServiceConnectionAuthenticationMethod.AutomaticHeaderInjection)
                    return true;

                // Login has been executed (either manually or automatically)
                // Cookie header is automatically injected into the HttpClient
                if (_httpClient.DefaultRequestHeaders.ToString().Contains("NITRO_AUTH_TOKEN")) 
                    return true;

                // Login has not been executed
                // Cookie header is not yet injected into the HttpClient
                if (_settings.AuthenticationMethod == NitroServiceConnectionAuthenticationMethod.ManualLogin)
                    return false;
            }
        }

        public async Task Login(CancellationToken cancellationToken)
        {

            var loginCommand = NitroCommandFactory.Create<NitroLoginCommand>(this, _credentials);
            var response = await loginCommand.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException("Could not log on.\n" + response);

            await using var contentStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var content =
                await JsonSerializer.DeserializeAsync<NitroLoginResponse>(
                    contentStream,
                    NitroServiceSerializerOptions.JsonSerializerOptions
                ).ConfigureAwait(false);

            ConfigureAuthenticationCookieHeader(content.SessionId);
        }

        public async Task Logout(CancellationToken cancellationToken)
        {
            if (!IsLoggedIn())
                return;


            //was var logoutCommand = NitroCommand.Create<NitroLogoutCommand>(this, new NitroLogoutData);
            var logoutCommand = NitroCommandFactory.Create<NitroLogoutCommand>(this);
            var response = await logoutCommand.ExecuteAsync(cancellationToken).ConfigureAwait(false);

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
        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {

            var task = _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);

            return await task.ConfigureAwait(false);
        }
    }
}
