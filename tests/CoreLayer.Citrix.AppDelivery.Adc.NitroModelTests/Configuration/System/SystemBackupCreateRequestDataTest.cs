using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommon;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;
using Xunit;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.System
{
    public class SystemBackupCreateRequestDataTest
    {
        [Theory]
        [ClassData(typeof(SystemBackupCreateRequestDataTestEnumerator))]
        public void ModelTest(SystemBackupCreateRequestData systemBackupCreateRequestData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(systemBackupCreateRequestData, typeof(SystemBackupCreateRequestData), NitroSerializerOptions.JsonSerializerOptions));
            Assert.Equal(expected["Level"], systemBackupCreateRequestData.Level);
            Assert.Equal(expected["Filename"], systemBackupCreateRequestData.Filename);
            Assert.Equal(expected["Comment"], systemBackupCreateRequestData.Comment);
        }
    }
}
