using CoreLayer.Citrix.AppDelivery.Adc.NitroCommon;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;
using System.Collections.Generic;
using System.Text.Json;
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
