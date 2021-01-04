using FluentValidation.Results;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces
{
    public interface INitroRequest
    {
        HttpMethod Method { get; }
        MediaTypeHeaderValue ContentType { get; }
        string ResourcePath { get; }
        INitroRequestOptions Options { get; set; }

        INitroRequestDataRoot DataRoot { get; }

        Task<ValidationResult> ValidateAsync();
        Task<HttpRequestMessage> GenerateHttpRequestMessageAsync();
    }
}
