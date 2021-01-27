using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Logout;
using System.Collections;
using System.Collections.Generic;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.Logout
{
    public class NitroLogoutRequestDataTestEnumerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NitroLogoutRequestData(),
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"},
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
