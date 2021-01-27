namespace CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.Login
{
    public class NitroLoginRequestData
    {
        public NitroLoginRequestData(string username, string password)
        {
            Username = username;
            Password = password;
            Timeout = 600;
        }
        public NitroLoginRequestData(string username, string password, int timeout)
        {
            Username = username;
            Password = password;
            Timeout = timeout;
        }

        public string Username { get; }

        public string Password { get; }

        public int Timeout { get; }

        public override string ToString()
        {
            return "{\"username\":\"" + Username + "\",\"password\":\"" + Password + "\",\"timeout\":\"" + Timeout + "\"}";
        }
    }
}
