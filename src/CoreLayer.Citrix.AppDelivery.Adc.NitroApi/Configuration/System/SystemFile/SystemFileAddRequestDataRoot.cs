using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemFile;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    public class SystemFileAddRequestDataRoot : INitroRequestDataRoot
    {
        // public dynamic[] SystemFile { get; set; }
        public SystemFileAddRequestData[] SystemFile { get; set; }

        // public SystemFileAddRequestDataRoot(dynamic data)
        // {
        //     SystemFile = new dynamic[] { data };
        // }
        //
        // public SystemFileAddRequestDataRoot(dynamic[] data)
        // {
        //     SystemFile = data;
        // }


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
/// TODO CLEANUP