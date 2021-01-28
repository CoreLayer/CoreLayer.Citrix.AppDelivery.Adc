using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands
{
    public class NitroCommandFactory
    {
        public static T Create<T>(INitroClient nitroClient)
        {
            return CreateCommandInstance(
                typeof(T),
                nitroClient,
                CreateNitroRequestInstance(typeof(T)));
        }

        public static T Create<T>(INitroClient nitroClient, string resourceName)
        {
            var nitroRequest = CreateNitroRequestInstance(typeof(T), resourceName);
            return CreateCommandInstance(
                typeof(T),
                nitroClient,
                nitroRequest);
        }

        public static T Create<T>(INitroClient nitroClient, INitroRequestData nitroRequestData)
        {
            var nitroRequest = CreateNitroRequestInstance(typeof(T), nitroRequestData);

            return CreateCommandInstance(
                typeof(T),
                nitroClient,
                nitroRequest
            );
        }

        public static T Create<T>(INitroClient nitroClient, INitroRequestData[] nitroRequestDatas)
        {
            var nitroRequest = CreateNitroRequestInstance(typeof(T), nitroRequestDatas);


            return CreateCommandInstance(
                typeof(T),
                nitroClient,
                nitroRequest);
        }

        public static T Create<T>(INitroClient nitroClient, INitroRequestOptions nitroRequestOptions)
        {
            var nitroRequest = CreateNitroRequestInstance(typeof(T));
            nitroRequest.Options = nitroRequestOptions;

            return CreateCommandInstance(
                typeof(T),
                nitroClient,
                nitroRequest);
        }

        public static T Create<T>(INitroClient nitroClient, INitroRequestData nitroRequestData, INitroRequestOptions nitroRequestOptions)
        {
            var nitroRequest = CreateNitroRequestInstance(typeof(T), nitroRequestData);
            nitroRequest.Options = nitroRequestOptions;


            return CreateCommandInstance(
                typeof(T),
                nitroClient,
                nitroRequest);
        }




        private static dynamic CreateCommandInstance(Type type, INitroClient nitroClient, INitroRequest nitroRequest)
        {
            return Activator.CreateInstance(type, new object[] {nitroClient, nitroRequest});
        }




        private static string GetNitroApiAssemblyName(string commandAssemblyName)
        {
            return commandAssemblyName.Replace("Commands", "Api");
        }

        private static string GetNitroApiNamespaceName(string commandNamespaceName)
        {
            return commandNamespaceName.Replace("Commands", "Api");
        }

        private static string GetNitroRequestTypeName(string commandTypeName)
        {
            return commandTypeName.Replace("Command", "Request");
        }




        private static INitroRequest CreateNitroRequestInstance(Type type)
        {
            var nitroRequestAssemblyName = GetNitroApiAssemblyName(type.Assembly.FullName);
            var nitroRequestTypeFullName = GetNitroApiNamespaceName(type.Namespace) + "." + GetNitroRequestTypeName(type.Name);

            try
            {
                return (INitroRequest) Activator.CreateInstance(
                    nitroRequestAssemblyName, 
                    nitroRequestTypeFullName
                    )?.Unwrap();
            }
            catch
            {
                var message = nitroRequestTypeFullName + " not found in " + nitroRequestAssemblyName;
                throw new NotImplementedException(message);
            }
        }

        private static INitroRequest CreateNitroRequestInstance(Type type, string resourceName)
        {
            var nitroRequestAssemblyName = GetNitroApiAssemblyName(type.Assembly.FullName);
            var nitroRequestTypeFullName = GetNitroApiNamespaceName(type.Namespace) + "." + GetNitroRequestTypeName(type.Name);

            try
            {
                return (INitroRequest)Activator.CreateInstance(
                    nitroRequestAssemblyName,
                    nitroRequestTypeFullName,
                    false,
                    0,
                    null,
                    new object[] { resourceName },
                    null,
                    null
                )?.Unwrap();
            }
            catch
            {
                var message = nitroRequestTypeFullName + " not found in " + nitroRequestAssemblyName;
                throw new NotImplementedException(message);
            }
        }

        private static INitroRequest CreateNitroRequestInstance(Type type, INitroRequestData nitroRequestData)
        {
            var nitroRequestAssemblyName = GetNitroApiAssemblyName(type.Assembly.FullName);
            var nitroRequestTypeFullName = GetNitroApiNamespaceName(type.Namespace) + "." + GetNitroRequestTypeName(type.Name);

            try
            {
                return (INitroRequest)Activator.CreateInstance(
                    nitroRequestAssemblyName,
                    nitroRequestTypeFullName,
                    false,
                    0,
                    null,
                    new object[] { nitroRequestData },
                    null,
                    null
                )?.Unwrap();
            }
            catch
            {
                var message = nitroRequestTypeFullName + " not found in " + nitroRequestAssemblyName;
                throw new NotImplementedException(message);
            }
        }

        private static INitroRequest CreateNitroRequestInstance(Type type, INitroRequestData[] nitroRequestData)
        {
            var nitroRequestAssemblyName = GetNitroApiAssemblyName(type.Assembly.FullName);
            var nitroRequestTypeFullName = GetNitroApiNamespaceName(type.Namespace) + "." + GetNitroRequestTypeName(type.Name);

            try
            {
                return (INitroRequest)Activator.CreateInstance(
                    nitroRequestAssemblyName,
                    nitroRequestTypeFullName,
                    false,
                    0,
                    null,
                    new object[] { nitroRequestData },
                    null,
                    null
                )?.Unwrap();
            }
            catch
            {
                var message = nitroRequestTypeFullName + " not found in " + nitroRequestAssemblyName;
                throw new NotImplementedException(message);
            }
        }
    }
}