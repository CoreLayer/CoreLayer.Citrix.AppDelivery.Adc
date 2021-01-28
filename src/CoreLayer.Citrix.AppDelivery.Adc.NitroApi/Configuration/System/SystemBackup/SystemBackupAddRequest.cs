using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    public class SystemBackupAddRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/systembackup";
        public override INitroRequestOptions Options => new SystemBackupAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }


        public SystemBackupAddRequest(SystemBackupAddRequestData systemBackupAddRequestData)
        {
            DataRoot = new SystemBackupAddRequestDataRoot(systemBackupAddRequestData);
        }
    }
}
