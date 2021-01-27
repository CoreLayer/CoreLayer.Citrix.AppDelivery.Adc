using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;
using System.Collections;
using System.Collections.Generic;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.System
{
    public class SystemBackupCreateRequestDataTestEnumerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemBackupCreateRequestData("full"),
                new Dictionary<string, string>
                {
                    // TODO Adapt to real values
                    {"ContentString", "{\"level\":\"full\",\"filename\":\"\",\"comment\":\"\"}"},
                    {"Level", "full"},
                    {"Filename", string.Empty},
                    {"Comment", string.Empty}

                }
            };
            yield return new object[]
            {
                new SystemBackupCreateRequestData("full", "backup.tgz"),
                new Dictionary<string, string>
                {
                    // TODO Adapt to real values
                    {"ContentString", "{\"level\":\"full\",\"filename\":\"backup.tgz\",\"comment\":\"\"}"},
                    {"Level", "full"},
                    {"Filename", "backup.tgz"},
                    {"Comment", string.Empty}

                }
            };
            yield return new object[]
            {
                new SystemBackupCreateRequestData("full","backup.tgz", "comment"),
                new Dictionary<string, string>
                {
                    // TODO Adapt to real values
                    {"ContentString", "{\"level\":\"full\",\"filename\":\"backup.tgz\",\"comment\":\"comment\"}"},
                    {"Level", "full"},
                    {"Filename", "backup.tgz"},
                    {"Comment", "comment"}

                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
