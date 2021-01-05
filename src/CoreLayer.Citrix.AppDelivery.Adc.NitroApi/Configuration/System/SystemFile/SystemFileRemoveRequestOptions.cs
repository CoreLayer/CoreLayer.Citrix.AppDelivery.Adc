namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemFile
{
    /// <summary>
    /// TODO SystemFileRemoveRequestOptions
    /// </summary>
    public class SystemFileRemoveRequestOptions : NitroDeleteRequestOptions
    {
        /// <summary>
        /// TODO SystemFileRemoveRequestOptions constructor
        /// </summary>
        /// <param name="fileName"></param>
        public SystemFileRemoveRequestOptions(string fileName) : base(fileName) { }
    }
}