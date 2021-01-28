using CoreLayer.Citrix.AppDelivery.Adc.NitroCommon;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Login;
using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.Login
{
    public class NitroLoginRequestDataTest
    {
        [Theory]
        [ClassData(typeof(NitroLoginRequestDataTestEnumerator))]
        public void ModelTest(NitroLoginRequestData nitroLoginRequestData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(nitroLoginRequestData, typeof(NitroLoginRequestData), NitroSerializerOptions.JsonSerializerOptions));
            Assert.Equal(expected["ToString"], nitroLoginRequestData.ToString());
        }
    }
}
