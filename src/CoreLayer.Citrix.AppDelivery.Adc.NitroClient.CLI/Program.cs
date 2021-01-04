using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.Ns.NsVersion;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.Ns.NsVersion;
using System;
using System.IO;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroClient.CLI
{
    class Program
    {
        static async System.Threading.Tasks.Task Main()
        {
            Console.Write("Address: ");
            var baseAddress = Console.ReadLine();

            Console.Write("Username: ");
            var username = Console.ReadLine();

            Console.Write("Password: ");
            var password = Console.ReadLine();

            var settings = new NitroClientSettings
            {
                BaseAddress = new Uri(baseAddress),
                Username = username,
                Password = password,
                AuthenticationMethod = NitroClientAuthenticationMethod.Automatic,
                Timeout = 300
            };

            var nitroClient = new NitroClient(settings, NitroClientFactoryCertificateValidationOption.Disabled);


            var command = NitroCommandFactory.Create<NsVersionGetCommand>(nitroClient);
            var response = await command.GetResponse();

            Console.WriteLine(response.NsVersion.Version);


            Console.ReadLine();
        }
    }
}
