using CoreLayer.Citrix.AppDelivery.Adc.NitroCommon;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;
using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.System
{
    public class SystemBackupResponseDataTest
    {
        [Theory]
        [ClassData(typeof(SystemBackupResponseDataTestEnumerator))]
        public void ModelTest(SystemBackupResponseData systemBackupResponseData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(systemBackupResponseData, typeof(SystemBackupResponseData), NitroSerializerOptions.JsonSerializerOptions));
        }
    }
}
