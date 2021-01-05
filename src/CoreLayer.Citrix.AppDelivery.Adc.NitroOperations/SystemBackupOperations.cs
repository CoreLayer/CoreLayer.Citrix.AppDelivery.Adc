using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemFile;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemFile;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroOperations
{
    /// <summary>
    /// TODO SystemBackupOperations
    /// </summary>
    public class SystemBackupOperations
    {
        /// <summary>
        /// TODO GetAsync
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static async Task<SystemBackupGetResponse> GetAsync(INitroClient nitroClient, string fileName)
        {
            var systemBackupGetCommand = NitroCommandFactory.Create<SystemBackupGetCommand>(nitroClient,
                new SystemBackupGetRequestOptions
                {
                    ResourceName = fileName
                });

            return await systemBackupGetCommand.GetResponse();
        }




        /// <summary>
        /// TODO GetAllAsync
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <returns></returns>
        public static async Task<SystemBackupGetResponse> GetAllAsync(INitroClient nitroClient)
        {
            var systemBackupGetCommand = NitroCommandFactory.Create<SystemBackupGetCommand>(nitroClient);

            return await systemBackupGetCommand.GetResponse();
        }




        /// <summary>
        /// TODO CreateAsync
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <param name="fileName"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public static async Task<SystemBackupCreateResponse> CreateAsync(INitroClient nitroClient, string fileName, string level = "full")
        {
            var systemBackupCreateCommand = NitroCommandFactory.Create<SystemBackupCreateCommand>(
                nitroClient,
                new SystemBackupCreateRequestData(level)
                {
                    Filename = fileName.Replace(".tgz", "")
                });

            return await systemBackupCreateCommand.GetResponse();
        }




        /// <summary>
        /// TODO DeleteAsync
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static async Task<SystemBackupDeleteResponse> DeleteAsync(INitroClient nitroClient, string fileName)
        {
            var systemBackupDeleteCommand = NitroCommandFactory.Create<SystemBackupDeleteCommand>(
                nitroClient,
                new SystemBackupDeleteRequestOptions(fileName)
            );

            return await systemBackupDeleteCommand.GetResponse();
        }




        /// <summary>
        /// TODO DownloadAsBase64Async
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static async Task<SystemFileResponseData> DownloadAsBase64Async(INitroClient nitroClient, string fileName)
        {
            var systemFileGetCommand = NitroCommandFactory.Create<SystemFileGetCommand>(
                nitroClient,
                new SystemFileGetRequestOptions
                {
                    Arguments = new Dictionary<string, string>
                    {
                        {"FileLocation", "/var/ns_sys_backup"},
                        {"FileName", fileName}
                    }
                });

            var response = await systemFileGetCommand.GetResponse();

            return response.SystemFiles.Single(file => file.FileName.Equals(fileName));
        }
    }
}
