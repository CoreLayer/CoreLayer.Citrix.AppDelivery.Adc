using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    public class SystemBackupCreateRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Post;
        public sealed override string ResourcePath => "/nitro/v1/config/systembackup";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemBackupCreateRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot { get; } = new SystemBackupCreateRequestDataRoot();


        public SystemBackupCreateRequest() { }

        public SystemBackupCreateRequest(SystemBackupCreateRequestData systemBackupCreateRequestData)
        {
            DataRoot = new SystemBackupCreateRequestDataRoot(systemBackupCreateRequestData);
        }
    }
}
