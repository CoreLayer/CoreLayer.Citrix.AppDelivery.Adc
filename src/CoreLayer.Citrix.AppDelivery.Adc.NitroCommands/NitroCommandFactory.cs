using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System;
using System.Linq;

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

        public static T Create<T>(INitroClient nitroClient, INitroRequestOptions options)
        {
            var nitroRequest = CreateNitroRequestInstance(typeof(T));
            nitroRequest.Options = options;

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

        // public static T Create<T>(INitroClient nitroClient, INitroRequestData nitroRequestData)
        // {
        //     var nitroRequest = CreateNitroRequestInstance(typeof(T), CreateNitroRequestDataRootInstance(typeof(T), nitroRequestData));
        //
        //     return CreateCommandInstance(
        //         typeof(T),
        //         nitroClient,
        //         nitroRequest
        //         );
        // }
        //
        // public static T Create<T>(INitroClient nitroClient, INitroRequestData[] nitroRequestDatas)
        // {
        //     var nitroRequest = CreateNitroRequestInstance(typeof(T), CreateNitroRequestDataRootInstance(typeof(T), nitroRequestDatas));
        //
        //
        //     return CreateCommandInstance(
        //         typeof(T),
        //         nitroClient,
        //         nitroRequest);
        // }
        //
        // public static T Create<T>(INitroClient nitroClient, INitroRequestOptions options)
        // {
        //     var nitroRequest = CreateNitroRequestInstance(typeof(T));
        //     nitroRequest.Options = options;
        //
        //     return CreateCommandInstance(
        //         typeof(T),
        //         nitroClient,
        //         nitroRequest);
        // }
        //
        // public static T Create<T>(INitroClient nitroClient, INitroRequestData nitroRequestData, INitroRequestOptions nitroRequestOptions)
        // {
        //     var nitroRequest = CreateNitroRequestInstance(typeof(T), CreateNitroRequestDataRootInstance(typeof(T), nitroRequestData));
        //     nitroRequest.Options = nitroRequestOptions;
        //
        //
        //     return CreateCommandInstance(
        //         typeof(T),
        //         nitroClient,
        //         nitroRequest);
        // }

        private static dynamic CreateCommandInstance(Type type, INitroClient nitroClient, INitroRequest nitroRequest)
        {
            return Activator.CreateInstance(type, new object[] { nitroClient, nitroRequest });
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

        // private static string GetNitroRequestDataRootTypeName(string commandNamespace)
        // {
        //     return commandNamespace.Replace("Command", "RequestDataRoot");
        // }

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

        // private static INitroRequest CreateNitroRequestInstance(Type type, INitroRequestDataRoot nitroRequestDataRoot)
        // {
        //     var nitroRequestAssemblyName = GetNitroApiAssemblyName(type.Assembly.FullName);
        //     var nitroRequestTypeFullName = GetNitroApiNamespaceName(type.Namespace) + "." + GetNitroRequestTypeName(type.Name);
        //
        //     try
        //     {
        //         return (INitroRequest) Activator.CreateInstance(
        //             nitroRequestAssemblyName, 
        //             nitroRequestTypeFullName,
        //             false, 
        //             0, 
        //             null, 
        //             new object[] {nitroRequestDataRoot}, 
        //             null, 
        //             null
        //             )?.Unwrap();
        //     }
        //     catch
        //     {
        //         var message = nitroRequestTypeFullName + " not found in " + nitroRequestAssemblyName;
        //         throw new NotImplementedException(message);
        //     }
        // }

        // private static INitroRequestDataRoot CreateNitroRequestDataRootInstance(Type type, INitroRequestData nitroRequestData)
        // {
        //     var nitroRequestAssemblyName = GetNitroApiAssemblyName(type.Assembly.FullName);
        //     var nitroRequestDataRootTypeFullName = GetNitroApiNamespaceName(type.Namespace) + "." + GetNitroRequestDataRootTypeName(type.Name);
        //
        //     try
        //     {
        //         return (INitroRequestDataRoot) Activator.CreateInstance(
        //             nitroRequestAssemblyName,
        //             nitroRequestDataRootTypeFullName,
        //             false,
        //             0,
        //             null,
        //             new object[] {nitroRequestData},
        //             null,
        //             null
        //             )?.Unwrap();
        //     }
        //     catch
        //     {
        //         var message = nitroRequestDataRootTypeFullName + " not found in " + nitroRequestAssemblyName;
        //         throw new NotImplementedException(message);
        //     }
        // }
        //
        // private static INitroRequestDataRoot CreateNitroRequestDataRootInstance(Type type, INitroRequestData[] nitroRequestData)
        // {
        //     var nitroRequestAssemblyName = GetNitroApiAssemblyName(type.Assembly.FullName);
        //     var nitroRequestDataRootTypeFullName = GetNitroApiNamespaceName(type.Namespace) + "." + GetNitroRequestDataRootTypeName(type.Name);
        //
        //     try
        //     {
        //         return (INitroRequestDataRoot)Activator.CreateInstance(
        //             nitroRequestAssemblyName,
        //             nitroRequestDataRootTypeFullName,
        //             false,
        //             0,
        //             null,
        //             nitroRequestData, //new object[] { nitroRequestData.Cast<dynamic>().ToArray() },
        //             null,
        //             null
        //         )?.Unwrap();
        //     }
        //     catch
        //     {
        //         var message = nitroRequestDataRootTypeFullName + " not found in " + nitroRequestAssemblyName;
        //         throw new NotImplementedException(message);
        //     }
        // }
    }
}
/// TODO CLEANUP