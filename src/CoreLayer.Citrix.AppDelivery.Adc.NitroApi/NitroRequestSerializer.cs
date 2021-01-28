using CoreLayer.Citrix.AppDelivery.Adc.NitroCommon;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    public static class NitroRequestSerializer
    {
        private static async Task SerializeRequestData(Stream dataStream, INitroRequestDataRoot requestDataRoot)
        {
            await JsonSerializer.SerializeAsync(
                dataStream,
                requestDataRoot,
                requestDataRoot.GetType(),
                NitroSerializerOptions.JsonSerializerOptions,
                CancellationToken.None).ConfigureAwait(false);

            dataStream.Seek(0, SeekOrigin.Begin);
        }

        private static StreamContent StreamContent(Stream dataStream) =>
            new StreamContent(new StreamReader(dataStream).BaseStream);

        public static async Task<HttpRequestMessage> GetHttpRequestMessageAsync(INitroRequest request)
        {
            var dataStream = new MemoryStream();
            await SerializeRequestData(dataStream, request.DataRoot).ConfigureAwait(false);

            var httpRequestMessage = new HttpRequestMessage(
                request.Method,
                request.ResourcePath + request.Options.ToString())
            {
                Content = StreamContent(dataStream)
            };
            httpRequestMessage.Content.Headers.ContentType = request.ContentType;

            return httpRequestMessage;
        }
    }
}
