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
                new SystemBackupCreateRequestData(SystemBackupLevel.Full),
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
                new SystemBackupCreateRequestData(SystemBackupLevel.Basic, "backup.tgz"),
                new Dictionary<string, string>
                {
                    // TODO Adapt to real values
                    {"ContentString", "{\"level\":\"basic\",\"filename\":\"backup\",\"comment\":\"\"}"},
                    {"Level", "basic"},
                    {"Filename", "backup"},
                    {"Comment", string.Empty}

                }
            };
            yield return new object[]
            {
                new SystemBackupCreateRequestData(SystemBackupLevel.Basic, "backup.bak"),
                new Dictionary<string, string>
                {
                    // TODO Adapt to real values
                    {"ContentString", "{\"level\":\"basic\",\"filename\":\"backup.bak\",\"comment\":\"\"}"},
                    {"Level", "basic"},
                    {"Filename", "backup.bak"},
                    {"Comment", string.Empty}

                }
            };
            yield return new object[]
            {
                new SystemBackupCreateRequestData(SystemBackupLevel.Full,"backup.tgz", "comment"),
                new Dictionary<string, string>
                {
                    // TODO Adapt to real values
                    {"ContentString", "{\"level\":\"full\",\"filename\":\"backup\",\"comment\":\"comment\"}"},
                    {"Level", "full"},
                    {"Filename", "backup"},
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
