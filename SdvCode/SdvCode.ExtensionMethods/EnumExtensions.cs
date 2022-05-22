namespace SdvCode.ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    public static class EnumExtensions
    {
        public static TAttribute? GetAttribute<TAttribute>(this Enum enumValue)
           where TAttribute : Attribute
        {
            var result = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<TAttribute>();

            return result;
        }

        public static string? GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()?
                .GetName();
        }
    }
}