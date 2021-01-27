using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using FluentValidation.Results;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    public class NitroRequest : INitroRequest
    {
        public virtual HttpMethod Method => HttpMethod.Get;
        public MediaTypeHeaderValue ContentType => new MediaTypeHeaderValue("application/json");
        public virtual string ResourcePath => "/nitro/v1";
        public virtual INitroRequestOptions Options { get; set; } = new NitroDefaultRequestOptions();
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public virtual INitroRequestDataRoot DataRoot { get; }

        
        protected NitroRequest() { }


        public async Task<ValidationResult> ValidateAsync()
        {
            // Create Generic Type Instance based on current instance
            var T = GetType();
            // Create base type of NitroRequestConfigurationValidator<>
            var objectType = typeof(NitroRequestValidator<>);

            // Make a combined generic type of NitroRequestConfigurationValidator<T>
            var genericType = objectType.MakeGenericType(T);
            var genericInstance = Activator.CreateInstance(genericType);

            // Get the required ValidateAsync method
            var validateMethod = genericInstance.GetType().GetMethods().Single(
                m =>
                    m.Name == "ValidateAsync"
                    && m.GetParameters()[0].Name.Equals("instance"));

            // Invoke and await the method
            var task = (Task)validateMethod.Invoke(genericInstance, new[] { this, null });
            await task.ConfigureAwait(false);

            // Cast the task into Task<ValidationResult>
            var result = (Task<ValidationResult>)task;
            // Old version
            // return result.Result;
            return await result.ConfigureAwait(false);
        }

        
        public async Task<HttpRequestMessage> GenerateHttpRequestMessageAsync()
        {
            return await NitroRequestSerializer.GenerateHttpRequestMessageAsync(this)
                .ConfigureAwait(false);
        }
    }
}
