using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    /// <summary>
    /// TODO SystemBackupAddRequest
    /// </summary>
    public class SystemBackupAddRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/systembackup";
        public override INitroRequestOptions Options => new SystemBackupAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        /// <summary>
        /// TODO SystemBackupAddRequest constructor
        /// </summary>
        /// <param name="dataRoot"></param>
        public SystemBackupAddRequest(SystemBackupAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
