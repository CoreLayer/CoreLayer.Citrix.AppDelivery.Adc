using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    /// <summary>
    /// TODO SystemFileAddRequestDataRoot
    /// </summary>
    public class SystemFileAddRequestDataRoot : INitroRequestDataRoot
    {
        /// <summary>
        /// TODO SystemFileAddRequestDataRoot constructor
        /// </summary>
        /// <param name="data"></param>
        public SystemFileAddRequestDataRoot(dynamic data)
        {
            SystemFile = new dynamic[] { data };
        }




        /// <summary>
        /// TODO SystemFileAddRequestDataRoot constructor
        /// </summary>
        /// <param name="data"></param>
        public SystemFileAddRequestDataRoot(dynamic[] data)
        {
            SystemFile = data;
        }




        /// <summary>
        /// TODO ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = "";
            foreach (var dataItem in SystemFile)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }




        public dynamic[] SystemFile { get; set; }

        
    }
}