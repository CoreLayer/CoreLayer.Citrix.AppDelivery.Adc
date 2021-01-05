using CoreLayer.Citrix.AppDelivery.Adc.NitroCommon;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns.NsLicense;
using Xunit;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.Ns
{
    public class NsLicenseResponseDataTest
    {
        [Theory]
        [ClassData(typeof(NsLicenseResponseDataTestEnumerator))]
        public void ModelTest(NsLicenseResponseData nsLicenseResponseData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(nsLicenseResponseData, typeof(NsLicenseResponseData), NitroSerializerOptions.JsonSerializerOptions));
        }
    }
}
