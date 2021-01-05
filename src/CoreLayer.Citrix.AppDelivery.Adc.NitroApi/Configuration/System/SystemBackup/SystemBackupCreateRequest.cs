using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System;
using System.Net.Http;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    /// <summary>
    /// TODO SystemBackupCreateRequest
    /// </summary>
    public class SystemBackupCreateRequest : NitroRequest
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/systembackup";
        public override INitroRequestOptions Options { get; set; } = new SystemBackupCreateRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; } = new SystemBackupCreateRequestDataRoot();




        /// <summary>
        /// TODO SystemBackupCreateRequest constructor
        /// </summary>
        public SystemBackupCreateRequest() { }




        /// <summary>
        /// TODO SystemBackupCreateRequest constructor
        /// </summary>
        /// <param name="systemBackupCreateRequestData"></param>
        public SystemBackupCreateRequest(SystemBackupCreateRequestData systemBackupCreateRequestData)
        {
            DataRoot = new SystemBackupCreateRequestDataRoot(systemBackupCreateRequestData);
        }




        /// <summary>
        /// TODO SystemBackupCreateRequest constructor
        /// </summary>
        /// <param name="systemBackupCreateRequestDataRoot"></param>
        public SystemBackupCreateRequest(INitroRequestDataRoot systemBackupCreateRequestDataRoot)
        {
            DataRoot = systemBackupCreateRequestDataRoot;
        }
    }
}
