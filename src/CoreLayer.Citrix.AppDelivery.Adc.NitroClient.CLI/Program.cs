using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.Ns.NsLicense;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.Ns.NsVersion;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemCmdPolicy;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemBackup;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemCmdPolicy;
using CoreLayer.Citrix.AppDelivery.Adc.NitroOperations;
using System;
using System.Threading;
using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUser;
using CoreLayer.Citrix.AppDelivery.Adc.NitroApi.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemUser;
using CoreLayer.Citrix.AppDelivery.Adc.NitroCommands.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemUser;
using CoreLayer.Citrix.AppDelivery.Adc.NitroModel.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreLayer.Citrix.AppDelivery.Adc.NitroOperations.SystemUser;

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


            var nsLicenseGetCommand = NitroCommandFactory.Create<NsLicenseGetCommand>(nitroClient);
            var nsLicenseGetResponse = await nsLicenseGetCommand.GetResponse();
            Console.WriteLine();
            Console.WriteLine(nsLicenseGetResponse.NsLicenseResponse.ModelId);
            Console.WriteLine(nsLicenseGetResponse.NsLicenseResponse.LicensingMode);
            Console.WriteLine(nsLicenseGetResponse.NsLicenseResponse.IsStandardEditionLicense);
            Console.WriteLine(nsLicenseGetResponse.NsLicenseResponse.IsAdvancedEditionLicense);
            Console.WriteLine(nsLicenseGetResponse.NsLicenseResponse.IsPremiumLicense);
            Console.WriteLine(nsLicenseGetResponse.NsLicenseResponse.IsSimpleGatewayLicense);
            Console.WriteLine(nsLicenseGetResponse.NsLicenseResponse.IsSecureWebGatewayLicense);

            Console.WriteLine();

            var nsVersionGetCommand = NitroCommandFactory.Create<NsVersionGetCommand>(nitroClient);
            var nsVersionGetResponse = await nsVersionGetCommand.GetResponse();
            Console.WriteLine(nsVersionGetResponse.NsVersionResponse.Version);

            Console.WriteLine();
        }
    }
}
;