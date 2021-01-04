using CoreLayer.Citrix.AppDelivery.Adc.NitroInterfaces;
using FluentValidation;
using System;

namespace CoreLayer.Citrix.AppDelivery.Adc.NitroApi
{
    public class NitroRequestValidator<T>
        : AbstractValidator<T>
        where T : INitroRequest
    {

        public NitroRequestValidator()
        {
            RuleForEach(x => x.Options.PropertyFilter)
                .IsEnumName(GetNitroRequestOptionsPropertiesTypeName(typeof(T)), false);
            RuleForEach(x => x.Options.ResourceFilter.Keys)
                .IsEnumName(GetNitroRequestOptionsPropertiesTypeName(typeof(T)), false);
        }

        public static Type GetNitroRequestOptionsPropertiesTypeName(Type inputType)
        {
            var targetType = inputType.Name.Replace("Configuration", "OptionsProperties");
            return Type.GetType(inputType.Namespace + "." + targetType);
        }
    }
}
