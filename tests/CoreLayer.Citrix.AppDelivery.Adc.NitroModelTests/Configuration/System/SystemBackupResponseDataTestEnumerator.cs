using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System;
using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.System
{
    public class SystemBackupResponseDataTestEnumerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemBackupResponseData()
                {
                    FileName = "backup.tar.gz",
                    Level = "full",
                    IncludeKernel = "false",
                    Comment = "comment",
                    Size = 100,
                    UseLocalTimeZone = false,
                    CreationTime = "1",
                    Version = "1",
                    CreatedBy = "1",
                    IpAddress = "1",
                },
                new Dictionary<string, string>
                {
                    // TODO Adapt to real values
                    {"ContentString", "{\"filename\":\"backup.tar.gz\",\"level\":\"full\",\"includekernel\":\"false\",\"comment\":\"comment\",\"size\":100,\"uselocaltimezone\":false,\"creationtime\":\"1\",\"version\":\"1\",\"createdby\":\"1\",\"ipaddress\":\"1\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
