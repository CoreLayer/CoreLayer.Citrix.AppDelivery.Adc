using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces
{
    public interface INitroClient
    {
        Task Login(CancellationToken cancellationToken);
        Task Logout(CancellationToken cancellationToken);

        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
    }
}
