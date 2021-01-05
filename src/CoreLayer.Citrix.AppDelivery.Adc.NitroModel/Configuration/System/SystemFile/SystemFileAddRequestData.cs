using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemFile
{
    /// <summary>
    /// TODO SystemFileAddRequestData
    /// TODO SystemFileAddRequestData Tests
    /// </summary>
    public class SystemFileAddRequestData : INitroRequestData
    {
        /// <summary>
        /// TODO SystemFileAddRequestData
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="fileContent"></param>
        public SystemFileAddRequestData(string fileName, string fileContent)
        {
            FileName = fileName;
            FileContent = fileContent;
        }




        public string FileName { get; }
        public string FileContent { get; }
        public string FileLocation { get; set; }
        public string FileEncoding { get; set; }
    }
}