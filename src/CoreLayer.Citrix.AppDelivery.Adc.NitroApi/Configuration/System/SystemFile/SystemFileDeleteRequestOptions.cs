using System.Collections.Generic;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    public class SystemFileDeleteRequestOptions : NitroDeleteRequestOptions
    {
        public SystemFileDeleteRequestOptions(string fileName, string fileLocation) : base(fileName)
        {
            Arguments = new Dictionary<string, string> {{"filelocation", fileLocation}};
        }
    }
}