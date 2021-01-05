using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemBackup
{
    /// <summary>
    /// TODO SystemBackupAddRequestDataRoot
    /// </summary>
    public class SystemBackupAddRequestDataRoot : INitroRequestDataRoot
    {
        /// <summary>
        /// TODO SystemBackupAddRequestDataRoot constructor
        /// </summary>
        /// <param name="data"></param>
        public SystemBackupAddRequestDataRoot(dynamic data)
        {
            SystemBackup = new dynamic[] { data };
        }




        /// <summary>
        /// TODO SystemBackupAddRequestDataRoot constructor
        /// </summary>
        /// <param name="data"></param>
        public SystemBackupAddRequestDataRoot(dynamic[] data)
        {
            SystemBackup = data;
        }




        /// <summary>
        /// TODO ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = "";
            foreach (var dataItem in SystemBackup)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
        
        
        
        
        public dynamic[] SystemBackup { get; set; }
    }
}