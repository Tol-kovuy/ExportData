using ExportData.Attributs;
using System.Reflection;

namespace ExportData.Extensions;

public static class EnumExtensions
{
    public static TAttr GetAttribute<TAttr>(this Enum value) where TAttr : Attribute
    {
        return value.GetType()
                    .GetMember(value.ToString())
                    .First()
                    .GetCustomAttribute<TAttr>();
    }

    public static TValue GetAttributeValue<TAttr, TValue>(this Enum value, Func<TAttr, TValue> valueSelector)
        where TAttr : Attribute
    {
        var attribute = value.GetAttribute<TAttr>();
        return attribute != null ? valueSelector(attribute) : default;
    }

    public static bool HasArgumentTypeAttributes(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        return field.IsDefined(typeof(ArgumentTypeAttribute));
    }

    public static bool HasValueTypeAttributes(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        return field.IsDefined(typeof(ValueTypeAttribute), false);
    }
}
