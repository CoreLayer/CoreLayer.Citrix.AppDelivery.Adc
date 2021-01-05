using CoreLayer.Citrix.AppDelivery.Adc.NitroCommon;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns.NsVersion;
using Xunit;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.Ns
{
    public class NsVersionResponseDataTest
    {
        [Theory]
        [ClassData(typeof(NsVersionResponseDataTestEnumerator))]
        public void ModelTest(NsVersionResponseData nsVersionResponseData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(nsVersionResponseData, typeof(NsVersionResponseData), NitroSerializerOptions.JsonSerializerOptions));
            Assert.Equal(expected["Release"], nsVersionResponseData.Release);
            Assert.Equal(expected["Build"], nsVersionResponseData.Build);
            Assert.Equal(expected["ReleaseDate"], nsVersionResponseData.ReleaseDate);
        }
    }
}
