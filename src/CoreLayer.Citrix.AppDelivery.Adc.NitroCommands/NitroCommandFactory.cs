using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using System;
using System.Linq;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroCommands
{
    /// <summary>
    /// TODO NitroCommandFactory
    /// </summary>
    public class NitroCommandFactory
    {
        /// <summary>
        /// TODO Create
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nitroClient"></param>
        /// <returns></returns>
        public static T Create<T>(INitroClient nitroClient)
        {
            return CreateCommandInstance(
                typeof(T),
                nitroClient,
                CreateNitroRequestInstance(typeof(T)));
        }




        /// <summary>
        /// TODO Create
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nitroClient"></param>
        /// <param name="nitroRequestData"></param>
        /// <returns></returns>
        public static T Create<T>(INitroClient nitroClient, INitroRequestData nitroRequestData)
        {
            var nitroRequest = CreateNitroRequestInstance(typeof(T), CreateNitroRequestDataRootInstance(typeof(T), nitroRequestData));

            return CreateCommandInstance(
                typeof(T),
                nitroClient,
                nitroRequest
                );
        }




        /// <summary>
        ///  TODO Create
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nitroClient"></param>
        /// <param name="nitroRequestDatas"></param>
        /// <returns></returns>
        public static T Create<T>(INitroClient nitroClient, INitroRequestData[] nitroRequestDatas)
        {
            var nitroRequest = CreateNitroRequestInstance(typeof(T), CreateNitroRequestDataRootInstance(typeof(T), nitroRequestDatas));


            return CreateCommandInstance(
                typeof(T),
                nitroClient,
                nitroRequest);
        }



        /// <summary>
        /// TODO Create
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nitroClient"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static T Create<T>(INitroClient nitroClient, INitroRequestOptions options)
        {
            var nitroRequest = CreateNitroRequestInstance(typeof(T));
            nitroRequest.Options = options;

            return CreateCommandInstance(
                typeof(T),
                nitroClient,
                nitroRequest);
        }
        
        
        
        
        /// <summary>
        /// TODO Create
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nitroClient"></param>
        /// <param name="nitroRequestData"></param>
        /// <param name="nitroRequestOptions"></param>
        /// <returns></returns>
        public static T Create<T>(INitroClient nitroClient, INitroRequestData nitroRequestData, INitroRequestOptions nitroRequestOptions)
        {
            var nitroRequest = CreateNitroRequestInstance(typeof(T), CreateNitroRequestDataRootInstance(typeof(T), nitroRequestData));
            nitroRequest.Options = nitroRequestOptions;


            return CreateCommandInstance(
                typeof(T),
                nitroClient,
                nitroRequest);
        }





        /// <summary>
        /// Create the target command instance based on the target INitroRequest
        /// </summary>
        /// <param name="type"></param>
        /// <param name="nitroClient"></param>
        /// <param name="nitroRequest"></param>
        /// <returns></returns>
        private static dynamic CreateCommandInstance(Type type, INitroClient nitroClient, INitroRequest nitroRequest)
        {
            return Activator.CreateInstance(type, new object[] { nitroClient, nitroRequest });
        }




        /// <summary>
        /// TODO GetNitroApiAssemblyName
        /// </summary>
        /// <param name="commandAssemblyName"></param>
        /// <returns></returns>
        private static string GetNitroApiAssemblyName(string commandAssemblyName)
        {
            return commandAssemblyName.Replace("Commands", "Api");
        }




        /// <summary>
        /// TODO GetNitroApiNamespaceName
        /// </summary>
        /// <param name="commandNamespaceName"></param>
        /// <returns></returns>
        private static string GetNitroApiNamespaceName(string commandNamespaceName)
        {
            return commandNamespaceName.Replace("Commands", "Api");
        }




        /// <summary>
        /// TODO GetNitroRequestTypeName
        /// </summary>
        /// <param name="commandTypeName"></param>
        /// <returns></returns>
        private static string GetNitroRequestTypeName(string commandTypeName)
        {
            return commandTypeName.Replace("Command", "Request");
        }




        /// <summary>
        /// TODO GetNitroRequestDataRootTypeName
        /// </summary>
        /// <param name="commandNamespace"></param>
        /// <returns></returns>
        private static string GetNitroRequestDataRootTypeName(string commandNamespace)
        {
            return commandNamespace.Replace("Command", "RequestDataRoot");
        }




        /// <summary>
        /// TODO CreateNitroRequestInstance
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
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




        /// <summary>
        /// TODO CreateNitroRequestInstance
        /// </summary>
        /// <param name="type"></param>
        /// <param name="nitroRequestDataRoot"></param>
        /// <returns></returns>
        private static INitroRequest CreateNitroRequestInstance(Type type, INitroRequestDataRoot nitroRequestDataRoot)
        {
            var nitroRequestAssemblyName = GetNitroApiAssemblyName(type.Assembly.FullName);
            var nitroRequestTypeFullName = GetNitroApiNamespaceName(type.Namespace) + "." + GetNitroRequestTypeName(type.Name);

            try
            {
                return (INitroRequest) Activator.CreateInstance(
                    nitroRequestAssemblyName, 
                    nitroRequestTypeFullName,
                    false, 
                    0, 
                    null, 
                    new object[] {nitroRequestDataRoot}, 
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




        /// <summary>
        /// TODO CreateNitroRequestDataRootInstance
        /// </summary>
        /// <param name="type"></param>
        /// <param name="nitroRequestData"></param>
        /// <returns></returns>
        private static INitroRequestDataRoot CreateNitroRequestDataRootInstance(Type type, INitroRequestData nitroRequestData)
        {
            var nitroRequestAssemblyName = GetNitroApiAssemblyName(type.Assembly.FullName);
            var nitroRequestDataRootTypeFullName = GetNitroApiNamespaceName(type.Namespace) + "." + GetNitroRequestDataRootTypeName(type.Name);

            try
            {
                return (INitroRequestDataRoot) Activator.CreateInstance(
                    nitroRequestAssemblyName,
                    nitroRequestDataRootTypeFullName,
                    false,
                    0,
                    null,
                    new object[] {nitroRequestData},
                    null,
                    null
                    )?.Unwrap();
            }
            catch
            {
                var message = nitroRequestDataRootTypeFullName + " not found in " + nitroRequestAssemblyName;
                throw new NotImplementedException(message);
            }
        }




        /// <summary>
        /// TODO CreateNitroRequestDataRootInstance
        /// </summary>
        /// <param name="type"></param>
        /// <param name="nitroRequestDatas"></param>
        /// <returns></returns>
        private static INitroRequestDataRoot CreateNitroRequestDataRootInstance(Type type, INitroRequestData[] nitroRequestDatas)
        {
            var nitroRequestAssemblyName = GetNitroApiAssemblyName(type.Assembly.FullName);
            var nitroRequestDataRootTypeFullName = GetNitroApiNamespaceName(type.Namespace) + "." + GetNitroRequestDataRootTypeName(type.Name);
            var nitroRequestData = nitroRequestDatas.Cast<dynamic>().ToArray();

            try
            {
                return (INitroRequestDataRoot)Activator.CreateInstance(
                    nitroRequestAssemblyName,
                    nitroRequestDataRootTypeFullName,
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
                var message = nitroRequestDataRootTypeFullName + " not found in " + nitroRequestAssemblyName;
                throw new NotImplementedException(message);
            }
        }
    }
}
