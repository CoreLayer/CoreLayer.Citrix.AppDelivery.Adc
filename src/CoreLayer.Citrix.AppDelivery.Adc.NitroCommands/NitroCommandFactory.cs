using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System;
using System.Linq;
using System.Reflection;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands
{
    public class NitroCommandFactory
    {
        private static string GetConfigurationApiAssembly(string commandAssembly)
        {
            return commandAssembly.Replace("Commands", "Api");
        }
        private static string GetConfigurationApiNamespace(string commandNamespace)
        {
            return commandNamespace.Replace("Commands", "Api");
        }

        private static string GetConfigurationTypeName(string commandNamespace)
        {
            return commandNamespace.Replace("Command", "Request");
        }

        private static string GetConfigurationDataRootTypeName(string commandNamespace)
        {
            return commandNamespace.Replace("Command", "RequestDataRoot");
        }

        private static INitroRequest GetTargetConfigurationInstance(Type type)
        {
            var requestAssembly = GetConfigurationApiAssembly(type.Assembly.FullName);
            var requestNameSpace = GetConfigurationApiNamespace(type.Namespace);
            var targetConfigurationTypeName = GetConfigurationTypeName(type.Name);

            var targetConfigurationType = requestNameSpace + "." + targetConfigurationTypeName;
            var targetConfigurationInstance = (INitroRequest)Activator.CreateInstance(requestAssembly, targetConfigurationType).Unwrap();

            return targetConfigurationInstance;
        }

        private static INitroRequest GetTargetConfigurationInstance(Type type,
            INitroRequestDataRoot dataRoot)
        {
            var requestNameSpace = GetConfigurationApiNamespace(type.Namespace);
            var targetConfigurationTypeName = GetConfigurationTypeName(type.Name);

            var targetConfigurationType =requestNameSpace + "." + targetConfigurationTypeName;
            var targetConfigurationInstance = (INitroRequest)Activator.CreateInstance(requestNameSpace, targetConfigurationType, false, 0, null, new object[] { dataRoot }, null, null).Unwrap();

            return targetConfigurationInstance;
        }

        private static INitroRequestDataRoot GetTargetConfigurationDataRootInstance(Type type, INitroRequestData data)
        {
            var requestNameSpace = GetConfigurationApiNamespace(type.Namespace);
            var targetRequestDataRootTypeName = GetConfigurationDataRootTypeName(type.Name);
            var targetRequestDataRootType =
                Type.GetType(requestNameSpace + "." + targetRequestDataRootTypeName);

            // TODO Exception handling
            var targetDataRootInstance = (INitroRequestDataRoot)Activator.CreateInstance(targetRequestDataRootType, new object[] { data });

            return targetDataRootInstance;
        }

        private static INitroRequestDataRoot GetTargetConfigurationDataRootInstance(Type type, dynamic[] data)
        {
            var requestNameSpace = GetConfigurationApiNamespace(type.Namespace);
            var targetRequestDataRootTypeName = GetConfigurationDataRootTypeName(type.Name);
            var targetRequestDataRootType =
                Type.GetType(requestNameSpace + "." + targetRequestDataRootTypeName);

            // TODO Exception handling
            var targetDataRootInstance = (INitroRequestDataRoot)Activator.CreateInstance(targetRequestDataRootType, new object[] { data });

            return targetDataRootInstance;
        }

        private static dynamic GetTargetCommandInstance(Type type, INitroClient nitroClient, INitroRequest requestConfiguration)
        {
            return Activator.CreateInstance(type, new object[] { nitroClient, requestConfiguration });
        }

        public static T Create<T>(INitroClient nitroClient)
        {
            return GetTargetCommandInstance(
                typeof(T),
                nitroClient,
                GetTargetConfigurationInstance(typeof(T)));
        }

        public static T Create<T>(INitroClient nitroClient, INitroRequestOptions options)
        {
            var targetConfigurationInstance = GetTargetConfigurationInstance(typeof(T));
            targetConfigurationInstance.Options = options;

            return GetTargetCommandInstance(
                typeof(T),
                nitroClient,
                targetConfigurationInstance);
        }

        public static T Create<T>(INitroClient nitroClient, INitroRequestData data)
        {
            var targetDataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);
            var targetConfigurationInstance = GetTargetConfigurationInstance(typeof(T), targetDataRoot);
            //targetConfigurationInstance.DataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);

            return GetTargetCommandInstance(
                typeof(T),
                nitroClient,
                targetConfigurationInstance);
        }

        public static T Create<T>(INitroClient nitroClient, INitroRequestData[] dataList)
        {
            dynamic[] data = dataList.Cast<dynamic>().ToArray();
            var targetDataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);
            var targetConfigurationInstance = GetTargetConfigurationInstance(typeof(T), targetDataRoot);
            //targetConfigurationInstance.DataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);

            return GetTargetCommandInstance(
                typeof(T),
                nitroClient,
                targetConfigurationInstance);

        }

        public static T Create<T>(INitroClient nitroClient, INitroRequestData data, INitroRequestOptions options)
        {
            var targetDataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);
            var targetConfigurationInstance = GetTargetConfigurationInstance(typeof(T), targetDataRoot);
            targetConfigurationInstance.Options = options;

            //targetConfigurationInstance.DataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);

            return GetTargetCommandInstance(
                typeof(T),
                nitroClient,
                targetConfigurationInstance);
        }
    }
}
