using CoreLayer.Citrix.AppDelivery.Adc.NitroCommon;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Logout;
using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.Logout
{
    public class NitroLogoutRequestDataTest
    {
        [Theory]
        [ClassData(typeof(NitroLogoutRequestDataTestEnumerator))]
        public void ModelTest(NitroLogoutRequestData nitroLogoutRequestData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(nitroLogoutRequestData, typeof(NitroLogoutRequestData), NitroSerializerOptions.JsonSerializerOptions));
        }
    }
}
