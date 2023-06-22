using ExportData.Enums;

namespace ExportData.Attributs;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class ValueTypeAttribute : Attribute
{
    public CrawlerArgType ArgType { get; set; }

    public ValueTypeAttribute(CrawlerArgType argType)
    {
        ArgType = argType;
    }
}
