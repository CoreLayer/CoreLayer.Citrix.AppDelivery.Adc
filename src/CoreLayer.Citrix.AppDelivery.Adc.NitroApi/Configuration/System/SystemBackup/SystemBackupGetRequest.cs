using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    public class SystemBackupGetRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Get;
        public sealed override string ResourcePath => "/nitro/v1/config/systembackup";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemBackupGetRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new SystemBackupGetRequestDataRoot();


        public SystemBackupGetRequest() { }

        public SystemBackupGetRequest(string resourceName)
        {
            Options = new SystemBackupGetRequestOptions(resourceName);
        }
    }
}
