using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemFile
{
    public class SystemFileAddRequestData : INitroRequestData
    {
        public string FileName { get; }
        public string FileContent { get; }
        public string FileLocation { get; set; }
        public string FileEncoding { get; set; }


        public SystemFileAddRequestData(string fileName, string fileContent)
        {
            FileName = fileName;
            FileContent = fileContent;
        }
    }
}