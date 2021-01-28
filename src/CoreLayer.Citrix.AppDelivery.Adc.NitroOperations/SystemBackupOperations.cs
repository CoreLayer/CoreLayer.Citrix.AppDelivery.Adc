﻿using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemFile;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemFile;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroOperations
{
    public class SystemBackupOperations
    {
        public static async Task<SystemBackupGetResponse> GetAsync(INitroClient nitroClient, string fileName)
        {
            var systemBackupGetCommand = NitroCommandFactory.Create<SystemBackupGetCommand>(nitroClient, new SystemBackupGetRequestOptions(fileName));
            return await systemBackupGetCommand.GetResponse();
        }

        public static async Task<SystemBackupGetResponse> GetAllAsync(INitroClient nitroClient)
        {
            var systemBackupGetCommand = NitroCommandFactory.Create<SystemBackupGetCommand>(nitroClient);
            return await systemBackupGetCommand.GetResponse();
        }

        public static async Task<SystemBackupCreateResponse> CreateAsync(INitroClient nitroClient, SystemBackupLevel level, string fileName)
        {
            var systemBackupCreateCommand = NitroCommandFactory.Create<SystemBackupCreateCommand>(nitroClient, new SystemBackupCreateRequestData(level, fileName));
            return await systemBackupCreateCommand.GetResponse();
        }

        public static async Task<SystemBackupDeleteResponse> DeleteAsync(INitroClient nitroClient, string fileName)
        {
            var systemBackupDeleteCommand = NitroCommandFactory.Create<SystemBackupDeleteCommand>(
                nitroClient,
                new SystemBackupDeleteRequestOptions(fileName)
            );

            return await systemBackupDeleteCommand.GetResponse();
        }

        public static async Task<SystemFileResponseData> DownloadAsBase64Async(INitroClient nitroClient, string fileName)
        {
            var systemFileGetCommand = NitroCommandFactory.Create<SystemFileGetCommand>(nitroClient, new SystemFileGetRequestOptions("/var/ns_sys_backup", fileName));
            var response = await systemFileGetCommand.GetResponse();

            return response.SystemFiles.Single(file => file.FileName.Equals(fileName));
        }
    }
}
