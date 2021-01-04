using FluentValidation.Results;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces
{
    public interface INitroCommand<T>
    {
        INitroClient ServiceClient { get; }
        INitroRequest Data { get; }
        Task<ValidationResult> ValidateAsync(CancellationToken cancellationToken);
        Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken);
        Task<T> GetResponse();
    }
}
