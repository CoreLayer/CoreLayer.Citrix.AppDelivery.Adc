using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemCmdPolicy;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyUpdateCommand : NitroCommand<SystemCmdPolicyUpdateResponse>
    {
        public SystemCmdPolicyUpdateCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
