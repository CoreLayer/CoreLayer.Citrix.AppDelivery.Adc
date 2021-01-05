using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System.Net.Http;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    /// <summary>
    /// TODO SystemBackupGetRequest
    /// TODO SystemBackupGetRequest Tests
    /// </summary>
    public class SystemBackupGetRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/systembackup";
        public override INitroRequestOptions Options { get; set; } = new SystemBackupGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new SystemBackupGetRequestDataRoot();



        /// <summary>
        /// TODO SystemBackupGetRequest constructor
        /// </summary>
        public SystemBackupGetRequest() { }
    }
}
