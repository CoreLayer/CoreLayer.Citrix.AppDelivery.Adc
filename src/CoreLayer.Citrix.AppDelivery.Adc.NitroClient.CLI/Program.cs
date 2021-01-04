using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.Ns.NsVersion;
using System;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroClient.CLI
{
    internal class Program
    {
        private static async System.Threading.Tasks.Task Main()
        {
            Console.Write("Address: ");
            var hostname = Console.ReadLine();

            Console.Write("Username: ");
            var username = Console.ReadLine();

            Console.Write("Password: ");
            var password = Console.ReadLine();

            var settings = new NitroClientSettings
            {
                Hostname = hostname,
                Username = username,
                Password = password,
                AuthenticationMethod = NitroClientAuthenticationMethod.Automatic,
                UseSsl = false,
                ValidateCertificate = NitroClientFactoryCertificateValidationOption.Disabled,
                Timeout = 300
            };

            var nitroClient = new NitroClient(settings);


            var command = NitroCommandFactory.Create<NsVersionGetCommand>(nitroClient);
            var response = await command.GetResponse();

            Console.WriteLine(response.NsVersion.Version);
            Console.WriteLine(response.NsVersion.Release);
            Console.WriteLine(response.NsVersion.Build);
            Console.WriteLine(response.NsVersion.ReleaseDate);


            Console.ReadLine();
        }
    }
}
