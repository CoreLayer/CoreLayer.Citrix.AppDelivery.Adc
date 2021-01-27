using CoreLayer.Citrix.AppDelivery.Adc.NitroApi;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using FluentValidation.Results;
using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands
{
    public abstract class NitroCommand<T> : INitroCommand<T>
    {
        public INitroClient NitroClient { get; }
        public INitroRequest NitroRequest { get; }

        
        protected NitroCommand() { }

        protected NitroCommand(INitroClient nitroClient, INitroRequest nitroRequest)
        {
            NitroClient = nitroClient;
            NitroRequest = nitroRequest;
        }


        public async Task<ValidationResult> ValidateAsync(CancellationToken cancellationToken)
        {
            var validationResult = await NitroRequest.ValidateAsync().ConfigureAwait(false);

            if (!validationResult.IsValid)
#pragma warning disable CA2208 // Instantiate argument exceptions correctly
                throw new ArgumentOutOfRangeException(
                    // ReSharper disable once NotResolvedInText
                    "NitroRequest",
                    JsonSerializer.Serialize(validationResult.Errors)
                );
#pragma warning restore CA2208 // Instantiate argument exceptions correctly

            return validationResult;
        }

        public async Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {

            var task = NitroClient.SendAsync(
                await NitroRequest.GenerateHttpRequestMessageAsync().ConfigureAwait(false),
                cancellationToken);
            return await task.ConfigureAwait(false);
        }

        public async Task<HttpResponseMessage> ExecuteAsync(bool validateCommand, CancellationToken cancellationToken)
        {

            if (validateCommand)
                await ValidateAsync(cancellationToken).ConfigureAwait(false);

            return await ExecuteAsync(cancellationToken).ConfigureAwait(false);
        }
        
        /// <summary>
        /// TODO GetResponse
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">The request is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The number of characters is larger than MaxValue.</exception>
        /// <exception cref="InvalidOperationException">The request message was already sent by the HttpClient instance.</exception>
        /// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout</exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        public async Task<T> GetResponse()
        {
            var cancellationToken = new CancellationToken();
            var task = ExecuteAsync(cancellationToken);
            var result = await task.ConfigureAwait(false);

            await using var contentStream = await result.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
            var reader = new StreamReader(contentStream);

            var resultString = await reader.ReadToEndAsync().ConfigureAwait(false);

            var response = NitroResponseDeserializer.DeserializeIntoObject<T>("{ \"errorcode\": 0 }");

            if (resultString != string.Empty)
            {
                response = NitroResponseDeserializer.DeserializeIntoObject<T>(resultString);
            }
            return (T)response;
        }
    }
}
