using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingAddCommand : NitroCommand<SystemUserSystemCmdPolicyBindingAddResponse>
    {
        public SystemUserSystemCmdPolicyBindingAddCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
