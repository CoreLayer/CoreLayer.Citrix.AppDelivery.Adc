using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Ns.NsVersion;
using System.Collections;
using System.Collections.Generic;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.Ns
{
    public class NsVersionResponseDataTestEnumerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsVersionResponseData()
                {
                    InstalledVersion = false,
                    Version = "NetScaler NS13.0: Build 64.35.nc, Date: Sep  1 2020, 06:54:54   (64-bit)",
                    Mode = "1"
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"installedversion\":false,\"version\":\"NetScaler NS13.0: Build 64.35.nc, Date: Sep  1 2020, 06:54:54   (64-bit)\",\"mode\":\"1\"}"},
                    {"Release", "13.0"},
                    {"Build", "64.35.nc"},
                    {"ReleaseDate", "Sep  1 2020, 06:54:54"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}