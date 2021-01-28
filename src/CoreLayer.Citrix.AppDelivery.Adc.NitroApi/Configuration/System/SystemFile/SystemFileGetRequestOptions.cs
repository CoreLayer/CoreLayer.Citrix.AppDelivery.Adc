using System.Collections.Generic;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    public class SystemFileGetRequestOptions : NitroRequestArgumentOptions
    {
        public SystemFileGetRequestOptions() { }

        public SystemFileGetRequestOptions(string fileLocation, string fileName)
        {
            Arguments = new Dictionary<string, string>
            {
                {"FileLocation", fileLocation},
                {"FileName", fileName}
            };
        }
    }
}