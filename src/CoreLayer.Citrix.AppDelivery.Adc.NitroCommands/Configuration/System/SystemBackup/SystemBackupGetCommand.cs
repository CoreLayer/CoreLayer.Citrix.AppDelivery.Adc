using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemBackup
{
    /// <summary>
    /// TODO SystemBackupGetCommand
    /// TODO SystemBackupGetCommand Tests
    /// </summary>
    public class SystemBackupGetCommand : NitroCommand<SystemBackupGetResponse>
    {
        /// <summary>
        /// TODO SystemBackupGetCommand constructor
        /// </summary>
        /// <param name="nitroClient"></param>
        /// <param name="nitroRequest"></param>
        public SystemBackupGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
