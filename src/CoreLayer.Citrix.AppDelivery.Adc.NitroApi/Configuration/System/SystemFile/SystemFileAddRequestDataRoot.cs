using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemFile;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    internal class SystemFileAddRequestDataRoot : INitroRequestDataRoot
    {
        public SystemFileAddRequestData[] SystemFile { get; set; }


        public SystemFileAddRequestDataRoot(SystemFileAddRequestData systemFileAddRequestData)
        {
            SystemFile = new [] {systemFileAddRequestData};
        }

        public SystemFileAddRequestDataRoot(SystemFileAddRequestData[] systemFileAddRequestDatas)
        {
            SystemFile = systemFileAddRequestDatas;
        }

        public override string ToString()
        {
            var result = "";

            foreach (var dataItem in SystemFile)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}