using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using FluentValidation;
using System;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    /// <summary>
    /// TODO NitroRequestValidator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class NitroRequestValidator<T>
        : AbstractValidator<T>
        where T : INitroRequest
    {
        /// <summary>
        /// TODO NitroRequestValidator
        /// </summary>
        public NitroRequestValidator()
        {
            RuleForEach(x => x.Options.PropertyFilter)
                .IsEnumName(GetNitroRequestOptionsPropertiesTypeName(typeof(T)), false);
            RuleForEach(x => x.Options.ResourceFilter.Keys)
                .IsEnumName(GetNitroRequestOptionsPropertiesTypeName(typeof(T)), false);
        }




        /// <summary>
        /// TODO GetNitroRequestOptionsPropertiesTypeName
        /// </summary>
        /// <param name="inputType"></param>
        /// <returns></returns>
        public static Type GetNitroRequestOptionsPropertiesTypeName(Type inputType)
        {
            // TODO Check replacement string
            var targetType = inputType.Name.Replace("Configuration", "OptionsProperties");
            return Type.GetType(inputType.Namespace + "." + targetType);
        }
    }
}
