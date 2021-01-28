using CoreLayer.Citrix.AppDelivery.Adc.NitroCommon;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemFile;
using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.System
{
    public class SystemFileResponseDataTest
    {
        [Theory]
        [ClassData(typeof(SystemFileResponseDataTestEnumerator))]
        public void ModelTest(SystemFileResponseData systemFileResponseData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(systemFileResponseData, typeof(SystemFileResponseData), NitroSerializerOptions.JsonSerializerOptions));
        }
    }
}
