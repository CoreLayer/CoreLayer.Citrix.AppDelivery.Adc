using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    public class SystemBackupDeleteRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/systembackup";
        public override INitroRequestOptions Options { get; set; } = new SystemBackupDeleteRequestOptions(null);
        public override INitroRequestDataRoot DataRoot => new SystemBackupDeleteRequestDataRoot();


        public SystemBackupDeleteRequest() { }
    }
}
