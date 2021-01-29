using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemUser;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroOperations.SystemUser
{
    public class SystemUserAddOperationData
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public SystemUserExternalAuthenticationStatus ExternalAuthenticationStatus { get; set; } =
            SystemUserExternalAuthenticationStatus.Disabled;
        
        public string CommandLinePrompt { get; set; }

        public double Timeout { get; set; } = 900;

        public SystemUserLoggingPrivilegeStatus LoggingPrivilege { get; set; } =
            SystemUserLoggingPrivilegeStatus.Disabled;

        public double MaximumUserSessions { get; set; } = 20;

        public string[] AllowedManagementInterface { get; set; } =
        {
            SystemUserAllowedManagementInterface.Api.ToString(),
            SystemUserAllowedManagementInterface.Api.ToString()
        };
    }
}