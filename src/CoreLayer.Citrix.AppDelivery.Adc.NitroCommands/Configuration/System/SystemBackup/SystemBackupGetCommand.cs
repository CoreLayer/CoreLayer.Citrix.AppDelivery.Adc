﻿using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemBackup
{
    public class SystemBackupGetCommand : NitroCommand<SystemBackupGetResponse>
    {
        public SystemBackupGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
