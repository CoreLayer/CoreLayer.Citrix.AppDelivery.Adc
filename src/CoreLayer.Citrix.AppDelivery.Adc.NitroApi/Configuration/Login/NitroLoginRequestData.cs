namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Login
{
    public class NitroLoginRequestData : INitroLoginRequestData
    {
        private readonly string _username;
        private readonly string _password;
        private readonly int _timeout;

        public NitroLoginRequestData(string username, string password)
        {
            _username = username;
            _password = password;
            _timeout = 600;
        }
        public NitroLoginRequestData(string username, string password, int timeout)
        {
            _username = username;
            _password = password;
            _timeout = timeout;
        }

        public string Username => _username;
        public string Password => _password;
        public int Timeout => _timeout;

        public override string ToString()
        {
            return "{\"username\":\"" + Username + "\",\"password\":\"" + Password + "\",\"timeout\":\"" + Timeout + "\"}";
        }
    }
}
