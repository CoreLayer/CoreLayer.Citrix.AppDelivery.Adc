using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUser;
using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemUser;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemUser;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemUserSystemCmdPolicyBinding;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroOperations.SystemUser
{
    public class SystemUserOperations
    {

        public static async Task<SystemUserAddResponse> AddAsync(INitroClient nitroClient,
            SystemUserAddOperationData userAddOperationData)
        {
            var systemUserAddCommand =
                NitroCommandFactory.Create<SystemUserAddCommand>(
                    nitroClient,
                    new SystemUserAddRequestData
                    {
                        Username = userAddOperationData.Username,
                        Password = userAddOperationData.Password,
                        ExternalAuthenticationStatus = userAddOperationData.ExternalAuthenticationStatus.ToString(),
                        LoggingPrivilege = userAddOperationData.LoggingPrivilege.ToString(),
                        CommandLinePrompt = userAddOperationData.CommandLinePrompt,
                        Timeout = userAddOperationData.Timeout,
                        MaximumUserSessions = userAddOperationData.MaximumUserSessions,
                        AllowedManagementInterface = userAddOperationData.AllowedManagementInterface
                    }
                );
            return await systemUserAddCommand.GetResponse();
        }

        public static async Task<SystemUserDeleteResponse> DeleteAsync(INitroClient nitroClient,
            string username)
        {
            var systemUserDeleteCommand =
                NitroCommandFactory.Create<SystemUserDeleteCommand>(
                    nitroClient,
                    username
                );
            return await systemUserDeleteCommand.GetResponse();
        }

        public static async Task<SystemUserGetResponse> GetAsync(INitroClient nitroClient, string username)
        {
            var systemUserGetCommand = NitroCommandFactory.Create<SystemUserGetCommand>(
                nitroClient,
                new SystemUserGetRequestOptions(username)
                );
            return await systemUserGetCommand.GetResponse();
        }

        public static async Task<SystemUserGetResponse> GetAllAsync(INitroClient nitroClient)
        {
            var systemUserGetCommand = NitroCommandFactory.Create<SystemUserGetCommand>(nitroClient);
            return await systemUserGetCommand.GetResponse();
        }

        public static async Task<SystemUserSystemCmdPolicyBindingAddResponse> BindSystemCmdPolicyAsync(
            INitroClient nitroClient, string username, string policyName, double priority)
        {
            var systemUserSystemCmdPolicyBindingAddCommand =
                NitroCommandFactory.Create<SystemUserSystemCmdPolicyBindingAddCommand>(
                    nitroClient,
                    new SystemUserSystemCmdPolicyBindingAddRequestData(username, policyName, priority)
                );
            return await systemUserSystemCmdPolicyBindingAddCommand.GetResponse();
        }

        public static async Task<SystemUserSystemCmdPolicyBindingDeleteResponse> UnbindSystemCmdPolicyAsync(
            INitroClient nitroClient, string username, string policyName)
        {
            var systemUserSystemCmdPolicyBindingDeleteCommand =
                NitroCommandFactory.Create<SystemUserSystemCmdPolicyBindingDeleteCommand>(
                    nitroClient,
                    new SystemUserSystemCmdPolicyBindingDeleteRequestOptions(username, policyName)
                );
            return await systemUserSystemCmdPolicyBindingDeleteCommand.GetResponse();
        }
    }
}
