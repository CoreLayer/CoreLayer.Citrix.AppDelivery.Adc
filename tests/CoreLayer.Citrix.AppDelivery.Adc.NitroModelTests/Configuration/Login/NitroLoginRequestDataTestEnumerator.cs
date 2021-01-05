using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Login;
using System.Collections;
using System.Collections.Generic;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.Login
{
    public class NitroLoginRequestDataTestEnumerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NitroLoginRequestData("nsroot", "nsroot", 300),
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"username\":\"nsroot\",\"password\":\"nsroot\",\"timeout\":300}"},
                    {"ToString", "{\"username\":\"nsroot\",\"password\":\"nsroot\",\"timeout\":\"300\"}"}
                }
            };
            yield return new object[]
            {
                new NitroLoginRequestData("nsroot", "nsroot"),
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"username\":\"nsroot\",\"password\":\"nsroot\",\"timeout\":600}"},
                    {"ToString", "{\"username\":\"nsroot\",\"password\":\"nsroot\",\"timeout\":\"600\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}