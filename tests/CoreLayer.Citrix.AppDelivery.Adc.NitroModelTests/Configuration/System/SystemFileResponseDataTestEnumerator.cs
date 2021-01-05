using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System;
using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemFile;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModelTests.Configuration.System
{
    public class SystemFileResponseDataTestEnumerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemFileResponseData()
                {
                    FileName = "backup.tar.gz",
                    FileLocation = "/var/sys_ns_backup",
                    FileContent = "backupContents",
                    FileEncoding = "Base64",
                    FileAccessTime = "1",
                    FileModifiedTime = "1",
                    FileMode = new []{"r", "w"},
                    FileSize = "1",
                },
                new Dictionary<string, string>
                {
                    // TODO Adapt to real values
                    {"ContentString", "{\"filename\":\"backup.tar.gz\",\"filelocation\":\"/var/sys_ns_backup\",\"filecontent\":\"backupContents\",\"fileencoding\":\"Base64\",\"fileaccesstime\":\"1\",\"filemodifiedtime\":\"1\",\"filemode\":[\"r\",\"w\"],\"filesize\":\"1\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
