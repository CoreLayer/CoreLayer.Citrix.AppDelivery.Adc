using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    public class SystemBackupDeleteRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Delete;
        public sealed override string ResourcePath => "/nitro/v1/config/systembackup";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemBackupDeleteRequestOptions(null);
        public sealed override INitroRequestDataRoot DataRoot => new SystemBackupDeleteRequestDataRoot();


        public SystemBackupDeleteRequest() { }

        public SystemBackupDeleteRequest(string resourceName)
        {
            Options = new SystemBackupDeleteRequestOptions(resourceName);
        }
    }
}
